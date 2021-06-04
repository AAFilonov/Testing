using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labs5;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RentService;
using Car = RentService.Car;

namespace TestProjectLabs5
{
    class Tests1
    {

 
        public void TestModuleADriver()
        {
            var types = new Catalog().getTypes();
            var flag = Add.doAdd(new Car()
            {
                Number = "a123aa",
                Brand = "Лада",
                Cost = 1000,
                CostPerDay = 100,
                Type = "Легковая"

            });
            var car = Search.doSearch("а");

            Assert.IsNotNull(types);
            Assert.IsTrue(flag);
            Assert.IsNotNull(car);
        }

    }
}
