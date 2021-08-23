using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace customerdatabase.model
{
    public class Order_Info
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Customer_Info")]
        public int Customer_ID { get; set; }
        public DateTime Date { get; set; }
        public String Location { get; set; }
        public int Product_ID { get; set; }
    }
}
