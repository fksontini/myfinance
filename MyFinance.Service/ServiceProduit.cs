using Data.Infrastructure;
using MyFinance.Domain;
using MyFinance.ServicePattern;

namespace MyFinance.Service
{
    public class ServiceProduit:Service<Product>
    {
        static DatabaseFactory dbf = new DatabaseFactory();
        static UnitOfWork ufwk = new UnitOfWork(dbf);

        public ServiceProduit():base(ufwk)
        {


        }

    }
}
