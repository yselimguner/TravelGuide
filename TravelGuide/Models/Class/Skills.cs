﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelGuide.Models.Class
{
    public class Skills
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Percentage { get; set; }
    }
}