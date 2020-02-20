using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace Code_First_Task_EntityFramework
{
    class Context:DbContext
    {
      public DbSet<Customer> Customers { get; set; }
    }
}
