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
    public class SettlementTest
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
        public void SettlementConstructorTest()
        {
            var target = new Settlement();
            Assert.IsInstanceOfType(target, typeof(Settlement));
        }

        /// <summary>
        ///Тест для Client
        ///</summary>
        [TestMethod]
        public void ClientTest()
        {
            var target = new Settlement();
            var expected = new Client { FirstName = "Имя1", LastName = "Фамилия1", SecondName = "Отчество1", Passport = "Паспортные данные1" };
            target.Client = expected;
            Client actual = target.Client;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Тест для EndDate
        ///</summary>
        [TestMethod]
        public void EndDateTest()
        {
            var target = new Settlement();
            var expected = DateTime.Now.AddDays(5);
            target.EndDate = expected;
            var actual = target.EndDate;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Тест для Room
        ///</summary>
        [TestMethod]
        public void RoomTest()
        {
            var target = new Settlement();
            var expected = new Room { Category = "Эконом", CostPerDay = 1000, Name = "101", PlaceCount = 4 };
            target.Room = expected;
            var actual = target.Room;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Тест для StartDate
        ///</summary>
        [TestMethod]
        public void StartDateTest()
        {
            var target = new Settlement();
            var expected = DateTime.Now;
            target.StartDate = expected;
            DateTime actual = target.StartDate;
            Assert.AreEqual(expected, actual);
        }
    }
}
