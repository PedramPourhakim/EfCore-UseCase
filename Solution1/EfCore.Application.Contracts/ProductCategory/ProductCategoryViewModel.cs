using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.Application.Contracts.ProductCategory
{
    class ProductCategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CreationDate { get; set; }
    }
}
