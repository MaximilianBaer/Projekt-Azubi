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

        public void Move()
        {
          

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < gamedata.dots.Count() - 1; i++)
            {
                gamedata.dots[i] = new dot();
            }
            PictureBox[] de = new PictureBox[100];
            for (int i = 0; i < gamedata.dots.Count() - 1; i++)
            {
                de[i] = new PictureBox()
                {
                    Width = gamedata.dots[i].size,
                    Height = gamedata.dots[i].size,
                    Top = gamedata.dots[i].posx,
                    Left = gamedata.dots[i].posy,
                    BackColor = gamedata.dots[i].color,
                    //Location = new systed
                };
                de[i].Show();
                de[i].BringToFront();
                de[i].Visible = true;
                this.Controls.Add(de[i]);
            }

            foreach (var dot in gamedata.dots)
            {
                Move();
            }
            //if (true)
            //{


            //    double deg;

            //    Random ran = new Random();
            //    deg = ran.Next(0, 360);

            //    double x;
            //    double y;


            //    y = Math.Cos(deg * (Math.PI / 180));
            //    x = Math.Sin(deg * (Math.PI / 180));
            //    var inty = Convert.ToInt32(y) * 5;
            //    var intx = Convert.ToInt32(x) * 5;




            //    pictureBox1.Top -= intx;
            //    pictureBox1.Left += inty;
            //}
        }
    }

    public class gamedata
    {
        public static dot[] dots = new dot[100];
        public static int maxspeed = 10;
        public static int acelleration = 1;
        public static int steps = 500;

    }

    public class dot
    {
        public int[] vectors = new int[gamedata.steps];
        public int speed { get; set; } = 0;
        public int direction { get; set; } = 0;
        public bool isDeat { get; set; } = false;
        public static bool moveup { get; set; } = false;
        public int posx { get; set; }  = 200;
        public int posy { get; set; }  = 200;
        public int fittnes { get; set; }  = 0;
        public int size { get; set; } = 10;
        public Color color { get; set; } = Color.Black;
    }

}

