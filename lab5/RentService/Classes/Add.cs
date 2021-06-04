using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentService
{
    public class Add
    {

        public static bool doAdd(Car car)
        {
            Form1._entities.Car.Add(car);
            Form1._entities.SaveChanges();
            return true;
        }
    }
}
