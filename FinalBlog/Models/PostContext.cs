using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace FinalBlog.Models
{
    public class PostContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
    }
}
