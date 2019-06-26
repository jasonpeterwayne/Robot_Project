using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_2019_06_26_
{
    public partial class Form1 : Form
    {
        int change;
        int result;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            trackBar1.Value = change;
            label4.Text = trackBar1.Value.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label4.Text = trackBar1.Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(int.TryParse(textBox1.Text, out result))
            {
                change = result;
            }
            else
            {
                change = 0;
            }
        }
    }
}
