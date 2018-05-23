using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DAS_Buchaltungsprogramm
{
    public partial class eingabe : Form
    {
        public eingabe()
        {
            InitializeComponent();
        }
        public class GlobalSQL
        {
            public static SqlConnection connektion1 = new SqlConnection("database=buchaltung");
        }

        private void eingabe_Load(object sender, EventArgs e)
        {
            //Open Datenbank
            SqlConnection connektion1 = new SqlConnection("buchaltung");
            connektion1.Open();
            //GlobalSQL.connektion1.Open();
        }

        private void speichern_Click(object sender, EventArgs e)
        {
            string Grund = grund.Text;
            int hohe = Convert.ToInt32(hoehe.Text);
            DateTime datum = Convert.ToDateTime(dattum);
        }

        protected override void OnClosed(EventArgs e)
        {
            GlobalSQL.connektion1.Close();
            base.OnClosed(e);
        }
    }
}
