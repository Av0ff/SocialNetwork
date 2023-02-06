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
        private readonly ProfileRepo _profile;
        private readonly PostRepo _post;

		public ProfileController(UserManager<User> manager, SocialMediaContext db, ProfileRepo profile, PostRepo post)
        {
            _manager = manager;
            _db = db;
			_profile = profile;
			_post = post;
		}

		public async Task<IActionResult> UserProfile(string? userId)
		{
			var user = await _profile.GetUser(userId);
            //var viewModel = new ProfileViewModel { Profile = user };
			return View(user);
		}

		[HttpGet]
        public async Task<IActionResult> UpdateProfile()
        {
            var user = await _profile.GetUser(_manager.GetUserId(base.User));
			//var viewModel = new ProfileViewModel { Profile = user };
			return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProfile(ProfileModel model)
        {
            var userId = _manager.GetUserId(base.User);
            await _profile.UpdateProfile(userId, model);
            return RedirectToAction(nameof(UserProfile), new { userId = userId });
        }

        [HttpPost]
        public async Task<IActionResult> UploadPost([FromForm]PostModel model)
        {
            await _post.CreatePost(model);
            return RedirectToAction(nameof(UserProfile), new { userId = _manager.GetUserId(User) });
        }

        [HttpPut]
        public async Task<IActionResult> ChangePost(int id,[FromForm] PostModel model)
        {
            await _post.UpdatePost(id, model);
			return RedirectToAction(nameof(UserProfile), new { userId = _manager.GetUserId(User) });
		}

        public async Task<IActionResult> RemovePost(int id) 
        {
            await _post.DeletePost(id);
            return RedirectToAction(nameof(UserProfile), new { userId = _manager.GetUserId(User) });
        }

    }
}
