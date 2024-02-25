using KodlamaioHomepage.DataAccess.Abstract;
using KodlamaioHomepage.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioHomepage.DataAccess.Concrete
{
    public class CourseDal : ICourseDal
    {
        private List<Course> _courses;
        public CourseDal()
        {
            _courses = new List<Course>
            {
               new Course
               {
                   Id=1,
                   CategoryId=1,
                   InstructorId=1,
                   CourseName ="Senior Yazılım Geliştirici Yetiştirme Kampı (.NET)",
                   CourseDescription="Ücretsiz ve profesyonel bir programla, ileri seviye yazılım geliştirme öğreniyoruz.",
                   CoursePrice=0,
               },
               new Course
               {
                    Id=2,
                    CategoryId=1,
                    InstructorId=1,
                    CourseName ="Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)",
                    CourseDescription="2 ay sürecek ücretsiz ve profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.",
                    CoursePrice=0,
               },
               new Course
               {
                     Id=3,
                     CategoryId=1,
                     InstructorId=2,
                     CourseName ="(2023) Yazılım Geliştirici Yetiştirme Kampı (Python & Selenium)",
                     CourseDescription="Profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.",
                     CoursePrice=0,
               },
               new Course
               {
                     Id=4,
                     CategoryId=1,
                     InstructorId=1,
                     CourseName ="(2022) Yazılım Geliştirici Yetiştirme Kampı (JAVA)",
                     CourseDescription="Profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.",
                     CoursePrice=0,
               },
               new Course
               {
                     Id=5,
                     CategoryId=1,
                     InstructorId=1,
                     CourseName ="Yazılım Geliştirici Yetiştirme Kampı (JavaScript)",
                     CourseDescription="1,5 ay sürecek ücretsiz ve profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.",
                     CoursePrice=0,
               },
               new Course
               {
                     Id=6,
                     CategoryId=1,
                     InstructorId=1,
                     CourseName ="Yazılım Geliştirici Yetiştirme Kampı (JAVA & REACT)",
                     CourseDescription="2 ay sürecek ücretsiz ve profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.",
                     CoursePrice=0,
               },
               new Course
               {
                     Id=7,
                     CategoryId=1,
                     InstructorId=1,
                     CourseName ="2024 Yazılım Geliştirici Yetiştirme Kampı (C#)",
                     CourseDescription="Ücretsiz ve profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.",
                     CoursePrice=0,
               },
               new Course
               {
                     Id=8,
                     CategoryId=1,
                     InstructorId=1,
                     CourseName ="Programlamaya Giriş İçin Temel Kurs",
                     CourseDescription="PYTHON, JAVA, C# gibi tüm programlama dilleri için temel programlama mantığını anlaşılır örneklerle öğrenin.",
                     CoursePrice=0,
               },
            };
        }
        public void Add(Course entity)
        {
            _courses.Add(entity);
        }

        public void Delete(int id)
        {
            Course courseToDelete = _courses.FirstOrDefault(c => c.Id == id);
            if (courseToDelete != null)
            {
                _courses.Remove(courseToDelete);
            }
            else
            {
                Console.WriteLine("Such a course could not be found. Therefore, the deletion process cannot be performed.");
            }
        }

        public Course Get(int id)
        {
            return _courses.SingleOrDefault(c => c.Id == id);
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        public void Update(Course entity)
        {
            Course courseToUpdate = _courses.FirstOrDefault(c => c.Id == entity.Id);
            if (courseToUpdate != null)
            {
                courseToUpdate.CategoryId = entity.CategoryId;
                courseToUpdate.InstructorId = entity.InstructorId;
                courseToUpdate.CourseName = entity.CourseName;
                courseToUpdate.CourseDescription = entity.CourseDescription;
                courseToUpdate.CoursePrice = entity.CoursePrice;
            }
            else
            {
                Console.WriteLine("The course with the entered ID number cannot be found. Therefore, the update process cannot be performed!");
            }
        }
    }
}
