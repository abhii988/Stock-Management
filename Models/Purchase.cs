using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StockManagementSystem.Models
{
    public class Purchase
    {
        [Key]
        [Required]
        public int PurchaseID { get; set; }

        public string VendorName { get; set; }
        public int BillNo { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string Address { get; set; }
        public List<PurchaseDetail> PurchaseDetails { get; set; }

    }
}
