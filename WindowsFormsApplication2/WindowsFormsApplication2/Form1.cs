using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using dot;

namespace WindowsFormsApplication2
{
    public partial class PlayField : Form 
    {
        public PlayField()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                dot.moveup = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                dot.moveup = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dot.moveup == true)
            {
                if(pictureBox1.Top <= 0 || pictureBox1.Top >= 900 )
                {
                    //timer1.Stop();
                }

                int deg = 0;




                int x;
                int y;


                y = (int)Math.Sin(deg)*10;
                x = (int)Math.Cos(deg)*10; 





                pictureBox1.Top -= y;
                pictureBox1.Left += x;
            }
        }
    }

    public class gamedata
    {
        public static int maxspeed = 10;
        public static int acelleration = 1;

    }

    public class dot
    {
        public int speed = 0;
        public int direction = 0;
        public bool isDeat = false;
        public static bool moveup = false;
    }


}
