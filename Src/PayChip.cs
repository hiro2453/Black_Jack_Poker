using static System.Net.Mime.MediaTypeNames;

namespace BJ.Src
{
    public partial class PayChip : Form
    {
        private FlowLayoutPanel[] panels;

        public PayChip(int chip)
        {
            InitializeComponent();
            panels = new FlowLayoutPanel[]
            {
                flowLayoutPanel0,
                flowLayoutPanel1,
                flowLayoutPanel2,
                flowLayoutPanel3,
                flowLayoutPanel4,
                flowLayoutPanel5,
                flowLayoutPanel6,
                flowLayoutPanel7,
                flowLayoutPanel8
            };
            keisan(chip);
        }
        private void keisan(int c)
        {
            for (int i = 0; i <= 8; i++)
            {
                Display_Nunber(c, panels[i],i);
            }
        }

        private void Display_Nunber(int chip, FlowLayoutPanel name,int num)
        {
            name.Controls.Clear();
            int Width = 20;
            int Width_1 = 0;
            int height = 0;
            int top = 0;
            int a = 0;
            double[] tests = { 1.05, 1.1, 1.15, 1.2, 1.5, 2, 5, 50, 300 };
            string chip_text = (Math.Ceiling(chip * tests[num])- chip).ToString();

            for (int i = 1; i < chip_text.Length; i++)
            {
                if (i % 3 == 0)
                {
                    a++;
                    Console.WriteLine($"{name.Name}のコンマの数は{a}");
                    chip_text = chip_text.Insert(i, ",");
                }
            }

            foreach (char item in chip_text)
            {
                PictureBox pic = new PictureBox();
                pic.Margin = new Padding(1, 0, 1, 0);

                if (num < 6)
                {
                    pic.Size = new Size(Width, 50);
                }
                else
                {
                    height = 20;
                    Width_1 = 30;
                    top = 15;
                    pic.Size = new Size(Width+10, 50);
                    pic.Margin = new Padding(1, 25, 1, 0);
                }

                switch (item)
                {
                    case '0':
                        pic.Image = Properties.Resources._0;
                        break;
                    case '1':
                        pic.Size = new Size(Width+Width_1, height + 30);
                        pic.Margin = new Padding(1, 10+top, 1, 0);
                        pic.Image = Properties.Resources._1;
                        break;
                    case '2':
                        pic.Image = Properties.Resources._2;
                        break;
                    case '3':
                        pic.Image = Properties.Resources._3;
                        break;
                    case '4':
                        pic.Image = Properties.Resources._4;
                        break;
                    case '5':
                        pic.Image = Properties.Resources._5;
                        break;
                    case '6':
                        pic.Image = Properties.Resources._6;
                        break;
                    case '7':
                        pic.Image = Properties.Resources._7;
                        break;
                    case '8':
                        pic.Image = Properties.Resources._8;
                        break;
                    case '9':
                        pic.Image = Properties.Resources._9;
                        break;
                    case ',':
                        pic.Image = Properties.Resources.Comma;
                        break;
                    case '円':
                        pic.Image = Properties.Resources.en;
                        break;

                }
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                name.Controls.Add(pic);
                name.Controls.SetChildIndex(pic, 0);
            }
        }
    }
}
