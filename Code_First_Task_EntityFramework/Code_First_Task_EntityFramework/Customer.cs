using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Code_First_Task_EntityFramework
{
    class Customer
    {   
        [Key]
        public int Cust_id { get; set; }
        public string Cust_name { get; set; }
        public string City { get; set; }
        public List<Product> Product_List { get; set; }

    }
}
