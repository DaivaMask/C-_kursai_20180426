using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13___0_izanga
{
    public partial class IvestiForma : Form
    {

        public string Tekstas { get; private set; }

        public IvestiForma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tekstas = textBox1.Text; //igaus nauja reiksme is tekstinio laukelio

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
