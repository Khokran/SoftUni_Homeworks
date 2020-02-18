using System;
using System.Xml.Linq;
using System.Collections.Generic;

namespace XmlDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new List<Book>
            {
                new Book("The Little Prince", "Exupéry", 1943),
                new Book("The Master and Margarita", "Bulgakov", 1967),
            };

            XDocument document = XDocument.Load(@"Data\cars.xml");
            XElement root = document.Root;
            var cars = root.Elements();
            root.RemoveAll();

            foreach (var car in cars)
            {
                var carObject = new Car
                {
                    Make = car.Element("make").Value,
                    Model = car.Element("model").Value,
                    TraveledDistance = long.Parse(car.Element("travelled-distance").Value)
                };
                // Console.WriteLine($"{car.Element("make").Value} {car.Element("model").Value}");
                car.Remove();

            }
            document.Save("Data/cars_modified.xml");
        }
    }

    class Book
    {
        private string title;
        private string autor;
        private string year;

        public Book(string title, string autor, int year)
        {
            this.Title = title;
            this.Autor = autor;
            this.Year = year;
        }

        public string Title { get; set; }
        public string Autor { get; set; }
        public int Year { get; set; }

    }
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public long TraveledDistance { get;  set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
