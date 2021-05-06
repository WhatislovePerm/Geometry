using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Figure;

namespace SquareCalculatorTests
{
    [TestClass]
    public class SquareCalculatorTests
    {
        [TestMethod]
        public void TestSquareCalcTriangle()
        {
            var figure = new Figure.Figure(new double?[] {7, 8, 9 });
            Assert.AreEqual(30, Figure.Figure.SquareCalc(figure));
        }
        [TestMethod]
        public void TestSquareCalcRound()
        {
            var figure = new Figure.Figure(4);
            Assert.AreEqual(25, Math.Floor(Figure.Figure.SquareCalc(figure)));
        }
        [TestMethod]
        public void TestSquareCalcExeption()
        {
            var figure = new Figure.Figure(4);
            Assert.AreEqual(25, Math.Floor(Figure.Figure.SquareCalc(figure)));
        }
        [TestMethod]
        public void TestSquareCalcRightTriangle()
        {
            var figure = new Figure.Figure(new double?[] {3, 4, 5});
            Assert.AreEqual(6, Figure.Figure.SquareCalc(figure));
        }
    }
}
