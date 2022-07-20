using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectPRN211.Models
{
    public partial class Student
    {
        public int Sid { get; set; }
        public string Sname { get; set; }
        public bool Gender { get; set; }
        public DateTime Dob { get; set; }
        public int Did { get; set; }

        public virtual Department DidNavigation { get; set; }
    }
}
