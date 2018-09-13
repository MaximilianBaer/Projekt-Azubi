using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Domain;
using Domain.Acces;

namespace DatabaseAcces
{
    public class DataAcces
    {
        public static void GetData()
        {
            string connectionstring = "SERVER=localhost; Database=stueckliste;user=root;Password=;";

            MySqlConnection connection = new MySqlConnection(connectionstring);
            MySqlCommand einleser = new MySqlCommand();
            MySqlDataReader reader;
            einleser.CommandText = "Select * from stueckliste";
            einleser.Connection = connection;
            connection.Open();
            reader = einleser.ExecuteReader();
            while (reader.Read())
            {
                Data dat = new Data();
                dat.ID = (int)reader.GetValue(0);
                dat.Bezeichnung = (string)reader.GetValue(1);
                dat.Menge = Convert.ToInt32(reader.GetValue(2));
                dat.Wert = Convert.ToInt32(reader.GetValue(3));
                Acces.DataSet.Add(dat);
            }
            connection.Close();
        }
    }
}
