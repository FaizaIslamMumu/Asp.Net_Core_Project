using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core_Auth.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace Core_Auth.Data
{
    public class Core_AuthContext : IdentityDbContext<ApplicationUser>
    {
        public Core_AuthContext(DbContextOptions<Core_AuthContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
