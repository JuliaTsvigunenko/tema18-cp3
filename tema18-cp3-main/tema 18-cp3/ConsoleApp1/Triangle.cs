using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Производный класс треугольника
    class Triangle : Figure
    {

        private double side1;
        private double side2;
        private double side3;

        /// <summary>
        /// Конструктор с параметрами для треугольника
        /// </summary>
        /// <param name="name"></param>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <param name="side3"></param>
        public Triangle(string name, double side1, double side2, double side3) : base(name)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public double Side1 { get { return side1; } set { side1 = value; } }
        public double Side2 { get { return side2; } set { side2 = value; } }
        public double Side3 { get { return side3; } set { side3 = value; } }


        /// <summary>
        /// метод для вычисления площади треугольника 
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
            double p = (side1 + side2 + side3) / 2;
            return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
        }


        /// <summary>
        /// метод для вычисления периметра треугольника
        /// </summary>
        /// <returns></returns>
        public override double Perimeter()
        {
            return side1 + side2 + side3;
        }


        /// <summary>
        ///  метод для вывода информации о треугольнике
        /// </summary>
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Стороны фигуры: {side1}, {side2}, {side3}");
        }


    }
}
