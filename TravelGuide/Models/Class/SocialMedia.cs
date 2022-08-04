using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelGuide.Models.Class
{
    public class SocialMedia
    {
        [Key]
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Link { get; set; }
        public string Icon { get; set; }
    }
}