using System;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;


namespace WindowsFormsApplication2
{
    public partial class PlayField : Form
    {
        #region INITPHASE
        public PlayField()
        {
            InitializeComponent();
            InitDots();
            timer1.Start();
        }

        private void InitDots()
        {
            pictureBox1.Top = GameData.GoalPosX;
            pictureBox1.Left = GameData.GoalPosY;
            GameData.Dots = new Dot[30];
            for (var i = 0; i < GameData.Dots.Count(); i++) GameData.Dots[i] = new Dot();
            var ran = new Random();
            CreateInitialDots(ran);


        }

        private void CreateInitialDots(Random ran)
        {
            ;
            foreach (var dot in GameData.Dots)
            {
                for (var j = 0; j < dot.Vectors.Length - 1; j++)
                {
                    if (j == 0)
                    {
                        var a = ran.Next(0, 360);
                        dot.Vectors[j] = a;
                    }
                    else
                    {
                        var a = ran.Next(-50, 50);
                        dot.Vectors[j] = dot.Vectors[j - 1] + a;
                    }
                }
            }
        }

        private int _t = -1;

        PictureBox[] de = new PictureBox[GameData.Dots.Count() + 1];
        #endregion

        #region MOVINGPHASE
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (_t == -1)
            {
                FirstStep();
            }

            if (_t < 500)
            {
                NormalSteps();
            }

            if (_t == 500)
            {
                RoundEnd();
            }
        }

        private void FirstStep()
        {
            for (var i = 0; i < GameData.Dots.Count(); i++)
            {
                de[i] = new PictureBox()
                {
                    Top = GameData.Dots[i].PosX,
                    Left = GameData.Dots[i].PosY,
                    Width = GameData.Dots[i].Size,
                    Height = GameData.Dots[i].Size,
                    BackColor = GameData.Dots[i].Color
                };
                de[i].Show();
                de[i].BringToFront();
                de[i].Visible = true;
                Controls.Add(de[i]);
            }
            _t = 0;
        }

        private void NormalSteps()
        {
            for (var i = 0; i < GameData.Dots.Count(); i++)
            {
                MoveDotOnScreen(i);
            }

            foreach (var dot in GameData.Dots)
            {
                MoveDot(dot);
            }

            _t++;
        }

        private void MoveDot(Dot dot)
        {
            if (dot.IsDead == true) return;

            MovingDot(dot);

            DoCalculations(dot);

            if (Secret.GetDistance(dot) < 10) EndRound(dot);
            if (dot.PosX > 990 || dot.PosX < 0 || dot.PosY > 990 || dot.PosY < 0) KillDot(dot);
        }

        private void MovingDot(Dot dot)
        {
            dot.PosX = MoveX(dot, _t);
            dot.PosY = MoveY(dot, _t);
        }

        private void KillDot(Dot dot)
        {
            dot.IsDead = true;
        }

        private void DoCalculations(Dot dot)
        {
            if (dot.Fitness < Secret.CalculateFitness(dot, _t))
            {
                dot.Fitness = Secret.CalculateFitness(dot, _t);
            }
        }

        private void EndRound(Dot dot)
        {
            label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 1);
            dot.Fitness = dot.Fitness + 1;
            _t = 499;
        }

        private void MoveDotOnScreen(int i)
        {
            de[i].Top = GameData.Dots[i].PosX;
            de[i].Left = GameData.Dots[i].PosY;
        }

        private void RoundEnd()
        {
            label1.Text = Convert.ToString(Convert.ToInt32(label1.Text) + 1);
            Secret.Breader();
            _t = 0;
        }

        private int MoveX(Dot dot, int i)
        {
            var vector = dot.Vectors[i];
            var moveX = Math.Sin(vector * (Math.PI / 180));
            var posX = dot.PosX - moveX * 10;
            return Convert.ToInt32(posX);
        }

        private int MoveY(Dot dot, int i)
        {
            var vector = dot.Vectors[i];
            var moveY = Math.Cos(vector * (Math.PI / 180));
            var posY = dot.PosY - moveY * 10;
            return Convert.ToInt32(posY);
        }
        #endregion
    }


    public static class Secret
    {
        private static void Mutator(Dot parentdot)
        {
            Random r = new Random();
            var mutattionLevel = 40;
            foreach (var dot in GameData.Dots)
            {
                dot.Color = Color.Chartreuse;
                dot.IsDead = false;
                dot.PosX = 200;
                dot.PosY = 200;
                for (var i = 0; i < dot.Vectors.Length; i++)
                {
                    dot.Vectors[i] = parentdot.Vectors[i] + r.Next(-mutattionLevel, mutattionLevel);
                }

            }
        }

        private static void DeMutator()
        {
            var MaxMutation = 40;
            var deMutatorGrade = 40;
            foreach (var dot in GameData.Dots)
            {
                for (var i = 0; i < dot.Vectors.Length - 1; i++)
                {
                    if (dot.Vectors[i + 1] - dot.Vectors[1] < MaxMutation &&
                        dot.Vectors[i + 1] - dot.Vectors[1] > -MaxMutation) continue;
                    if (!(dot.Vectors[i + 1] - dot.Vectors[1] < MaxMutation))
                    {
                        dot.Vectors[i + 1] = dot.Vectors[i + 1] + (dot.Vectors[1] / 100) * deMutatorGrade;
                    }
                    if (!(dot.Vectors[i + 1] - dot.Vectors[1] > -MaxMutation))
                    {
                        dot.Vectors[i + 1] = dot.Vectors[i + 1] - (dot.Vectors[1] / 100) * deMutatorGrade;
                    }

                }

            }
        }

        public static void Breader()
        {
            var a = GameData.Dots.OrderBy(f=> f.Fitness).ToList();
            var c = a.Max(h => h.Fitness);
            var bestDot = a[0];
            var secondBestDot = a[1];
            var thirdBestDot = a[2];
            Dot pdot = new Dot();
            pdot = GetMittleDot(bestDot, secondBestDot, thirdBestDot);
            Mutator(pdot);
            //DeMutator();
        }

        private static Dot GetMittleDot(Dot bestDot, Dot secondBestDot, Dot thirdBestDot)
        {
            var pdot = new Dot();
            for (int i = 0; i < bestDot.Vectors.Length; i++)
            {
                //pdot.Vectors[i] = (bestDot.Vectors[i] + secondBestDot.Vectors[i] + thirdBestDot.Vectors[i]) / 3;
                pdot.Vectors[i] = bestDot.Vectors[i];
            }

            return pdot;
        }

        #region Fitness
        public static float CalculateFitness(Dot dot, int i)
        {
            var dis = GetDistance(dot);
            return (float)(i/(1 / (dis * dis)));
        }
        #endregion

        #region Distance

        public static double GetDistance(Dot dot)
        {
            var disX = GetDistanceX(dot.PosX);
            var disY = GetDistanceY(dot.PosY);
            var dis = Math.Sqrt(disX ^ 2) + (disY ^ 2);
            return dis;
        }

        private static int GetDistanceY(int dotPosY)
        {
            var dis = GameData.GoalPosY - dotPosY;
            if (dis < 0)
            {
                dis = -dis;
            }

            return dis;
        }

        private static int GetDistanceX(int dotPosX)
        {
            var dis = GameData.GoalPosX - dotPosX;
            if (dis < 0)
            {
                dis = -dis;
            }

            return dis;
        }
        #endregion
    }
}






//foreach (var d in de)
//{
//    try
//    {
//        d.Dispose();
//    }
//    catch
//    {

//    }
//}


//foreach (var dot in GameData.Dots) Move();
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