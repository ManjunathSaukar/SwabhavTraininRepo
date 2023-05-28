﻿using Microsoft.AspNetCore.Identity;

namespace MovieApis.Models.Domain
{
    public class ApplicationUser :IdentityUser
    {
        public string? Name { get; set; }

    }
}
