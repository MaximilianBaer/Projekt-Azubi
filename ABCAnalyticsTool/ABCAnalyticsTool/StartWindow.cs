using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Acces;
using DatabaseAcces;
using KIzuna;

namespace ABCAnalyticsTool
{
    public partial class StartWindow : Form
    {
        public StartWindow()
        {
            InitializeComponent();
            Acces.LodeSettingsFromFile();
        }

        private void New_Click(object sender, EventArgs e)
        {
            DataAcces.GetData();
            KIzunaAI.Decide();
            DataEditor editor = new DataEditor();
            editor.Show();
            
        }

        private void Open_Click(object sender, EventArgs e)
        {

        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Settings setting = new Settings();
            setting.Show();
        }
    }
}