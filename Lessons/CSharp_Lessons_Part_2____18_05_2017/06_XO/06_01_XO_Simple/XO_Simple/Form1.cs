using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XO_Simple
{
    public partial class Form1 : Form
    {
        private int[,] matr = new int[3, 3];     // Initial values 0
        private string currMove = "X";
        private int counter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button tempButton = (Button)sender;
            int i = tempButton.TabIndex / 3;
            int j = tempButton.TabIndex % 3;
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