using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EF_Task_Code
{
    class Purchase
    {
        [Key]
        public int id { get; set; }
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        public int Cust_id { get; set; }
        public int Product_id { get; set; }


        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}
