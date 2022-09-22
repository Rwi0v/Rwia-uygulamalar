using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rwi0v1
{
    public partial class ButonDuyuru : Form
    {
        public ButonDuyuru()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Text = "Mouse, buton1'e tıkladı.";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "Mouse, buton1'den ayrıldı.";
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Mouse, buton1'in üzerinde.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Mouse, buton2'e tıkladı.";
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Mouse, buton2'nin üzerinde.";
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "Mouse, buton3'den ayrıldı.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Mouse, buton3'e tıkladı.";
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Mouse, buton3'ün üzerinde.";
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "Mouse, buton3'den ayrıldı.";
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Mouse, buton4'ün Üzerinde.";
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "Mouse, buton4'den ayrıldı.";
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Text = "Mouse, buton4'e Tıkladı.";
        }
    }
}
