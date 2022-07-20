using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectPRN211.Models
{
    public partial class BookAuthor
    {
        public int Bid { get; set; }
        public int Aid { get; set; }

        public virtual Author AidNavigation { get; set; }
        public virtual Book BidNavigation { get; set; }
    }
}
