using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Производный класс круга
    class Circle : Figure
    {

        private double radius;

        /// <summary>
        ///  Конструктор с параметром для круга
        /// </summary>
        /// <param name="radius"></param>
        public Circle(string name, double radius) : base(name)
        {
            this.radius = radius;
        }

        public double Radius { get { return radius; } set { radius = value; } }


        /// <summary>
        /// метод для вычисления площади круга
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
            return Math.PI * radius * radius;
        }



        /// <summary>
        /// метод для вычисления длины окружности (периметр) круга
        /// </summary>
        /// <returns></returns>
        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }




        /// <summary>
        ///  метод для вывода информации о круге
        /// </summary>
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Радиус: {radius}");
        }










    }
}
