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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //mbox
            MessageBox.Show("Pranesimas");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tekstoLaukelis.Text);
            var skaicius = Convert.ToInt32(tekstoLaukelis.Text); //jeigu reikes gauti skaicius
            MessageBox.Show(skaicius.ToString()); //jeigu reikes pakeisti i teksta (2eil)
            tekstoLaukelis.Text = ""; //paliks tuscia eilute (tekstinio laukelio isvalymas)
        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    var skaicius = Convert.ToInt32(perkelti.Text);
        //    var forma = new GautiDuomenysForma(skaicius);
        //    forma.ShowDialog(); //atvaizduos forma
        //}

        private void button3_Click_1(object sender, EventArgs e)
        {
            var skaicius = Convert.ToInt32(perkelti.Text);
            var forma = new GautiDuomenysForma(skaicius);
            forma.ShowDialog(); //atvaizduos forma
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var forma = new IvestiForma())
            {
                forma.ShowDialog();

                if (forma.DialogResult == DialogResult.OK)
                {
                    label1.Text = forma.Tekstas;
                }
            }
        }
    }
}
