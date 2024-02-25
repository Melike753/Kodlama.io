using KodlamaioHomepage.Business.Concrete;
using KodlamaioHomepage.DataAccess.Concrete;
using KodlamaioHomepage.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioHomepage
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------Tüm Kurslar---------");
            CourseManager courseManager = new CourseManager(new CourseDal());
            List<Course> courses = courseManager.GetAll();
            foreach (var course in courses)
            {
                Console.WriteLine(course.CourseName);
            }

            Console.WriteLine("\n\n");

            Console.WriteLine("---------Tüm Kategoriler---------");
            CategoryManager categoryManager = new CategoryManager(new CategoryDal());
            List<Category> categories = categoryManager.GetAll();
            foreach (var category in categories)
            {
                Console.WriteLine(category.CategoryName);
            }

            Console.WriteLine("\n\n");

            Console.WriteLine("---------Kurs Ekleme---------");
            Console.WriteLine("Bir kurs mu eklemek istiyorsunuz ?\nEğer bir kurs eklemek istiyorsanız 1 i tuşlayınız : ");

            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine();

            // Eğer kullanıcı "1" tuşuna bastıysa kurs ekleme işlemini gerçekleştirin
            if (key.Key == ConsoleKey.D1)
            {
                // Kullanıcıdan kurs bilgilerini al
                Console.Write("Kurs ID: ");
                int courseId = int.Parse(Console.ReadLine());

                Console.Write("Kategori ID: ");
                int categoryId = int.Parse(Console.ReadLine());

                Console.Write("Eğitmen ID: ");
                int instructorId = int.Parse(Console.ReadLine());

                Console.Write("Kurs Adı: ");
                string courseName = Console.ReadLine();

                Console.Write("Kurs Açıklaması: ");
                string courseDescription = Console.ReadLine();

                Console.Write("Kurs Fiyatı: ");
                decimal coursePrice = decimal.Parse(Console.ReadLine());
                Course course1 = new Course
                {
                    Id = courseId,
                    CategoryId = categoryId,
                    InstructorId = instructorId,
                    CourseName = courseName,
                    CourseDescription = courseDescription,
                    CoursePrice = (int)coursePrice
                };


                courseManager.Add(course1);
                List<Course> courses1 = courseManager.GetAll();
                foreach (var course in courses1)
                {
                    Console.WriteLine(course.CourseName);
                }
            }
            else
            {
                Console.WriteLine("İşlem iptal edildi.");
            }

            Console.WriteLine("\n\n");

            Console.WriteLine("---------Kategori Ekleme---------");
            Console.WriteLine("Bir kategori mi eklemek istiyorsunuz ?\nEğer bir kategori eklemek istiyorsanız 2 yi tuşlayınız : ");

            ConsoleKeyInfo key2 = Console.ReadKey();
            Console.WriteLine();

            // Eğer kullanıcı "2" tuşuna bastıysa kategori ekleme işlemini gerçekleştirin
            if (key2.Key == ConsoleKey.D2)
            {
                Console.Write("Kategori ID: ");
                int categoryId = int.Parse(Console.ReadLine());

                Console.Write("Kategori Adı: ");
                string categoryName = Console.ReadLine();

                Category category1 = new Category
                {
                    Id = categoryId,
                    CategoryName = categoryName
                };
                categoryManager.Add(category1);
                List<Category> categories1 = categoryManager.GetAll();
                foreach (var category in categories1)
                {
                    Console.WriteLine(category.CategoryName);
                }
            }
            else
            {
                Console.WriteLine("İşlem iptal edildi.");
            }

            Console.WriteLine("\n\n");

            Console.WriteLine("---------Kurs Güncelleme---------");
            Console.WriteLine("Bir kursu güncellemek mi istiyorsunuz ?\nEğer bir kursu güncellemek istiyorsanız 3 ü tuşlayınız : ");

            ConsoleKeyInfo key3 = Console.ReadKey();
            Console.WriteLine();

            // Eğer kullanıcı "3" tuşuna bastıysa güncelleme işlemini gerçekleştirin
            if (key3.Key == ConsoleKey.D3)
            {
                // Kullanıcıdan güncellenecek kursun ID'sini al
                Console.Write("Güncellenecek Kursun ID'sini girin: ");
                int courseIdToUpdate = int.Parse(Console.ReadLine());

                // Güncellenecek kursun bilgilerini al
                Console.Write("Kategori ID: ");
                int categoryId = int.Parse(Console.ReadLine());

                Console.Write("Eğitmen ID: ");
                int instructorId = int.Parse(Console.ReadLine());

                Console.Write("Kurs Adı: ");
                string courseName = Console.ReadLine();

                Console.Write("Kurs Açıklaması: ");
                string courseDescription = Console.ReadLine();

                Console.Write("Kurs Fiyatı: ");
                decimal coursePrice = decimal.Parse(Console.ReadLine());

                // Yeni kurs nesnesi oluştur
                Course updatedCourse = new Course
                {
                    Id = courseIdToUpdate,
                    CategoryId = categoryId,
                    InstructorId = instructorId,
                    CourseName = courseName,
                    CourseDescription = courseDescription,
                    CoursePrice = (int)coursePrice
                };

                // Kursu güncelleyip listeyi güncelle
                courseManager.Update(updatedCourse);
                List<Course> updatedCourses = courseManager.GetAll();

                // Güncellenmiş kurs listesini konsola yazdır
                Console.WriteLine("---------Güncellenmiş Kurslar---------");
                foreach (var course in updatedCourses)
                {
                    Console.WriteLine(course.CourseName);
                }
            }
            else
            {
                Console.WriteLine("İşlem iptal edildi.");
            }

            Console.WriteLine("\n\n");

            Console.WriteLine("---------Kurs Silme---------");
            Console.WriteLine("Bir kursu silmek mi istiyorsunuz ?\nEğer bir kursu silmek istiyorsanız 4 ü tuşlayınız : ");
            ConsoleKeyInfo key4 = Console.ReadKey();
            Console.WriteLine();

            // Eğer kullanıcı "4" tuşuna bastıysa silme işlemini gerçekleştirin
            if (key4.Key == ConsoleKey.D4)
            {
                Console.Write("Silmek istediğiniz kursun ID'sini girin: ");
                int deleteCourseId;
                if (int.TryParse(Console.ReadLine(), out deleteCourseId))
                {
                    // Kursu sil ve listeyi güncelle
                    courseManager.Delete(deleteCourseId);
                    List<Course> updatedCourses = courseManager.GetAll();

                    // Güncellenmiş kurs listesini konsola yazdır
                    Console.WriteLine("---------Güncellenmiş Kurslar---------");
                    foreach (var course in updatedCourses)
                    {
                        Console.WriteLine(course.CourseName);
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz ID girişi. İşlem iptal edildi.");
                }
            }
            else
            {
                Console.WriteLine("İşlem iptal edildi.");
            }

            Console.ReadLine();
        }
    }
}