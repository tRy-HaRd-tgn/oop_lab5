using System;
using System.Collections.Generic;

namespace oop_lab5_Makarichev
{
    internal class Operations 
    {
        static public bool isInclude(Shape first, Shape second)
        {


            double f1_xmin, f1_xmax, f1_ymin, f1_ymax;
            f1_xmax = Math.Max(Math.Max(first.getx1(), first.getx2()), Math.Max(first.getx3(), first.getx4()));
            f1_xmin = Math.Min(Math.Min(first.getx1(), first.getx2()), Math.Min(first.getx3(), first.getx4()));
            f1_ymax = Math.Max(Math.Max(first.gety1(), first.gety2()), Math.Max(first.gety3(), first.gety4()));
            f1_ymin = Math.Min(Math.Min(first.gety1(), first.gety2()), Math.Min(first.gety3(), first.gety4()));
            int f2_xmin, f2_xmax, f2_ymin, f2_ymax;
            f2_xmax = (int)Math.Max(Math.Max(second.getx1(), second.getx2()), Math.Max(second.getx3(), second.getx4()));
            f2_xmin = (int)Math.Min(Math.Min(second.getx1(), second.getx2()), Math.Min(second.getx3(), second.getx4()));

            f2_ymax = (int)Math.Max(Math.Max(second.gety1(), second.gety2()), Math.Max(second.gety3(), second.gety4()));
            f2_ymin = (int)Math.Min(Math.Min(second.gety1(), second.gety2()), Math.Min(second.gety3(), second.gety4()));

            if (f1_xmin <= f2_xmin && f1_xmax >= f2_xmax && f1_ymin <= f2_ymin && f1_ymax >= f2_ymax)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static public void compare(Shape first, Shape second)
        {
            if (first.square() > second.square())
            {
                Console.WriteLine("Площадь первой фигуры больше чем второй\n");

            }
            else
            {
                if (first.square() == second.square())
                {
                    Console.WriteLine("Площадь фигур одинакова\n");
                }
                else
                {
                    Console.WriteLine("Площадь второй фигуры больше чем первой\n");
                }

            }


        }
        static public bool inTersect(Shape first, Shape second)
        {
            double f1_xmin, f1_xmax, f1_ymin, f1_ymax;
            f1_xmax = Math.Max(Math.Max(first.getx1(), first.getx2()), Math.Max(first.getx3(), first.getx4()));
            f1_xmin = Math.Min(Math.Min(first.getx1(), first.getx2()), Math.Min(first.getx3(), first.getx4()));

            f1_ymax = Math.Max(Math.Max(first.gety1(), first.gety2()), Math.Max(first.gety3(), first.gety4()));
            f1_ymin = Math.Min(Math.Min(first.gety1(), first.gety2()), Math.Min(first.gety3(), first.gety4()));

            if ((second.getx1() <= f1_xmax && second.getx1() >= f1_xmin) && (second.gety1() <= f1_ymax && second.gety1() >= f1_ymin)) return true;
            if ((second.getx2() <= f1_xmax && second.getx2() >= f1_xmin) && (second.gety2() <= f1_ymax && second.gety2() >= f1_ymin)) return true;
            if ((second.getx3() <= f1_xmax && second.getx3() >= f1_xmin) && (second.gety3() <= f1_ymax && second.gety3() >= f1_ymin)) return true;
            if ((second.getx4() <= f1_xmax && second.getx4() >= f1_xmin) && (second.gety4() <= f1_ymax && second.gety4() >= f1_ymin)) return true;

            int f2_xmin, f2_xmax, f2_ymin, f2_ymax;
            f2_xmax = (int)Math.Max(Math.Max(second.getx1(), second.getx2()), Math.Max(second.getx3(), second.getx4()));
            f2_xmin = (int)Math.Min(Math.Min(second.getx1(), second.getx2()), Math.Min(second.getx3(), second.getx4()));

            f2_ymax = (int)Math.Max(Math.Max(second.gety1(), second.gety2()), Math.Max(second.gety3(), second.gety4()));
            f2_ymin = (int)Math.Min(Math.Min(second.gety1(), second.gety2()), Math.Min(second.gety3(), second.gety4()));

            if ((first.getx1() <= f2_xmax && first.getx1() >= f2_xmin) && (first.gety1() <= f2_ymax && first.gety1() >= f2_ymin)) return true;
            if ((first.getx2() <= f2_xmax && first.getx2() >= f2_xmin) && (first.gety2() <= f2_ymax && first.gety2() >= f2_ymin)) return true;
            if ((first.getx3() <= f2_xmax && first.getx3() >= f2_xmin) && (first.gety3() <= f2_ymax && first.gety3() >= f2_ymin)) return true;
            if ((first.getx4() <= f2_xmax && first.getx4() >= f2_xmin) && (first.gety4() <= f2_ymax && first.gety4() >= f2_ymin)) return true;
            return false;
        }

    }
}