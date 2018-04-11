using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BuffteksWebsite.Models;

    public class BuffTeksWebsiteContext : DbContext
    {
        public BuffTeksWebsiteContext (DbContextOptions<BuffTeksWebsiteContext> options)
            : base(options)
        {
        }

        public DbSet<BuffteksWebsite.Models.Client> Client { get; set; }

        public DbSet<BuffteksWebsite.Models.Project> Project { get; set; }

        public DbSet<BuffteksWebsite.Models.Member> Member { get; set; }
    }
