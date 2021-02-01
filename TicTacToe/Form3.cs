using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form3 : Form
    {
        bool playerTurn = true;

        public Form3()
        {
            InitializeComponent();
        }

        public bool check()
        {
            bool isWinner = false;

            if (button1.Text == button2.Text && button1.Text == button3.Text && button1.Text != "")
                isWinner = true;
            else if (button1.Text == button4.Text && button1.Text == button7.Text && button1.Text != "")
                isWinner = true;
            else if (button1.Text == button5.Text && button1.Text == button9.Text && button1.Text != "")
                isWinner = true;
            else if (button2.Text == button5.Text && button2.Text == button8.Text && button2.Text != "")
                isWinner = true;
            else if (button3.Text == button6.Text && button3.Text == button9.Text && button3.Text != "")
                isWinner = true;
            else if (button3.Text == button5.Text && button3.Text == button7.Text && button3.Text != "")
                isWinner = true;
            else if (button4.Text == button5.Text && button4.Text == button6.Text && button4.Text != "")
                isWinner = true;
            else if (button7.Text == button8.Text && button7.Text == button9.Text && button7.Text != "")
                isWinner = true;

            return (isWinner);
        }

        public int isOpportunity(string move)
        {

            int free = 0;
            if (button1.Text == button2.Text && button3.Text == "" && button1.Text == move)
                free = 3;
            else if (button1.Text == button3.Text && button2.Text == "" && button1.Text == move)
                free = 2;
            else if (button1.Text == button5.Text && button9.Text == "" && button1.Text == move)
                free = 9;
            else if (button1.Text == button9.Text && button5.Text == "" && button1.Text == move)
                free = 5;
            else if (button1.Text == button4.Text && button7.Text == "" && button1.Text == move)
                free = 7;
            else if (button1.Text == button7.Text && button4.Text == "" && button1.Text == move)
                free = 4;

            else if (button2.Text == button3.Text && button1.Text == "" && button2.Text == move)
                free = 1;
            else if (button2.Text == button5.Text && button8.Text == "" && button2.Text == move)
                free = 8;
            else if (button2.Text == button8.Text && button5.Text == "" && button2.Text == move)
                free = 5;

            else if (button3.Text == button5.Text && button7.Text == "" && button3.Text == move)
                free = 7;
            else if (button3.Text == button6.Text && button9.Text == "" && button3.Text == move)
                free = 9;
            else if (button3.Text == button9.Text && button6.Text == "" && button3.Text == move)
                free = 6;
            else if (button3.Text == button7.Text && button5.Text == "" && button3.Text == move)
                free = 5;

            else if (button4.Text == button5.Text && button6.Text == "" && button4.Text == move)
                free = 6;
            else if (button4.Text == button6.Text && button5.Text == "" && button4.Text == move)
                free = 5;
            else if (button4.Text == button7.Text && button1.Text == "" && button4.Text == move)
                free = 1;

            else if (button5.Text == button6.Text && button4.Text == "" && button5.Text == move)
                free = 4;
            else if (button5.Text == button9.Text && button1.Text == "" && button5.Text == move)
                free = 1;
            else if (button5.Text == button8.Text && button2.Text == "" && button5.Text == move)
                free = 2;
            else if (button5.Text == button7.Text && button3.Text == "" && button5.Text == move)
                free = 3;

            else if (button6.Text == button9.Text && button3.Text == "" && button6.Text == move)
                free = 3;

            else if (button7.Text == button8.Text && button9.Text == "" && button7.Text == move)
                free = 9;
            else if (button7.Text == button9.Text && button8.Text == "" && button7.Text == move)
                free = 8;

            else if (button8.Text == button9.Text && button7.Text == "" && button8.Text == move)
                free = 7;


            return (free - 1);
        }

        int counter = 0;

        private void button_Click(object sender, EventArgs e)
        {


            Button[] av = new Button[9];

            av[0] = button1;
            av[1] = button2;
            av[2] = button3;
            av[3] = button4;
            av[4] = button5;
            av[5] = button6;
            av[6] = button7;
            av[7] = button8;
            av[8] = button9;


            bool ended = false;
            Button b = (Button)sender;
            b.Text = "X";
            b.Enabled = false;
            if (!ended && check())
            {
                MessageBox.Show("You won, congratulations!");
                ended = true;
                this.Hide();
            }

            counter++;
            playerTurn = !playerTurn;

            if (!ended && counter == 9)
            {
                MessageBox.Show("It's a draw, tough game!");
                ended = true;
                this.Hide();
            }


            //computer move

            if (counter == 1)
            {
                if (av[4].Enabled)
                {
                    av[4].Text = "O";
                    av[4].Enabled = false;
                }
                else
                {
                    av[0].Text = "O";
                    av[0].Enabled = false;
                }
            }
            else
            {
                int op = isOpportunity("O");
                if (op != -1)
                {
                    av[op].Text = "O";
                    av[op].Enabled = false;
                }
                else
                {
                    int th = isOpportunity("X");
                    if (th != -1)
                    {
                        av[th].Text = "O";
                        av[th].Enabled = false;
                    }
                    else
                    {
                        Random r = new Random();
                        while (!ended && true)
                        {
                            int i = r.Next(0, 8);
                            if (av[i].Enabled)
                            {
                                av[i].Text = "O";
                                av[i].Enabled = false;
                                break;
                            }
                        }
                    }
                }

                /**for (int i = 0; i < 9; i++)
                {
                    if (av[i].Enabled)
                    {
                        av[i].Text = "O";
                        av[i].Enabled = false;
                        break;
                    }
                }**/
            }

            if (!ended && check())
            {
                MessageBox.Show("You lost, hahaha!");
                ended = true;
                this.Hide();
            }

            counter++;
            playerTurn = !playerTurn;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }
    }
}
