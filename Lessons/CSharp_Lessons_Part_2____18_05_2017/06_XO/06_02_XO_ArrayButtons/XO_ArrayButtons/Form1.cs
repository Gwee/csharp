using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XO_ArrayButtons
{
    public partial class Form1 : Form
    {
        private int[,] matr = new int[3, 3];   // Initial values 0
        private string currMove = "X";
        private int counter = 0;

        private Button[,] arrButtons = new Button[3, 3];

        public Form1()
        {
            InitializeComponent();
            int i, j;
            int w = 40, h = 40;
            for (i = 0; i < 3; i++)
                for (j = 0; j < 3; j++)
                {
                    arrButtons[i, j] = new Button();
                    arrButtons[i, j].Width = w;
                    arrButtons[i, j].Height = h;
                    arrButtons[i, j].Left = 1 + j % 3 * w;
                    arrButtons[i, j].Top = 40 + i * h;
                    arrButtons[i, j].Font = new Font("Microsoft Sans Serif", 15, FontStyle.Regular);
                    arrButtons[i, j].TabIndex = i * 3 + j;
 //                   arrButtons[i, j].Name = (i * 3 + j).ToString();
 //                   arrButtons[i, j].Tag = i * 3 + j;

                    arrButtons[i, j].Click += new EventHandler(btn_Click);
                    this.Controls.Add(arrButtons[i, j]);
                }
        }
        private void btn_Click(object sender, System.EventArgs e)
        {
            Button tempButton = (Button)sender;
            int i = tempButton.TabIndex / 3;
            int j = tempButton.TabIndex % 3;

            //int i = int.Parse(tempButton.Name) / 3;
            //int j = int.Parse(tempButton.Name) % 3;
            
            //int i = (int)tempButton.Tag / 3;
            //int j = (int)tempButton.Tag % 3;
 
            if (matr[i, j] == 0)
            {
                matr[i, j] = counter % 2 + 1;
                tempButton.Text = currMove;

                Check(i, j);
                nextStep();
            }
        }

        private void Check(int i, int j)
        {
            int ii, jj;

            for (ii = 0; ii < 3; ii++)
                if (matr[i, j] != matr[ii, j])
                    break;
            if (ii == 3)
                gameIsOver(true);

            for (jj = 0; jj < 3; jj++)
                if (matr[i, j] != matr[i, jj])
                    break;
            if (jj == 3)
                gameIsOver(true);

            if (i == j)
            {
                for (ii = 0; ii < 3; ii++)
                    if (matr[i, j] != matr[ii, ii])
                        break;
                if (ii == 3)
                    gameIsOver(true);
            }
            if (i + j == 2)
            {
                for (ii = 0; ii < 3; ii++)
                    if (matr[i, j] != matr[ii, 2 - ii])
                        break;
                if (ii == 3)
                    gameIsOver(true);
            }
        }

        private void gameIsOver(bool result)
        {
            if (result)
                MessageBox.Show("The game is over. " + currMove + "  conquer");
            else
                MessageBox.Show("The game is over. Drawn game");
            this.Close();
        }

        private void nextStep()
        {
            counter++;
            if (counter == 9)
                gameIsOver(false);

            if (counter % 2 == 1)
                currMove = "O";
            else currMove = "X";
            label2.Text = currMove;
        }
    }
}
