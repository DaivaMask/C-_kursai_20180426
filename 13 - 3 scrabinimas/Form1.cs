using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13___3_scrabinimas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var url = textBox1.Text;
            textBox1.Text = "";
            GautiHTML(url);
        }

        private static async void GautiHTML(string url) //async - leidzia vykdyti koda nepertruakiant programos
        {
            var httpClient = new HttpClient(); //leidzia jungtis prie serverio ar puslaio
            var html = await httpClient.GetStringAsync(url); //nuskaitytas html kaip string
            var htmlDocument = new HtmlAgilityPack.HtmlDocument(); //paruostas apdorojimui
            htmlDocument.LoadHtml(html); //objektas, paruosia string 

            //nuskaitinejami duomenys
            var produktuSarasas = htmlDocument.DocumentNode.Descendants("ul") //bus kiti duomenys = zymos, jose ieskoti 'ul'
                .Where(x => x.GetAttributeValue("id", "") //kuris atitiktu salyga: pasiimti atributa 'id'
                    .Equals("s-results-list-atf")).ToList(); //butu atitinkantis nurodytam . gauta rezutlata paverstu i sarasa (ToList)

            var produktuElementai = produktuSarasas[0].Descendants("li")
                .Where(x => x.GetAttributeValue("id", "")
                    .Contains("result")).ToList();

            var Vardas = "";
            foreach (var htmlNode in produktuElementai)
            {
                //MessageBox.Show(htmlNode.InnerText); //rodys kiekviena rasta atskiram messageBox'e
                Vardas += htmlNode.InnerText;
            }
            MessageBox.Show(Vardas);

            //trim - apkarpo tuscias vietas
            // atsakyme padeti enter - \n (new line)




        }
    }
}
