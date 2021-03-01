using Labs5;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProjectLabs5
{
    /// <summary>
    ///Это класс теста для HotelTest, в котором должны
    ///находиться все модульные тесты HotelTest
    ///</summary>
    [TestClass]
    public class HotelTest
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
        ///Тест для Конструктор Hotel
        ///</summary>
        [TestMethod]
        public void HotelConstructorTest()
        {
            var target = new Hotel();
            Assert.IsInstanceOfType(target, typeof(Hotel));
        }

        /// <summary>
        ///Тест для GetClientInRoom
        ///</summary>
        [TestMethod]
        public void GetClientInRoomTest()
        {
            var target = new Hotel();
            var client1 = new Client { FirstName = "Имя1", LastName = "Фамилия1", SecondName = "Отчество1", Passport = "Паспортные данные1" };
            var client2 = new Client { FirstName = "Имя2", LastName = "Фамилия2", SecondName = "Отчество2", Passport = "Паспортные данные2" };
            target.Clients.Add(client1);
            target.Clients.Add(client2);
            var room1 = new Room { Category = "Эконом", CostPerDay = 1000, Name = "101", PlaceCount = 4 };
            var room2 = new Room { Category = "Бизнес", CostPerDay = 2500, Name = "106", PlaceCount = 2 };
            target.Rooms.Add(room1);
            target.Rooms.Add(room2);
            var endDate = DateTime.Now.AddDays(2);
            target.Settle(client2, room1, endDate);
            var actual = target.GetClientInRoom(room1);
            Assert.AreEqual(1, actual.Count);
            Assert.AreEqual(client2, actual[0]);
        }

        /// <summary>
        ///Тест для GetFreeRooms
        ///</summary>
        [TestMethod]
        public void GetFreeRoomsTest()
        {
            var target = new Hotel();
            var client1 = new Client { FirstName = "Имя1", LastName = "Фамилия1", SecondName = "Отчество1", Passport = "Паспортные данные1" };
            var client2 = new Client { FirstName = "Имя2", LastName = "Фамилия2", SecondName = "Отчество2", Passport = "Паспортные данные2" };
            target.Clients.Add(client1);
            target.Clients.Add(client2);
            var room1 = new Room { Category = "Эконом", CostPerDay = 1000, Name = "101", PlaceCount = 4 };
            var room2 = new Room { Category = "Бизнес", CostPerDay = 2500, Name = "106", PlaceCount = 2 };
            target.Rooms.Add(room1);
            target.Rooms.Add(room2);
            var endDate = DateTime.Now.AddDays(2);
            target.Settle(client2, room1, endDate);
            var actual = target.GetFreeRooms();
            Assert.AreEqual(1, actual.Count);
        }

        /// <summary>
        ///Тест для MoveOut
        ///</summary>
        [TestMethod]
        public void MoveOutTest()
        {
            var target = new Hotel();
            var client1 = new Client { FirstName = "Имя1", LastName = "Фамилия1", SecondName = "Отчество1", Passport = "Паспортные данные1" };
            var client2 = new Client { FirstName = "Имя2", LastName = "Фамилия2", SecondName = "Отчество2", Passport = "Паспортные данные2" };
            target.Clients.Add(client1);
            target.Clients.Add(client2);
            var room1 = new Room { Category = "Эконом", CostPerDay = 1000, Name = "101", PlaceCount = 4 };
            var room2 = new Room { Category = "Бизнес", CostPerDay = 2500, Name = "106", PlaceCount = 2 };
            target.Rooms.Add(room1);
            target.Rooms.Add(room2);
            var endDate = DateTime.Now.AddDays(2);
            target.Settle(client2, room1, endDate);
            Assert.AreEqual(1, target.Settlements.Count);
            target.Settlements[0].EndDate = DateTime.Now.AddMinutes(-1);
            target.MoveOut(client2);
            Assert.AreEqual(0, target.Settlements.Count);
        }

        /// <summary>
        ///Тест для Settle
        ///</summary>
        [TestMethod]
        public void SettleTest()
        {
            var target = new Hotel();
            var client1 = new Client { FirstName = "Имя1", LastName = "Фамилия1", SecondName = "Отчество1", Passport = "Паспортные данные1" };
            var client2 = new Client { FirstName = "Имя2", LastName = "Фамилия2", SecondName = "Отчество2", Passport = "Паспортные данные2" };
            target.Clients.Add(client1);
            target.Clients.Add(client2);
            var room1 = new Room { Category = "Эконом", CostPerDay = 1000, Name = "101", PlaceCount = 4 };
            var room2 = new Room { Category = "Бизнес", CostPerDay = 2500, Name = "106", PlaceCount = 2 };
            target.Rooms.Add(room1);
            target.Rooms.Add(room2);
            var endDate = DateTime.Now.AddDays(2);
            bool actual = target.Settle(client2, room1, endDate);
            Assert.AreEqual(true, actual);
        }

        /// <summary>
        ///Тест для Clients
        ///</summary>
        [TestMethod]
        public void ClientsTest()
        {
            var target = new Hotel();
            var client1 = new Client { FirstName = "Имя1", LastName = "Фамилия1", SecondName = "Отчество1", Passport = "Паспортные данные1" };
            var client2 = new Client { FirstName = "Имя2", LastName = "Фамилия2", SecondName = "Отчество2", Passport = "Паспортные данные2" };
            target.Clients.Clear();
            target.Clients.Add(client1);
            target.Clients.Add(client2);
            Assert.AreEqual(2, target.Clients.Count);
        }

        /// <summary>
        ///Тест для Rooms
        ///</summary>
        [TestMethod]
        public void RoomsTest()
        {
            var target = new Hotel();
            var room1 = new Room { Category = "Эконом", CostPerDay = 1000, Name = "101", PlaceCount = 4 };
            var room2 = new Room { Category = "Бизнес", CostPerDay = 2500, Name = "106", PlaceCount = 2 };
            target.Rooms.Clear();
            target.Rooms.Add(room1);
            target.Rooms.Add(room2);
            Assert.AreEqual(2, target.Rooms.Count);
        }

        /// <summary>
        ///Тест для Settlements
        ///</summary>
        [TestMethod]
        public void SettlementsTest()
        {
            var target = new Hotel();
            var client1 = new Client { FirstName = "Имя1", LastName = "Фамилия1", SecondName = "Отчество1", Passport = "Паспортные данные1" };
            var client2 = new Client { FirstName = "Имя2", LastName = "Фамилия2", SecondName = "Отчество2", Passport = "Паспортные данные2" };
            target.Clients.Add(client1);
            target.Clients.Add(client2);
            var room1 = new Room { Category = "Эконом", CostPerDay = 1000, Name = "101", PlaceCount = 4 };
            var room2 = new Room { Category = "Бизнес", CostPerDay = 2500, Name = "106", PlaceCount = 2 };
            target.Rooms.Add(room1);
            target.Rooms.Add(room2);
            target.Settlements.Clear();
            target.Settlements.Add(new Settlement { Client = client2, Room = room1, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(1) });
            Assert.AreEqual(1, target.Settlements.Count);
        }
    }
}
