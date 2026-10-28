using BJ.Src;
using NAudio.Wave;
using System.Xml.Linq;

namespace BJ
{
    public partial class Game : Form
    {
        Display display = new();
        Deck d = new();
        bool Start_AA = false;
        bool Start_A = false;
        int Start_chip = 0;
        int End_chip = 0;
        int battle_Start_chip = 0;


        public Game()
        {
            InitializeComponent();
            Properties.Settings.Default.Now_battle = 1;
            Properties.Settings.Default.Save();
            Play_Count_Max.Text = Properties.Settings.Default.battle_count.ToString();
            Start();
            if (Properties.Settings.Default.Now_battle == 1)
            {
                battle_Start_chip = Properties.Settings.Default.Now_battle + Properties.Settings.Default.battle_chip;
            }
        }

        /// <summary>
        /// カードのシャッフルとカード配布を行います。
        /// </summary>
        public void Start()
        {
            using (var chip_window = new Chip())
            {
                // 戻り値が OK 以外の場合（×ボタンで閉じられた場合）
                if (chip_window.ShowDialog() != DialogResult.OK)
                {
                    // ×ボタンで閉じられた時のみ実行したい処理
                    this.Close();
                }

            }
            Deck deck = new();

            Dealer_Card.ControlAdded -= Dealer_Total_Calc;
            Play_Count.Text = Properties.Settings.Default.Now_battle.ToString();
            Start_chip = int.Parse(Chip_Count.Text) + int.Parse(battle_Chip_Count.Text);

            //設定読み込み
            bool double_Down_Check = Properties.Settings.Default.double_Down;

            //初期化
            Dealer_Card.Controls.Clear();
            User_Card.Controls.Clear();
            Dealer_Total_Count.Text = "0";
            Dealer_Total_Count.ForeColor = Color.Black;
            User_Total_Count.Text = "0";
            User_Total_Count.ForeColor = Color.Black;
            Table2.Visible = false;
            Select_Action_Panel.Visible = true;
            hit_Button.Visible = true;
            stand_Button.Visible = true;
            doubleDown_Button.Visible = true;
            hit_Button.Enabled = true;
            stand_Button.Enabled = true;
            doubleDown_Button.Enabled = double_Down_Check;

            int Chip_check = Properties.Settings.Default.battle_chip;
            battle_Chip_Count.Text = Chip_check.ToString();
            int chip = Properties.Settings.Default.Chip - Properties.Settings.Default.battle_chip;
            Chip_Count.Text = chip.ToString();

            deck.Crad_Shuffle();

            //ユーザーの手札2枚配布
            for (int i = 0; i < 2; i++)
            {
                Label L = new();
                L.Text = deck.Please_Card();
                Console.WriteLine(d.How_many());
                L.AutoSize = true;
                User_Card.Controls.Add(L);

                //合計値計算
                string check = deck.Mark_remove(L.Text);
                int Count = 0;
                if (check == "A" || check == "J" || check == "Q" || check == "K")
                {
                    Count = deck.Start_BlackJackValue(check);
                }
                else
                {
                    Count = int.Parse(check);
                }
                int Total = int.Parse(User_Total_Count.Text);
                Total = Total + Count;
                User_Total_Count.Text = Total.ToString();
            }

            //Dealerの手札2枚配布
            for (int i = 0; i < 2; i++)
            {
                if (i == 1)
                {
                    Label Secret = new Label
                    {
                        Text = "??",
                        AutoSize = true
                    };

                    Dealer_Card.Controls.Add(Secret);
                }
                else
                {
                    Label L = new Label
                    {
                        Text = d.Please_Card(),
                        AutoSize = true
                    };

                    Dealer_Card.Controls.Add(L);

                    //合計値計算
                    string check = d.Mark_remove(L.Text);
                    int Count = 0;
                    if (check == "A" || check == "J" || check == "Q" || check == "K")
                    {
                        Count = d.Start_BlackJackValue(check);
                    }
                    else
                    {
                        Count = int.Parse(check);
                    }
                    int Total = int.Parse(Dealer_Total_Count.Text);
                    Total = Total + Count;
                    Dealer_Total_Count.Text = Total.ToString();
                }
            }
            Dealer_Card.ControlAdded += Dealer_Total_Calc;
            string item_0 = d.Mark_remove(User_Card.Controls[0].Text);
            Console.WriteLine($">>{item_0}");
            string item_1 = d.Mark_remove(User_Card.Controls[1].Text);
            Console.WriteLine($">>{item_1}");

            if (item_0 == "A" || item_1 == "A")
            {
                Start_A = true;
                Console.WriteLine("片方Aです");
            }
            if (item_0 == "A" && item_1 == "A")
            {
                Start_AA = true;
                Console.WriteLine("どちらもAです");
            }
        }

