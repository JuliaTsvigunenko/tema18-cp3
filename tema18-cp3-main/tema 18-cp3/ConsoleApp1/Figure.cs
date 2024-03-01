using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Абстрактный класс фигуры
    abstract class Figure
    {

        private string name;

        /// <summary>
        /// Конструктор с одним параметром, инициализирующий название фигуры
        /// </summary>
        /// <param name="name"></param>
        public Figure(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Свойство для доступа к названию фигуры
        /// </summary>
        public string Name { get { return name; } set { name = value; } }


        /// <summary>
        /// Абстрактный метод для вычисления площади фигуры
        /// </summary>
        /// <returns></returns>
        public abstract double Area();

        /// <summary>
        /// Абстрактный метод для вычисления периметра фигуры
        /// </summary>
        /// <returns></returns>
        public abstract double Perimeter();

        /// <summary>
        /// Виртуальный метод для вывода информации о фигуре
        /// </summary>
        public virtual void Print()
        {
            Console.WriteLine($"информации о фигуре: {name}");
        }








    }
}
