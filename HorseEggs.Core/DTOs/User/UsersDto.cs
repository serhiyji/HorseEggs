﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseEggs.Core.DTOs.User
{
    public class UsersDto
    {
        public string Id { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber {  get; set; } = string.Empty;
        public bool EmailConfirmed { get; set; } = false;
        public string LockedOut { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
    }
}
