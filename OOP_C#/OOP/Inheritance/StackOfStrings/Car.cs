using System;
using System.Collections.Generic;
using System.Text;

namespace StackOfStrings
{
    public class Car
    {
        public string Maker { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public Engine Engine { get; set; }
        public List<Door> Doors { get; set; }
        public Reservior Reservior { get; set; }
    }
}
