using Microsoft.AspNetCore.Mvc;
using ProjectPRN211.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjectPRN211.Logics
{
    public class ChatManager : Controller
    {
        TestContext _context;
        public ChatManager()
        {
            _context = new TestContext();
        }

        public List<Post> GetPort()
        {
            List<Post> postList = new List<Post>();
            List<Account> accountList = new List<Account>();
            List<Comment> commentList = new List<Comment>();
            postList = _context.Posts.ToList();
            accountList = _context.Accounts.ToList();
            commentList = _context.Comments.ToList();
            
            return from ;
        }
    }
}