        /// <summary>
        /// カードを引きます。
        /// </summary>
        private async void Card_pull()
        {
            Label L = new Label();
            L.Text = d.Please_Card();
            L.AutoSize = true;
            User_Card.Controls.Add(L);
            doubleDown_Button.Enabled = false;

            //合計値計算
            string check = d.Mark_remove(L.Text);
            int Count = 0;
            int Total = int.Parse(User_Total_Count.Text);

            //最初にAA持ってるのに
            if (Start_AA == true)
            {
                Total -= 20;
                Dealer_Total_Count.Text = Total.ToString();
                Start_AA = false;
            }

            //最初にAを持っていたとしても、21を超えるまではAを11とカウントする
            if (Start_A == true)
            {
                Total -= 10;
                Dealer_Total_Count.Text = Total.ToString();
                Start_A = false;
            }

            if (check == "A" || check == "J" || check == "Q" || check == "K")
            {
                Count = d.BlackJackValue(check);
            }
            else
            {
                Count = int.Parse(check);
            }

            Total = Total + Count;
            User_Total_Count.Text = Total.ToString();
        }

        /// <summary>
        /// 行動を起こしたときのイベントです。
        /// </summary>
        private async void Button_Action(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            switch (B.Text)
            {
                case "ヒット":
                    await Action_anime('h');
                    Card_pull();
                    break;
                case "スタンド":
                    await Action_anime('s');
                    await Battale();
                    break;
                case "ダブルダウン":
                    await Action_anime('d');

                    int My_Chip = int.Parse(battle_Chip_Count.Text);
                    int check = My_Chip * 2;

                    // 掛け金上昇のアニメーション
                    while (My_Chip != check)
                    {
                        My_Chip++;
                        battle_Chip_Count.Text = My_Chip.ToString();
                        await Task.Delay(1);
                    }

                    Card_pull();
                    break;
            }
        }

        /// <summary>
        /// 賭け金の数字をクリックしたときのイベントです
        /// </summary>
        private void Battle_Chip_Count_Click(object sender, EventArgs e)
        {
            PayChip paypay = new PayChip(int.Parse(battle_Chip_Count.Text));
            paypay.Show();
        }

        /// <summary>
        /// ディーラーとプレイヤーが勝負をします。
        /// </summary>
        private async Task Battale()
        {
            await Battale_anime();
            await Task.Delay(500);

            //ディーラの「??」を削除
            Dealer_Card.Controls.RemoveAt(1);

            //カードを一枚引くて設置
            Label L = new Label
            {
                Text = d.Please_Card(),
                AutoSize = true
            };

            Dealer_Card.Controls.Add(L);

            await Task.Delay(1000);

            while (int.Parse(Dealer_Total_Count.Text) < 16)
            {
                Label LL = new Label
                {
                    Text = d.Please_Card(),
                    AutoSize = true
                };
                Dealer_Card.Controls.Add(LL);
                await Task.Delay(500);
            }

            //ディーラーと自分の合計値が21以下かつ一緒か確認
            if (int.Parse(Dealer_Total_Count.Text) <= 21 &&
                int.Parse(User_Total_Count.Text) <= 21 &&
                int.Parse(Dealer_Total_Count.Text) == int.Parse(User_Total_Count.Text))
            {
                //ひきわけの処理をここに入力
                await Tonton_anime();
            }
            else
            {
                //ディーラーが21を超えているか確認
                if (int.Parse(Dealer_Total_Count.Text) > 21)
                {
                    await BattleResult_anime('w');
                    End_chip = Start_chip + int.Parse(Chip_Count.Text);
                }
                else
                {
                    //ディーラーと自分の合計値を比較する
                    if (int.Parse(Dealer_Total_Count.Text) > int.Parse(User_Total_Count.Text))
                    {
                        //true ディーラーが大きい
                        await BattleResult_anime('l');
                        End_chip = int.Parse(Chip_Count.Text);
                    }
                    else
                    {
                        //false 自分が大きい
                        await BattleResult_anime('w');
                        int startValue = int.Parse(battle_Chip_Count.Text);
                        int durationMs = 100;
                        int steps = 32;
                        int delayPerStep = durationMs / steps;
                        Table2.Visible = true;
                        Chip_count2.Text = battle_Chip_Count.Text;
                        int kake_chip = int.Parse(battle_Chip_Count.Text);
                        int my_chip = int.Parse(battle_Chip_Count.Text);
                        int kake_base = int.Parse(Chip_Count.Text);
                        Table2.AutoSizeMode = AutoSizeMode.GrowOnly;

                        await Task.Delay(500);

                        for (int i = 0; i <= steps; i++)
                        {
                            await Task.Delay(24);
                            kake_chip = (int)(startValue * (1.0 - (double)i / steps));
                            my_chip = (int)(startValue * ((double)i / steps));
                            Chip_Count.Text = (kake_base + my_chip).ToString();
                            Chip_count2.Text = kake_chip.ToString();
                            battle_Chip_Count.Text = kake_chip.ToString();
                        }

                        battle_Chip_Count.Text = "0";
                        End_chip = Start_chip + int.Parse(battle_Chip_Count.Text);
                    }
                }
            }

            await Task.Delay(500);
            await Result();

        }

