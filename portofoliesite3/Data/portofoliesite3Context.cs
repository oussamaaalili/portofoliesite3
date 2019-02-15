using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using portofoliesite3.Models;

namespace portofoliesite3.Models
{
    public class portofoliesite3Context : DbContext
    {
        public portofoliesite3Context (DbContextOptions<portofoliesite3Context> options)
            : base(options)
        {
        }

        public DbSet<portofoliesite3.Models.Post> Post { get; set; }

        public DbSet<portofoliesite3.Models.Video> Video { get; set; }
    }
}
