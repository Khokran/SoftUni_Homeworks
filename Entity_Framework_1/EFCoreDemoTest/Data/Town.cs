using System;
using System.Text;
using System.Collections.Generic;

namespace EFCoreDemoTest.Data
{
    public class Town
    {
        public int TownId { get; set; }
        public string Name { get; set; }
        public byte[] TownImage { get; set; } 

        public virtual ICollection<Addresses> Addresses { get; set; }
    }
}
