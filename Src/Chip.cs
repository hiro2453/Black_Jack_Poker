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
            Debt_label.Text = Properties.Settings.Default.Debt ? "※借金可能" : "※借金できません";

        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            Chip_Count.Text = "0";
            Enter_Button.Enabled = false;
        }

        private void Max_Button_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Chip > 1000000)
            {
                Chip_Count.Text = "999999";
                Enter_Button.Enabled = true;
            }
        }
        
        private void Num_Button_Click(object sender, EventArgs e)
        {
            if (Chip_Count.Text.Length <= 6)
            {
                Button btn = sender as Button;
                if (Chip_Count.Text == "0")
                {
                    Chip_Count.Text = btn.Text;
                }
                else
                {
                    Chip_Count.Text = Chip_Count.Text + btn.Text;
                }

                if (Chip_Count.Text.Length < Chip_Count.Text.Length)
                {
                    
                }
            }

            if (Chip_Count.Text.Length > 6)
            {
                if (Properties.Settings.Default.Debt == true)
                {
                    Chip_Count.Text = "999999";
                }
                else
                {
                    Chip_Count.Text = Properties.Settings.Default.Chip.ToString();
                }
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
