using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BookApp
{
    class Book
    {
        [Key]
        public int Bid { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
    }
}
