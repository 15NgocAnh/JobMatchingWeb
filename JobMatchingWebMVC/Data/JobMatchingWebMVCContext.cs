using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JobMatchingWebMVC.Models;

namespace JobMatchingWebMVC.Data
{
    public class JobMatchingWebMVCContext : DbContext
    {
        public JobMatchingWebMVCContext (DbContextOptions<JobMatchingWebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<JobMatchingWebMVC.Models.Users> Users { get; set; }
        public DbSet<JobMatchingWebMVC.Models.Jobs> Jobs { get; set; }
        public DbSet<JobMatchingWebMVC.Models.Roles> Roles { get; set; } = default!;

    }
}
