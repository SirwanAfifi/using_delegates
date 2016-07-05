using System.Collections.Generic;

namespace UsingDelegates.Models
{
    public class Product
    {
        public string Title { get; set; }
        public float Price { get; set; }
    }

    public class Products : List<Product>
    {
        public Products()
        {
            this.Add(new Product { Title = "Titl1", Price = 50000 });
            this.Add(new Product { Title = "Titl2", Price = 55000 });
            this.Add(new Product { Title = "Titl3", Price = 88000 });
            this.Add(new Product { Title = "Titl4", Price = 23000 });
            this.Add(new Product { Title = "Titl5", Price = 150000 });
        }
    }
}