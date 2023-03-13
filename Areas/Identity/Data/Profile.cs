using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using SocialMedia.Models;
using System.Collections.Generic;
using System.IO;

namespace SocialMedia.Areas.Identity.Data
{
    public class Profile
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public virtual User User { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Birth { get; set; }
        public string? Status { get; set; }
        public byte[]? Picture { get; set; }
        public virtual List<Post> Posts { get; set; }

    }
}
