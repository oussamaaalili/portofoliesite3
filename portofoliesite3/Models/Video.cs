using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portofoliesite3.Models
{
    public class Video
    {
        public long Id { get; set; }

        public string description { get; set; }

        public string title { get; set; }

        public string link { get; set; }

        public string genre { get; set; }

        public string age { get; set; }

        public int rating { get; set; }

        public string thumbnail { get; set; }

    }
}
