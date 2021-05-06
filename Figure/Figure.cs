using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public sealed class Figure
    {
        /// <summary>
        /// Радиус фигуры
        /// </summary>
        public double? Radius { get; set; }
        /// <summary>
        /// Стороны фигуры
        /// </summary>
        public double?[] Sides { get; set; }
        /// <summary>
        /// Признак того, что фигура является прямоугольным треугольником
        /// </summary>
        public bool IsRightTriangle => Sides.Length == 3 && CheckOnPythagoreanTriple() ? true : false; 
        /// <summary>
        /// Метод вычисления площади фигуры
        /// </summary>
        /// <returns></returns>
        public static double SquareCalc(Figure f)
        {
            if(f.Radius.HasValue && f.Sides != null)
            {
                throw new Exception("Ошибка инициализации фигуры");
            }
            if (f.Radius.HasValue)
            {
                return Math.PI * f.Radius.Value * f.Radius.Value / 2.0;
            }
            if (f.IsRightTriangle)
            {
                Array.Sort(f.Sides);
                if (f.Sides[0].HasValue && f.Sides[1].HasValue)
                    return f.Sides[0].Value * f.Sides[1].Value / 2;
                else
                {
                    throw new Exception("Ошибка в инициализации треугольника");
                }   
            }
            if(f.Sides != null && f.Sides.Length == 3)
            {
                double square = 1;
                foreach(var s in f.Sides)
                {
                    square *= (f.halfMeter.Value - s.Value);
                }
                return Math.Sqrt(square * f.halfMeter.Value);
            }
            return -1;
        }
        /// <summary>
        /// Метод определения признака прямоугольности треугольника
        /// </summary>
        /// <returns>Возвращает:
        ///     True, если треугольник прямоугольный, иначе False
        /// </returns>
        private bool CheckOnPythagoreanTriple()
        {
            if((Sides[0] * Sides[0]) + (Sides[1] * Sides[1]) == (Sides[2] * Sides[2]))
            {
                return true;
            }
            if ((Sides[0] * Sides[0]) + (Sides[2] * Sides[2]) == (Sides[1] * Sides[1]))
            {
                return true;
            }
            if ((Sides[1] * Sides[1]) + (Sides[2] * Sides[2]) == (Sides[0] * Sides[0]))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Полупериметр фигуры
        /// </summary>
        public double? halfMeter
        {
            get
            {
                double? hf = 0;
                foreach(var s in Sides)
                {
                    hf += s;
                }
                return hf / 2;
            }
        }
        //Конструктор круга
        public Figure(double? radius)
        {
            Radius = radius;
        }
        //Конструктор треугольника
        public Figure(double?[] sides)
        {
            Sides = sides;
        }
    }
}
