using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            Major.Text=radioButton1.Text;
            if (radioButton2.Checked)
                Major.Text = radioButton2.Text;
            if (radioButton3.Checked)
                Major.Text = radioButton3.Text;
            if (radioButton4.Checked)
                Major.Text = radioButton4.Text;
            if (radioButton5.Checked)
                Major.Text = radioButton5.Text;
            if (radioButton6.Checked)
                Major.Text = radioButton6.Text;
            if (radioButton7.Checked)
                Major.Text = radioButton7.Text;
            if (radioButton8.Checked)
                Major.Text = radioButton8.Text;
            if (radioButton9.Checked)
                Major.Text = radioButton9.Text;

        }
    }
}
