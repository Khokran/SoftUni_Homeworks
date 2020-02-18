namespace INStock.Contracts
{
    using System;
    using System.Collections;

    public interface IProduct : IComparable<IProduct>
    {
        string Label { get; }

        decimal Price { get; } 

        int Quantity { get;}
        int Count { get; }

        void Add(Product product);
        object FirstOrDefault();
        ICollection ToList();
        object Find(int v);
        object FindByLabel(string v);
        double First();
        object FindAllInPriceRange(decimal v1, decimal v2);
    }
}