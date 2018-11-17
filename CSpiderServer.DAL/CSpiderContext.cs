using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSpiderServer.DAL
{
    public class CSpiderContext : DbContext
    {
        public CSpiderContext(DbContextOptions<CSpiderContext> options) : base(options) { }

        public DbSet<Entities.User> Users { get; set; }
    }
}
