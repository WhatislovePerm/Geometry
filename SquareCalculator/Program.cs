using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figure;

namespace SquareCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = new Figure.Figure(new double?[] { 7, 8, 9 });
            var x = Figure.Figure.SquareCalc(figure);
            Console.WriteLine(x);
        }
    }



}
