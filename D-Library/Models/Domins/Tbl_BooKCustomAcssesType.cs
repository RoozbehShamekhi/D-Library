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
    
    public partial class Tbl_BooKCustomAcssesType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_BooKCustomAcssesType()
        {
            this.Tbl_BookCustomAcsses = new HashSet<Tbl_BookCustomAcsses>();
        }
    
        public int BCAT_ID { get; set; }
        public string BCAT_Name { get; set; }
        public string BCAT_Display { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_BookCustomAcsses> Tbl_BookCustomAcsses { get; set; }
    }
}
