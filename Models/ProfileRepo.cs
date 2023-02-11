using Microsoft.AspNetCore.Identity;
using SocialMedia.Areas.Identity.Data;
using System.Net.NetworkInformation;
using SocialMedia.Areas.Identity;
using SocialMedia.Areas.Identity.Pages;
using System.Threading.Tasks;
using System.Security.Claims;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SocialMedia.Models
{
    public class ProfileRepo
    {
        public ProfileRepo(SocialMediaContext db, UserManager<User> manager, IHttpContextAccessor context)
        {
            Db = db;
            Manager = manager;
			Context = context;
		}

        public SocialMediaContext Db { get; }
        public UserManager<User> Manager { get; }
		public IHttpContextAccessor Context { get; }

		public async Task<ProfileModel> GetUser(string? userId)
        {
            if (userId == null)
            {
                return null;
            }
            else
            {
                var profile = await Db.Profiles
                    .Where(p => p.UserId == userId)
                    .Select(p => new ProfileModel { FirstName = p.FirstName, LastName = p.LastName, Birth = p.Birth, Status = p.Status, UserId = p.UserId, Picture = p.Picture})
                    .FirstOrDefaultAsync();

                if (profile == null)
                {
                    return null;
                }
                return profile;
            }
        }

        public async Task<ProfileModel> GetProfile(int? profileId)
        {
            if (profileId == null) 
            { 
                return null;
            }
            else
            {
                var profile = await Db.Profiles
                    .Where(p => p.Id == profileId)
                    .Select(p => new ProfileModel { FirstName = p.FirstName, LastName = p.LastName, Birth = p.Birth, Status = p.Status, UserId = p.UserId, Picture = p.Picture })
                    .FirstOrDefaultAsync();

                if (profile == null)
                {
                    return null;
                }
                return profile;
            }
        }

        public async Task UpdateProfile(string? userId, ProfileModel model)
        {
			if (userId == null)
			{
				return;
			}
            else
            {
                var profile = Db.Profiles
                    .Where(p => p.UserId == userId)
                    .FirstOrDefault();

                if (Context.HttpContext.Request.Form.Files.Count > 0)
                {
                    IFormFile file = Context.HttpContext.Request.Form.Files.FirstOrDefault();
                    using (var memo = new MemoryStream())
                    {
                        await file.CopyToAsync(memo);
                        profile.Picture = memo.ToArray();
                    }
                }

                profile.FirstName = model.FirstName;
                profile.LastName = model.LastName;
                profile.Birth = model.Birth;
                profile.Status = model.Status;

                Db.Profiles.Update(profile);
                Db.SaveChanges();
            }
		}
    }
    public class ProfileModel
    {
        public string UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Birth { get; set; }
        public string? Status { get; set; }
        public byte[]? Picture { get; set; }
    }
}
