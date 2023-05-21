﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public bool Status { get; set; }
        public List<Project> Projects { get; set; }
    }
}
