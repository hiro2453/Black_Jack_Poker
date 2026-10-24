using NAudio.Wave;

namespace BJ.Src
{
    public partial class Result : Form
    {
        Display display = new Display();
        private WaveOut waveOut;
        private AudioFileReader audioFile;
        public Result(int BJ, string PK, int Before_Chip,int After_Chip)
        {
            InitializeComponent();
            audioFile = new AudioFileReader(@"C:\Users\KBC2510\Desktop\github\Black_Jack_Poker\sound\kekka.wav");
            waveOut = new WaveOut();

            // 音量設定（0.0f ～ 1.0f の範囲で指定）
            audioFile.Volume = 10;

            waveOut.Init(audioFile);
            waveOut.Play();
            display.Num(Num_panel, BJ);
            display.Yaku(yaku_pic, PK);
            display.Num(Before_panel, Before_Chip);
            display.Num(After_panel, After_Chip);


        }
    }
}
