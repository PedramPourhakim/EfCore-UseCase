using System;
using System.Collections.Generic;

namespace EfCore.Domain.ProductAgg
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  List<Product> Products { get; set; }
        public DateTime CreationDate { get; set; }
        public Category(string name)
        {
            Name = name;
            Products = new List<Product>();
            CreationDate = DateTime.Now;
        }
        public void Edit(string name)
        {
            Name = name;
        }
    }
}