        /// <summary>
        /// 「勝負!」のアニメーションクラスです
        /// </summary>
        private async Task Battale_anime()
        {
            /*アニメーション初期設定*/
            VS_text.Opacity = 0;
            VS_text.Location = new Point(200, 70);
            VS_text.Size = new Size(400, 305);
            VS_text.Angle = -360;
            VS_text.Scale = 400;
            VS_text.Visible = true;
            Select_Action_Panel.Visible = false;

            for (int count = 0; count < 24; count++)
            {
                VS_text.Scale -= 8;
                VS_text.Angle += 30;
                VS_text.Opacity += 4;
                VS_text.Size = new Size(400, 305 - (count * 2));
                await Task.Delay(10);
            }

            await Task.Delay(1000);

            while (VS_text.Scale > 30)
            {
                VS_text.Scale -= 8;
                VS_text.Opacity -= 4;
                VS_text.Angle += 30;
                await Task.Delay(10);
            }

            VS_text.Visible = false;
        }

        /// <summary>
        /// アクションした際のテキストアニメーションクラスです。
        /// </summary>
        private async Task Action_anime(char id)
        {
            bool DD_Check = doubleDown_Button.Enabled;
            hit_Button.Enabled = false;
            stand_Button.Enabled = false;
            doubleDown_Button.Enabled = false;
            PictureBox pic = new PictureBox();
            pic.Size = new Size(395, 50);
            pic.SizeMode = PictureBoxSizeMode.Zoom;

            switch (id)
            {
                case 'h':
                    pic.Image = Properties.Resources.Hit_text;
                    break;

                case 's':
                    pic.Image = Properties.Resources.Stand_text;
                    break;

                case 'd':
                    pic.Image = Properties.Resources.DoubleDown_text;
                    break;
            }
            this.Controls.Add(pic);
            pic.BringToFront();

            int x = 800;
            while (x > 160)
            {
                pic.Location = new Point(x, 190);
                x -= 40;
                await Task.Delay(10);
            }

            await Task.Delay(1000);

            while (x > -400)
            {
                pic.Location = new Point(x, 190);
                x -= 40;
                await Task.Delay(10);
            }

            pic.Hide();

            hit_Button.Enabled = true;
            stand_Button.Enabled = true;
            doubleDown_Button.Enabled = DD_Check;
        }

        /// <summary>
        /// バーストした際のクラスです
        /// </summary>
        private async Task Burst_anime()
        {
            hit_Button.Visible = false;
            stand_Button.Visible = false;
            doubleDown_Button.Visible = false;

            PictureBox pic = new PictureBox
            {
                Size = new Size(180, 50),
                Location = new Point(190, -60),
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = Properties.Resources.Burst_text
            };

            this.Controls.Add(pic);
            pic.BringToFront();

            display.Num(Num_Panel, int.Parse(User_Total_Count.Text));
            Table.Visible = true;

            /* アニメーション */
            int x = 305;
            int y = -60;
            while (y < 150)
            {
                pic.Location = new Point(x, y);
                y += 20;
                await Task.Delay(10);
            }

            await Task.Delay(1000);

            while (y < 450)
            {
                pic.Location = new Point(x, y);
                y += 20;
                await Task.Delay(10);
            }

            /* アニメーション終わり */
            pic.Hide();
            Table.Hide();

            await Count_Down();

            await Task.Delay(1000);

            await Result();

        }
        private async Task Result()
        {
            End_chip = int.Parse(Chip_Count.Text);

            if (Chip_Count.Text.Length <6)
            {
                
            }

            if (Properties.Settings.Default.Now_battle == Properties.Settings.Default.battle_count)
            {
                //true 終わりへ行く
                using (var dialog = new Result(
                    Properties.Settings.Default.Now_battle,
                    int.Parse(User_Total_Count.Text),
                    Start_chip,
                    Chip_Count.Text))
                {
                    dialog.ShowDialog();
                }
            }
            else
            {
                //false 勝負結果を見せて続行
                using (var dialog = new Result(
                    Properties.Settings.Default.Now_battle,
                    int.Parse(User_Total_Count.Text),
                    Start_chip,
                    Chip_Count.Text))
                {
                    dialog.ShowDialog();
                }

                Properties.Settings.Default.Now_battle++;
                Properties.Settings.Default.Chip = End_chip;
                Properties.Settings.Default.Save();
                Start();
            }
        }

