using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW1
{
    public partial class Form1 : Form
    {
        private int[,] numMtrx = new int[4,4];
        private Button[,] btnArray = new Button[4, 4];
        private Random rnd = new Random();
        Button fucker;
        public Form1()
        {
            InitializeComponent();
            int w = 60, h = 60;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                    btnArray[i, j] = new Button();
                    btnArray[i, j].BackColor = randomColor;
                    btnArray[i, j].FlatStyle = FlatStyle.Flat;
                    btnArray[i, j].FlatAppearance.BorderColor = Color.Black;
                    btnArray[i, j].FlatAppearance.BorderSize = 1;
                    while (true)
                    {
                        int rndNum = rnd.Next(1, 17);
                        if (!isNumInArr(rndNum))
                        {
                            numMtrx[i, j] = rndNum;
                            break;
                        }
                    }
                    btnArray[i, j].Text = Convert.ToString((numMtrx[i,j]));
                    btnArray[i, j].Width = w;
                    btnArray[i, j].Height = h;
                    btnArray[i, j].Left = 1 + j % 4 * w;
                    btnArray[i, j].Top = i * h;
                    btnArray[i, j].TabIndex = i * 4 + j;
                    btnArray[i, j].Click += new EventHandler(BtnClick);
                    this.Controls.Add(btnArray[i, j]);
                }
            }
            fucker = btnArray[3, 3];
            HideButton(fucker);
        }
        private Boolean isNumInArr (int num)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (numMtrx[i, j] == num)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private void HideButton (Button b)
        {
            b.Visible = false;
            b.Tag = "hidden";
        }
        private void SwapWithHidden(Button b)
        {

            HideButton(b);
            fucker.Text = b.Text;
            fucker.BackColor = b.BackColor;
            fucker.Visible = true;
            fucker = b;
            

        }
        private Boolean CheckWinState()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    if (Int32.Parse(btnArray[i,j-1].Text) > Int32.Parse(btnArray[i,j].Text))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void BtnClick(object sender, EventArgs e)
        {
            if (((Button)sender).TabIndex +1 == fucker.TabIndex || ((Button)sender).TabIndex - 1 == fucker.TabIndex || ((Button)sender).TabIndex + 4 == fucker.TabIndex || ((Button)sender).TabIndex -4 == fucker.TabIndex)
            {
                SwapWithHidden((Button)sender);
                if (CheckWinState())
                {
                    MessageBox.Show("Winner!");
                }
            }

        }

    }
}
