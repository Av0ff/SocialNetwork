using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SocialMedia.Areas.Identity.Data;

namespace SocialMedia.Areas.Identity.Data
{
    public class SocialMediaContext : IdentityDbContext<User>
    {

        public SocialMediaContext(DbContextOptions<SocialMediaContext> options)
            : base(options)
        {
        }
        
        public DbSet<Profile> Profiles { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<User>()
                .HasOne(u => u.Profile)
                .WithOne(p => p.User)
                .OnDelete(DeleteBehavior.Cascade);
            builder.Entity<Profile>()
                .HasOne(p => p.User)
                .WithOne(u => u.Profile);
        }
    }
}
