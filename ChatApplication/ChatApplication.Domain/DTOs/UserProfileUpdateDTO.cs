﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication.Domain.DTOs
{
    public class UserProfileUpdateDTO
    {
        public string DisplayName { get; set; }
        public string EmailAddress { get; set; }
    }
}
