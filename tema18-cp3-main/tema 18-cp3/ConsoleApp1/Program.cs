using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            List<Figure> figures = new List<Figure>();

            while (true)
            {
                Console.Write("Введите фигуру: ");
                string format = Console.ReadLine();
                switch(format)
                {

                    case "R":
                    case "r":

                        string nameR = "Прямоугольник";
                        Console.Write("Введите сторону 1: ");
                        double side1R = double.Parse(Console.ReadLine());
                        Console.Write("Введите сторону 2: ");
                        double side2R = double.Parse(Console.ReadLine());
                        figures.Add(new Rectangle(nameR, side1R, side2R));

                        foreach (var elem in figures)
                        {
                            elem.Print();
                            Console.WriteLine($"Площадь: {elem.Area()}");
                            Console.WriteLine($"Периметр: {elem.Perimeter()}");
                        }

                        break;


                    case "S":
                    case "s":

                        string nameS = "Квадрат";
                        Console.Write("Введите сторону: ");
                        double sideS = double.Parse(Console.ReadLine());
                        figures.Add(new Square(nameS, sideS));

                        foreach (var elem in figures)
                        {
                            elem.Print();
                            Console.WriteLine($"Площадь: {elem.Area()}");
                            Console.WriteLine($"Периметр: {elem.Perimeter()}");
                        }


                        break;



                    case "T":
                    case "t":

                        string nameT = "Треугольник";
                        Console.Write("Введите сторону 1: ");
                        double side1T = double.Parse(Console.ReadLine());
                        Console.Write("Введите сторону 2: ");
                        double side2T = double.Parse(Console.ReadLine());
                        Console.Write("Введите сторону 3: ");
                        double side3T = double.Parse(Console.ReadLine());
                        figures.Add(new Triangle(nameT, side1T, side2T, side3T));


                        foreach (var elem in figures)
                        {
                            elem.Print();
                            Console.WriteLine($"Площадь: {elem.Area()}");
                            Console.WriteLine($"Периметр: {elem.Perimeter()}");
                        }


                        break;


                    case "C":
                    case "c":

                        string nameC = "Круг";
                        Console.Write("Введите радиус: ");
                        double radiusC = double.Parse(Console.ReadLine());
                        figures.Add(new Circle(nameC, radiusC));
                       

                        foreach (var elem in figures)
                        {
                            elem.Print();
                            Console.WriteLine($"Площадь: {elem.Area()}");
                            Console.WriteLine($"Периметр: {elem.Perimeter()}");
                        }
                        break;

                    default:
                        Console.WriteLine("Неверно :(   Пожалуйста, попробуйте снова.");
                        break;

                }
                Console.ReadKey();
            }
          










           







        }
    }
}
