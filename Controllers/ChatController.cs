using Microsoft.AspNetCore.Mvc;
using ProjectPRN211.Models;
using ProjectPRN211.Logics;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace ProjectPRN211.Controllers
{
    public class ChatController : Controller
    {
        

        public IActionResult Chat()
        {
            Account account = new Account();
            string jsonStr = HttpContext.Session.GetString("account");
            account = JsonConvert.DeserializeObject<Account>(jsonStr);
            ChatManager chatManager = new ChatManager();

            List<Post> listPost = new List<Post>();
            List<Comment> commentList = new List<Comment>();

            listPost = chatManager.GetPort(account);
            commentList = chatManager.GetComment();

            

            ViewBag.Account = account;
            ViewBag.Post = listPost;
            ViewBag.Comment = commentList;

            return View();
        }
       
    }
}
