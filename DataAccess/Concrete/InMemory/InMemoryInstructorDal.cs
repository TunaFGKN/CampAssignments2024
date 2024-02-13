using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryInstructorDal : IInstructorDal
    {
        List<Instructor> _instructors;
        public InMemoryInstructorDal()
        {
            _instructors = new List<Instructor>
            {
                new Instructor{ InstructorId=1, InstructorName = "Engin Demiroğ", InstructorEmail = "demirog@kodlama.io"},
                new Instructor{ InstructorId=2, InstructorName = "Halit Enes Kalaycı", InstructorEmail = "kalayci@kodlama.io"},
                new Instructor{ InstructorId=3, InstructorName = "Tuna Figankaplan", InstructorEmail = "figankaplan@kodlama.io"}
            };
        }
        public void Add(Instructor entity)
        {
            _instructors.Add(entity);
            Console.WriteLine($"{entity.InstructorName} eğitmeni belleğe eklendi.");
        }

        public void Delete(Instructor entity)
        {
            Instructor instructorToDelete = null;
            instructorToDelete = _instructors.SingleOrDefault(i => i.InstructorId == entity.InstructorId);
            _instructors.Remove(instructorToDelete);
            Console.WriteLine($"{instructorToDelete.InstructorName} eğitmeni bellekten silindi.");
        }

        public Instructor Get(int id)
        {
            return _instructors.SingleOrDefault(i => i.InstructorId == id);
        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }

        public void Update(Instructor entity)
        {
            Instructor instructorToUpdate = null;
            instructorToUpdate = _instructors.SingleOrDefault(i => i.InstructorId==entity.InstructorId);
            instructorToUpdate.InstructorName = entity.InstructorName;
            instructorToUpdate.InstructorEmail = entity.InstructorEmail;
            Console.WriteLine($"{entity.InstructorName} düzenlendi.");
        }
    }
}
