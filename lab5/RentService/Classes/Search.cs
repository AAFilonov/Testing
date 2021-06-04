using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentService
{
    public  class Search
    {
        public static Car doSearch(string searchName)
        {
            return  Form1._entities.Car.FirstOrDefault(b => b.Number.Contains(searchName));
        }
    }
}
