using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the german test.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Willkommen beim Test";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Do you really wanna close this program?", "Confirm", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
                this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hiermit erklären sie sich bereit ihre Seele zu verkaufen.");
            DialogResult y = MessageBox.Show("Are you sure?", "Too late now", MessageBoxButtons.YesNo);
            if (y == DialogResult.Yes)
                ;
            if (y == DialogResult.No)
                    MessageBox.Show("Wrong answer :)");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
