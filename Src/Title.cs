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
                // 1. チップ画面を開く前に、先にタイトル画面を非表示にする
                this.Hide();

                // 2. チップ画面の表示
                DialogResult chipResult;
                using (Chip chipForm = new Chip())
                {
                    chipResult = chipForm.ShowDialog(this);
                }

                // 3. チップ画面の結果判定
                if (chipResult == DialogResult.OK)
                {
                    // チップ確定画面で「決定」などが押された場合
                    // ここで「ゲーム画面」を開く処理を呼び出す
                    // 例: OpenGameForm();
                }
                else
                {
                    // 「×」ボタンやキャンセルが押された場合は、タイトル画面を再表示して戻す
                    this.Show();
                }
            }
            // No が押された場合は何もせずタイトル画面のまま
        }

        public void This_show()
        {
            this.Show();
        }

        private void Setting_button_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Check(object sender, FormClosingEventArgs e)
        {

        }
    }
}
