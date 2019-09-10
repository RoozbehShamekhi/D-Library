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
    
    public partial class Tbl_Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Book()
        {
            this.Tbl_BookTag = new HashSet<Tbl_BookTag>();
            this.Tbl_BookValidateRequest = new HashSet<Tbl_BookValidateRequest>();
            this.Tbl_Files = new HashSet<Tbl_Files>();
            this.Tbl_SpecialAcssesBook = new HashSet<Tbl_SpecialAcssesBook>();
            this.Tbl_Wishlist = new HashSet<Tbl_Wishlist>();
        }
    
        public int Book_ID { get; set; }
        public Nullable<int> Book_Code { get; set; }
        public string Book_Name { get; set; }
        public int Book_BookTypeID { get; set; }
        public Nullable<int> Book_BDID { get; set; }
        public int Book_UploaderUserID { get; set; }
        public bool Book_Publish { get; set; }
        public Nullable<int> Book_BAID { get; set; }
    
        public virtual Tbl_BookAcsses Tbl_BookAcsses { get; set; }
        public virtual Tbl_BookDetails Tbl_BookDetails { get; set; }
        public virtual Tbl_BookType Tbl_BookType { get; set; }
        public virtual Tbl_User Tbl_User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_BookTag> Tbl_BookTag { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_BookValidateRequest> Tbl_BookValidateRequest { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Files> Tbl_Files { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_SpecialAcssesBook> Tbl_SpecialAcssesBook { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Wishlist> Tbl_Wishlist { get; set; }
    }
}
