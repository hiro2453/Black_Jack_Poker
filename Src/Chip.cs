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
            if (Properties.Settings.Default.Chip > 1000000)
            {
                Chip_Count.Text = "999999";
                Enter_Button.Enabled = true;
            }
        }
        
        private void Num_Button_Click(object sender, EventArgs e)
        {
            Enter_Button.Enabled = true;

            if (int.Parse(Chip_Count.Text) <= int.Parse(Chip_before.Text))
            {
                //押したボタンの情報をbtnに格納
                Button btn = (Button)sender;

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

            if (int.Parse(Chip_Count.Text) > int.Parse(Chip_before.Text))
            {
                if (Properties.Settings.Default.Debt == true)
                {
                    if (int.Parse(Chip_before.Text) - int.Parse(Chip_Count.Text) < -1)
                    {
                        Chip_Count.Text = Chip_before.Text;
                    }
                }
                else
                {
                    Chip_Count.Text = Properties.Settings.Default.Chip.ToString();
                }
            }

        }

        private void Enter_Button_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.battle_chip = int.Parse(Chip_Count.Text);
            Properties.Settings.Default.Save();
            this.DialogResult = DialogResult.OK;
        }
        private void Chip_Change(object sender, EventArgs e)
        {
            int num = Properties.Settings.Default.Chip - int.Parse(Chip_Count.Text);
            Chip_After.Text = num.ToString();
        }
    }
}
