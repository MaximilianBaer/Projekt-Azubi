using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAS_Buchaltungsprogramm
{
    public partial class startfenster : Form
    {
        public startfenster()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void ausgabe_Click(object sender, EventArgs e)
        {
            Ausgabe kekse = new Ausgabe();
            kekse.Show();
        }

        private void eingab_Click_1(object sender, EventArgs e)
        {
            eingabe kekse = new eingabe();
            kekse.Show();
        }
    }
}
