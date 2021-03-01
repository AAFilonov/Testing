using System;
using System.Collections.Generic;
using System.Linq;

namespace Labs5
{
    public class Hotel
    {
        private List<Client> _clients = new List<Client>();
        private List<Room> _rooms = new List<Room>();
        private List<Settlement> _settlements = new List<Settlement>();
        public List<Client> Clients
        {
            get { return _clients; }
            set { _clients = value; }
        }

        public List<Room> Rooms
        {
            get { return _rooms; }
            set { _rooms = value; }
        }

        public List<Settlement> Settlements
        {
            get { return _settlements; }
            set { _settlements = value; }
        }

        public bool Settle(Client client, Room room, DateTime endDate)
        {
            var flag = false;
            if (_clients.IndexOf(client) > 0 && _rooms.IndexOf(room) >= 0)
            {
                var now = DateTime.Now;
                var clientsInRoomNow = _settlements.Count(s => s.Room == room && s.StartDate <= now && s.EndDate > now);
                if (clientsInRoomNow < room.PlaceCount)
                {
                    var settlement = new Settlement
                                                {
                                                    Client = client,
                                                    Room = room,
                                                    StartDate = now,
                                                    EndDate = endDate
                                                };
                    _settlements.Add(settlement);
                    flag = true;
                }
            }
            return flag;
        }

        public bool MoveOut(Client client)
        {
            var flag = false;
            var now = DateTime.Now;
            var settlement = _settlements.FirstOrDefault(s => s.Client == client && s.EndDate < now);
            if (settlement != null)
            {
                _settlements.Remove(settlement);
                flag = true;
            }
            return flag;
        }

        public List<Room> GetFreeRooms()
        {
            var notFreeRooms = _settlements.Select(s => s.Room).Distinct();
            List<Room> rooms = _rooms.Except(notFreeRooms).ToList();
            return rooms;
        }

        public List<Client> GetClientInRoom(Room room)
        {
            var clients = new List<Client>();
            clients.AddRange(_settlements.Where(s => s.Room == room).Select(s => s.Client).Distinct().ToList());
            return clients;
        }
    }
}
