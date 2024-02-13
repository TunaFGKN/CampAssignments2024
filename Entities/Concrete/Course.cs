using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Course: IEntity
    {
        public int CourseId { get; set; }
        public int InstructorId { get; set; }
        public int CategoryId { get; set; }
        public string CourseName { get; set; }
        public double CoursePrice { get; set; }
        public string Description { get; set; }
    }
}
