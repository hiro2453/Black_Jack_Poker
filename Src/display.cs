using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ.Src
{
    internal class Display
    {
        public void Num(Control name, int num)
        {
            name.Controls.Clear();

            foreach (char c in num.ToString())
            {
                PictureBox picnum = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.AutoSize,
                    Dock = DockStyle.Left,
                    Margin = new Padding(3, 0, 0, 0)
                };

                switch (c)
                {
                    case '0':
                        picnum.Image = Properties.Resources._00;
                        break;
                    case '1':
                        picnum.Image = Properties.Resources._01;
                        break;
                    case '2':
                        picnum.Image = Properties.Resources._02;
                        break;
                    case '3':
                        picnum.Image = Properties.Resources._03;
                        break;
                    case '4':
                        picnum.Image = Properties.Resources._04;
                        break;
                    case '5':
                        picnum.Image = Properties.Resources._05;
                        break;
                    case '6':
                        picnum.Image = Properties.Resources._06;
                        break;
                    case '7':
                        picnum.Image = Properties.Resources._07;
                        break;
                    case '8':
                        picnum.Image = Properties.Resources._08;
                        break;
                    case '9':
                        picnum.Image = Properties.Resources._09;
                        break;
                }

                name.Controls.Add(picnum);
            }
        }
        public void Yaku(PictureBox name,string Yaku)
        {
            switch (Yaku)
            {
                case "役無し":
                    name.Image = Properties.Resources.Hand_No1;
                    break;
                case "ワンペア":
                    name.Image = Properties.Resources.Hand_OnePair1;
                    break;
                case "ツーペア":
                    name.Image = Properties.Resources.Hand_TwoPair1;
                    break;
                case "スリーカード":
                    name.Image = Properties.Resources.Hand_ThreePair1;
                    break;
                case "ストレート":
                    name.Image = Properties.Resources.Hand_Straight1;
                    break;
                case "フラッシュ":
                    name.Image = Properties.Resources.Hand_Flash1;
                    break;
                case "フルハウス":
                    name.Image = Properties.Resources.Hand_FullHouse1;
                    break;
                case "フォーカード":
                    name.Image = Properties.Resources.Hand_FourCard1;
                    break;
                case "ストレートフラッシュ":
                    name.Image = Properties.Resources.Hand_StraightFlash1;
                    break;
                case "ロイヤルストレートフラッシュ":
                    name.Image = Properties.Resources.Hand_RoyalStraightFlush1;
                    break;
            }
        }
    }
}
