using System;

namespace Labs5
{
    public class Rent
    {
        public Client Client { get; set; }
        public Car Car { get; set; }
        public DateTime DateGive { get; set; }
        public DateTime DateReturn { get; set; }
    }
}
