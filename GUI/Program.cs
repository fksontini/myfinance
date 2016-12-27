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

            Product p = new Product();
            FullPrice fp = new FullPrice();
            Category c = new Category();
            Provider pro = new Provider();
            Login login= new Login();

            login.UserName = "Firas";
            login.Password = "password";
            pro.ConfirmPassword = "password";
            c.NameCategory = "cat 1";
            fp.Price = 14;
            fp.Quantity = 2;

            p.Name = "produit 1";
            p.Description = "desc prod 1";
            p.fullprice = fp;
            p.DateProd = DateTime.Now;

            Chemical ch = new Chemical();
            ch.Name = "new chemical";
            ch.LabName = "name lab test";
            ch.StreetAddress = "address test";
            ch.fullprice = new FullPrice() { Price = 20, Quantity = 50 };
          //  p.CategoryFK = 2;
            Context ctx = new Context();
            ctx.Category.Add(c);
            ctx.product.Add(p);
            ctx.product.Add(ch);
            ctx.SaveChanges();
            Console.WriteLine("database created");
            Console.ReadLine();

        }
    }
}
