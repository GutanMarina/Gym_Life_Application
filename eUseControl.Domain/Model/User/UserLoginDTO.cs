﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eUseControl.Domain.Model.User
{
    public class UserLoginDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string UserIp { get; set; }
    }
}
