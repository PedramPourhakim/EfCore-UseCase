using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.Domain.ProductAgg
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public bool IsRemoved { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public DateTime CreationDate { get; set; }
        public Product(string name,double unitprice,int categoryid)
        {
            Name = name;
            UnitPrice = unitprice;
            CategoryId = categoryid;
            CreationDate = DateTime.Now;
        }
        public void edit(string name,double unitprice,int categoryid)
        {
            Name = name;
            UnitPrice = unitprice;
            CategoryId = categoryid;
        }
        public void Remove()
        {
            IsRemoved = true;
        }
        public void Restore()
        {
            IsRemoved = false;
        }
    }
}
