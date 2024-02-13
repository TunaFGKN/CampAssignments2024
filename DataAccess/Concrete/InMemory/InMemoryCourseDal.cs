using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCourseDal : ICourseDal
    {
        List<Course> _courses;
        public InMemoryCourseDal()
        {
            _courses = new List<Course>()
            {
                new Course{CourseId=1, CategoryId=1, InstructorId=1, CourseName = "C#", CoursePrice = 0, Description = ".NET 8"},
                new Course{CourseId=2, CategoryId=1, InstructorId=1, CourseName = "JAVA", CoursePrice = 20, Description = "SpringBoot"},
                new Course{CourseId=3, CategoryId=2, InstructorId=1, CourseName = "JavaScript", CoursePrice = 10, Description = "Node.JS"},
                new Course{CourseId=4,CategoryId=2,InstructorId=2,CourseName="Python",CoursePrice=15,Description="Selenium"}
            };
        }
        public void Add(Course entity)
        {
            _courses.Add(entity);
            Console.WriteLine($"{entity.CourseName} kursu belleğe eklendi.");
        }

        public void Delete(Course entity)
        {
            Course courseToDelete = null;
            courseToDelete = _courses.SingleOrDefault(c => c.CourseId == entity.CourseId);
            _courses.Remove(courseToDelete);
            Console.WriteLine($"{courseToDelete.CourseName} kursu bellekten silindi.");
        }

        public Course Get(int id)
        {
            return _courses.SingleOrDefault(c => c.CourseId == id);
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        public void Update(Course entity)
        {
            Course courseToUpdate = null;
            courseToUpdate = _courses.SingleOrDefault(c => c.CourseId == entity.CourseId);
            courseToUpdate.CategoryId = entity.CategoryId;
            courseToUpdate.InstructorId = entity.InstructorId;
            courseToUpdate.CourseName = entity.CourseName;
            courseToUpdate.CoursePrice = entity.CoursePrice;
            courseToUpdate.Description = entity.Description;
            Console.WriteLine($"{entity.CourseName} düzenlendi.");
        }
    }
}
