using System.Linq;
using MyCarSystem.Data;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using System;
using MyCarSystem.Results;
using System.Collections.Generic;

namespace MyCarSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            using var db = new CarDbContext();
            db.Database.Migrate();

            var Price = 5000;



            db.Cars
                .Where(c => c.Price > price)
                .Select(c => new
                {
                    FullName = c.Model.Make.Name
                })
                .ToList();

            var opelMake = db.Models.FirstOrDefault(m => m.Name == "Opel");

            var result = db.Cars
                .FromSqlInterpolated($"SELECT * FROM Cars WHERE Price > {price}")
                .ToList();


            EF.CompileQuery<CarDbContext, IEnumerable<ResultModel>>(db =>
                db.Cars
               .Where(c => c.Price > price)
               .Select(c => new
               {
                   FullName = c.Model.Make.Name
               })
               .ToList();


            var result = query(db);

            Console.WriteLine(stopwatch.Elapsed);
        }
    }
}
