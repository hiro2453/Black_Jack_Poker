using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace BJ.Src
{
    public partial class Result : Form
    {
        display display = new display();
        public Result(int BJ, string PK, int Before_Chip,int After_Chip)
        {
            InitializeComponent();
            display.Num(Num_panel, BJ);
            display.Yaku(yaku_pic, PK);
            display.Num(Before_panel, Before_Chip);
            display.Num(After_panel, After_Chip);
        }
    }
}
