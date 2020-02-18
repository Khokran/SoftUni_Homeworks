namespace INStock.Tests
{
    using System;
    using System.Linq;
    using NUnit.Framework;
    using INStock.Contracts;
    using System.Reflection.Emit;

    [TestFixture]
    public class ProductStockTests
    {
        private IProduct productStock;
        [SetUp]
        public void CreateTestObjects()
        {
            productStock = new ProductStock();
            productStock.Add(new Product()
            {
                Label = "MyProduct",
                Quantity = 1,
                Price = 100m
            });
        }
        [Test]
        public void DuplicateLabelAfterAddingNewProduct()
        {
            int countBeforeAdd = productStock.Count;

            productStock.Add(new Product()
            {
                Label = "MyProduct"
            });
            Assert.That(productStock.Count == countBeforeAdd);
        }
        [Test]
        public void ProductQuantityIncreasedByQuantityAdded()
        {
            int quantityBefore = productStock.FirstOrDefault().Quantity;
            productStock.Add(new Product()
            {
                Label = "MyProduct",
                Quantity = 5,
                Price = 100m
            });
            Assert.That(productStock.FirstOrDefault().Quantity == 6);
        }
        [Test]
        public void PricePreservedAfterNewProductAdded()
        {
            var product = new Product();
            {
                Label = "MyProduct";
                Price = 5.9m;
            };
            Assert.That(() => productStock.Add(product), Throws.ArgumentException);
        }
        [Test]
        public void TrueIfContainsProduct()
        {
            var product = new Product()
            {
                Label = "MyProduct",
                Quantity = 5,
                Price = 100m
            };
            Assert.That(productStock.Contains(product));
        }
        [Test]
        public void FalseIfContainsProduct()
        {
            var product = new Product()
            {
                Label = "MyProduct",
                Quantity = 5,
                Price = 100m
            };
            Assert.That(!productStock.Contains(product));
        }
        [Test]
        public void FindNthProductInStock()
        {
            var product = new Product()
            {
                Label = "NewProduct",
                Quantity = 5,
                Price = 100m
            };
            productStock.Add(product);
            var findedProduct = productStock.Find(2);
            Assert.That(findedProduct.Label, Is.EqualTo(product.Label));
        }
        [Test]
        public void ErrorIfProductIndexIsNotValid()
        {
            Assert.Throws<IndexOutOfRangeException>(() => productStock.Find(8));
        }
        [Test]
        public void ProductFoundByLabel()
        {
            var product = productStock.FindByLabel("MyProduct");

            Assert.AreEqual(product, productStock.First());
        }
        [Test]
        public void ErrorIfLabelNotFound()
        {
            Assert.Throws<ArgumentException>(() => productStock.FindByLabel("ala-bala"));
        }
        [Test]
        public void EmptyListIfNotFound()
        {
            var products = (ProductStock)productStock.FindAllInPriceRange(1.0m, 2.0m);
            Assert.That(products.Count == 0);

        }
        [TearDown]
        public void RemoveObjects()
        {
            productStock = null;
        }
    }
}
