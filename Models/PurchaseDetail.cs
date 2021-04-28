using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StockManagementSystem.Models
{
    public class PurchaseDetail
    {
        [Key]
        [Required]
        public int PurchaseDetailID { get; set; }

        public int PurchaseID { get; set; }
        [ForeignKey("PurchaseID")]

        public Int64 ProductID { get; set; }
        [ForeignKey("ProductID")]

        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public virtual Purchase purchase { get; set; }
        public virtual Product product { get; set; }
    }
}
