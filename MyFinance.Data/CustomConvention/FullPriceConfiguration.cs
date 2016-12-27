using MyFinance.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Data.CustomConvention
{
    public class FullPriceConfiguration:ComplexTypeConfiguration<FullPrice>
    {

        public FullPriceConfiguration()
        {
            // set the price as required.
            Property(c => c.Price).IsRequired();

        }
    }
}
