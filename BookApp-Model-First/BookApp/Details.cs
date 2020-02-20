using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace BookApp
{
    class Details
    {
        [Key]

        public int P_num { get; set; }
        public int Bid { get; set; }        
        public int Aid { get; set; }
            
        public virtual Book Books { get; set; }
        public virtual Author Authors { get; set; }


    }
}
