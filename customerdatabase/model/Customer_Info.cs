using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace customerdatabase.model
{
    public class Customer_Info
    {
        [Key]
        public int Customer_ID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Mail { get; set; }
        public String Password { get; set; }
        public String PhoneNumber { get; set; }
        public String Gender { get; set; }
    }
}


