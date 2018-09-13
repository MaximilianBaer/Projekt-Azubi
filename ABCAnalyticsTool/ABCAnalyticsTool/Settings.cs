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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            InitializeSettings();
        }

        private void InitializeSettings()
        {
            if (Acces.Setting.Seperations == 0)
            {
                return;
            }
            ValueSeperations.Text = Acces.Setting.Seperations.ToString();
            DataGridViewWriter();
        }

        private void DataGridViewWriter()
        {
            var counter = SetCounter();
            for (int i = 0; i < counter; i++)
            {
                dataGridView1.Rows[0].Cells[i].Value = Acces.Setting.Values[i].ToString();
                dataGridView1.Rows[1].Cells[i].Value = Acces.Setting.Amount[i].ToString();
            }
        }

        private int SetCounter()
        {
            if (Acces.Setting.Values.Count > (Convert.ToInt32(ValueSeperations.Text)-1))
            {
                return Convert.ToInt32(ValueSeperations.Text) - 1;
            }
            else
            {
                return Acces.Setting.Values.Count;
            }
        }

        private void CreateSections(int sections)
        {
            if (sections < 2 || sections > 26)
            {
                return;
            }
            dataGridView1.Columns.Clear();
            for (int i = 0; i < sections-1; i++)
            {
                ABC abc1 = (ABC)i;
                ABC abc2 = (ABC)i + 1;
                var abc = Convert.ToString(abc1) + "+" + Convert.ToString(abc2);
                dataGridView1.Columns.Add(Convert.ToString(abc), Convert.ToString(abc));
            }
            this.dataGridView1.RowCount = 2;
            this.dataGridView1.RowHeadersWidth = 70;
            this.dataGridView1.Rows[0].HeaderCell.Value = "Wert";
            this.dataGridView1.Rows[1].HeaderCell.Value = "Menge";
        }

        private void ValueSeperations_TextChanged(object sender, EventArgs e)
        {
            if (ValueSeperations.Text == "")
            {
                return;
            }
            var seperations = Convert.ToInt32(ValueSeperations.Text);
            CreateSections(seperations);
            DataGridViewWriter();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void SaveSettings()
        {
            Acces.Setting.SaveLocal(dataGridView1.Rows[0].Cells, dataGridView1.Rows[1].Cells, Convert.ToInt32(ValueSeperations.Text));
            Acces.SaveSettingsToFile();
            Acces.LodeSettingsFromFile();
            this.Close();
        }
    }
}
