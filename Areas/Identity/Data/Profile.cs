﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.IO;

namespace SocialMedia.Areas.Identity.Data
{
    public class Profile
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Birth { get; set; }
        public string? Status { get; set; }
        public byte[]? Picture { get; set; }

    }
}
