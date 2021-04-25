using Labs5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProjectLabs5
{
    /// <summary>
    ///Это класс теста для RoomTest, в котором должны
    ///находиться все модульные тесты RoomTest
    ///</summary>
    [TestClass]
    public class RoomTest
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
        ///Тест для Конструктор Room
        ///</summary>
        [TestMethod]
        public void RoomConstructorTest()
        {
            var target = new Room();
            Assert.IsInstanceOfType(target, typeof(Room));
        }

        /// <summary>
        ///Тест для Category
        ///</summary>
        [TestMethod]
        public void CategoryTest()
        {
            var target = new Room();
            const string expected = "Бизнес";
            target.Category = expected;
            var actual = target.Category;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Тест для CostPerDay
        ///</summary>
        [TestMethod]
        public void CostPerDayTest()
        {
            var target = new Room();
            const decimal expected = 1000M;
            target.CostPerDay = expected;
            var actual = target.CostPerDay;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Тест для Name
        ///</summary>
        [TestMethod]
        public void NameTest()
        {
            var target = new Room();
            const string expected = "404";
            target.Name = expected;
            var actual = target.Name;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Тест для PlaceCount
        ///</summary>
        [TestMethod]
        public void PlaceCountTest()
        {
            var target = new Room();
            const int expected = 4;
            target.PlaceCount = expected;
            var actual = target.PlaceCount;
            Assert.AreEqual(expected, actual);
        }
    }
}
