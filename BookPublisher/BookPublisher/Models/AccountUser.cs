﻿using System;
using System.Collections.Generic;

#nullable disable

namespace BookPublisher.Models
{
    public partial class AccountUser
    {
        public string UserId { get; set; }
        public string UserPassword { get; set; }
        public string UserFullName { get; set; }
        public int? UserRole { get; set; }
    }
}
