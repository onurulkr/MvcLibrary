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
    
    public partial class tblPunishments
    {
        public int PunishmentId { get; set; }
        public Nullable<int> Member { get; set; }
        public Nullable<System.DateTime> Start { get; set; }
        public Nullable<System.DateTime> Finish { get; set; }
        public Nullable<decimal> Money { get; set; }
        public Nullable<int> Movement { get; set; }
    
        public virtual tblMembers tblMembers { get; set; }
        public virtual tblMovements tblMovements { get; set; }
    }
}
