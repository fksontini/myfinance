using Data.Infrastructure;
using MyFinance.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Data
{
   public class ProductRepository: RepositoryBase<Product>
    {
       
        public ProductRepository(IDatabaseFactory databaseFactory) :base(databaseFactory)
        {

        }

       public List<Product> filterbycategory(Category cat)
        {

            //List<Product> ListProduct = this.GetAll().ToList();
            //ListProduct.Where(c => c.category == cat);
            
            //IDatabaseFactory databaseFactory = new DatabaseFactory();
            //ProductRepository p = new ProductRepository(databaseFactory);

         return   this.GetMany(c => c.category.CategoryId == cat.CategoryId).ToList();


         
        }
    }
}
