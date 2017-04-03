//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookMyTicket.DomainModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Movie
    {
        public Movie()
        {
            this.Shows = new HashSet<Show>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string MetaData { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public bool Active { get; set; }
        public bool Deleted { get; set; }
    
        public virtual ICollection<Show> Shows { get; set; }
    }
}
