using KodlamaioHomepage.DataAccess.Abstract;
using KodlamaioHomepage.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioHomepage.DataAccess.Concrete
{

    public class InstructorDal : IInstructorDal
    {
        private List<Instructor> _instructors;
        public InstructorDal()
        {
            _instructors = new List<Instructor>
            {
                new Instructor{Id=1,InstructorFirstName="Engin", InstructorLastName="Demiroğ"},
                new Instructor{Id=2,InstructorFirstName="Halit Enes", InstructorLastName="Kalaycı"}

            };
        }
        public void Add(Instructor entity)
        {
            _instructors.Add(entity);
        }

        public void Delete(int id)
        {
            Instructor instructorToDelete = _instructors.FirstOrDefault(i => i.Id == id);
            if (instructorToDelete != null)
            {
                _instructors.Remove(instructorToDelete);
            }
        }

        public Instructor Get(int id)
        {
            return _instructors.SingleOrDefault(i => i.Id == id);
        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }

        public void Update(Instructor entity)
        {
            Instructor instructorToUpdate = _instructors.FirstOrDefault(i => i.Id == entity.Id);
            if (instructorToUpdate != null)
            {
                instructorToUpdate.InstructorFirstName = entity.InstructorFirstName;
                instructorToUpdate.InstructorLastName = entity.InstructorLastName;
            }
            else
            {
                Console.WriteLine("The instructor with the entered ID number cannot be found. Therefore, the update process cannot be performed..");
            }

        }
    }
}
