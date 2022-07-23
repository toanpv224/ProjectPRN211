using Microsoft.AspNetCore.Mvc;
using ProjectPRN211.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace ProjectPRN211.Logics
{
    public class ChatManager : Controller
    {
        TestContext _context;
        public ChatManager()
        {
            _context = new TestContext();
        }

        public List<Post> GetPort(Account account)
        {
            List <Post> postList = new List<Post>();
            postList = _context.Posts.Where(p => p.Username != account.Username).ToList();
            List<Comment> commentList = new List<Comment>();
            commentList = _context.Comments.ToList();
            foreach (Post post in postList)
            {
                post.Comments = commentList.Where(commentList => commentList.Pid == post.Pid).ToList();
            }
            return postList;
        }public List<Comment> GetComment()
        {
            List<Comment> commentList = new List<Comment>();
            commentList = _context.Comments.ToList();
            return commentList;
        }
    }
}
