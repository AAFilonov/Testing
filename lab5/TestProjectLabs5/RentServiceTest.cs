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
    public class RentServiceTest
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
            var target = new Labs5.RentService();
            Assert.IsInstanceOfType(target, typeof(Labs5.RentService));
        }

        /// <summary>
        ///Тест для GetRentsForCar
        ///</summary>
        [TestMethod]
        public void GetRentsForCarTest()
        {
            var target = new Labs5.RentService();

            var client1 = new Client { FirstName = "Имя1", LastName = "Фамилия1", SecondName = "Отчество1", Phone = "79201234567", Adress = "Адрес1" };
            var client2 = new Client { FirstName = "Имя2", LastName = "Фамилия2", SecondName = "Отчество2", Phone = "79201234568", Adress = "Адрес2" };
            target.Clients.Add(client1);
            target.Clients.Add(client2);

            var car1 = new Car { Number = "к964вз", Brand = "Тойота Камри", CostPerDay = 1000, Cost = 10000, Type = "Седан" };
            var car2 = new Car { Number = "п234ав", Brand = "Хендай Солярис", CostPerDay = 2000, Cost = 20000, Type = "Седан" };
            target.Cars.Add(car1);
            target.Cars.Add(car2);
          
            var endDate = DateTime.Now.AddDays(2);


            target.StartRentCar(client2, car1, endDate);
            var actual = target.GetclientsForCar(car1);
            Assert.AreEqual(1, actual.Count);
            Assert.AreEqual(client2, actual[0]);
        }

        /// <summary>
        ///Тест для isCarRentedNow
        ///</summary>
        [TestMethod]
        public void isCarRentedTest()
        {
            var target = new Labs5.RentService();
            var client1 = new Client { FirstName = "Имя1", LastName = "Фамилия1", SecondName = "Отчество1", Phone = "79201234567", Adress = "Адрес1" };
            var client2 = new Client { FirstName = "Имя2", LastName = "Фамилия2", SecondName = "Отчество2", Phone = "79201234568", Adress = "Адрес2" };
            target.Clients.Add(client1);
            target.Clients.Add(client2);
            var car1 = new Car { Number = "к964вз", Brand = "Тойота Камри", CostPerDay = 1000, Cost = 10000, Type = "Седан" };
            var car2 = new Car { Number = "п234ав", Brand = "Хендай Солярис", CostPerDay = 2000, Cost = 20000, Type = "Седан" };
            target.Cars.Add(car1);
            target.Cars.Add(car2);
          
            var endDate = DateTime.Now.AddDays(2);


            target.StartRentCar(client2, car1, endDate);
            var actual = target.IsCarRentedNow(car1);
            Assert.AreEqual(true, actual);
         
        }




        /// <summary>
        ///Тест для StartRentCar
        ///</summary>
        [TestMethod]
        public void StartRentCarTest()
        {
            var target = new Labs5.RentService();
            var client1 = new Client { FirstName = "Имя1", LastName = "Фамилия1", SecondName = "Отчество1", Phone = "79201234567", Adress = "Адрес1" };
            var client2 = new Client { FirstName = "Имя2", LastName = "Фамилия2", SecondName = "Отчество2", Phone = "79201234568", Adress = "Адрес2" };
            target.Clients.Add(client1);
            target.Clients.Add(client2);
            var car1 = new Car { Number = "к964вз", Brand = "Тойота Камри", CostPerDay = 1000, Cost = 10000, Type = "Седан" };
            var car2 = new Car { Number = "п234ав", Brand = "Хендай Солярис", CostPerDay = 2000, Cost = 20000, Type = "Седан" };
            target.Cars.Add(car1);
            target.Cars.Add(car2);

            var endDate = DateTime.Now.AddDays(2);
            bool actual = target.StartRentCar(client2, car1, endDate);
            Assert.AreEqual(true, actual);
        }

        /// <summary>
        ///Тест для EndRentCar
        ///</summary>
        [TestMethod]
        public void EndRentCarTest()
        {
            var target = new Labs5.RentService();
            var client1 = new Client { FirstName = "Имя1", LastName = "Фамилия1", SecondName = "Отчество1", Phone = "79201234567", Adress = "Адрес1" };
            var client2 = new Client { FirstName = "Имя2", LastName = "Фамилия2", SecondName = "Отчество2", Phone = "79201234568", Adress = "Адрес2" };
            target.Clients.Add(client1);
            target.Clients.Add(client2);
            var car1 = new Car { Number = "к964вз", Brand = "Тойота Камри", CostPerDay = 1000, Cost = 10000, Type = "Седан" };
            var car2 = new Car { Number = "п234ав", Brand = "Хендай Солярис", CostPerDay = 2000, Cost = 20000, Type = "Седан" };
            target.Cars.Add(car1);
            target.Cars.Add(car2);

            var endDate = DateTime.Now.AddDays(2);
            target.StartRentCar(client2, car1, endDate);
            bool actual = target.EndRentCar(client2);
            Assert.AreEqual(true, actual);
        }


        /// <summary>
        ///Тест для Clients
        ///</summary>
        [TestMethod]
        public void ClientsTest()
        {
            var target = new Labs5.RentService();
            var client1 = new Client { FirstName = "Имя1", LastName = "Фамилия1", SecondName = "Отчество1", Phone = "79201234567", Adress = "Адрес1" };
            var client2 = new Client { FirstName = "Имя2", LastName = "Фамилия2", SecondName = "Отчество2", Phone = "79201234568", Adress = "Адрес2" };
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
            var target = new Labs5.RentService();
            var car1 = new Car { Number = "к964вз", Brand = "Тойота Камри", CostPerDay = 1000, Cost = 10000, Type = "Седан" };
            var car2 = new Car { Number = "п234ав", Brand = "Хендай Солярис", CostPerDay = 2000, Cost = 20000, Type = "Седан" };
            target.Cars.Clear();
            target.Cars.Add(car1);
            target.Cars.Add(car2);        
            Assert.AreEqual(2, target.Cars.Count);
        }

        /// <summary>
        ///Тест для Settlements
        ///</summary>
        [TestMethod]
        public void SettlementsTest()
        {
            var target = new Labs5.RentService();
            var client1 = new Client { FirstName = "Имя1", LastName = "Фамилия1", SecondName = "Отчество1", Phone = "79201234567", Adress = "Адрес1" };
            var client2 = new Client { FirstName = "Имя2", LastName = "Фамилия2", SecondName = "Отчество2", Phone = "79201234568", Adress = "Адрес2" };
            target.Clients.Add(client1);
            target.Clients.Add(client2);
            var car1 = new Car { Number = "к964вз", Brand = "Тойота Камри", CostPerDay = 1000, Cost = 10000, Type = "Седан" };
            var car2 = new Car { Number = "п234ав", Brand = "Хендай Солярис", CostPerDay = 2000, Cost = 20000, Type = "Седан" };
            target.Cars.Add(car1);
            target.Cars.Add(car2);

           
            target.Rents.Clear();
            target.Rents.Add(new Rent { Client = client2, Car = car1, DateGive = DateTime.Now, DateReturn = DateTime.Now.AddDays(1) });
            Assert.AreEqual(1, target.Rents.Count);
        }
       
    }
}
