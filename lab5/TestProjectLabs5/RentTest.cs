using Labs5;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProjectLabs5
{
    
    
    /// <summary>
    ///Это класс теста для SettlementTest, в котором должны
    ///находиться все модульные тесты SettlementTest
    ///</summary>
    [TestClass]
    public class RentTest
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
        ///Тест для Конструктор Settlement
        ///</summary>
        [TestMethod]
        public void RentConstructorTest()
        {
            var target = new Rent();
            Assert.IsInstanceOfType(target, typeof(Rent));
        }

        /// <summary>
        ///Тест для Client
        ///</summary>
        [TestMethod]
        public void ClientTest()
        {
            var target = new Rent();
            var expected = new Client { FirstName = "Имя1", LastName = "Фамилия1", SecondName = "Отчество1", Phone = "79201234567",Adress="Адрес1" };
            target.Client = expected;
            Client actual = target.Client;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Тест для DateReturn
        ///</summary>
        [TestMethod]
        public void EndDateTest()
        {
            var target = new Rent();
            var expected = DateTime.Now.AddDays(5);
            target.DateReturn = expected;
            var actual = target.DateReturn;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Тест для Room
        ///</summary>
        [TestMethod]
        public void RoomTest()
        {
            var target = new Rent();
            var expected = new Car { Number= "к964вз", Brand="Тойота Камри", CostPerDay = 1000, Cost=10000, Type= "Седан" };
            target.Car = expected;
            var actual = target.Car;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Тест для DateGive
        ///</summary>
        [TestMethod]
        public void StartDateTest()
        {
            var target = new Rent();
            var expected = DateTime.Now;
            target.DateGive = expected;
            DateTime actual = target.DateGive;
            Assert.AreEqual(expected, actual);
        }
    }
}
