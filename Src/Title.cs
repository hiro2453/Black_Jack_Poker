using System.Reflection;
using System.Resources;
using System.Security.Cryptography.X509Certificates;

namespace BJ
{
    public partial class Title : Form
    {
        //変数のられつ
        int logo_count = 0;
        public Title()
        {
            InitializeComponent();
        }

        private void Logo_click(object sender, EventArgs e)
        {
            if (logo_count == 4)
            {
                Title_Logo.Image = Properties.Resources.Logo_ikasama;
                Title_Logo.Click -= Logo_click;
                Title_Logo.Click += Ikamasa_Logo_click;
                MessageBox.Show("イカサマモードが有効になりました。\nでも、それで君は楽しめるの？", "ようこそ", MessageBoxButtons.OK);
            }
            else
            {
                logo_count++;
                MessageBox.Show("クリックする箇所を間違えているようです。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine(logo_count);
            }

        }
        private void Ikamasa_Logo_click(object sender, EventArgs e)
        {
            MessageBox.Show("元に戻したいですか？\n再起動してください。", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void New_button_click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "はじめから開始しますか？",
                "確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (Chip chipForm = new Chip())
                {
                    // 2. モーダル表示（サブ画面が閉じるまで、ここで実行が一時停止します）
                    chipForm.ShowDialog(this);
                }

                // Title フォームを非表示にする（または Close() で閉じる）
                this.Hide();
            }
        }

        private void Setting_button_Click(object sender, EventArgs e)
        {

        }
    }
}
