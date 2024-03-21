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

        // public const string ConnectString = @"Data Source=HUE-ANHNTN\\ROOT;Initial Catalog=DBJobMatching;Integrated Security=True;Trust Server Certificate=True";
    }
}
