﻿using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using eUseControl.BusinessLogic.Interfaces;
using eUseControl.Domain.Model.User;
using eUseControl.Web.Models.Auth;

namespace eUseControl.Web.Controllers
{
    public class LoginController : Controller

    {
        private readonly ILogin _login;
        public LoginController()

        {
            var Bl = new BusinessLogic.BusinessLogic();
            _login = Bl.GetAuthBl();
         
        }
    
        // GET: Auth
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserDataLogin login)
        {

            var data = new UserLoginDTO
            {
                Password = login.Password,
                Username = login.Username,
                UserIp = "localhost"

            };
            string token = _login.UserAuthLogic(data);


            return View();
            
        }
    }
}