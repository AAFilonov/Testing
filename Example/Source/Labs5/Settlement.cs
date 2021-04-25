using System;

namespace Labs5
{
    public class Settlement
    {
        public Client Client { get; set; }
        public Room Room { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