        private async Task BattleResult_anime(char Result)
        {

            PictureBox pic = new PictureBox
            {
                Size = new Size(165, 0),
                Location = new Point(310, 170),
                SizeMode = PictureBoxSizeMode.StretchImage,
            };

            switch (Result)
            {
                case 'l':
                    pic.Image = Properties.Resources.LOSE;
                    break;
                case 'w':
                    pic.Image = Properties.Resources.WIN;
                    break;
            }

            this.Controls.Add(pic);
            pic.BringToFront();

            /* アニメーション */
            int y = 170;
            int xy = 0;

            while (pic.Size.Height < 90)
            {
                pic.Size = new Size(165, xy);
                xy += 3;
                await Task.Delay(5);
            }

            await Task.Delay(1000);

            while (pic.Size.Height > 0)
            {
                pic.Location = new Point(310, y);
                y += 1;
                pic.Size = new Size(165, xy);
                xy -= 3;
                await Task.Delay(5);
            }

            /* アニメーション終わり */
            pic.Hide();
            Table.Hide();
            if (Result == 'l')
            {
                await Count_anime(false);
            }
            else
            {
                await Count_anime(true);
            }

            await Task.Delay(1000);
        }

        private async Task Count_Down()
        {
            int startValue = int.Parse(battle_Chip_Count.Text);
            int durationMs = 100;
            int steps = 32;
            int delayPerStep = durationMs / steps;
            Table2.Visible = true;
            Chip_count2.Text = battle_Chip_Count.Text;
            int kake_chip = int.Parse(battle_Chip_Count.Text);
            Table2.AutoSizeMode = AutoSizeMode.GrowOnly;

            await Task.Delay(1000);

            for (int i = 0; i <= steps; i++)
            {
                await Task.Delay(24);
                kake_chip = (int)(startValue * (1.0 - (double)i / steps));
                Chip_count2.Text = kake_chip.ToString();
                battle_Chip_Count.Text = kake_chip.ToString();
            }

            battle_Chip_Count.Text = "0";
            await Task.Delay(1000);
        }

        private async Task Count_anime(bool u)
        {
            int startValue = int.Parse(battle_Chip_Count.Text);
            int durationMs = 100;
            int steps = 32;
            int delayPerStep = durationMs / steps;
            Table2.Visible = true;
            Chip_count2.Text = battle_Chip_Count.Text;
            int kake_chip = int.Parse(battle_Chip_Count.Text);
            Table2.AutoSizeMode = AutoSizeMode.GrowOnly;

            await Task.Delay(1000);

            if (u == true)
            {
                //trueならカウントアップ
                for (int i = 0; i <= steps; i++)
                {
                    await Task.Delay(24);
                    kake_chip = (int)(startValue * (1.0 + (double)i / steps));
                    Chip_count2.Text = kake_chip.ToString();
                    battle_Chip_Count.Text = kake_chip.ToString();
                }
                battle_Chip_Count.Text = kake_chip.ToString();
            }
            else
            {
                //falseならカウントダウン
                for (int i = 0; i <= steps; i++)
                {
                    await Task.Delay(24);
                    kake_chip = (int)(startValue * (1.0 - (double)i / steps));
                    Chip_count2.Text = kake_chip.ToString();
                    battle_Chip_Count.Text = kake_chip.ToString();
                }
                battle_Chip_Count.Text = "0";
            }

            await Task.Delay(1000);
        }
        private async void test_Click(object sender, EventArgs e)
        {
            await Tonton_anime();
        }

