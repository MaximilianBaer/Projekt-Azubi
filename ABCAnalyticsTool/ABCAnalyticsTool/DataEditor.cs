using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Domain.Acces;

namespace ABCAnalyticsTool
{
    public partial class DataEditor : Form
    {
        public DataEditor()
        {
            InitializeComponent();
            InitializeData();
            InitializeDataGridview();
        }

        private void InitializeData()
        {
            foreach (GroupedData data in Acces.groupedData.OrderBy(a => a.Group))
            {
                Output outputData = new Output();
                outputData.ID = data.Data.ID;
                outputData.Bezeichnung = data.Data.Bezeichnung;
                outputData.Menge = data.Data.Menge;
                outputData.MengeProzent = MengeProzent(data.Data.Menge);
                outputData.Wert = WertGesamMt(data.Data.Wert, data.Data.Menge);
                outputData.WertProzent = WertProzent(data.Data.Wert, data.Data.Menge);
                ABC abc = (ABC)data.Group;
                outputData.Kategorie = abc;
                Acces.OutputData.Add(outputData);
            }
            for (int i = 0; i < Acces.Setting.Seperations; i++)
            {
                var menge = KumulativMenge(i);
                var wert = KumulativWert(i);
                Acces.OutputData.Last(f => f.Kategorie == (ABC)i).AnteilMenge = menge;
                Acces.OutputData.Last(f => f.Kategorie == (ABC)i).AnteilWert = wert;
            }
        }

        private string KumulativWert(int i)
        {
            var wert = Convert.ToString(Math.Round(Acces.OutputData.Where(d => d.Kategorie == (ABC)i).Sum(a => a.WertProzent), 2));
            return wert; 
        }

        private string KumulativMenge(int i)
        {
            var menge = Convert.ToString(Math.Round(Acces.OutputData.Where(d => d.Kategorie == (ABC)i).Sum(a => a.MengeProzent),2));
            return menge;
        }

        private double WertProzent(int wert, int menge)
        {
            var prozent = 100 * (Convert.ToDouble(wert * menge) / Convert.ToDouble(Acces.groupedData.Sum(b => b.Data.Wert * b.Data.Menge)));
            return Math.Round(prozent, 2);
        }

        private Double MengeProzent(int Menge)
        {
            var prozent = 100 * (Convert.ToDouble(Menge) / Convert.ToDouble(Acces.groupedData.Sum(a => a.Data.Menge)));
            return Math.Round(prozent, 2);
        }

        private int WertGesamMt(int wert, int menge)
        {
            return wert * menge;
        }

        private void InitializeDataGridview()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource =  Acces.OutputData;


        }
    }
}
