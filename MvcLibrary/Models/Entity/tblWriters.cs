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
    
    public partial class tblWriters
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblWriters()
        {
            this.tblBooks = new HashSet<tblBooks>();
        }
    
        public int WriterId { get; set; }
        public string WriterName { get; set; }
        public string WriterSurname { get; set; }
        public string WriterDetail { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBooks> tblBooks { get; set; }
    }
}
