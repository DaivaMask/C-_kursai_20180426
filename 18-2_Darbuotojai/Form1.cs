using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_2_Darbuotojai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string line;
            System.IO.StreamReader reader = new System.IO.StreamReader("IDList.txt"); //kelias nusirodytu @"c:\users...."
            System.IO.StreamReader readeris = new System.IO.StreamReader("Darbuotojai.txt");

            while ((line = reader.ReadLine()) != null)
            {
                ComboUsersID.Items.Add(line);

            }

              

                while ((line = readeris.ReadLine()) != null)
                {
                    try
                    {
                        string[] data = line.Split(' ');
                        int year = int.Parse((data[3])) / 10000;
                        if (year > DateTime.Today.Year)
                        {
                            throw new DataException("netinkamai parinkti metai (daugiau uz 2018). Patikrink duomenis");
                        }

                    //int month = int.Parse((data[3])) % 10000 / 100;
                    //if (month > DateTime.Today.Month)
                    //{
                    //    throw new DataException("netinkamai parinktas menuo (daugiau nei 12). \n reikia patikrinti duomenis");
                    //}

                    //int day = int.Parse((data[3])) % 100;
                    //if (day > DateTime.Today.Day )
                    //{
                    //    throw new DataException("netinkamai parinkta diena(daugiau nei 31). \n patikrink duomenis");
                    //}

                    Darbuotojai darbuotojas = new Darbuotojai(data[0], data[1], data[2],
                            new DateTime(year: year,
                            month: int.Parse((data[3])) % 10000 / 100,
                            day: int.Parse((data[3])) % 100),
                            int.Parse(data[4]), int.Parse(data[5]));
                        darbuotojuSarasas.Add(darbuotojas);


                        //    tikrins ar yra didesni metai nei einamieji
                        if (darbuotojas.DOB.Year > DateTime.Today.Year)
                            throw new KlaidosDarbuotojaiExeption(darbuotojas.DOB);



                    }
                    catch (KlaidosDarbuotojaiExeption ex)
                    {
                        MessageBox.Show("Neteisingas datos formatas");
                        //throw;
                    }
                    catch (Exception ex)     //kad nepakibtu programa idedame tiesiog pranesima
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            
            reader.Dispose(); //atlaisvins pasiimta faila
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        //listas bus globalus, tai kuriamas cia
        List<Darbuotojai> darbuotojuSarasas = new List<Darbuotojai>();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {








            foreach (var item in darbuotojuSarasas)
            {
                    if (item.ID.ToString() == ComboUsersID.SelectedItem.ToString())
                    {
                        textBox1.Text = item.Vardas;
                        textBox2.Text = item.Pavarde;
                        textBox3.Text = item.DOB.ToShortDateString().ToString();
                        textBox4.Text = item.Alga.ToString();
                        textBox5.Text = item.KiekLaikoDirba.ToString();
                    }


                }




            }
    }
    }
