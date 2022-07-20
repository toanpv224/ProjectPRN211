using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectPRN211.Models
{
    public partial class Request
    {
        public int Rid { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Categoryid { get; set; }
        public string Statusid { get; set; }
    }
}
