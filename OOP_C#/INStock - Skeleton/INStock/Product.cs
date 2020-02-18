using System;
using System.Collections;
using INStock.Contracts;

namespace INStock
{
    public class Product : IProduct
    {
        public string Label { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public int Count => throw new NotImplementedException();

        public void Add(Product product)
        {
            throw new NotImplementedException();
        }
        public int CompareTo(IProduct other)
        {
            throw new NotImplementedException();
        }

        public object Find(int v)
        {
            throw new NotImplementedException();
        }

        public object FirstOrDefault()
        {
            throw new NotImplementedException();
        }

        public ICollection ToList()
        {
            throw new NotImplementedException();
        }
    }
}
