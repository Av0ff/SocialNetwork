using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SocialMedia.Areas.Identity.Data;
using SocialMedia.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly UserManager<User> _user;
        private readonly SignInManager<User> _signIn;
        private readonly PostRepo _post;

		public HomeController(ILogger<HomeController> logger, UserManager<User> user, SignInManager<User> signIn, PostRepo post)
		{
			_logger = logger;
			_user = user;
			_signIn = signIn;
			_post = post;
		}

		[Authorize]
        public async Task<IActionResult> Index()
        {
            var allUsers = _user.Users.ToList();
            allUsers.Remove(await _user.GetUserAsync(User));
            return View(allUsers);
        }

        [Authorize]
        public async Task<IActionResult> Posts()
        {
            var posts = await _post.AllPosts().OrderByDescending(p => p.Id).ToListAsync();
            return View(posts);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
