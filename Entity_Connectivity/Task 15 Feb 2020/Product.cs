//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Task_15_Feb_2020
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int Pid { get; set; }
        public string Title { get; set; }
        public Nullable<long> Price { get; set; }
        public Nullable<int> Cid { get; set; }
    
        public virtual Category Category { get; set; }
    }
}
