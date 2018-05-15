using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13___5_uzduotis
{
    public partial class Ivedimas : Form
    {
        public Knyga Knyga { get; private set; }

        public Ivedimas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // cia pasiimti visus knygos duomenis ir sudeti i klaseje esanti objekta knyga
            //using (var ivesti = new Ivedimas())
            //{
               //ivesti.ShowDialog();

                //if (ivesti.DialogResult == DialogResult.OK)
                //{
                    //textBox1.Text = Knyga.Autorius;
                    //textBox2.Text = Knyga.Pavadinimas;
                    //textBox3.Text = Convert.ToInt32(Knyga.PuslapiuSkaicius);
                    //textBox4.Text = Convert.ToDouble(Knyga.Kaina);

                    ////string autorius = Knyga.Autorius(textBox1.Text);
                    ////string pavadinimas = Knyga.Pavadinimas(textBox2.Text);
                    //int puslapiuSkaicius = Convert.ToInt32 ( Knyga.PuslapiuSkaicius(textBox3.Text));

                    var vardas = textBox1.Text;
                    var uzvadinimas = textBox2.Text;
                    var puslapiai = Convert.ToInt32(textBox3.Text);
                    var kainuke = Convert.ToDouble(textBox4.Text);

                    Knyga = new Knyga(vardas, uzvadinimas, puslapiai, kainuke);



                //}
            //}


            //textBox1 = Knyga.Autorius;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
