using Microsoft.AspNetCore.Mvc;
using ProjectPRN211.Models;
using ProjectPRN211.Logics;
using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Http;

namespace ProjectPRN211.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Home()
        {
            if (Request.Cookies["AccCookie"] != null)
            {
                string objCartListStr = Request.Cookies["AccCookie"];
                string[] objCartListStringSplit = objCartListStr.Split(',');
                ViewBag.User = objCartListStringSplit[0];
                ViewBag.Pass = objCartListStringSplit[1];
            }
            return View();
        }
        public IActionResult Signin(string user, string pass, string remember)
        {
            if(remember != null)
            {
                AccountManager accountManager = new AccountManager();
                Account account = new Account();
                account = accountManager.GetAcc(user, pass);
                if (account == null)
                {
                    return RedirectToAction("Home");
                }
                else
                {
                    if (remember.Equals("1"))
                    {
                        CookieOptions options = new CookieOptions();
                        options.Expires = DateTimeOffset.Now.AddDays(30);
                        string AccCookie = user + "," + pass;
                        Response.Cookies.Append("AccCookie", AccCookie, options);
                    }
                    return RedirectToAction("Chat", "Chat");
                }

            }

            return RedirectToAction("Chat", "Chat");
        }
        public IActionResult Signup(string user, string pass, string repass)
        {
            return View();
        }
    }
}
