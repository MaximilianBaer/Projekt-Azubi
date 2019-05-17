using System;
using System.Drawing;

namespace WindowsFormsApplication2
{
    public class Dot
    {
        public int[] Vectors = new int[GameData.Steps];
        public int Speed { get; set; } = 0;
        public int Direction { get; set; } = 0;
        public bool IsDead { get; set; } = false;
        public static bool MoveUp { get; set; }
        public int PosX { get; set; } = 200;
        public int PosY { get; set; } = 200;
        public float Fitness { get; set; } = 0;
        public int Size { get; set; } = 10;
        public Color Color { get; set; } = Color.Black;

        public int[] CreateVectors()
        {
            var ran = new Random();
            var vectors = new int[GameData.Steps];
            for (var i = 0; i < vectors.Length; i++) vectors[i] = ran.Next(0, 360);
            return vectors;
        }
    }
}