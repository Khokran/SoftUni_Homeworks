using Microsoft.EntityFrameworkCore;
using MyCarSystem.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCarSystem.Data.Queries
{
    public class CarQueries
    {
        public static Func<CarDbContext, IEnumerable<ResultModel>> ToResult
            = EF.CompileQuery<CarDbContext, IEnumerable<ResultModel>>(db =>
                db.Cars
               .Where(c => c.Price > price)
               .Select(c => new
               {
                   FullName = c.Model.Make.Name
               })
               .ToList(); 

    }
}
