using System.Reflection;
using System.Resources;
using System.Data.SQLite;
using System.Security.Cryptography.X509Certificates;

namespace BJ
{
    public partial class Title : Form
    {
        //変数のられつ
        int logo_count = 0;
        ResourceManager rm = new ResourceManager("BJ.assets", Assembly.GetExecutingAssembly());
        public Title()
        {
            InitializeComponent();
        }

        private void Logo_click(object sender, EventArgs e)
        {
            if (logo_count == 4)
            {
                Title_Logo.Image = (Bitmap)rm.GetObject("Logo_ikasama");
                Title_Logo.Click -= Logo_click;
                Title_Logo.Click += Ikamasa_Logo_click;
                MessageBox.Show("イカサマモードが有効になりました。", "ようこそ");
            }
            else
            {
                logo_count++;
                MessageBox.Show("クリックする箇所を間違えているようです。", "エラー");
            }

        }
        private void Ikamasa_Logo_click(object sender, EventArgs e)
        {
            MessageBox.Show("元に戻したいですか？\n再起動してください。", "Tips");
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
                // 遷移先の Game フォームを生成
                Game gameForm = new Game();

                // Game フォームを表示
                gameForm.Show();

                // Title フォームを非表示にする（または Close() で閉じる）
                this.Hide();
            }
        }
    }
}
