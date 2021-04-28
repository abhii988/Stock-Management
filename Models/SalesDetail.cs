using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StockManagementSystem.Models
{
    public class SalesDetail
    {
        [Key]
        [Required]
        public int SalesDetailID { get; set; }
        public int SalesID { get; set; }
        [ForeignKey("SalesID")]
        public int ProductID { get; set; }
        [ForeignKey("ProcudtID")]
        public int Quantity { get; set; }
        public int Amount { get; set; }
        public virtual Product product { get; set; }
        public virtual Sales sales { get; set; }

    }
}
