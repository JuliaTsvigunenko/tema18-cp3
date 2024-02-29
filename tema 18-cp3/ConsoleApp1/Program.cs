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

                    case "1":
                        Console.Write("Введите название: ");
                        string nameR = Console.ReadLine();
                        Console.Write("Введите сторону 1: ");
                        double side1R = double.Parse(Console.ReadLine());
                        Console.Write("Введите сторону 2: ");
                        double side2R = double.Parse(Console.ReadLine());
                        figures.Add(new Rectangle(nameR, side1R, side2R));
                        break;


                    case "2":
                        Console.Write("Введите название: ");
                        string nameS = Console.ReadLine();
                        Console.Write("Введите сторону: ");
                        double sideS = double.Parse(Console.ReadLine());
                        figures.Add(new Square(nameS, sideS));
                        break;



                    case "3":
                        Console.Write("Введите название: ");
                        string nameT = Console.ReadLine();
                        Console.Write("Введите сторону 1: ");
                        double side1T = double.Parse(Console.ReadLine());
                        Console.Write("Введите сторону 2: ");
                        double side2T = double.Parse(Console.ReadLine());
                        Console.Write("Введите сторону 3: ");
                        double side3T = double.Parse(Console.ReadLine());
                        figures.Add(new Triangle(nameT, side1T, side2T, side3T));
                        break;


                    case "4":
                        Console.Write("Введите название: ");
                        string nameC = Console.ReadLine();
                        Console.Write("Введите радиус: ");
                        double radiusC = double.Parse(Console.ReadLine());
                        figures.Add(new Circle(nameC, radiusC));
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
