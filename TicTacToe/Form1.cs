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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /**var Form5 = new Form5();
            Form5.Show();**/
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Come on...");
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.pacek.it");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /**var Form4 = new Form4();
            Form4.Show();**/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /**var Form2 = new Form2();
            Form2.Show();**/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /**var Form3 = new Form3();
            Form3.Show();**/
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Focus();
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            var Form2 = new Form2();
            Form2.Show();
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Focus();
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            var Form3 = new Form3();
            Form3.Show();
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Focus();
        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            var Form5 = new Form5();
            Form5.Show();
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Focus();
        }

        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            var Form4 = new Form4();
            Form4.Show();
        }

        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Focus();
        }

        private void button5_MouseUp(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Come on...");
        }
    }
}