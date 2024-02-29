using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Производный класс квадрата
    class Square : Figure
    {

        private double side;


        /// <summary>
        ///  // Конструктор с параметром для квадрата
        /// </summary>
        /// <param name="name"></param>
        /// <param name="side"></param>
        public Square(string name, double side) : base(name)
        {
            this.side = side;
        }

        public double Side { get { return side; } set { side = value; } }



        /// <summary>
        ///  метод для вычисления площади квадрата
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
            return side * side;
        }



        /// <summary>
        ///  метод для вычисления периметра квадрата
        /// </summary>
        /// <returns></returns>
        public override double Perimeter()
        {
            return 4 * side;
        }


        /// <summary>
        ///  метод для вывода информации о квадрате
        /// </summary>
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Сторона фигуры: {side}");
        }







    }
}
