﻿using Abp.Auditing;
using System.ComponentModel.DataAnnotations;

namespace PruebaQuercu.Web.Models.Account;

public class LoginViewModel
{
    [Required]
    public string UsernameOrEmailAddress { get; set; }

    [Required]
    [DisableAuditing]
    public string Password { get; set; }

    public bool RememberMe { get; set; }
}
