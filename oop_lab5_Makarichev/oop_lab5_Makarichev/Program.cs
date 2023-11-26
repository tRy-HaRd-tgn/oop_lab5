using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab5_Makarichev
{
    
    internal class Program
    {
        

        static void Main(string[] args)
        {
            int temp;
            bool cond = true;
            Shape ptr1 = null;// фигура 1
            Shape ptr2 = null;// фигура 2

            while (cond)//интерфейс создания первой фигуры
            {
                Console.WriteLine("Введите тип первой фигуры\n1 - квадрат\n2 - параллелограм\n3 - прекратить создание фигур\n");
                temp = int.Parse(Console.ReadLine());

                ptr1 = Shape.createShape(temp);

                if (ptr1==null) { cond = false; }//введение координат для фигуры 1
                else
                {
                    int x1, y1, x2, y2, x3, y3, x4, y4;

                    Console.WriteLine("Введите координаты x1 - ");
                    x1= int.Parse(Console.ReadLine());
                    ptr1.setx1(x1);

                    Console.WriteLine("\n");
   
                    Console.WriteLine("Введите координаты y1 - ");
                    y1 = int.Parse(Console.ReadLine());
                    ptr1.sety1(y1);

                    Console.WriteLine("\n");

                    Console.WriteLine("Введите координаты x2 - ");
                    x2 = int.Parse(Console.ReadLine());
                    ptr1.setx2(x2);

                    Console.WriteLine("\n");

                    Console.WriteLine("Введите координаты y2 - ");
                    y2 = int.Parse(Console.ReadLine());
                    ptr1.sety2(y2);

                    Console.WriteLine("\n");

                    Console.WriteLine("Введите координаты x3 - ");
                    x3 = int.Parse(Console.ReadLine());
                    ptr1.setx3(x3);

                    Console.WriteLine("\n");

                    Console.WriteLine("Введите координаты y3 - ");
                    y3 = int.Parse(Console.ReadLine());
                    ptr1.sety3(y3);

                    Console.WriteLine("\n");

                    Console.WriteLine("Введите координаты x4 - ");
                    x4 = int.Parse(Console.ReadLine());
                    ptr1.setx4(x4);

                    Console.WriteLine("\n");

                    Console.WriteLine("Введите координаты y4 - ");
                    y4 = int.Parse(Console.ReadLine());
                    ptr1.sety4(y4);

                    Console.WriteLine("\n");

                    cond = false;
                }

            }

            cond = true;
            while (cond)//интерфейс создания второй фигуры
            {
                Console.WriteLine("Введите тип второй фигуры\n1 - квадрат\n2 - параллелограм\n3 - прекратить создание фигур\n");
                temp = int.Parse(Console.ReadLine());
                ptr2 = Shape.createShape(temp);

                if (ptr2 == null) { cond = false; }//введение координат второй фигуры
                else
                {
                    int x1, y1, x2, y2, x3, y3, x4, y4;

                    Console.WriteLine("Введите координаты x1 - ");
                    x1 = int.Parse(Console.ReadLine());
                    ptr2.setx1(x1);

                    Console.WriteLine("\n");

                    Console.WriteLine("Введите координаты y1 - ");
                    y1 = int.Parse(Console.ReadLine());
                    ptr2.sety1(y1);

                    Console.WriteLine("\n");

                    Console.WriteLine("Введите координаты x2 - ");
                    x2 = int.Parse(Console.ReadLine());
                    ptr2.setx2(x2);

                    Console.WriteLine("\n");

                    Console.WriteLine("Введите координаты y2 - ");
                    y2 = int.Parse(Console.ReadLine());
                    ptr2.sety2(y2);

                    Console.WriteLine("\n");

                    Console.WriteLine("Введите координаты x3 - ");
                    x3 = int.Parse(Console.ReadLine());
                    ptr2.setx3(x3);

                    Console.WriteLine("\n");

                    Console.WriteLine("Введите координаты y3 - ");
                    y3 = int.Parse(Console.ReadLine());
                    ptr2.sety3(y3);

                    Console.WriteLine("\n");

                    Console.WriteLine("Введите координаты x4 - ");
                    x4 = int.Parse(Console.ReadLine());
                    ptr2.setx4(x4);

                    Console.WriteLine("\n");

                    Console.WriteLine("Введите координаты y4 - ");
                    y4 = int.Parse(Console.ReadLine());
                    ptr2.sety4(y4);

                    Console.WriteLine("\n");

                    cond = false;
                }

            }


            cond = true;
            
            while (cond) // Интерфейс работы с фигурами(мы можем повернуть, подвинуть, посчитать площадь фигуры, найти координаты центра тяжести фигуры)
            {
                Console.WriteLine("Введите номер фигуры с которой мы будем работать\n1 - первая фигура\n2 - вторая фигура\n3 - прекратить работу с фигурами\n" );
                temp = int.Parse(Console.ReadLine());
                if (temp == 1) //фигура 1
                {
                    if (temp == 1 && ptr1 == null) { Console.WriteLine("Фигуры с которой вы хотите поработать не существует\n"); break; }
                    while (cond)
                    {
                        Console.WriteLine("1 - вывести в консоль площадь фигуры 1\n");
                        Console.WriteLine("2 - вывести в консоль координаты центра тяжести фигуры 1\n");
                        Console.WriteLine("3 - повернуть фигуру 1\n");
                        Console.WriteLine("4 - подвинуть фигуру 1\n");
                        Console.WriteLine("Любое другое число прекращение работы с фигурой 1\n");
                        temp = int.Parse(Console.ReadLine());
                        switch (temp)
                        {
                            case 1:
                                {
                                    Console.WriteLine(ptr1.square());
                                    Console.WriteLine("\n");
                                    break;
                                }

                            case 2:
                                {
                                    ptr1.centerOfGravity();
                                    string result = "координата по x - " + ptr1.getCenterOfGravityX() + "\nкоордината по y - " + ptr1.getCenterOfGravityY() + "\n";
                                    Console.WriteLine(result);
                                    break;
                                }

                            case 3:
                                {
                                    int degres;
                                    Console.WriteLine("Введите количество градусов на которое нужно повернуть фигуру - ");
                                    degres = int.Parse(Console.ReadLine());
                                    ptr1.rotate(degres);
                                    Console.WriteLine("\n");
                                    break;
                                }

                            case 4:
                                {
                                    int x, y;
                                    Console.WriteLine("Введите X - ");
                                    x = int.Parse(Console.ReadLine());
                                    Console.WriteLine("\nВведите Y - ");;
                                    y = int.Parse(Console.ReadLine());
                                    ptr1.move(x, y);//подвинуть фигуру на x,y
                                    break;
                                }

                            default:
                                {
                                    cond = false;
                                    break;
                                }
                        }
                    }
                }
                cond = true;
                if (temp == 2) //фигура 2
                {
                    if (temp == 2 && ptr2 == null) { Console.WriteLine("Фигуры с которой вы хотите поработать не существует \n");  cond = false; break; }
                    Console.WriteLine("1 - вывести в консоль площадь фигуры 2\n");
                    Console.WriteLine("2 - вывести в консоль координаты центра тяжести фигуры 2\n");
                    Console.WriteLine("3 - повернуть фигуру 2\n");
                    Console.WriteLine("4 - подвинуть фигуру 2\n");
                    Console.WriteLine("Любое другое число прекращение работы с фигурой 2\n");
                    temp = int.Parse(Console.ReadLine());
                    switch (temp)
                    {
                        case 1:
                            {
                                Console.WriteLine(ptr2.square());
                                Console.WriteLine("\n");
                                break;
                            }

                        case 2:
                            {
                                ptr2.centerOfGravity();
                                Console.WriteLine(ptr2.getCenterOfGravityX()); Console.WriteLine(" - координата по x\n");//координата x
                                Console.WriteLine(ptr2.getCenterOfGravityY()); Console.WriteLine(" - координата по y\n");//координата y
                                break;
                            }

                        case 3:
                            {
                                int degres;
                                Console.WriteLine("Введите количество градусов на которое нужно повернуть фигуру - ");
                                degres=int.Parse(Console.ReadLine());
                                ptr2.rotate(degres);
                                Console.WriteLine("\n");
                                break;
                            }

                        case 4:
                            {
                                int x, y;
                                Console.WriteLine(" Введите X - ");
                                x=int.Parse(Console.ReadLine());
                                Console.WriteLine("\nВведите Y - ");
                                y = int.Parse(Console.ReadLine());
                                ptr2.move(x, y);//подвинуть фигуру на x,y
                                break;
                            }

                        default:
                            {
                                cond = false;
                                break;
                            }

                    }
                }
                if (temp == 3) //прекращение работы с фигурой 2
                {
                    cond = false;
                    break;
                }

            }
            Console.WriteLine("Для работы с объектами у вас должно быть создано две фигуры\n");
            if (ptr1 != null && ptr2 != null)
            {
                cond = true;
                while (cond)
                {
                    Console.WriteLine("Введите 1 чтобы сравнить фигуры по площади - \n");
                    Console.WriteLine("Введите 2 чтобы проверить пересекаемость фигур - \n");
                    Console.WriteLine("Введите 3 чтобы проверить входимость одной фигуры в другую - \n");
                    Console.WriteLine("Введите любую другую цифру  чтобы выйти - \n");
                    temp = int.Parse(Console.ReadLine());
                    switch (temp)
                    {
                        case 1:
                            {
                                Operations.compare(ptr1, ptr2);
                                break;
                            }
                        case 2:
                            {
                                if (Operations.inTersect(ptr1, ptr2) == true)
                                {
                                    Console.WriteLine("Первая фигура пересекается со второй\n");
                                }
                                else
                                {
                                    Console.WriteLine("Первая фигуры не пересекается со второй\n");
                                }
                                break;
                            }
                        case 3:
                            {
                                if (Operations.isInclude(ptr1, ptr2) == true)
                                {
                                    Console.WriteLine("Первая фигура включена во вторую\n");
                                }
                                else
                                {
                                    Console.WriteLine("Первая фигура не включена во вторую\n");
                                }
                                break;
                            }
                        default:
                            {
                                cond = false;
                                break;
                            }
                    }
                }

            }
        }
    }
}
