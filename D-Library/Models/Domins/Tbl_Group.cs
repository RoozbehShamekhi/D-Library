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
    
    public partial class Tbl_Group
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Group()
        {
            this.Tbl_BookCustomAcsses = new HashSet<Tbl_BookCustomAcsses>();
            this.Tbl_branch = new HashSet<Tbl_branch>();
        }
    
        public int Group_ID { get; set; }
        public string Group_Name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_BookCustomAcsses> Tbl_BookCustomAcsses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_branch> Tbl_branch { get; set; }
    }
}
