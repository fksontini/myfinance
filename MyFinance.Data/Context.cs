using MyFinance.Data.Configuration;
using MyFinance.Data.CustomConvention;
using MyFinance.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Data
{
    public class Context:DbContext
    {
        public Context():base("Name=MyFinancecnx")
        {
               
        }
        public DbSet<Category> Category{ get; set; }
        public DbSet<Product> product{ get; set; }
        public DbSet<Provider> provider{ get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Add(new DateTime2Convention());
            modelBuilder.Configurations.Add(new ProductConfiguration());
        }

    }
    //public class MyFinanceContextInitialiser : DropCreateDatabaseIfModelChanges<Context>
    //{
    //    protected override void Seed(Context context)
    //    {
    //        Product p = new Product();
    //        p.Name = "def prod";
    //        p.Description = "def desc";
    //        p.fullprice = new FullPrice { Price = 15, Quantity = 17 };
    //        p.DateProd = DateTime.Now;
    //        context.product.Add(p);
    //        context.SaveChanges();

    //    }

    //}


}
