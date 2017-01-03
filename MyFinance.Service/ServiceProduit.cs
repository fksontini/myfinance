using Data.Infrastructure;
using MyFinance.Domain;
using MyFinance.ServicePattern;
using System.Collections.Generic;
using System.Linq;

namespace MyFinance.Service
{
    public class ServiceProduit:Service<Product>
    {
        static DatabaseFactory dbf = new DatabaseFactory();
        static UnitOfWork ufwk = new UnitOfWork(dbf);

        public ServiceProduit():base(ufwk)
        {


        }

        public List<Product> ProductByCategoryId(int categoryId)
        {
            var x = ufwk.getRepository<Product>().GetMany(c => c.category.CategoryId == categoryId).ToList();
            return x;
        }

    }
}
