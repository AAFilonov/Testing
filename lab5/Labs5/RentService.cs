using System;
using System.Collections.Generic;
using System.Linq;

namespace Labs5
{
    public class RentService
    {
        private List<Client> _clients = new List<Client>();
        private List<Car> _cars = new List<Car>();
        private List<Rent> _rents = new List<Rent>();
        public List<Client> Clients
        {
            get { return _clients; }
            set { _clients = value; }
        }

        public List<Car> Cars
        {
            get { return _cars; }
            set { _cars = value; }
        }

        public List<Rent> Rents
        {
            get { return _rents; }
            set { _rents = value; }
        }

        public bool StartRentCar(Client client, Car car, DateTime dateReturn)
        {
            bool flag = false;
            if (_clients.IndexOf(client) > 0 && _cars.IndexOf(car) >= 0)
            {
                var now = DateTime.Now;
                var isCarRented = _rents.Count(s => s.Car == car && s.DateGive <= now && s.DateReturn    > now);
                var isClientRentedCarAlready = _rents.Count(s => s.Client == client && s.DateGive <= now && s.DateReturn > now);
                if(isCarRented==0 && isClientRentedCarAlready == 0)
                {
                    var rent = new Rent
                    {
                        Car = car,
                        Client = client,
                        DateGive = now,
                        DateReturn = dateReturn
                    };
                    _rents.Add(rent);
                    flag = true;
                }
           

            }
            return flag;
        }

        public bool EndRentCar(Client client)
        {
            bool flag = false;
            var now = DateTime.Now;
            var rent = _rents.FirstOrDefault(s => s.Client == client && s.DateReturn < now);
            if (rent != null)
            {
                _rents.Remove(rent);
                flag = true;
            }
            return flag;
        }


        public List<Car> GetFreeCars()
        {
            var notFreeCars= _rents.Select(s => s.Car).Distinct();
            List<Car> cars = _cars.Except(notFreeCars).ToList();
            return cars;
        }

       public bool IsCarRentedNow(Car car)
        {
            var flag = false;
            var now = DateTime.Now;
            var t = _rents.FirstOrDefault(s => s.Car == car && s.DateReturn < now);
            if (t != null) flag = true;
            return flag;
        }
       public List<Client> GetRentsForCar(Car car)
        {
            var clients = new List<Client>();
            clients.AddRange(_rents.Where(s => s.Car == car).Select(s => s.Client).Distinct().ToList());
            return clients;
        }
    }
}
