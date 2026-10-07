namespace BJ.Src
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
            switch (Properties.Settings.Default.Rule)
            {
                case "ベストファイブ": BestFive_radio.Checked = true; break;
                case "ロックファイブ": LookFive_radio.Checked = true; break;
                case "ファイブターゲット": FiveTarget_radio.Checked = true; break;
            }

        }

        private void BestFive_Description(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "何枚になっても最終的に使えるのは手札の中の5枚のみ";
        }

        private void LookFive_Description(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "手札を5枚までしか持てません。まだ引く場合は手札から1枚捨てて引かないといけません。";
        }

        private void FiveTarget_Description(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "バーストせずに手札に5枚集めれたら勝ちです";
        }

        private void Default_Description(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "選択項目にマウスをかざすとここに説明が表示されます";
        }

        private void Setting_OK(object sender, EventArgs e)
        {
            RadioButton selectedRadio = null;
            string Check = Properties.Settings.Default.Rule;

            // groupBox1 の中にあるコントロールを順番に確認
            foreach (Control control in groupBox1.Controls)
            {
                // コントロールが RadioButton かつ Checked が true の場合
                if (control is RadioButton radio && radio.Checked)
                {
                    selectedRadio = radio;
                    Console.WriteLine(selectedRadio);
                    break; // 見つかったらループを抜ける
                }
            }

            if (selectedRadio.Text == Check)
            {
                Console.WriteLine("なにも変更してないね!");
            }
            else
            {
                double sanmaruOFF = Properties.Settings.Default.Chip * 0.6;
                DialogResult result = MessageBox.Show($"ルールが変更されました。\n都合よくルールを変更して所持金を増やす行為を\n防ぐため所持金から60%引かせていただきます。よろしいですか？\n\n現在の所持金:{Properties.Settings.Default.Chip}\n支払い後:{(int)sanmaruOFF}","不正防止のための確認",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (sanmaruOFF < 0)
                    {
                        MessageBox.Show("所持金が不足しています。\nルールのみ保存せずにタイトルに戻ります", "支払い失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Properties.Settings.Default.Chip = (int)sanmaruOFF;
                        Properties.Settings.Default.Save();

                        switch (selectedRadio.Text)
                        {
                            case "ベストファイブ": Properties.Settings.Default.Rule = selectedRadio.Text; break;
                            case "ロックファイブ": Properties.Settings.Default.Rule = selectedRadio.Text; break;
                            case "ファイブターゲット": Properties.Settings.Default.Rule = selectedRadio.Text; break;
                        }

                        Properties.Settings.Default.Save();
                        MessageBox.Show($"設定を保存しました！\n\n現在の所持金：{Properties.Settings.Default.Chip}","支払い完了",MessageBoxButtons.OK,MessageBoxIcon.Question);

                        Title title = new Title();

                        title.Show();

                        this.Hide();
                    }
                }
            }
        }
    }
}
