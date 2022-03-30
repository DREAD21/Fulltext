using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace front.Models
{
    public class TextContext : DbContext
    {
        public DbSet<Text> Texts { get; set; }
        public TextContext(DbContextOptions<TextContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
