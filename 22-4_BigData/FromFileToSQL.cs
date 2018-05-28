using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Data.Linq;         //leidzia pasiimti lenteles i List'us
using System.Text;
using System.Threading.Tasks;

namespace _22_4_BigData
{
    class FromFileToSQL
    {


        public void Converter(string path)
        {
            ////exeption'ai
            //if (true)
            //{
            //    //trintu toki pati
            //}

            //nusiskaitom duomenis
            StreamReader reader = new StreamReader(path);
            string data = reader.ReadToEnd();
            data = data.Replace("\n", "");
            data = data.Replace("\r", "");
            data = data.Replace(".", ",");

            string[] dataString = data.Split(';');

            //prisijungimas prie DB ir prisijungimas tu lenteliu
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\C_kursai_20180424\22-4_BigData\DataBig.mdf;Integrated Security=True";
            reader.Dispose();  //arba Close()
            DataContext db = new DataContext(connectionString);
            Table<Sensor> sensor = db.GetTable<Sensor>(); //gausim duomenis is lenteles
            Table<Measurement> measurement = db.GetTable<Measurement>();

            //sudeliojam informacija
            Sensor sen = new Sensor(); //objektas
            sen.Id = long.Parse(dataString[93]); //is failo 
            
            

            sen.DateOfRecord = DateTime.Parse(dataString[90]);
            sen.StationNumber = dataString[91];
            sen.SV = int.Parse(dataString[96]);

            for (int i = 100; i < dataString.Length-2; i+=5)
            {
                Measurement temp = new Measurement();
                temp.SN = long.Parse(dataString[93]);
                temp.Position = decimal.Parse(dataString[i]);
                temp.Vout = decimal.Parse(dataString[i+1]);
                temp.Min = decimal.Parse(dataString[i+3]);
                temp.Max = decimal.Parse(dataString[i+4]);

                measurement.InsertOnSubmit(temp);
                db.SubmitChanges();

            }

            //kreipiames i lentele
            sensor.InsertOnSubmit(sen); //uzkraunu naujai suformuota objekta i lentele Table<Sensor>
            db.SubmitChanges(); //pakeitimai itraukti i DB

        }

    }
}
