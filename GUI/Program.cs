using Data.Infrastructure;
using MyFinance.Data;
using MyFinance.Domain;
using MyFinance.Service;
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
            //Product p = new Product();
            //p.Name = "produit  1";
            //p.Description = "desc prod wi";
            //p.fullprice = new FullPrice { Price = 2, Quantity = 2 };
            //p.DateProd = DateTime.Now;
            //p.CategoryFK = 10;
            //Product p2 = new Product();
            //p.Name = "produit  2";
            //p.Description = "desc prod wi";
            //p.fullprice = new FullPrice { Price = 3, Quantity = 2 };
            //p.DateProd = DateTime.Now;
            //p.CategoryFK = 10;
            //List<Product> resultat = new List<Product>();
            //DatabaseFactory dbf = new DatabaseFactory();
            //ProductRepository PR = new ProductRepository(dbf);
            //UnitOfWork uw = new UnitOfWork(dbf);
            //PR.Add(p);
            //uw.Commit();
            ////PR.Add(p2);
            //// uw.Commit();
            //// uw.getRepository<Category>().Add(c);
            //// uw.getRepository<Product>().Add(p);
            //var resultat1 = PR.filterbycategory(c);
            //Console.WriteLine("show the table");
            //foreach (Product px in resultat1)
            //{
            //    Console.WriteLine(px.Name);
            //}
            //Console.WriteLine("database created with design pattern");
            //Console.ReadLine();
            //uw.Dispose();

            // create a category to set the product categorie.
            Category c = new Category();
            //category ID
            c.CategoryId = 10;
            Product pu = new Product();
            pu.Name = "Unit of work ";
            pu.DateProd = DateTime.Now;
            pu.fullprice = new FullPrice { Price = 1, Quantity = 2 };
            pu.category = c;
            pu.Description = " test of UW";
            ServiceProduit sp = new ServiceProduit();
            sp.Add(pu);
            sp.Commit();
var Products= sp.ProductByCategoryId(10);
            foreach(var Px in Products)
            {
                Console.WriteLine(Px.Name );


            }
            Console.ReadKey();

            sp.Dispose();
        }
    }
}
