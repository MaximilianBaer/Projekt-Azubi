using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Collections;

namespace Domain.Acces
{
    public class Acces
    {
        public static Settings Setting = new Settings();
        public static DecisionData DeciData = new DecisionData();
        public static List<Data> DataSet = new List<Data>();
        public static List<GroupedData> groupedData = new List<GroupedData>();
        public static List<Output> OutputData = new List<Output>();

        public static void LodeDataFromDatabase()
        {
            //Lode Data from Database
        }

        public static void SaveSettingsToFile()
        {
            FileStream settings = new FileStream("settings.dat", FileMode.OpenOrCreate);
            BinaryFormatter formater = new BinaryFormatter();
            formater.Serialize(settings, Setting);
            settings.Close();
        }

        public static void LodeSettingsFromFile()
        {
            if (File.Exists("settings.dat"))
            {
                FileStream settings = new FileStream("settings.dat", FileMode.Open);
                BinaryFormatter formater = new BinaryFormatter();
                Setting = (Settings)formater.Deserialize(settings);
                settings.Close();
            }
        }

        public static void SaveDataLocal()
        {

        }

        public static void SaveDataToFile()
        {

        }
    }
}
