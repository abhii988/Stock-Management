using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StockManagementSystem.Models
{
    public class Stock
    {
        [Key]
        [Required]
        public int StockID { get; set; }
        public int ProductID { get; set; }
        [ForeignKey("ProductID")]
        public int Quantity { get; set; }
        
        public virtual Product product { get; set; }

    }
}
