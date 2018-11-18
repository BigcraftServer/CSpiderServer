using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using CSpiderServer.Models.Entities;

namespace CSpiderServer.DAL
{
    public class CSpiderContext : DbContext
    {
        public CSpiderContext(DbContextOptions<CSpiderContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<SpiderItem> SpiderItems { get; set; }
        public DbSet<UserToken> UserTokens { get; set; }
    }
}
