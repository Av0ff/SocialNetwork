namespace SocialMedia.Areas.Identity.Data
{
	public class Post
	{
		public int Id { get; set; }
		public string Text { get; set; }
		public byte[] Image { get; set; }
		public virtual Profile Profile { get; set; }
		public int ProfileId { get; set; }
	}
}
