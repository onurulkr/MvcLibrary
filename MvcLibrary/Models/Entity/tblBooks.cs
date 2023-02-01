//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcLibrary.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblBooks
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblBooks()
        {
            this.tblMovements = new HashSet<tblMovements>();
        }
    
        public int BookId { get; set; }
        public string BookName { get; set; }
        public Nullable<byte> Category { get; set; }
        public Nullable<int> Writer { get; set; }
        public string Year { get; set; }
        public string Publisher { get; set; }
        public string Page { get; set; }
        public Nullable<bool> Status { get; set; }
        public string BookImage { get; set; }
    
        public virtual tblCategories tblCategories { get; set; }
        public virtual tblWriters tblWriters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMovements> tblMovements { get; set; }
    }
}
