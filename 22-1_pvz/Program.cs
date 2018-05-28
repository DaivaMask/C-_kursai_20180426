using System;
using System.Data.SqlClient;            //isirasyti
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_1_pvz
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\C_kursai_20180424\22-1_pvz\KCS.mdf;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //1.3 uzduotis
            /*using (SqlCommand sqlCommand = new SqlCommand("INSERT INTO Students (Name, Surname, Phone, Email) VALUES (@Name, @Surname, @Phone, @Email) ", sqlConnection))
            {
                sqlConnection.Open();
                Console.WriteLine("Iveskite varda:");
                sqlCommand.Parameters.AddWithValue("@Name", Console.ReadLine());
                Console.WriteLine("Iveskite pavarde:");
                sqlCommand.Parameters.AddWithValue("@Surname", Console.ReadLine());
                Console.WriteLine("Iveskite telefona:");
                sqlCommand.Parameters.AddWithValue("@Phone", Console.ReadLine());
                Console.WriteLine("Iveskite email:");
                sqlCommand.Parameters.AddWithValue("@Email", Console.ReadLine());
                sqlCommand.ExecuteNonQuery(); //vykdo kaip uzklausa "insert int...."
                sqlConnection.Close();
            }
            */

            //1.4 uzduotis
            /* using (SqlCommand sqlCommand = new SqlCommand("INSERT INTO Student_address (Student_id, Country, City, Street, Post_code) VALUES (@Student_id, @Country, @City, @Street, @Post_code) ", sqlConnection))
             {
                 sqlConnection.Open();
                 sqlCommand.Parameters.AddWithValue("@Student_id", "3");
                 sqlCommand.Parameters.AddWithValue("@Country", "Lietuva");
                 sqlCommand.Parameters.AddWithValue("@City", "Klaipeda");
                 sqlCommand.Parameters.AddWithValue("@Street", "H.Manto");
                 sqlCommand.Parameters.AddWithValue("@Post_code", "9525");

                 sqlCommand.ExecuteNonQuery(); //vykdo kaip uzklausa "insert int...."
                 sqlConnection.Close();
             }
             */
            //1.5 uzduotis

            /* using (SqlCommand sqlCommand = new SqlCommand("INSERT INTO Student_marks (Student_id, Title, Mark, Time_stamp) VALUES (@Student_id, @Title, @Mark, @Time_stamp) ", sqlConnection))
             {
                 sqlConnection.Open();
                 sqlCommand.Parameters.AddWithValue("@Student_id", "5");
                 sqlCommand.Parameters.AddWithValue("@Title", "Matematika");
                 sqlCommand.Parameters.AddWithValue("@Mark", "8");
                 sqlCommand.Parameters.AddWithValue("@Time_stamp", "2018/04/12");

                 sqlCommand.ExecuteNonQuery(); //vykdo kaip uzklausa "insert int...." ; reikalingas dejimui i lentele, kai negauni atgal duomenu
                 sqlConnection.Close();
             }
             */

            //1.6 uzduotis
            /*using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Students ORDER BY Name ASC", sqlConnection))
            {
                sqlConnection.Open();
                var reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Console.Write(reader["Id"].ToString() + " ");
                    Console.WriteLine(reader["Name"].ToString());
                }

                sqlConnection.Close();

    */
            //1.7 uzduotis
            /*using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Students WHERE Name like '%as' OR Surname like '%as' ORDER BY Name DESC", sqlConnection))
            {
                sqlConnection.Open();
                var reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Console.Write(reader["Id"].ToString() + " ");
                    Console.Write(reader["Name"].ToString() + " ");
                    Console.WriteLine(reader["Surname"].ToString());

                }

                sqlConnection.Close();
                */

            //1.8

            /*using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Student_address WHERE City = 'Kaunas'", sqlConnection))
            {
                sqlConnection.Open();
                var reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Console.Write(reader["Id"].ToString() + " ");
                    Console.Write(reader["Student_id"].ToString() + " ");
                    Console.Write(reader["Country"].ToString() + " ");
                    Console.WriteLine(reader["Street"].ToString());

                }

                sqlConnection.Close();

            }
            */

            //1.9

            /*using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Student_address WHERE Post_code IS NOT NULL", sqlConnection))
            {
                sqlConnection.Open();
                var reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Console.Write(reader["Id"].ToString() + " ");
                    Console.Write(reader["Student_id"].ToString() + " ");
                    Console.Write(reader["City"].ToString() + " ");
                    Console.WriteLine(reader["Post_code"].ToString());

                }

                sqlConnection.Close();
            }
            */

            //1.10

            /*using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Student_marks ORDER BY Mark DESC", sqlConnection))
            {
                sqlConnection.Open();
                var reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Console.Write(reader["Id"].ToString() + " ");
                    Console.Write(reader["Student_id"].ToString() + " ");
                    Console.WriteLine(reader["Mark"].ToString() );

                }

                sqlConnection.Close();
            }
            */

            //1.11


            /*using (SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(Mark) AS MARK FROM Student_marks WHERE Mark = 10", sqlConnection))
            {
                sqlConnection.Open();
                var reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader["mark"].ToString() + " ");
                    

                }

                sqlConnection.Close();
            }
            */

            //1.12
            /*using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Student_marks WHERE Mark > 6", sqlConnection))
            {
                sqlConnection.Open();
                var reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Console.Write(reader["student_id"].ToString() + " ");
                    Console.WriteLine(reader["mark"].ToString());

                }

                sqlConnection.Close();
            }
            */


            //1.13
            /* using (SqlCommand sqlCommand = new SqlCommand("UPDATE Student_address SET Street = 'Pakeista_gatve'   where City IN ('Kaunas', 'Vilnius')", sqlConnection))
             {
                 sqlConnection.Open();
                 sqlCommand.ExecuteNonQuery();

                 sqlConnection.Close();
             }
             */

            //1.14

            /* using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Students LEFT JOIN Student_address ON Students.id = Student_address.Student_id ORDER BY Students.Name ASC  ", sqlConnection))
             {
                 sqlConnection.Open();
                 var reader = sqlCommand.ExecuteReader();
                 while (reader.Read())
                 {
                     Console.Write(reader["student_id"].ToString() + " ");
                     Console.Write(reader["Name"].ToString() + " ");
                     Console.Write(reader["City"].ToString() + " ");
                     Console.WriteLine(reader["Street"].ToString());


                 }

                 sqlConnection.Close();
             }
             */

            // 1.22 SELECT visus studentus kurie gavo tik teigiamus pažymius. Laikykime, kad teigiamas pažymys yra 5.

            using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Students LEFT JOIN Student_marks ON Students.Id = Student_marks.Student_id " +
                "WHERE Student_marks.Mark >= 5", sqlConnection))
            {
                sqlConnection.Open();
                var reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Console.Write(reader["student_id"].ToString() + " ");
                    Console.Write(reader["Name"].ToString() + " ");
                    Console.Write(reader["Title"].ToString() + " ");
                    Console.WriteLine(reader["Mark"].ToString() + " ");
                    //Console.WriteLine(reader["Street"].ToString());


                }

                sqlConnection.Close();
            }








        }
    }
}
