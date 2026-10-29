using NAudio.Wave;

namespace BJ.Src
{
    public partial class Result : Form
    {
        Display display = new Display();
        public Result(int battle_count, int BJ, int Before_Chip, string After_Check_Chip)
        {
            InitializeComponent();

            this.Text = $"{battle_count}回戦　結果発表";

            /*
            audioFile = new AudioFileReader(@"C:\Users\KBC2510\Desktop\github\Black_Jack_Poker\sound\kekka.wav");
            waveOut = new WaveOut();

            // 音量設定（0.0f ～ 1.0f の範囲で指定）
            audioFile.Volume = 10;

            waveOut.Init(audioFile);
            waveOut.Play();
            */

            display.Num(Num_panel, BJ);

            //もし、チップ数の桁が6桁より大きいなら小さいバージョンの数字を使用
            //どっちも検証はめんどくさいから片方のみ検証

            if (Before_Chip.ToString().Length > 6)
            {
                display.Num_small(Before_panel, Before_Chip);
                if (int.TryParse(After_Check_Chip, out int After_Chip))
                {
                    display.Num_small(After_panel, After_Chip);
                }
                else
                {
                    display.Nothing(After_panel, After_Check_Chip);
                }
            }
            else
            {
                display.Num(Before_panel, Before_Chip);
                if (int.TryParse(After_Check_Chip, out int After_Chip))
                {
                    display.Num(After_panel, After_Chip);
                }
                else
                {
                    display.Nothing(After_panel, After_Check_Chip);
                }
            }
        }
        private async void Text_tenmetu(object sender, EventArgs e)
        {
            Message_label.Visible = Message_label.Visible ? false : true;
        }
    }
}
