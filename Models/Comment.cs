using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectPRN211.Models
{
    public partial class Comment
    {
        public int Cid { get; set; }
        public string Ccontent { get; set; }
        public int Pid { get; set; }
        public string Username { get; set; }
        public string To { get; set; }
        public DateTime Date { get; set; }
        public virtual Post PidNavigation { get; set; }
        public virtual Account UsernameNavigation { get; set; }
    }
}
