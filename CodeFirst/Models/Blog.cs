using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string BlogName { get; set; }
        public virtual List<Post> posts { get; set; }
    }
}