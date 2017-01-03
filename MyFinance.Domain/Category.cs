using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Domain
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string NameCategory { get; set; }
        public ICollection<Product> product { get; set; }

        public static implicit operator Category(int v)
        {
            throw new NotImplementedException();
        }
    }
}
