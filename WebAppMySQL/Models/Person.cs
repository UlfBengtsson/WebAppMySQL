﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppMySQL.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}