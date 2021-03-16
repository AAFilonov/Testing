using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lab7_2;
using System.Drawing;
namespace Lab7_2Tests
{
    [TestClass]
    public class GeometryTests
    {
        
        //проверяет корректность преобразования строки в точки + корректность обработки количества точек
        [TestMethod]
        public void IntersectionCheck_Given4point_ReturnsNoException()
        {
            //arrange
            var Geometry = new Geometry();
            var arg = "0.0 0.0 "+ "1.0 1.0 " + "1.0 1.0 "+"0.0 1.0";
            IntersectionResult expected = new IntersectionResult();

            //act
            var actual = Geometry.IntersectionCheckStr(arg);
            //assert
            Assert.AreEqual(null, actual.GetError());

        }

        //3 точки 
        [TestMethod]
        public void IntersectionCheck_Given3point_ReturnsException()
        {

            //arrange
            var Geometry = new Geometry();
            var arg = "0.0 0.0 " + "1.0 1.0 " + "0.0 1.0";
            IntersectionResult expected = new IntersectionResult();

            //act
            var actual = Geometry.IntersectionCheckStr(arg);
            //assert
            Assert.AreNotEqual(null, actual.GetError());

        }
        //5 точек 
        [TestMethod]
        public void IntersectionCheck_Given5point_ReturnsException()
        {

            //arrange
            var Geometry = new Geometry();
            var arg = "0.0 0.0 " + "1.0 1.0 " + "1.0 1.0 " + "0.0 1.0 " + "0.0 1.0";
            IntersectionResult expected = new IntersectionResult();

            //act
            var actual = Geometry.IntersectionCheckStr(arg);
            //assert
            Assert.AreNotEqual(null, actual.GetError());

        }
        //0 точек 
        [TestMethod]
        public void IntersectionCheck_GivenEmtyString_ReturnsException()
        {

            //arrange
            var Geometry = new Geometry();
            var arg = "";
            IntersectionResult expected = new IntersectionResult();

            //act
            var actual = Geometry.IntersectionCheckStr(arg);
            //assert
            Assert.AreNotEqual(null, actual.GetError());

        }
    }
}

