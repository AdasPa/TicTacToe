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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        bool playerTurn = true;
        int counter = 0;
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

        bool ended = false;
        private void button_Click(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            if (playerTurn)
                b.Text = "X";
            else
                b.Text = "O";
            b.Enabled = false;
            counter++;
            if (check())
            {
                if (playerTurn)
                {
                    MessageBox.Show("Player X won, congratulations!");
                    ended = true;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Player O won, congratulations!");
                    ended = true;
                    this.Hide();
                }
            }
            if(counter == 9 && !ended)
            {
                MessageBox.Show("It's a draw, it seems both of you can think...");
                ended = true;
                this.Hide();
            }

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
