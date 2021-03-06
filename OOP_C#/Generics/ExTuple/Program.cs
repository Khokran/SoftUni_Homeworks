﻿using System;
using System.Linq;

namespace ExTuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] personInfo = Console.ReadLine().Split();
            string[] personBeerInfo = Console.ReadLine().Split();
            string[] numbersInfo = Console.ReadLine().Split();

            string personName = personInfo[0] + " " + personInfo[1];
            string personTown = personInfo[2];

            string personBeerName = personBeerInfo[0];
            int amauntOfBeer = int.Parse(personBeerInfo[1]);

            int myInteger = int.Parse(numbersInfo[0]);
            double myDouble = double.Parse(numbersInfo[1]);

            var personTuple = new Tuple<string, string>(personName, personTown);
            var personBeerTuple = new Tuple<string, int>(personBeerName, amauntOfBeer);
            var numbersTuple = new Tuple<int, double>(myInteger, myDouble);

            Console.WriteLine(personTuple.GetInfo());
            Console.WriteLine(personBeerTuple.GetInfo());
            Console.WriteLine(numbersTuple.GetInfo());
        }
    }
}
