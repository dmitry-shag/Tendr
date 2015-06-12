﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TenderIt.Models
{
    public class Category
    {
        public int Id { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifieldOn { get; set; }
        public string Name { get; set; }
    }
}