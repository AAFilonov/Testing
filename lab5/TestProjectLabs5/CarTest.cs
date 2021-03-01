using Labs5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProjectLabs5
{
    /// <summary>
    ///Это класс теста для RoomTest, в котором должны
    ///находиться все модульные тесты RoomTest
    ///</summary>
    [TestClass]
    public class CarTest
    {
        /// <summary>
        ///Получает или устанавливает контекст теста, в котором предоставляются
        ///сведения о текущем тестовом запуске и обеспечивается его функциональность.
        ///</summary>
        public TestContext TestContext { get; set; }

        #region Дополнительные атрибуты теста
        // 
        //При написании тестов можно использовать следующие дополнительные атрибуты:
        //
        //ClassInitialize используется для выполнения кода до запуска первого теста в классе
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //ClassCleanup используется для выполнения кода после завершения работы всех тестов в классе
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //TestInitialize используется для выполнения кода перед запуском каждого теста
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //TestCleanup используется для выполнения кода после завершения каждого теста
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Тест для Конструктор Car
        ///</summary>
        [TestMethod]
        public void RoomConstructorTest()
        {
            var target = new Car();
            Assert.IsInstanceOfType(target, typeof(Car));
        }

        /// <summary>
        ///Тест для Number
        ///</summary>
        [TestMethod]
        public void NumberTest()
        {
            var target = new Car();
            const string expected = "к964вз";
            target.Number = expected;
            var actual = target.Number;
            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        ///Тест для Brand
        ///</summary>
        [TestMethod]
        public void BrandTest()
        {
            var target = new Car();
            const string expected = "Тойота Камри";
            target.Brand = expected;
            var actual = target.Brand;
            Assert.AreEqual(expected, actual);
        }

      
        /// <summary>
        ///Тест для Cost
        ///</summary>
        [TestMethod]
        public void CostPTest()
        {
            var target = new Car();
            const decimal expected = 1000M;
            target.Cost = expected;
            var actual = target.Cost;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Тест для CostPerDay
        ///</summary>
        [TestMethod]
        public void CostPerDayTest()
        {
            var target = new Car();
            const decimal expected = 10M;
            target.CostPerDay = expected;
            var actual = target.CostPerDay;
            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        ///Тест для Type
        ///</summary>
        [TestMethod]
        public void TypeTest()
        {
            var target = new Car();
            const string expected = "Седан";
            target.Type = expected;
            var actual = target.Type;
            Assert.AreEqual(expected, actual);
        }


    }
}
