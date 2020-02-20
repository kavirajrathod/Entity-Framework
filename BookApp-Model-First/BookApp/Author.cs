using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace BookApp
{
    class Author
    {
        [Key]
        public int Aid { get; set; }
        public string Author_name { get; set; }
        public string Author_Address { get; set; }
    }
}
