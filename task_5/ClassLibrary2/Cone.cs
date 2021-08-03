using System;

namespace ClassLibrary2
{
    public class Cone
    {
        private int H { get; set; }
        private int R { get; set; }
        private double pi = 3.14;

        public Cone(int h, int r)
        {
            H = h;
            R = r;
        }

        public double SCircle()
        {
            return pi * Math.Pow(R, 2);
        }

        public double SCone()
        {
            return pi * R * (H + R);
        }
    }
}
