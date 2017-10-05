using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalXData;

namespace DigitalXDataAccess
{
    public interface IProductRepository
    {
        IQueryable<Product> Get();

        Product FindBy(System.Linq.Expressions.Expression<Func<Product, bool>> predicate);

        void UpdatePrice(int productid, decimal price);

        void Save();
    }
}
