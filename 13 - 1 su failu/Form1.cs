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

namespace _13___1_su_failu
{
    public partial class Form1 : Form
    {
        //propg
        public List<Automobilis> Automobiliai { get; } //= new List<Automobilis>(); --galima taip vietoj konstruktoriaus


        public Form1()
        {
            InitializeComponent();
            Automobiliai = new List<Automobilis>();
        }

        private void išeitiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void atidarytiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var failas = new OpenFileDialog())
            {
                failas.InitialDirectory = "D:\\C#\\C_kursai_20180424\\13 - 1 su failu";
                failas.Filter = "csv failas (*.csv)|*.csv"; //rodys ir leis parinkti tik tokio tipo failus
                                                            // failas.ShowDialog(); //iskvieciamas langas failo paieskai

                //MessageBox.Show(failas.FileName);

                if (failas.ShowDialog() == DialogResult.OK) // iskviecia langa failo paieskai, tikrins ar egzistuoja failas
                {
                    try
                    {
                        var tekstas = File.ReadAllLines(failas.FileName);
                        foreach (var eilute in tekstas)
                        {
                            //MessageBox.Show(eilute);

                            //var auto = new Automobilis(eilute);
                            //Automobiliai.Add(auto);
                            //dvi eilutes virsuj tas pats kaip eilute zemiau
                            Automobiliai.Add(new Automobilis(eilute));

                        }

                        dataGridView1.DataSource = Automobiliai; //atvaizduos eilutej (i forma reikia isikelti DataGridView)

                        // dataGridView1.Rows....
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    }
                }
            }
        }
    }
}
