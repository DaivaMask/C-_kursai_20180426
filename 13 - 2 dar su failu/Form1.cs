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

namespace _13___2_dar_su_failu
{
    public partial class Form1 : Form
    {
        private object dataGridView2;

        public List<Zmones> Zmones { get; } = new List<Zmones>();

        public Form1()
        {
            InitializeComponent();
        }

        private void iseitiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void atidarytiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var failas = new OpenFileDialog())
            {
                //failas.InitialDirectory = "D:\\C#\\C_kursai_20180424\\13 - 2 dar su failu";
                failas.Filter = "csv failas (*.csv)|*.csv";

                if (failas.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var tekstas = File.ReadAllLines(failas.FileName);
                        foreach (var eilute in tekstas)
                        {
                            Zmones.Add(new Zmones(eilute));
                        }

                        dataGridView2.DataSource = Zmones; //i forma reikia isikelti DataGridView
                        label1.Text = "Bendras zmoniu amzius " + AmziuSuma(); //iskviecia bendro amziaus sumos metoda AmziuSuma

                    }
                    catch(Exception ex) //try pabaiga
                    {
                        MessageBox.Show(ex.Message);
                    }

                 }
            }
        }
        //label1 parodytu visa zmoniu amziu

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        public int AmziuSuma()
        {
            var suma = 0;
            foreach (var metai in Zmones)
            {
                suma += metai.Amzius;
            }
            return suma;
        }
    }
}
