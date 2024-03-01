using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Производный класс прямоугольника
    class Rectangle : Figure
    {

        private double side1;
        private double side2;



        /// <summary>
        ///  Конструктор с параметрами для прямоугольника
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        public Rectangle(string name, double side1, double side2) : base(name)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        /// <summary>
        /// Свойство для доступа к внутренним полям side1    side2
        /// </summary>
        public double Side1R { get { return side1; } set { side1 = value; } }
        public double Side2R { get { return side2; } set { side2 = value; } }




        /// <summary>
        ///  Переопределенный метод для вычисления площади прямоугольника
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
            return side1 * side2;
        }

        /// <summary>
        ///   метод для вычисления периметра прямоугольника
        /// </summary>
        /// <returns></returns>
        public override double Perimeter()
        {
            return 2 * (side1 + side2);
        }

        /// <summary>
        /// метод для вывода информации о прямоугольнике
        /// </summary>
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Стороны фигуры: {side1}, {side2}");
        }









    }
}
