using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Domain
{
   public class FullPrice
    {
        [DataType(DataType.Currency)]

        public double Price { get; set; }

        [Range(0, int.MaxValue)]

        public int Quantity { get; set; }
    }
}
