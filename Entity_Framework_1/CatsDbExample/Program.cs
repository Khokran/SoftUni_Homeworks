using System;
using System.Linq;

namespace CatsDbExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new CatsDbContext())
            {
                db.Cats.Add(new Cat
                    Name = "Vanio",
                    Age = 5,
                    Color = "Black",
                    Owner = "Bai Ivan"                    
                    );
            }
        }
    }
}
