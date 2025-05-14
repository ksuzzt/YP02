using System;

namespace TriangleApp
{
    class Triangle
    {
        private double x0, y0, x1, y1, x2, y2, x3, y3;
        private double a, b, c, p, pp, s;

        // ввод координат вершин треугольника
        public void PostroitTreugolnik()
        {
            Console.Write("x1 = "); x1 = double.Parse(Console.ReadLine());
            Console.Write("y1 = "); y1 = double.Parse(Console.ReadLine());
            Console.Write("x2 = "); x2 = double.Parse(Console.ReadLine());
            Console.Write("y2 = "); y2 = double.Parse(Console.ReadLine());
            Console.Write("x3 = "); x3 = double.Parse(Console.ReadLine());
            Console.Write("y3 = "); y3 = double.Parse(Console.ReadLine());
        }

        // вычисление длин сторон
        public void DliniStoron()
        {
            a = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            b = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
            c = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));

            Console.WriteLine($"a = {a:F2}");
            Console.WriteLine($"b = {b:F2}");
            Console.WriteLine($"c = {c:F2}");
        }

        // вычисление периметра и полупериметра
        public void Perimetr()
        {
            p = a + b + c;
            pp = p / 2;
            Console.WriteLine($"Периметр = {p:F2}");
        }

        // формула Герона
        public void Ploshad()
        {
            s = Math.Sqrt(pp * (pp - a) * (pp - b) * (pp - c));
            Console.WriteLine($"Площадь = {s:F2}");
        }

        // сравнение площадей 
        public void Sravnenie()
        {
            Triangle t1 = new Triangle();
            Console.WriteLine("Введите координаты первого треугольника:");
            t1.PostroitTreugolnik();
            t1.DliniStoron();
            t1.Perimetr();
            t1.Ploshad();

            Triangle t2 = new Triangle();
            Console.WriteLine("Введите координаты второго треугольника:");
            t2.PostroitTreugolnik();
            t2.DliniStoron();
            t2.Perimetr();
            t2.Ploshad();

            if (t1.s == t2.s)
                Console.WriteLine("Площади треугольников равны.");
            else if (t1.s > t2.s)
                Console.WriteLine("Площадь первого треугольника больше.");
            else
                Console.WriteLine("Площадь второго треугольника больше.");
        }

        // Проверка принадлежности точки треугольнику
        //public void ProverkaTochki()
        //{
        //Console.WriteLine("Введите координаты точки (x0, y0):");
        //Console.Write("x0 = "); x0 = double.Parse(Console.ReadLine());
        //Console.Write("y0 = "); y0 = double.Parse(Console.ReadLine());

        // int a1 = (int)((x1 - x0) * (y2 - y1) - (x2 - x1) * (y1 - y0));
        //  int b1 = (int)((x2 - x0) * (y3 - y2) - (x3 - x2) * (y2 - y0));
        // int c1 = (int)((x3 - x0) * (y1 - y3) - (x1 - x3) * (y3 - y0));

        //   if ((a1 >= 0 && b1 >= 0 && c1 >= 0) || (a1 <= 0 && b1 <= 0 && c1 <= 0))
        // Console.WriteLine("Точка принадлежит треугольнику.");
        //else
        // Console.WriteLine("Точка НЕ принадлежит треугольнику.");
        //}
        //}

        // Console.WriteLine("2 - Проверить принадлежность точки треугольнику");
        // case 2: 
        //    Triangle triangle1 = new Triangle();
        //    triangle1.PostroitTreugolnik();
        //    triangle1.ProverkaTochki();
        //    break;

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1 - Сравнить площади двух треугольников");
                Console.Write("Ваш выбор: ");
                int v = int.Parse(Console.ReadLine());

                switch (v)
                {
                    case 1:
                        Triangle triangle2 = new Triangle();
                        triangle2.Sravnenie();
                        break;

                    default:
                        Console.WriteLine("Ошибка ввода!");
                        break;
                }

                Console.WriteLine("Нажмите любую клавишу для выхода...");
                Console.ReadKey();
            }
        }
    }
}