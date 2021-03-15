using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lab7_2;
using System.Drawing;
namespace Lab7_2Tests
{
    //допустимые классы эквивалентности:
    [TestClass]
    public class GeometryTestsValid
    {


        //возвращенное значение - как то заполненная структура IntersectionResult
        //аргументы верного формата и их  8 - ошибки нет
        [TestMethod]
        public void IntersectionCheck_GivenValidDataWith4point_ReturnsNoException()
        {
            //arrange
            var Geometry = new Geometry();
            var arg = "0.0 0.0 " + "1.0 1.0 " + "1.0 1.0 " + "0.0 1.0";
            IntersectionResult expected = new IntersectionResult();

            //act
            var actual = Geometry.IntersectionCheckStr(arg);
            //assert
            Assert.AreEqual(null, actual.GetError());

        }

        //произошла ошибка
        //переданы координаты неверного формата - выдало ошибку формата
        [TestMethod]
        public void IntersectionCheck_GivenInValidDataWith4point_ReturnsException()
        {
            //arrange
            var Geometry = new Geometry();
            var arg = "0.0;0.0;" + "1.0;1.0;" + "1.0;1.0;" + "0.0;1.0;";
            IntersectionResult expected = new IntersectionResult();

            //act
            var actual = Geometry.IntersectionCheckStr(arg);
            //assert
            Assert.AreEqual(typeof(FormatException), actual.GetError().GetType());

        }

        //переданно количество координат отличное от 8 - ошибка переданных аргументов
        //3 пары координат
        [TestMethod]
        public void IntersectionCheck_GivenValidDataWithLessThen4point_ReturnsException()
        {
            //arrange
            var Geometry = new Geometry();
            var arg = "0.0 0.0 " + "1.0 1.0 " + "0.0 1.0";
            IntersectionResult expected = new IntersectionResult();

            //act
            var actual = Geometry.IntersectionCheckStr(arg);
            //assert
            Assert.AreEqual(new Exception("Wrong amount of arguments").Message, actual.GetError().Message);

        }

        //переданно количество координат отличное от 8 - ошибка переданных аргументов
        //5 пар координат
        [TestMethod]
        public void IntersectionCheck_GivenValidDataWithMoreThen4point_ReturnsException()
        {
            //arrange
            var Geometry = new Geometry();
            var arg = "0.0 0.0 " + "1.0 1.0 " + "1.0 1.0 " + "0.0 1.0 " + "0.0 1.0"; ;
            IntersectionResult expected = new IntersectionResult();

            //act
            var actual = Geometry.IntersectionCheckStr(arg);
            //assert
            Assert.AreEqual(new Exception("Wrong amount of arguments").Message, actual.GetError().Message);

        }

        //переданы координаты неверного формата - выдало ошибку формата
        //пустая строка
        [TestMethod]
        public void IntersectionCheck_GivenEmptySring_ReturnsException()
        {
            //arrange
            var Geometry = new Geometry();
            var arg = ""; 
            IntersectionResult expected = new IntersectionResult();

            //act
            var actual = Geometry.IntersectionCheckStr(arg);
            //assert         
            Assert.AreEqual( typeof(FormatException), actual.GetError().GetType());

        }
    }

    //не допустимые классы эквивалентности:
    [TestClass]
    public class GeometryTestsInValid
    {
        //возвращенное значение - null
        [TestMethod]
        public void IntersectionCheck_GivenEmtyString_ReturnsException()
        {

            //arrange
            var Geometry = new Geometry();
            var arg = "0.0 0.0 " + "1.0 1.0 " + "1.0 1.0 " + "0.0 1.0";
            IntersectionResult expected = new IntersectionResult();

            //act
            var actual = Geometry.IntersectionCheckStr(arg);
            //assert
            Assert.AreNotEqual(null, actual);

        }
        //аргументы верного формата и их  8  - возникла ошибка (отличная от фомрата и количества аргументов)
        [TestMethod]
        public void IntersectionCheck_GivenInVaidData_ReturnsException()
        {

            //arrange
            var Geometry = new Geometry();
            var arg = "0.0 0.0 " + "1.0 1.0 " + "1.0 1.0 " + "1.0 1.0 ";
            IntersectionResult expected = new IntersectionResult();

            //act
            var actual = Geometry.IntersectionCheckStr(arg);
            //assert
            Assert.AreNotEqual(null, actual.GetError());

        }

        /*
        //переданы координаты неверного формата - не выдало ошибку формата
        [TestMethod]
        public void IntersectionCheck_GivenVaidData_ReturnsNoException()
        {

            //arrange
            var Geometry = new Geometry();
            var arg = "0.00.0asdasd" + "1.01.0 " + "1.01.0" + "0.01.0";
            IntersectionResult expected = new IntersectionResult();

            //act
            var actual = Geometry.IntersectionCheckStr(arg);
            //assert
            Assert.AreNotEqual(new FormatException(), actual.GetError());

        }

        //переданно количество координат отличное от 8 -  не выдаст ошибки
        [TestMethod]
        public void IntersectionCheck_GivenInVaidData_ReturnsException()
        {

            //arrange
            var Geometry = new Geometry();
            var arg = "0.0;0.0;" + "1.0;1.0" + "1.0 1.0 ";
            IntersectionResult expected = new IntersectionResult();

            //act
            var actual = Geometry.IntersectionCheckStr(arg);
            //assert
            Assert.AreEqual(new Exception("Wrong amount of arguments"), actual.GetError());

        }
        */
    }
}

