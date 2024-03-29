﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace D_Library.Models.Domins
{
    internal class MetaData_BookDetails
    {
        public int BD_ID { get; set; }
     //   [Display(Name = "نسخه دیجتال دارد")]
        [Display(Name = " ")]
        public bool BD_DigitalVersionAvailable { get; set; }
       // [Display(Name = "نسخه فیزیکی دارد")]
        [Display(Name = " ")]
        public bool BD_PhysicalVersionAvailable { get; set; }
        [Display(Name = "کتاب خانه")]
        public Nullable<int> BD_LibraryID { get; set; }
        public Nullable<bool> BD_FileEnabel { get; set; }
        public Nullable<int> BD_FileCount { get; set; }
        [Display(Name = "تعداد صفحه ها")]
        [DataType(DataType.Text)]
        public Nullable<int> BD_PageCount { get; set; }
        [Display(Name = "عنوان")]
        //[Required(ErrorMessage = "لطفا مقدار را وارد نمایید")]
        [StringLength(100, ErrorMessage = "مقدار وارد شده بیش 100 کارکتراست")]
        public string BD_Titel { get; set; }
        [Display(Name = "نویسنده")]
        //[Required(ErrorMessage = "لطفا مقدار را وارد نمایید")]
        [StringLength(100, ErrorMessage = "مقدار وارد شده بیش 100 کارکتراست")]
        public string BD_WriterName { get; set; }
        [Display(Name = "زبان")]
        public string BD_LanguageID { get; set; }
        [Display(Name = "توضیحات")]
        [AllowHtml]
        //[Required(ErrorMessage = "لطفا مقدار را وارد نمایید")]
        [DataType(DataType.MultilineText)]
        public string BD_Description { get; set; }
        [Display(Name = "چکیده")]
        [AllowHtml]
        //[Required(ErrorMessage = "لطفا مقدار را وارد نمایید")]
        [DataType(DataType.MultilineText)]
        public string BD_Abstract { get; set; }
        [Display(Name = "تاریخ انتشار")]
        [DataType(DataType.Time)]
        public Nullable<System.DateTime> BD_ReleaseDate { get; set; }
        [Display(Name = "نوبت چاپ")]
        //[Required(ErrorMessage = "لطفا مقدار را وارد نمایید")]
        [StringLength(100, ErrorMessage = "مقدار وارد شده بیش 100 کارکتراست")]
        public Nullable<int> BD_ReleaseCount { get; set; }
        [Display(Name = "دانشجو")]
        public Nullable<int> BD_StudentID { get; set; }
        [Display(Name = "استاد")]
        public Nullable<int> BD_MasterID { get; set; }
        [Display(Name = "انتشارات")]
        //[Required(ErrorMessage = "لطفا مقدار را وارد نمایید")]
        [StringLength(100, ErrorMessage = "مقدار وارد شده بیش 100 کارکتراست")]
        public string BD_Publishers { get; set; }
        [Display(Name = "شابک")]
        //[Required(ErrorMessage = "لطفا مقدار را وارد نمایید")]
        [StringLength(100, ErrorMessage = "مقدار وارد شده بیش 100 کارکتراست")]
        public string BD_ISBN { get; set; }
        [Display(Name = "موضوع")]
        //[Required(ErrorMessage = "لطفا مقدار را وارد نمایید")]
        [StringLength(100, ErrorMessage = "مقدار وارد شده بیش 100 کارکتراست")]
        public string BD_Subject { get; set; }
        [Display(Name = "گروه")]
        public Nullable<int> BD_GroupID { get; set; }
        [Display(Name = "رشته")]
        public Nullable<int> BD_BranchID { get; set; }
        [Display(Name = "مترجم")]
        //[Required(ErrorMessage = "لطفا مقدار را وارد نمایید")]
        [StringLength(100, ErrorMessage = "مقدار وارد شده بیش 100 کارکتراست")]
        public string BD_Translator { get; set; }
        [Display(Name = "رده‌بندی کنگره")]
        //[Required(ErrorMessage = "لطفا مقدار را وارد نمایید")]
        [StringLength(100, ErrorMessage = "مقدار وارد شده بیش 100 کارکتراست")]
        public string BD_LCC { get; set; }
        [Display(Name = "سال نشر")]
        //[Required(ErrorMessage = "لطفا مقدار را وارد نمایید")]
        [StringLength(100, ErrorMessage = "مقدار وارد شده بیش 100 کارکتراست")]
        public Nullable<int> BD_ReleaseYear { get; set; }
    }

    [MetadataType(typeof(MetaData_BookDetails))]
    public partial class Tbl_BookDetails
    {

    }
}