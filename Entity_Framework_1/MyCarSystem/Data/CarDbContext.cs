using System;
using System.Text;
using MyCarSystem.Data.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using static MyCarSystem.Data.Datavalidations;

namespace MyCarSystem.Data
{
    public class CarDbContext
    {
        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }
        public object Database { get; internal set; }
        public IEnumerable<object> Cars { get; internal set; }

        protected override void OnModel;
        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
