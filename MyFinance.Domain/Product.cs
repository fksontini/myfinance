using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Domain
{
    public class Product
    {
        [Display(Name = "Production Date")]
        [DataType(DataType.Date)]
        public DateTime DateProd { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Required]
        [StringLength(25, ErrorMessage = "Chaine ne doit pas dépassé 25 caractére")]
        [MaxLength(50)]
        public string Name { get; set; }
        public FullPrice fullprice { get; set; }
        public int ProductId { get; set; }

        [ForeignKey("CategoryFK")]
        public Category category { get; set; }
        public int? CategoryFK { get; set; }
        public ICollection<Provider> provider { get; set; }

    }
}
