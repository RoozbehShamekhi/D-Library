//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace D_Library.Models.Domins
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_branch
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_branch()
        {
            this.Tbl_User = new HashSet<Tbl_User>();
        }
    
        public int branch_ID { get; set; }
        public string branch_Name { get; set; }
        public int branch_GroupID { get; set; }
    
        public virtual Tbl_Group Tbl_Group { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_User> Tbl_User { get; set; }
    }
}
