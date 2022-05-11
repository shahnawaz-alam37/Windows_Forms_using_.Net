using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello "+textBox1.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked){
                textBox1.UseSystemPasswordChar = false;
                }
            else
            {
                textBox1.UseSystemPasswordChar = true;
            }
        }
        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("nice");
        }

        private void newOneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 ff = new Form2();
            ff.Show(); 
        }
    }
}
