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
    //проверки допустимых классов эквивалентности
    [TestClass]
    public class StraightTestsValid
    {
        //прямые персекаются
        //прямые персеются - точка задана в структуре
        //Прямые пересекаются - точка соотвествует ожиданиям
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
                IPoint = new PointF(2, 2)          
            };

            //act
            var actual = S1.GetIntersectioWith(S2);

            //assert
            Assert.AreEqual(expected.IPoint, actual.IPoint);

        }

        //точки задают параельные  - флаг параллельности поднят  
        //прямые параллельны
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
                IsParallel = true,
            };

            //act
            var actual = S1.GetIntersectioWith(S2);
            //assert
            Assert.AreEqual(expected.IsParallel, actual.IsParallel);

        }

        //точки лежат на 1 прямой - флаг совпадения поднят
        //прямые совпадают
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
                IsSame = true
            };

            //act
            var actual = S1.GetIntersectioWith(S2);
            //assert

            Assert.AreEqual(expected.IsSame, actual.IsSame);


        }



        //входные числа имеютот 1 до 9 целых значащих разрядов
        //выходные числа имеютот 1 до 9 целых значащих разрядов
        [TestMethod]
        public void GetIntersectioWith_Given4PointsThatCrossedInsideFloatPresitionOnBigNumbers_ReturnIPoint()
        {
            //если все введенные разряды обработаны - результат не будет равен  точке 
            // заданной выражением, в котором разряды сократиись


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


        //входные числа имеютот 1 до 9 дробных значащих разрядов
        //выходные числа имеютот 1 до 9 дробных значащих разрядов       
        [TestMethod]
        public void GetIntersectioWith_Given4PointsThatCrossedInsideFloatPresitionOnSmallNumbers_ReturnIPoint()
        {
            //если все введенные разряды обработаны - результат не будет равен  точке 
            // заданной выражением, в котором разряды сократиись

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
    }

    //проверки недопустимых классов эквивалентности
    [TestClass]
    public class StraightTestsInValid
    {
        //прямые персекаются но точки нет
        [TestMethod]
        public void GetIntersectioWith_GivenValid4Points_NotReturnNoIPoint()
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
                IPoint = new PointF(2, 2)
            };

            //act
            var actual = S1.GetIntersectioWith(S2);

            //assert
            Assert.AreNotEqual(null, actual.IPoint);

        }

        /*
        //прямые пересекаются но точка не соотвесвует ожидаемой
        [TestMethod]
        public void GetIntersectioWith_GivenValid4PointsStraightsIntersect_ReturnValidIPoint()
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
                IPoint = new PointF(2, 2)
            };

            //act
            var actual = S1.GetIntersectioWith(S2);

            //assert
            Assert.AreEqual(expected.IPoint, actual.IPoint);

        }
        */

        //произошло более одной ситуации
        //параллельны и совпадают
        [TestMethod]
        public void GetIntersectioWith_4PointsOnStraight_NotSameAndParralel()
        {
            //arrange         
            Straight S1 = new Straight(
                new PointF(0, 0),
                new PointF(2, 2)
                );
            Straight S2 = new Straight(
                new PointF(3, 3),
                new PointF(4, 4)

                );
            //прямые на одной прямой
            IntersectionResult expected = new IntersectionResult
            {
                IPoint = null,
                IsParallel = true,
                IsSame = true
            };

            //act
            var actual = S1.GetIntersectioWith(S2);

            //assert
            if (expected.IsParallel == actual.IsParallel
                && expected.IsSame == actual.IsSame)
               Assert.Fail();         
        }



        //произошло более одной ситуации
        //персекаются и параллельны
        [TestMethod]
        public void GetIntersectioWith_IntersectedStraight_ReturnNotIpointAndParallel()
        {
            //arrange         
            Straight S1 = new Straight(
                new PointF(0, 0),
                new PointF(2, 2)
                );
            Straight S2 = new Straight(
                new PointF(0, 2),
                new PointF(2, 0)
                );
            //прямые пересекаются
   
            //act
            var actual = S1.GetIntersectioWith(S2);

            //assert
            if (actual.IsParallel == true
                && actual.IPoint!= null)
                Assert.Fail();
        }

        //произошло более одной ситуации
        //персекаются и совпадают
        [TestMethod]
        public void GetIntersectioWith_IntersectedStraight_ReturnNotIpointAndSame()
        {
            //arrange         
            Straight S1 = new Straight(
                new PointF(0, 0),
                new PointF(2, 2)
                );
            Straight S2 = new Straight(
                new PointF(0, 2),
                new PointF(2, 0)
                );
            //прямые пересекаются
       

            //act
            var actual = S1.GetIntersectioWith(S2);

            //assert
            if (actual.IsSame == true
               && actual.IPoint != null)
                Assert.Fail();
        }


        //входные числа имеют более 9 целых значащих разрядов 
        //выходные числа имеют более 9 целых значащих разрядов 
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
            Assert.AreEqual(expected.IPoint, actual.IPoint);

        }

        //входные числа имеют более 9 дробных значащих разрядов 
        //выходные числа имеют более 9 дробных значащих разрядов 
        //проверяем что точность теряется при выходе за границы точности  float
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
            Assert.AreEqual(expected.IPoint, actual.IPoint);

        }

        //задать входные значения так чтобы выходные выщли за верхнюю гарницу не даст нижняя граница


    }

}