//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Company.Domain.Repository.GenericRepository
{
    using System;
    using System.Collections.Generic;
    
    public partial class Visit
    {
        public int VisitID { get; set; }
        public int CityID { get; set; }
        public int UserID { get; set; }
        public System.DateTime DateAdded { get; set; }
        public System.DateTime DateTimeAdded { get; set; }
    
        public virtual City City { get; set; }
        public virtual User User { get; set; }
    }
}