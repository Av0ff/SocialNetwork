using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SocialMedia.Areas.Identity.Data;
using SocialMedia.Migrations;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Models
{
	public class PostRepo
	{
		public PostRepo(SocialMediaContext context, UserManager<User> userManager, IHttpContextAccessor http)
		{
			Context = context;
			UserManager = userManager;
			Http = http;
		}

		public SocialMediaContext Context { get; }
		public UserManager<User> UserManager { get; }
		public IHttpContextAccessor Http { get; }

		public IQueryable<PostModel> AllPosts()
		{
			var posts = Context.Posts.Select(p => new PostModel { Id = p.Id, Text = p.Text, Image = p.Image, ProfileId = p.ProfileId }).AsQueryable();
			return posts;
		}

		public IQueryable<PostModel> GetUserPosts(int profileId)
		{
			IQueryable<PostModel> allPosts = Context.Posts
				.Where(post => post.ProfileId == profileId)
				.Select(post => new PostModel { Id = post.Id, Text = post.Text, Image = post.Image, ProfileId = post.ProfileId });

			return allPosts;
		}

		public async Task<PostModel> GetPost(int postId)
		{
			var post = await Context.Posts
				.Where(post => post.Id == postId)
				.Select(post => new PostModel { Id = post.Id, Text = post.Text, Image = post.Image, ProfileId = post.ProfileId })
				.FirstOrDefaultAsync();

			return post;
		}

		public async Task CreatePost(PostModel model)
		{
			if (model == null)
				return;

			var currentUser = await UserManager.GetUserAsync(Http.HttpContext.User);

			if (Http.HttpContext.Request.Form.Files.Count > 0)
			{
				IFormFile file = Http.HttpContext.Request.Form.Files.FirstOrDefault();
				using (var memo = new MemoryStream())
				{
					await file.CopyToAsync(memo);
					model.Image = memo.ToArray();
				}
			}

			Post post = new Post { Text = model.Text, Image = model.Image, ProfileId = currentUser.Profile.Id };

			await Context.Posts.AddAsync(post);
			await Context.SaveChangesAsync();
		}

		//public async Task UpdatePost(int postId, PostModel model)
		//{
		//	var post = await Context.Posts.Where(post => post.Id == postId)
		//		.FirstOrDefaultAsync();

		//	post.Text = model.Text;
		//	post.Image = model.Image;

		//	Context.Posts.Update(post);
		//	await Context.SaveChangesAsync();
		//}

		public async Task DeletePost(int postId)
		{
			var post = await Context.Posts.Where(post => post.Id == postId).FirstOrDefaultAsync();

			Context.Posts.Remove(post);
			await Context.SaveChangesAsync();
		}
	}
	public class PostModel
	{
		public int Id { get; set; }
		public string Text { get; set; }
		public byte[] Image { get; set; }
		public int ProfileId { get; set; }
	}
}
