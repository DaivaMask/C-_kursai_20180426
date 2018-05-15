using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13___5_uzduotis
{
    public partial class Biblioteka : Form
    //private void atidarytiFailaToolStripMenuItem_Click(object sender, EventArgs e)
    {
        public List<Knyga> Knygos { get; } = new List<Knyga>();


        public Biblioteka()
        {
            InitializeComponent();
        }

        private void baigtiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void atidarytiFailaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (var failas = new OpenFileDialog())
            {
                failas.InitialDirectory = "D:\\C#\\C_kursai_20180424\\13 - 5 uzduotis";
                failas.Filter = "csv failas (*.csv)|*.csv";


                if (failas.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        foreach (var failiukas in failas.FileNames)
                        {
                            var tekstas = File.ReadAllLines(failiukas);
                            foreach (var eilute in tekstas)
                            {
                                Knygos.Add(new Knyga(eilute));

                            }

                            dataGridView3.DataSource = Knygos;
                            label1.Text = "Visa lentynos suma " + LentynosSuma();

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("error" + ex.Message);
                    }
                }

            }
        }

        private void ivestinaujaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Reikes ivesti autoriu, pavadinima, puslapiu skaiciu ir kaina.");

            Ivedimas ivedimas = new Ivedimas();

            ivedimas.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

            
        }

        public double LentynosSuma()
        {
            double suma = 0;
            foreach (var kainele in Knygos)
            {
                suma += (double) kainele.Kaina;
            }
            return suma;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Kiek ledu porciju iseina? :) ");
        }
    }
}
