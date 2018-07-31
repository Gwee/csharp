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
        private int[] numMtrx = new int[15];
        List<int> rndList = new List<int>();
        private Button[,] btnArray = new Button[4, 4];
        private Random rnd = new Random();
        Button fucker;
        int rndNumber = 0;
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

                    btnArray[i, j].Width = w;
                    btnArray[i, j].Height = h;
                    btnArray[i, j].Left = 1 + j % 4 * w;
                    btnArray[i, j].Top = i * h;
                    btnArray[i, j].TabIndex = i * 4 + j;
                    btnArray[i, j].Click += new EventHandler(BtnClick);
                    if (i == 3 && j == 3)
                    {
                        btnArray[i, j].Text = "100";
                    }
                    else
                    {
                        rndNumber = GetRndNum();
                        btnArray[i, j].Text = Convert.ToString(rndNumber);
                    }
                    this.Controls.Add(btnArray[i, j]);
                }
            }
            fucker = btnArray[3, 3];
            HideButton(fucker);
        }
        private int GetRndNum ()
        {
            int retNum = rnd.Next(1,16);
            while (rndList.Contains(retNum))
            {
                retNum = rnd.Next(1,16);
            }
            rndList.Add(retNum);
            return retNum;
               
        }
        private void HideButton (Button b)
        {
            b.Visible = false;
            b.Tag = "hidden";
        }
        private void SwapArray(Button a, Button b)
        {
            Button temp;
            int Ia=0, Ja=0, Ib=0, Jb=0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (btnArray[i,j].Text == a.Text)
                    {
                        Ia = i;
                        Ja = j;
                    }
                    if (btnArray[i,j].Text == b.Text)
                    {
                        Ib = i;
                        Jb = j;
                    }

                }
            }
            temp = a;
            btnArray[Ia,Ja] = b;
            btnArray[Ib, Jb] = temp;
        }
        private void SwapWithHidden(Button b)
        {
            Button temp = b;
            int indx = b.TabIndex;
            Point loc = new Point(b.Top, b.Left); ;
            //HideButton(b);
            //fucker.Text = b.Text;
            //fucker.BackColor = b.BackColor;
            //fucker.Visible = true;
            //fucker = b;
            b.Location = new Point(fucker.Top, fucker.Left);
            b.TabIndex = fucker.TabIndex;
            fucker.Location = loc;
            fucker.TabIndex = indx;
            SwapArray(b, fucker);
        }
        private void SwapWithHiddenAnimate(Button b)
        {
            timer1.Start();
            Button temp = b;
            int indx = b.TabIndex;
            Point loc = new Point(b.Top, b.Left); ;
            b.Location = new Point(fucker.Top, fucker.Left);
            b.TabIndex = fucker.TabIndex;
            fucker.Location = loc;
            fucker.TabIndex = indx;
            timer1.Stop();
        }
        private void AnimateThisShit(Button b, Point dest)
        {
            for (int i = 0; i < 40; i++)
            {

            }
        }
        private Boolean CheckWinState()
        {
            bool sorted = true;
            int[] tmp = new int[btnArray.Length];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    tmp[i * 4 + j] = Int32.Parse(btnArray[i, j].Text);
                    
                }
            }
            for (int i = 1; i < tmp.Length; i++)
            {
                if (tmp[i- 1] > tmp[i])
                {
                    sorted = false;
                }
                if (i == 14)
                {
                    if (tmp[14] == 15 && tmp[15] == 14)
                    {
                        MessageBox.Show("Game is not winnable");
                        //this.Close();  pop up the Game Over screen with message not winnable
                    }
                }
                else
                {
                    continue;
                }
            }
            if (sorted)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void BtnClick(object sender, EventArgs e)
        {
            if (((Button)sender).TabIndex +1 == fucker.TabIndex || ((Button)sender).TabIndex - 1 == fucker.TabIndex || ((Button)sender).TabIndex + 4 == fucker.TabIndex || ((Button)sender).TabIndex -4 == fucker.TabIndex)
            {
                //SwapWithHidden((Button)sender);
                SwapWithHidden((Button)sender);

                if (CheckWinState())
                {
                    MessageBox.Show("Winner!");
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("tick fucker");
            Console.WriteLine("tick");
        }
    }
}
