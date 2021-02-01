using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TicTacToe
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            label2.Hide();
            MessageBox.Show("Maybe next time...");
            this.Hide();
        }

        private void WaitNSeconds(int segundos)
        {
            if (segundos < 1) return;
            DateTime _desired = DateTime.Now.AddSeconds(segundos);
            while (DateTime.Now < _desired)
            {
                System.Windows.Forms.Application.DoEvents();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            
            label1.Show();
            pictureBox1.Show();
            button1.Show();
            button1.Focus();
            label2.Focus();
            button2.Hide();


            WaitNSeconds(10);
            label1.Text = "Do you really think someone is playing this game right now?";
            WaitNSeconds(10);
            label1.Text = "It looks like you are really waiting for something...";
            WaitNSeconds(10);
            label1.Text = "Wow, you are really good...";
            WaitNSeconds(10);
            label1.Text = "Do you still believe it's an online game?";
            WaitNSeconds(10);
            label1.Text = "XD";
            WaitNSeconds(10);
            pictureBox2.Show();
            label1.Text = "Marcinku, poczekaj jeszcze, przyjadę za godzinę, siemanko!";

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
