﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelGuide.Models.Class
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string BlogImage { get; set; }
        public ICollection<Comments> Comments { get; set; }//Bir bloğun birden fazla yorumu olabilir.
        //fakat bir yorum sadece 1 bloga ait olur.
    }
}