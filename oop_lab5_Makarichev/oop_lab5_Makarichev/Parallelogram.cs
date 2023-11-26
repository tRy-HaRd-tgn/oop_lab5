using System;

namespace oop_lab5_Makarichev
{
    internal class Parallelogram : Shape
    {
        public override double square()//площадь
        {
            double ab = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            h = Math.Sqrt(Math.Pow(x1 - x1, 2) + Math.Pow(y1 - y4, 2));
            return ab * h;
        }
        public override void centerOfGravity()
        {
            centerOfGravityX = (x1 + x2 + x3 + x4) / 4;
            centerOfGravityY = (y1 + y2 + y3 + y4) / 4;
        }

        public override double getCenterOfGravityX()
        {
            return centerOfGravityX;
        }

        public override double getCenterOfGravityY()
        {
            return centerOfGravityY;
        }

        public override void move(int x, int y)
        {
            x1 += x;
            y1 += y;

            x2 += x;
            y2 += y;

            x3 += x;
            y3 += y;

            x4 += x;
            y4 += y;
        }

        public override void rotate(int degrees)
        {
            x1 = (x1 - centerOfGravityX) * Math.Cos(degrees) - (y1 - centerOfGravityY) * Math.Sin(degrees) + x1;
            y1 = (x1 - centerOfGravityX) * Math.Sin(degrees) + (y1 - centerOfGravityY) * Math.Cos(degrees) + y1;

            x2 = (x2 - centerOfGravityX) * Math.Cos(degrees) - (y2 - centerOfGravityY) * Math.Sin(degrees) + x2;
            y2 = (x2 - centerOfGravityX) * Math.Sin(degrees) + (y2 - centerOfGravityY) * Math.Cos(degrees) + y2;

            x3 = (x3 - centerOfGravityX) * Math.Cos(degrees) - (y3 - centerOfGravityY) * Math.Sin(degrees) + x3;
            y3 = (x3 - centerOfGravityX) * Math.Sin(degrees) + (y3 - centerOfGravityY) * Math.Cos(degrees) + y3;

            x4 = (x4 - centerOfGravityX) * Math.Cos(degrees) - (y4 - centerOfGravityY) * Math.Sin(degrees) + x4;
            y4 = (x4 - centerOfGravityX) * Math.Sin(degrees) + (y4 - centerOfGravityY) * Math.Cos(degrees) + y4;
        }

        private double h;
        private double centerOfGravityX;//центр тяжести по x
        private double centerOfGravityY;//центр тяжести по y
    }
}