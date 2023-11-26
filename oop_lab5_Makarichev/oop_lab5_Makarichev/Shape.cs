using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace oop_lab5_Makarichev
{
    abstract class Shape
    {
        public abstract double square();//нахождение площади
        public abstract void centerOfGravity();//нахождение центра тяжести
        public abstract void rotate(int degrees);//поворот фигуры
        public abstract void move(int x, int y);//двигать фигуру
        public abstract double getCenterOfGravityX();//получить координату центра тяжести по x
        public abstract double getCenterOfGravityY();//получить координату центра тяжести по y

        public static Shape createShape(int i)//создание фигуры
        {
            switch (i) //выбор какую фигуру создавать
            {
                case 1:
                    {
                        return new Square();
                    }
                case 2:
                    {
                        return new Parallelogram();
                    }
                case 3:
                    {
                        return null;
                    }
                default:
                    {
                        Console.WriteLine("Создание такого объекта не возможно\n");
                        return null;
                    }
            }
        }

        // инкапсуляция координат
        public void setx1(int x1)
        {
            this.x1 = x1;
        }
        public void sety1(int y1)
        {
            this.y1 = y1;
        }
        public void setx2(int x2)
        {
            this.x2 = x2;
        }
        public void sety2(int y2)
        {
            this.y2 = y2;
        }
        public void setx3(int x3)
        {
            this.x3 = x3;
        }
        public void sety3(int y3)
        {
            this.y3 = y3;
        }
        public void setx4(int x4)
        {
            this.x4 = x4;
        }
        public void sety4(int y4)
        {
            this.y4 = y4;
        }
        public double getx1()
        {
            return x1;
        }
        public double gety1()
        {
            return y1;
        }
        public double getx2()
        {
            return x2;
        }
        public double gety2()
        {
            return y2;
        }
        public double getx3()
        {
            return x3;
        }
        public double gety3()
        {
            return y3;
        }
        public double getx4()
        {
            return x4;
        }
        public double gety4()
        {
            return y4;
        }


        //координаты
        protected double x1;
        protected double y1;

        protected double x2;
        protected double y2;

        protected double x3;
        protected double y3;

        protected double x4;
        protected double y4;
    }
}