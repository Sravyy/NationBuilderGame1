using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using NationBuilderGame.Models;

namespace NationBuilderGame.Models
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class NationBuilderContext : DbContext
    {
        public NationBuilderContext()
        {
        }

        public virtual DbSet<Nation> Nations { get; set; }
        public virtual DbSet<Event> Events { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(@"Server=localhost;Port=8889;database=nationbuildergame;uid=root;pwd=root;");
        }

        public NationBuilderContext(DbContextOptions<NationBuilderContext> options)
                : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
