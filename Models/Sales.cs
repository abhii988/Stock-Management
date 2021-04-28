using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StockManagementSystem.Models
{
    public class Sales
    {
        [Key]
        [Required]
        public int SalesID { get; set; }
        

        public DateTime SalesDate { get; set; }
        public int BillNo { get; set; }
        public long Remarks { get; set; }
        public int CustomerID { get; set; }
        [ForeignKey("CustomerID")]
        public List<SalesDetail> SalesDetails { get; set; }
        public virtual  Customer customers{ get; set; }
    }
}
