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
    
    public partial class Tbl_Permission
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Permission()
        {
            this.Tbl_BaseRolesPermission = new HashSet<Tbl_BaseRolesPermission>();
            this.Tbl_UsersPermission = new HashSet<Tbl_UsersPermission>();
        }
    
        public int Permission_ID { get; set; }
        public string Permission_Name { get; set; }
        public string Permission_Titel { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_BaseRolesPermission> Tbl_BaseRolesPermission { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_UsersPermission> Tbl_UsersPermission { get; set; }
    }
}
