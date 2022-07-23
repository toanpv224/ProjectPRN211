using Microsoft.AspNetCore.Mvc;
using ProjectPRN211.Models;
using ProjectPRN211.Logics;
using System.Collections.Generic;

namespace ProjectPRN211.Controllers
{
    public class ChatController : Controller
    {
        

        public IActionResult Chat()
        {
            ChatManager chatManager = new ChatManager();

            List<Post> listPost = new List<Post>();
            List<Comment> commentList = new List<Comment>();

            listPost = chatManager.GetPort();
            commentList = chatManager.GetComment();
            
            ViewBag.Post = listPost;
            ViewBag.Comment = commentList;

            return View();
        }
       
    }
}
