using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portofoliesite3.Models
{
    public class Post
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public DateTime CreationDate { get; set; }

        public string Content { get; set; }
    }
}
