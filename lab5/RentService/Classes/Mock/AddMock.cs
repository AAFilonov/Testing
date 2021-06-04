using RentService.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentService
{
    public class AddMock
    {
        public static void doAdd(Car car)
        {
            MockData.cars.Add(car);
        }
    }
}
