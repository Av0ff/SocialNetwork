using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SocialMedia.Areas.Identity.Data;
using SocialMedia.Models;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SocialMedia.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        private readonly UserManager<User> _manager;
        private readonly SocialMediaContext _db;

        public ProfileController(UserManager<User> manager, SocialMediaContext db)
        {
            _manager = manager;
            _db = db;
        }

        new public async Task<IActionResult> GetUser(string? userId)
        {
            var profile = new ProfileRepo(_db, _manager);
            var user = await profile.GetUser(userId);
            return View(user);
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
