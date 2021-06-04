using RentService.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentService
{
    public class SearchMock
    {
        public static Car doSearch(string searchName)
        {
            return MockData.cars.Find(b => b.Number.Contains(searchName));
        }
    }
}
