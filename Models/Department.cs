using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectPRN211.Models
{
    public partial class Department
    {
        public Department()
        {
            Students = new HashSet<Student>();
        }

        public int Did { get; set; }
        public string Dname { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
