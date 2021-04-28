using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StockManagementSystem.Models
{
    public class Product
    {
        [Key]
        [Required]
        public int ProductID { get; set; }

        public string Name { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }
        public int CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public List<Stock> stocks { get; set; }
        public List<SalesDetail> salesDetails { get; set; }

        public virtual Category category { get; set; }
       
        


        public List<PurchaseDetail> purchaseDetails { get; set; }

    }
}
