using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
В класс Circle добавить:
c. Свойства:
позволяющие получить-установить координаты центра круга (доступные для чтения и записи);
позволяющее получить-установить значение радиуса круга (доступное для чтения и записи).
d. Индексатор, позволяющий по индексу 0 получить значение площади круга, по индексу 1 – получить значение периметра круга, 
по индексу 2 получить значение диаметра круга.
*/

namespace Task2_Var5_OOP
{
    class Circle
    {
        private double x, y;
        private double r;

        public Circle(double radius)
        {
            x = 0;
            y = 0;
            r = radius;
        }

        public Circle(double axisX, double axisY, double radius)
        {
            x = axisX;
            y = axisY;
            r = radius;
        }

        public double coordinateX
        {
            get { return x; }
            set { x = value; }
        }

        public double coordinateY
        {
            get { return y; }
            set { y = value; }
        }

        public double radius
        {
            get { return r; }
            set { r = value; }
        }
       
        public void Print()
        {
            Console.WriteLine("Radius = " + r);
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
        }

        public double CircleSquare()
        {
            return Math.PI * Math.Pow(r, 2);
        }

        public void Move(double newX, double newY)
        {
            x = newX;
            y = newY;
        }

        //Добавим индексатор
        public double this[int i]
        {
            get
            {
                if (i == 0)
                {
                    return Math.PI * Math.Pow(r, 2);
                }
                else if (i == 1)
                {
                    return 2 * Math.PI * r;
                }
                else if (i == 2)
                {
                    return 2 * r;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double radius = 4;
            Circle circ1 = new Circle(radius);
            Console.WriteLine("Get координату X = " + circ1.coordinateX);
            //Выводим радиус и координаты центра круга на экран
            circ1.Print();
            //Рассчитываем площадь круга
            Console.WriteLine(circ1.CircleSquare());
            Console.WriteLine();

            double x = 3;
            double y = 7;
            radius = 5;
            Circle circ2 = new Circle(x, y, radius);
            Console.WriteLine("Get координату X = " + circ2.coordinateX);
            //Устанавливаем координату Y = 6
            circ2.coordinateY = 6;
            //Выводим радиус и координаты центра второго круга на экран
            circ2.Print();
            //Рассчитываем площадь круга
            Console.WriteLine(circ2.CircleSquare());
            Console.WriteLine();

            Console.WriteLine("Устанавливаем новые координаты круга:");
            circ2.coordinateX = 8;
            circ2.coordinateY = 9;
            circ2.Move(circ2.coordinateX, circ2.coordinateY);
            circ2.Print();
            Console.WriteLine();

            Console.WriteLine("Воспользуемся индексатором, узнаем длину окружности");
            Console.WriteLine(circ2[1]);
            Console.ReadKey();
        }
    }
}