        private async Task Tonton_anime()
        {

            CustomPictureBox pic = new CustomPictureBox
            {
                SizeMode = PictureBoxSizeMode.AutoSize,
                Location = new Point(225, 160),
                Image = Properties.Resources.TONTON,
                Opacity = 0
            };

            this.Controls.Add(pic);
            pic.BringToFront();

            /* アニメーション */
            float opacity = 0;

            while (opacity < 1)
            {
                Console.WriteLine(opacity);
                pic.Opacity = opacity;
                opacity += 0.02f;
                await Task.Delay(5);
            }

            await Task.Delay(1000);

            while (opacity > 0)
            {
                Console.WriteLine(opacity);
                pic.Opacity = opacity;
                opacity -= 0.02f;
                await Task.Delay(5);
            }

            /* アニメーション終わり */
            pic.Hide();
            Table.Hide();

            Information_label.Visible = true;
            timer1.Enabled = true;
            int startValue = int.Parse(battle_Chip_Count.Text);
            int durationMs = 100;
            int steps = 32;
            int delayPerStep = durationMs / steps;
            Table2.Visible = true;
            Chip_count2.Text = battle_Chip_Count.Text;
            int kake_chip = int.Parse(battle_Chip_Count.Text);
            int my_chip = int.Parse(battle_Chip_Count.Text);
            int kake_base = int.Parse(Chip_Count.Text);
            Table2.AutoSizeMode = AutoSizeMode.GrowOnly;

            await Task.Delay(1000);

            for (int i = 0; i <= steps; i++)
            {
                await Task.Delay(24);
                kake_chip = (int)(startValue * (1.0 - (double)i / steps));
                my_chip = (int)(startValue * ((double)i / steps));
                Chip_Count.Text = (kake_base + my_chip).ToString();
                Chip_count2.Text = kake_chip.ToString();
                battle_Chip_Count.Text = kake_chip.ToString();
            }

            battle_Chip_Count.Text = "0";

            await Task.Delay(1000);
            timer1.Enabled = false;
            Information_label.Visible = false;

            if (Properties.Settings.Default.Now_battle == Properties.Settings.Default.battle_count)
            {
                //true 終わりへ行く
                using (var dialog = new Result(
                    Properties.Settings.Default.Now_battle,
                    int.Parse(User_Total_Count.Text),
                    int.Parse(Chip_Count.Text),
                    "変更なし"))
                {
                    dialog.ShowDialog();
                }
            }
            else
            {
                //false 勝負結果を見せて続行
                using (var dialog = new Result(
                    Properties.Settings.Default.Now_battle,
                    int.Parse(User_Total_Count.Text),
                    int.Parse(Chip_Count.Text),
                    "変更なし"))
                {
                    dialog.ShowDialog();
                }

                Properties.Settings.Default.Now_battle++;
                Properties.Settings.Default.battle_chip = 0;
                Properties.Settings.Default.Chip = int.Parse(Chip_Count.Text);
                Properties.Settings.Default.Save();
                Start();
            }
        }

        private void Exit_Check(object sender, FormClosingEventArgs e)
        {
            // 確認メッセージを表示
            DialogResult result = MessageBox.Show(
                "本当に終了しますか？\n試合放棄扱いになり、賭けたチップは戻ってきません！",
                "終了確認",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning
            );

            // 「OK」以外が押された場合は、閉じる処理をキャンセルする
            if (result != DialogResult.OK)
            {
                e.Cancel = true; // これによりウィンドウが閉じるのを防ぐ
            }
        }

        private async void Total_Change(object sender, EventArgs e)
        {
            if (int.Parse(User_Total_Count.Text) > 21)
            {
                User_Total_Count.ForeColor = Color.Red;
                await Burst_anime();
            }
        }

        private void Dealer_Total_Calc(object? sender, ControlEventArgs e)
        {
            string check;
            int Count = 0;
            int Total = 0;
            Console.WriteLine(Dealer_Card.Controls.Count);
            for (int i = 0; i < Dealer_Card.Controls.Count; i++)
            {
                Control targetControl = Dealer_Card.Controls[i];
                check = d.Mark_remove(targetControl.Text);
                if (check == "A" || check == "J" || check == "Q" || check == "K")
                {
                    Count = d.BlackJackValue(check);
                }
                else
                {
                    Count = int.Parse(check);
                }
                Total += Count;
            }

            Dealer_Total_Count.Text = Total.ToString();
        }

        private void Label_tenmetu(object sender, EventArgs e)
        {
            Information_label.Visible = Information_label.Visible ? false : true;
        }
    }
}
