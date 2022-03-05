using EfCore.Domain.ProductAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.Domain.ProductCateoryAgg
{
    public interface IProductCategoryRepository
    {
        void Create(Category productCategory);
        Category Get(int Id);
    }
}
