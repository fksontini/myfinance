using MyFinance.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Data.Configuration
{
    public class ProductConfiguration:EntityTypeConfiguration<Product>
    {
        // changement in the descriminitor type 
        // 0 for the Chemical
        // 1 for the biological
        public ProductConfiguration()
        {
            // change the type in descriminateur.
            Map<Chemical>(c => c.Requires("custom").HasValue(0));
            Map<Biological>(c => c.Requires("custom").HasValue(1));
            Map<Product>(c => c.Requires("custom").HasValue(2));
            //HasKey(c => c.ProductId);
            //Property(c => c.Name).HasMaxLength(50);

            // to set the connection 0..1 between category and Product.
            HasOptional(c => c.category)
                .WithMany(c => c.product)
                .HasForeignKey(c => c.CategoryFK);
            // to set the connection *..* between production
            HasMany(c => c.provider)
                .WithMany(c => c.product)
                .Map(
                c =>
                {
                    c.ToTable("tableAssocia");
                    // product car with many
                    c.MapRightKey("pr");
                    // provider car has many
                    c.MapLeftKey("po");


                });

        }

    }
}
