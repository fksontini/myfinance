using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Domain
{
    public class Provider
    {
        [NotMapped]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        public Login login { get; set; }
        public DateTime DateCreated { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
        public bool IsApproved { get; set; }
        public ICollection<Product> product { get; set; }
        
      
    }
}
