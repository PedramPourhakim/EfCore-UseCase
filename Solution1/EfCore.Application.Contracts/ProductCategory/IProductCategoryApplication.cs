using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.Application.Contracts.ProductCategory
{
    interface IProductCategoryApplication
    {
        void Create(CreateProductCategory command);
        void Edit(EditProductCategory command);
        List<ProductCategoryViewModel> Search(string name);
    }
}
