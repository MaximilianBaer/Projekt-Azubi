using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace DAS_Buchaltungsprogramm
{
    public partial class eingabe : Form
    {
        public eingabe()
        {
            InitializeComponent();
        }

        public static class GlobalSQL
        {
            public static string data = "server = 127.0.0.1;database=buchhaltung;Uid=root;password=''";
            public static MySqlConnection connektion1 = new MySqlConnection(data);
            public static MySqlCommand komando = new MySqlCommand();
            public static MySqlCommand komando2 = new MySqlCommand();
            public static MySqlCommand ID_finder = new MySqlCommand();
        }

        public static class GlobalVar
        {
            public static string Grund;
            public static double hohe;
            public static string datum;
            public static int ID;
        }

        private void eingabe_Load(object sender, EventArgs e)
        {
            //Open Datenbank      
            GlobalSQL.connektion1.Open();
            GlobalSQL.komando.Connection = GlobalSQL.connektion1;
        }

        private void speichern_Click(object sender, EventArgs e)
        {
            GlobalVar.Grund = grund.Text;
            GlobalVar.hohe = Convert.ToDouble(hoehe.Text);
            GlobalVar.datum = Convert.ToString(dattum.Value.ToString("yyyy-MM-dd"));
            MessageBox.Show(GlobalVar.datum);
            if (ein.Checked)
            {
                Thread ein = new Thread(einname);
                ein.Start();
            }
            else
            {
                Thread aus = new Thread(ausgaben);
                aus.Start();
            }
        }
        private void ID_finder()
        {
            GlobalSQL.ID_finder.CommandText = "SELECT MAX(ID) FROM buchhaltung";
            ID_finder_querry();
        }

        private void ID_finder_querry()
        {
            GlobalSQL.ID_finder.Connection = GlobalSQL.connektion1;
            MySqlDataReader id = GlobalSQL.ID_finder.ExecuteReader();
            while (id.Read())
            {
                GlobalVar.ID = Convert.ToInt32(id[0]);
            }
            GlobalSQL.connektion1.Close();
            GlobalSQL.connektion1.Open();
        }

        private void einname()
        {
            DBB1();
            ID_finder();
            GlobalSQL.komando2.CommandText = "INSERT INTO einnahmen(ID,hohe, datum) VALUES('" + GlobalVar.ID + "','" + GlobalVar.hohe + "','" + GlobalVar.datum + "')";
            DBB2();
        }

        private void ausgaben()
        {
            DBB1();
            ID_finder();
            GlobalSQL.komando2.CommandText = "INSERT INTO ausgabe(ID,hohe, datum) VALUES('" + GlobalVar.ID + "','" + GlobalVar.hohe + "','" + GlobalVar.datum + "')";
            DBB2();
        }

        private void DBB1()
        {
            GlobalSQL.komando.CommandText = "INSERT INTO buchhaltung(grund, einnahme) VALUES('" + GlobalVar.Grund + "','" + Convert.ToInt32(ein.Checked) + "')";
            GlobalSQL.komando.Connection = GlobalSQL.connektion1;
            GlobalSQL.komando.ExecuteNonQuery();
        }

        private void DBB2()
        {
            GlobalSQL.komando2.Connection = GlobalSQL.connektion1;
            GlobalSQL.komando2.ExecuteNonQuery();
        }

        protected override void OnClosed(EventArgs e)
        {
            GlobalSQL.connektion1.Close();
            base.OnClosed(e);
        }
    }
}
