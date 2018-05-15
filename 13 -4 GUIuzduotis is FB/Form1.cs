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

namespace _13__4_GUIuzduotis_is_FB
{
    public partial class Form1 : Form
    {
        private readonly object tabControlSalys;

        public Form1()
        {
            InitializeComponent();
        }

        private void baigtiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void atidarytiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var failoPasirinkimoLangas = new OpenFileDialog())
            {
                failoPasirinkimoLangas.InitialDirectory = "D:\\C#\\C_kursai_20180424\\13 -4 GUIuzduotis is FB";
                failoPasirinkimoLangas.Filter = "csv failas (*.csv)|*.csv";
                failoPasirinkimoLangas.Multiselect = true;


                if (failoPasirinkimoLangas.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        foreach (var failas in failoPasirinkimoLangas.FileNames)
                        {
                            var tekstas = File.ReadAllLines(failas);
                            foreach (var eilute in tekstas)
                            {
                                Miestas.Add(new Miestas(eilute));

                            }
                            var skirtukas = new TabPage("atvaizduojamas skirtuko pav");
                            tabControl1.Controls.Add(skirtukas);

                            skirtukas.Controls.Add(new DataGridView()
                            {
                                Dock = DockStyle.Fill,
                                //DataSource = Pasaulis.Salis.Last().Miestai
                            });

                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                //parodymas
                //var skirtukas = new TabPage(Miestas.duomenys[0]);
                //tabControlSalys.Controls.Add(skirtukas);

                //skirtukas.Controls.Add(new DataGridView()
                //{
                //    Dock = DockStyle.Fill,
                //    DataSource = Pasaulis.Salys.Last().Miestai
                //});
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {


        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
           


        }
    }
}
