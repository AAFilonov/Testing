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


        //числа не ниже границы float
        [TestMethod]
        public void GetIntersectioWith_Given4PointsThatCrossedInsideFloatPresitionOnBigNumbers_ReturnIPoint()
        {

            //arrange         
            Straight S1 = new Straight(
                new PointF(0f, 345678910f),
                new PointF(1f, 345678910f)
                );
            Straight S2 = new Straight(
                new PointF(345678810f, 0f),
                new PointF(345678910f, 1f)

                );

            IntersectionResult expected = new IntersectionResult
            {
                IPoint = new PointF(345678910f, 345678910f),
                IsParallel = false,
                IsSame = false
            };

            //act
            var actual = S1.GetIntersectioWith(S2);
            //assert
            Assert.AreNotEqual(expected.IPoint, actual.IPoint);

        }



        [TestMethod]
        public void GetIntersectioWith_Given4PointsThatCrossedInsideFloatPresitionOnSmallNumbers_ReturnIPoint()
        {

            //arrange         
            Straight S1 = new Straight(
                new PointF(0f, 0.45678910f),
                new PointF(1f, 0.45678910f)
                );
            Straight S2 = new Straight(
                new PointF(0.45678810f, 0f),
                new PointF(0.45678910f, 1f)

                );

            IntersectionResult expected = new IntersectionResult
            {
                IPoint = new PointF(0.45678910f, 0.45678910f),
                IsParallel = false,
                IsSame = false
            };
            //act
            var actual = S1.GetIntersectioWith(S2);
            //assert
            Assert.AreNotEqual(expected.IPoint, actual.IPoint);

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




        //входные и выходные числа выше границы float
        [TestMethod]
        public void GetIntersectioWith_Given4PointsThatCrossedOutsideFloatPresitionOnBigNumbers_ReturnIPoint()
        {

            //arrange         
            Straight S1 = new Straight(
                new PointF(0f, 12345678910f),
                new PointF(1f, 12345678910f)
                );
            Straight S2 = new Straight(
                new PointF(12345678888f, 0f),
                new PointF(12345678910f, 1f)

                );

            IntersectionResult expected = new IntersectionResult
            {
                IPoint = new PointF(12345678910f, 12345678910f),
                IsParallel = false,
                IsSame = false
            };

            //act
            var actual = S1.GetIntersectioWith(S2);
            //assert
            Assert.AreNotEqual(expected.IPoint, actual.IPoint);

        }

        //входные и выходные числа ниже границы float
        [TestMethod]
        public void GetIntersectioWith_Given4PointsThatCrossedOutsideFloatPresitionOnSmallNumbers_ReturnIPoint()
        {

            //arrange         
            Straight S1 = new Straight(
                new PointF(0f, 0.12345678910f),
                new PointF(1f, 0.12345678910f)
                );
            Straight S2 = new Straight(
                new PointF(0.12345678888f, 0f),
                new PointF(0.12345678910f, 1f)

                );

            IntersectionResult expected = new IntersectionResult
            {
                IPoint = new PointF(0.12345678910f, 0.12345678910f),
                IsParallel = false,
                IsSame = false
            };

            //act
            var actual = S1.GetIntersectioWith(S2);
            //assert
            Assert.AreNotEqual(expected.IPoint, actual.IPoint);

        }

        //задать входные значения так чтобы выходные выщли за верхнюю гарницу не даст нижняя граница


    }

}