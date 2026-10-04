using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BJ
{
    public partial class Chip : Form
    {
        public Chip()
        {
            InitializeComponent();
            Check();
        }

        private void Check()
        {
            Chip_before.Text = Properties.Settings.Default.Chip.ToString();
            Chip_After.Text = Properties.Settings.Default.Chip.ToString();
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            Chip_Count.Text = "0";
            Enter_Button.Enabled = false;
        }

        private void Max_Button_Click(object sender, EventArgs e)
        {
            Chip_Count.Text = "100";
            Enter_Button.Enabled = true;
        }

        private void Num0_Button_Click(object sender, EventArgs e)
        {
            int Count = int.Parse(Chip_Count.Text);
            if (Count >= 10)
            {
                Chip_Count.Text = "100";
            }
            else if (Chip_Count.Text == "0")
            {
                Chip_Count.Text = "0";
            }
            else
            {
                Chip_Count.Text = Chip_Count.Text + "0";
                Enter_Button.Enabled = true;
            }
        }

        private void Num1_Button_Click(object sender, EventArgs e)
        {
            int Count = int.Parse(Chip_Count.Text);
            Enter_Button.Enabled = true;
            if (Count >= 10)
            {
                Chip_Count.Text = "100";
            }
            else if (Chip_Count.Text == "0")
            {
                Chip_Count.Text = "1";
            }
            else
            {
                Chip_Count.Text = Chip_Count.Text + "1";
            }
        }

        private void Num2_Button_Click(object sender, EventArgs e)
        {
            int Count = int.Parse(Chip_Count.Text);
            Enter_Button.Enabled = true;
            if (Count >= 10)
            {
                Chip_Count.Text = "100";
            }
            else if (Chip_Count.Text == "0")
            {
                Chip_Count.Text = "2";
            }
            else
            {
                Chip_Count.Text = Chip_Count.Text + "2";
            }
        }

        private void Num3_Button_Click(object sender, EventArgs e)
        {
            int Count = int.Parse(Chip_Count.Text);
            Enter_Button.Enabled = true;
            if (Count >= 10)
            {
                Chip_Count.Text = "100";
            }
            else if (Chip_Count.Text == "0")
            {
                Chip_Count.Text = "3";
            }
            else
            {
                Chip_Count.Text = Chip_Count.Text + "3";
            }
        }

        private void Num4_Button_Click(object sender, EventArgs e)
        {
            int Count = int.Parse(Chip_Count.Text);
            Enter_Button.Enabled = true;
            if (Count >= 10)
            {
                Chip_Count.Text = "100";
            }
            else if (Chip_Count.Text == "0")
            {
                Chip_Count.Text = "4";
            }
            else
            {
                Chip_Count.Text = Chip_Count.Text + "5";
            }
        }

        private void Num5_Button_Click(object sender, EventArgs e)
        {
            int Count = int.Parse(Chip_Count.Text);
            Enter_Button.Enabled = true;
            if (Count >= 10)
            {
                Chip_Count.Text = "100";
            }
            else if (Chip_Count.Text == "0")
            {
                Chip_Count.Text = "5";
            }
            else
            {
                Chip_Count.Text = Chip_Count.Text + "5";
            }
        }

        private void Num6_Button_Click(object sender, EventArgs e)
        {
            int Count = int.Parse(Chip_Count.Text);
            Enter_Button.Enabled = true;
            if (Count >= 10)
            {
                Chip_Count.Text = "100";
            }
            else if (Chip_Count.Text == "0")
            {
                Chip_Count.Text = "6";
            }
            else
            {
                Chip_Count.Text = Chip_Count.Text + "6";
            }
        }

        private void Num7_Button_Click(object sender, EventArgs e)
        {
            int Count = int.Parse(Chip_Count.Text);
            Enter_Button.Enabled = true;
            if (Count >= 10)
            {
                Chip_Count.Text = "100";
            }
            else if (Chip_Count.Text == "0")
            {
                Chip_Count.Text = "7";
            }
            else
            {
                Chip_Count.Text = Chip_Count.Text + "7";
            }
        }

        private void Num8_Button_Click(object sender, EventArgs e)
        {
            int Count = int.Parse(Chip_Count.Text);
            Enter_Button.Enabled = true;
            if (Count >= 10)
            {
                Chip_Count.Text = "100";
            }
            else if (Chip_Count.Text == "0")
            {
                Chip_Count.Text = "8";
            }
            else
            {
                Chip_Count.Text = Chip_Count.Text + "8";
            }
        }

        private void Num9_Button_Click(object sender, EventArgs e)
        {
            int Count = int.Parse(Chip_Count.Text);
            Enter_Button.Enabled = true;
            if (Count >= 10)
            {
                Chip_Count.Text = "100";
            }
            else if (Chip_Count.Text == "0")
            {
                Chip_Count.Text = "9";
            }
            else
            {
                Chip_Count.Text = Chip_Count.Text + "9";
            }
        }

        private void Enter_Button_Click(object sender, EventArgs e)
        {
            int test = int.Parse(Chip_Count.Text);
            Properties.Settings.Default.Save();
            // 遷移先の Game フォームを生成
            Game GameForm = new Game(test);

            // Game フォームを表示
            GameForm.Show();

            // Title フォームを非表示にする（または Close() で閉じる）
            this.Hide();
        }

        private void Chip_Change(object sender, EventArgs e)
        {
            int num = Properties.Settings.Default.Chip - int.Parse(Chip_Count.Text);
            Chip_After.Text = num.ToString();
        }
    }
}
