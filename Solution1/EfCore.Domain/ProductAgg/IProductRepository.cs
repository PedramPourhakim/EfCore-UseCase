using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.Domain.ProductAgg
{
    public interface IProductRepository
    {
        void Create(Product product);
        Product Get(int Id);
    }
}
