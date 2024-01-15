using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T14._1
{
    /// <summary>
    /// Нестат класс описания точки
    /// </summary>
    class Point
    {
        /// <summary>
        /// Описаны внутренние поля класса Point
        /// </summary>
        private double x, y;
        /// <summary>
        /// Счётчик
        /// </summary>
        public static int count;
        
        /// <summary>
        /// Нестат. конструктор с параметрами
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Point(double x, double y)
        {
            this.x = x; this.y = y;
            //count++;
            Point.count++;
        }
        /// <summary>
        /// Нестат. конст. без параметров
        /// </summary>
        public Point()
        {
            this.x = 1.0; this.y = 1.0;
            count++;
        }
        /// <summary>
        /// Статический конструктор Point(), 
        /// который инициализирует статическую переменную count нулевым значением
        /// </summary>
        static Point()
        {
            count = 0;
        }
        /// <summary>
        /// Методы доступа к внутренним переменным x, y 
        /// с именами GetX(), GetY(), SetX(), SetY();
        /// </summary>
        /// <returns></returns>
        public double GetX()
        {
            return x;
        }
        public double GetY()
        {
            return y;
        }
        public void SetX(double x)
        {
            this.x = x;
        }
        public void SetY(double y)
        {
            this.y = y;
        }
        /// <summary>
        /// Output
        /// </summary>
        public void Print()
        {
            WriteLine($"{x}\t{y}");
        }
        /*public static double LengthPoint(double x, double y)
        {
            return Math.Sqrt(Math.Pow(x + y, 2) - Math.Pow(x + y, 2));
        }*/
       
    }
}
