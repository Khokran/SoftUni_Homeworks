using System;
using System.Linq;
using Shopping_Spree.Models;
using System.Collections.Generic;

namespace Shopping_Spree.Core
{
    public class Engine
    {
        private List<Person> persons;
        private List<Product> products;
        public Engine()
        {
            this.persons = new List<Person>();
            this.products = new List<Product>();
        }
        public void Run()
        {
            try
            {
                ReadPersonsInput();
                ReadProductsInput();
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
                return;
            }

            string command = Console.ReadLine();
            while (command != "END")
            {
                try
                {
                    string[] commandTokens = command
                                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                            .ToArray();

                    string personName = commandTokens[0];
                    string productName = commandTokens[1];

                    Person person = this.persons.FirstOrDefault(p => p.Name == personName);
                    Product product = this.products.FirstOrDefault(p => p.Name == productName);
                    if (person != null && product != null)
                    {
                        person.BuyProduct(product);
                        Console.WriteLine($"{person.Name} bought {product.Name}");
                    }
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(Environment.NewLine, this.persons));
        }

        private void ReadProductsInput()
        {
            string[] productsInput = Console.ReadLine()
                                    .Split(";", StringSplitOptions.RemoveEmptyEntries)
                                    .ToArray();
            foreach (var pt in productsInput)
            {
                string[] productInfo = pt
                                      .Split("=")
                                      .ToArray();

                string name = productInfo[0];
                decimal cost = decimal.Parse(productInfo[1]);

                Product product = new Product(name, cost);

                this.products.Add(product);
            }
        }

        private void ReadPersonsInput()
        {
            string[] personTokens = Console.ReadLine()
                                   .Split(";", StringSplitOptions.RemoveEmptyEntries)
                                   .ToArray();
            foreach (var pt in personTokens)
            {
                string[] personInfo = pt
                                     .Split("=")
                                     .ToArray();

                string name = personInfo[0];
                decimal money = decimal.Parse(personInfo[1]);

                Person person = new Person(name, money);

                this.persons.Add(person);
            }
        }
    }
}

