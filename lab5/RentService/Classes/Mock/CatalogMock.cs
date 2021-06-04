using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentService
{
    public class CatalogMock
    {
        public static List<String> _types = new List<String>();
        public string[] getTypes()
        {
            return _types.ToArray();
        }
        public CatalogMock()
        {
            _types.Add("Легковая");
            _types.Add("Грузовая");
            _types.Add("Мотоцикл");
        }
    }
}
