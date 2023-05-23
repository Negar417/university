using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityNG.models
{
    public class Course
    {
        public Course()
        {
            this.Students = new HashSet<Students>();
        }

        public int Id { get; set; }
        public string CourseName { get; set; }
        public string TeacherName { get; set; }
        public virtual ICollection<Students> Students { get; set; }

    }
}
