using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.Application.Contracts.ProductCategory
{
    class EditProductCategory : CreateProductCategory
    {
        public int Id { get; set; }
    }
}
