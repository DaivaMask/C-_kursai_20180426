using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20_2_pvz2_randomEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += MetaMessageBox; //ivykis 'click'
            textBox1.Click += textBox1_Click;

        }
        private void MetaMessageBox(object sender, EventArgs e)
        {
            MessageBox.Show("Issoko langas");
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Labas";
        }
    }
}
