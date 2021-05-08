using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Figure;

namespace SquareCalculatorTests
{
    [TestClass]
    public class SquareCalculatorTests
    {
        /// <summary>
        /// Тест на обычный треугольник
        /// </summary>
        [TestMethod]
        public void TestSquareCalcTriangle()
        {
            var figure = new Figure.Figure(new double?[] {3, 8, 9 });
            Assert.AreEqual(11, Math.Floor(Figure.Figure.SquareCalc(figure)));
        }
        /// <summary>
        /// Тест на круг
        /// </summary>
        [TestMethod]
        public void TestSquareCalcRound()
        {
            var figure = new Figure.Figure(4);
            Assert.AreEqual(25, Math.Floor(Figure.Figure.SquareCalc(figure)));
        }
        /// <summary>
        /// Тест на прямоугольный треугольник
        /// </summary>
        [TestMethod]
        public void TestSquareCalcRightTriangle()
        {
            var figure = new Figure.Figure(new double?[] {3, 4, 5});
            Assert.AreEqual(6, Figure.Figure.SquareCalc(figure));
        }
    }
}
