using NAudio.Wave;

namespace BJ.Src
{
    public partial class Result : Form
    {
        Display display = new Display();
        public Result(int battle_count, int BJ, int Before_Chip, int After_Chip)
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
            display.Num(Before_panel, Before_Chip);
            display.Num(After_panel, After_Chip);
        }

        private async void Text_tenmetu(object sender, EventArgs e)
        {
            Message_label.Visible = Message_label.Visible ? false : true;
        }
    }
}
