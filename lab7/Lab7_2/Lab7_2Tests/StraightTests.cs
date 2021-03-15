using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab7_2;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_2Tests
{
    [TestClass]
    public class StraightTests
    {

        //проверки допустимых классов

        [TestMethod]
        public void GetIntersectioWith_Given4PointsThatCrossedOnAverageNumbers_ReturnIPoint()
        {

            //arrange         
            Straight S1 = new Straight(
                new PointF(2, 0),
                new PointF(2, 2)
                );
            Straight S2 = new Straight(

                new PointF(0, 2),
                new PointF(2, 2)

                );

            IntersectionResult expected = new IntersectionResult
            {
                IPoint = new PointF(2, 2),
                IsParallel = false,
                IsSame = false
            };

            //act
            var actual = S1.GetIntersectioWith(S2);
            //assert
            Assert.AreEqual(expected.IsParallel, actual.IsParallel);
            Assert.AreEqual(expected.IsSame, actual.IsSame);
            Assert.AreEqual(expected.IPoint, actual.IPoint);

        }


        [TestMethod]
        public void GetIntersectioWith_Given4PointsThatCrossedInsideFloatPresitionOnBigNumbers_ReturnIPoint()
        {

            //arrange         
            Straight S1 = new Straight(
                new PointF(0f, 123456f),
                new PointF(1f, 123456f)
                );
            Straight S2 = new Straight(
                new PointF(123456f, 0f),
                new PointF(123456f, 1f)

                );

            IntersectionResult expected = new IntersectionResult
            {
                IPoint = new PointF(123456f, 123456f),
                IsParallel = false,
                IsSame = false
            };

            //act
            var actual = S1.GetIntersectioWith(S2);
            //assert
            Assert.AreEqual(expected.IsParallel, actual.IsParallel);
            Assert.AreEqual(expected.IsSame, actual.IsSame);
            Assert.AreEqual(expected.IPoint, actual.IPoint);

        }
        [TestMethod]
        public void GetIntersectioWith_Given4PointsThatCrossedInsideFloatPresitionOnSmallNumbers_ReturnIPoint()
        {

            //arrange         
            Straight S1 = new Straight(
                new PointF(0f, 0.123456f),
                new PointF(1f, 0.123456f)
                );
            Straight S2 = new Straight(
                new PointF(0.123456f, 0f),
                new PointF(0.123456f, 1f)

                );

            IntersectionResult expected = new IntersectionResult
            {
                IPoint = new PointF(0.123456f, 0.123456f),
                IsParallel = false,
                IsSame = false
            };

            //act
            var actual = S1.GetIntersectioWith(S2);
            //assert
            Assert.AreEqual(expected.IsParallel, actual.IsParallel);
            Assert.AreEqual(expected.IsSame, actual.IsSame);
            Assert.AreEqual(expected.IPoint, actual.IPoint);

        }

        //проверки недопустимых классов
        // 0 общих точек паралельные
        [TestMethod]
        public void GetIntersectioWith_parallel_Parallel()
        {

            //arrange         
            Straight S1 = new Straight(
                new PointF(1f, 0f),
                new PointF(2f, 1f)
                );
            Straight S2 = new Straight(
                    new PointF(1f, 1f),
                new PointF(2f, 2f)

                );

            IntersectionResult expected = new IntersectionResult
            {
                IPoint = null,
                IsParallel = true,
                IsSame = false
            };

            //act
            var actual = S1.GetIntersectioWith(S2);
            //assert
            Assert.AreEqual(expected.IsParallel, actual.IsParallel);
            Assert.AreEqual(expected.IsSame, actual.IsSame);
            Assert.AreEqual(expected.IPoint, actual.IPoint);

        }
        // 0 общих точек паралельные
        [TestMethod()]
        public void GetIntersectioWith_same_Same()
        {
            //arrange         
            Straight S1 = new Straight(
                new PointF(1f, 1f),
                new PointF(2f, 2f)
                );
            Straight S2 = new Straight(
               new PointF(3f, 3f),
               new PointF(4f, 4f)

               );

            IntersectionResult expected = new IntersectionResult
            {
                IPoint = null,
                IsParallel = false,
                IsSame = true
            };

            //act
            var actual = S1.GetIntersectioWith(S2);
            //assert
            Assert.AreEqual(expected.IsParallel, actual.IsParallel);
            Assert.AreEqual(expected.IsSame, actual.IsSame);
            Assert.AreEqual(expected.IPoint, actual.IPoint);

        }
    }
}