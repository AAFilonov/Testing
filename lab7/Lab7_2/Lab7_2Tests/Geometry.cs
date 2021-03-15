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
        public void IntersectionCheck_4point_notNull()
        {
            //arrange
            var Geometry = new Geometry();
            PointF S1P1 = new PointF(0f, 0f);
            PointF S1P2 = new PointF(1f, 1f);
            PointF S2P1 = new PointF(2f, 2f);
            PointF S2P2 = new PointF(3f, 2f);
            IntersectionResult expected = new IntersectionResult();

            //act
            var actual = Geometry.IntersectionCheck(S1P1, S1P2, S2P1, S2P2);
            //assert
            Assert.AreNotEqual(null, actual.IPoint);

        }

        //3 точки 
        [TestMethod]
        public void IntersectionCheck_3point_Null()
        {

           // throw new  NotImplementedException();

        }
        //5 точек 
        [TestMethod]
        public void IntersectionCheck_5point_Null()
        {

          //  throw new NotImplementedException();

        }
    }
}

