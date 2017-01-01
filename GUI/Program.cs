using Data.Infrastructure;
using MyFinance.Data;
using MyFinance.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    class Program
    {
        static void Main(string[] args)
        {

            //  Product p = new Product();
            //  FullPrice fp = new FullPrice();
            //  Category c = new Category();
            //  Provider pro = new Provider();
            //  Login login= new Login();

            //  login.UserName = "Firas";
            //  login.Password = "password";
            //  pro.ConfirmPassword = "password";
            //  c.NameCategory = "cat 1";
            //  fp.Price = 14;
            //  fp.Quantity = 2;

            //  p.Name = "produit 1";
            //  p.Description = "desc prod 1";
            //  p.fullprice = fp;
            //  p.DateProd = DateTime.Now;

            //  Chemical ch = new Chemical();
            //  ch.Name = "new chemical";
            //  ch.LabName = "name lab test";
            //  ch.StreetAddress = "address test";
            //  ch.fullprice = new FullPrice() { Price = 20, Quantity = 50 };
            ////  p.CategoryFK = 2;
            //  Context ctx = new Context();
            //  ctx.Category.Add(c);
            //  ctx.product.Add(p);
            //  ctx.product.Add(ch);
            //  ctx.SaveChanges();
            //  Console.WriteLine("database created");
            //  Console.ReadLine();

           
            Category c = new Category();
            c.NameCategory = "category1 with design pattern";

            Product p = new Product();
            p.Name = "produit  with design";
            p.Description = "desc prod with design pattern";
            p.fullprice = new FullPrice { Price = 3, Quantity = 2 } ;
            p.DateProd = DateTime.Now;

            DatabaseFactory dbf = new DatabaseFactory();
            UnitOfWork uw = new UnitOfWork(dbf);

            uw.getRepository<Category>().Add(c);
            uw.getRepository<Product>().Add(p);
            uw.Commit();
            uw.Dispose();





            Console.WriteLine("database created with design pattern");
            Console.ReadLine();

        }
    }
}
