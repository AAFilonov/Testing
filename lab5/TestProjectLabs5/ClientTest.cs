using Labs5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProjectLabs5
{
    /// <summary>
    ///Это класс теста для ClientTest, в котором должны
    ///находиться все модульные тесты ClientTest
    ///</summary>
    [TestClass]
    public class ClientTest
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
        ///Тест для Конструктор Client
        ///</summary>
        [TestMethod]
        public void ClientConstructorTest()
        {
            var target = new Client();
            Assert.IsInstanceOfType(target, typeof(Client));
        }

        /// <summary>
        ///Тест для FirstName
        ///</summary>
        [TestMethod]
        public void FirstNameTest()
        {
            var target = new Client();
            const string expected = "Сергей";
            target.FirstName = expected;
            string actual = target.FirstName;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Тест для LastName
        ///</summary>
        [TestMethod]
        public void LastNameTest()
        {
            var target = new Client();
            const string expected = "Иванов";
            target.LastName = expected;
            string actual = target.LastName;
            Assert.AreEqual(expected, actual);
        }

      

        /// <summary>
        ///Тест для SecondName
        ///</summary>
        [TestMethod]
        public void SecondNameTest()
        {
            var target = new Client(); 
            const string expected = "Петрович";
            target.SecondName = expected;
            string actual = target.SecondName;
            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        ///Тест для Adress
        ///</summary>
        [TestMethod]
        public void PassportTest()
        {
            var target = new Client();
            const string expected = "ул. Ленина 3";
            target.Adress = expected;
            string actual = target.Adress;
            Assert.AreEqual(expected, actual);
        }



        /// <summary>
        ///Тест для Phone
        ///</summary>
        [TestMethod]
        public void PhoneTest()
        {
            var target = new Client();
            const string expected = "79207658798";
            target.Phone = expected;
            string actual = target.Phone;
            Assert.AreEqual(expected, actual);
        }

    }
}
