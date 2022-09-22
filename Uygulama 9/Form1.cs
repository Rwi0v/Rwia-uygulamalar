using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rwi0v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Mouse Button3'e tıkladı";
            button3.BackColor = Color.Gray;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Text = "Mouse Button1'e tıkladı";
            button1.BackColor = Color.Blue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Mouse Button2'e tıkladı";
            button2.BackColor = Color.Red;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "Mouse Button3'e tıkladı";
            button4.BackColor = Color.Green;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "Mouse Button4'den ayrıldı.";
            button4.BackColor = Color.Transparent;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "Mouse Button3'den ayrıldı.";
            button3.BackColor = Color.Transparent;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "Mouse Button2'den ayrıldı.";
            button2.BackColor = Color.Transparent;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "Mouse Button1'den ayrıldı.";
            button1.BackColor = Color.Transparent;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Mouse Button1'in üstünde.";
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Mouse Button2'nin üstünde.";
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Mouse Button3'ün üstünde.";
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Mouse Button4'ün üstünde.";
        }

    }
}
