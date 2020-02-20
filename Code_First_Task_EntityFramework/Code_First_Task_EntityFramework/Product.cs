using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Code_First_Task_EntityFramework
{
    class Product
    {
        [Key]
        public int Product_id { get; set; }
        public string Product_name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; } 
    }
}
