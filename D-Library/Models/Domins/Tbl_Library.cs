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
    
    public partial class Tbl_Library
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Library()
        {
            this.Tbl_BookDetails = new HashSet<Tbl_BookDetails>();
        }
    
        public int Library_ID { get; set; }
        public string Library_Name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_BookDetails> Tbl_BookDetails { get; set; }
    }
}
