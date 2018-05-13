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
    public partial class GautiDuomenysForma : Form
    {
        public GautiDuomenysForma(int skaicius) //konstruktorius
        {
            InitializeComponent();
            label1.Text = skaicius.ToString();
        }
    }
}
