﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using D_Library.Models.Domins;

namespace D_Library.Models.Model
{
    public class BookEditModel
    {
        public int ID { get; set; }
        public List<string> DetailsNav { get; set; }
        public Tbl_Book Book { get; set; }
        public Tbl_BookDetails Details { get; set; }

    }
}