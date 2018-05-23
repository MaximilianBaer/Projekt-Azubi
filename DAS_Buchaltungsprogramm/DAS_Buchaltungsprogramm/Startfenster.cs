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

        }

        private void eingab_Click_1(object sender, EventArgs e)
        {
            //Application.Run(new eingabe());
            eingabe kekse = new eingabe();
            kekse.Show();
        }
    }
}
