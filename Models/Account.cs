using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectPRN211.Models
{
    public partial class Account
    {
        public Account()
        {
            Comments = new HashSet<Comment>();
            Posts = new HashSet<Post>();
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public string Displayname { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
