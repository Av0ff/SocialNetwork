using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using SocialMedia.Areas.Identity.Data;

[assembly: HostingStartup(typeof(SocialMedia.Areas.Identity.IdentityHostingStartup))]
namespace SocialMedia.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<SocialMediaContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("SocialMediaContextConnection")));

                services.AddDefaultIdentity<User>(ops => ops.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<SocialMediaContext>();

                services.Configure<IdentityOptions>( ops => 
                {
                    ops.Password.RequireNonAlphanumeric = false;
                    ops.Password.RequireUppercase = false;
                });

            });
        }
    }
}