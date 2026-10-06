using BJ.Src;
using System.Numerics;
using System.Resources;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace BJ
{
    public partial class Game : Form
    {
        Deck d = new Deck();
        bool Start_AA = false;
        bool Start_A = false;
        public Game(int chip)
        {
            InitializeComponent();
            Start(chip);
        }

        public void Start(int vs_chip)
        {
            bool double_Down_Check = Properties.Settings.Default.double_Down;

            int Chip_check = vs_chip;
            battle_Chip_Count.Text = Chip_check.ToString();
            int chip = Properties.Settings.Default.Chip - vs_chip;
            Chip_Count.Text = chip.ToString();

            d.Crad_Shuffle();

            //ユーザーの手札2枚配布
            for (int i = 0; i < 2; i++)
            {
                Label L = new Label();
                L.Text = d.Please_Card();
                L.AutoSize = true;
                User_Card.Controls.Add(L);

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
                int Total = int.Parse(User_Total_Count.Text);
                Total = Total + Count;
                User_Total_Count.Text = Total.ToString();
            }

            //Dealerの手札2枚配布
            for (int i = 0; i < 2; i++)
            {
                Label L = new Label();
                L.Text = d.Please_Card();
                L.AutoSize = true;
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

            string item_0 = d.Mark_remove(User_Card.Controls[0].Text);
            string item_1 = d.Mark_remove(User_Card.Controls[1].Text);
            if (item_0 == "A" && item_1 == "A")
            {
                Start_AA = true;
                Console.WriteLine("どちらもAです");
            }
            if (item_0 == "A" || item_1 == "A")
            {
                Start_A = true;
                Console.WriteLine("片方Aです");
            }
        }

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
            if (Start_A == true && Total < 21)
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
            if (Total > 21)
            {
                await Burst_anime();
                /*
                Title title = new Title();

                title.Show();

                this.Hide();
                */
            }
        }
        private async void Hit_Button_Click(object sender, EventArgs e)
        {
            await Action_anime('h');
            Card_pull();
        }

        private async void stand_Button_Click(object sender, EventArgs e)
        {
            await Action_anime('s');
            Console.WriteLine("hello");
        }

        private async void doubleDown_Button_Click(object sender, EventArgs e)
        {
            await Action_anime('d');

            int My_Chip = int.Parse(battle_Chip_Count.Text);
            int check = My_Chip * 2;

            while (My_Chip != check)
            {
                My_Chip++;
                battle_Chip_Count.Text = My_Chip.ToString();
                await Task.Delay(1);
            }

            Card_pull();
            
        }

        private void Battle_Chip_Count_Click(object sender, EventArgs e)
        {

        }

        private void Battale()
        {
            OutlinedLabel outline = new OutlinedLabel();
            outline.Text = "勝負！";
            outline.Font = new Font("A P-SK 石井ゴシック StdN B", 32F, FontStyle.Bold);
            outline.StrokeWidth = 5;
            outline.AutoSize = true;
            this.Controls.Add(outline);

        }

        private async Task Action_anime(char id)
        {
            bool DD_Check = doubleDown_Button.Enabled;
            hit_Button.Enabled= false;
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
                    pic.Image= Properties.Resources.Stand_text;
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

        private async Task Burst_anime()
        {
            hit_Button.Visible = false;
            stand_Button.Visible = false;
            doubleDown_Button.Visible = false;
            PictureBox pic = new PictureBox();
            pic.Size = new Size(180, 50);
            pic.Location = new Point(190, -60);
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Image = Properties.Resources.Burst_text;
            this.Controls.Add(pic);
            pic.BringToFront();

            int x = 305;
            int y = -60;
            while (y < 200)
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

            pic.Hide();
        }

        private async void test_Click(object sender, EventArgs e)
        {
            await Burst_anime();
            Console.WriteLine("実行！");
        }
    }
}
