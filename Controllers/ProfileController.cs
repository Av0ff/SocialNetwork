using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SocialMedia.Areas.Identity.Data;
using SocialMedia.Models;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SocialMedia.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        private readonly UserManager<User> _manager;
        private readonly SocialMediaContext _db;
		public ProfileRepo Profile { get; }

		public ProfileController(UserManager<User> manager, SocialMediaContext db, ProfileRepo profile)
        {
            _manager = manager;
            _db = db;
			Profile = profile;
		}

        new public async Task<IActionResult> GetUser(string? userId)
        {
            var user = await Profile.GetUser(userId);
            return View(user);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateProfile()
        {
            var user = await Profile.GetUser(_manager.GetUserId(User));
			return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProfile(ProfileModel model)
        {
            var userId = _manager.GetUserId(User);
            await Profile.UpdateProfile(userId, model);
            return RedirectToAction(nameof(GetUser), new { userId = userId });
        }

        public IActionResult UploadPost()
        {
            //
            return RedirectToAction(nameof(GetUser));
        }

        public IActionResult RemovePost() 
        {
            //
            return RedirectToAction(nameof(GetUser));
        }

    }
}
