using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityNG.models
{
    public class Students
    {
        public Students()
        {
            this.Courses = new HashSet<Course>();
        }

        public int Id { get; set; }
       
        public string StudentName { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
