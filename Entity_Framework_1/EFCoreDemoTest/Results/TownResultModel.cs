using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreDemoTest.Results
{
    public class TownResultModel
    { 
        public string Name { get; set; }
        public IEnumerable<string> Addresses { get; set; }
    }
}
