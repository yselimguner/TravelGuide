 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace TravelGuide.Models.Class
{
    public class BlogComment
    {
        public IEnumerable<Blog> value1 { get; set; }
        public IEnumerable<Comments> value2 { get; set; }//Bir view içerisine birden fazla tablo çekmek istiyorsak bunu kullanıcaz.
        public IEnumerable<Blog> value3 { get; set; }
        public IEnumerable<Comments> value4 { get; set; }

    }
}