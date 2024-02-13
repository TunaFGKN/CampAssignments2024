using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CourseManager courseManager = new CourseManager(new InMemoryCourseDal());
CategoryManager categoryManager = new CategoryManager(new InMemoryCategoryDal());
InstructorManager instructorManager = new InstructorManager(new InMemoryInstructorDal());

foreach(var course in courseManager.GetAll())
{
    Console.WriteLine(course.CourseName);
}

Console.WriteLine("--------------------------------------------------------------");

courseManager.Add(new Course { CourseId = 5, CategoryId = 1 , InstructorId = 2, CourseName = "C++", CoursePrice = 10, Description = "C++ 20"});

Console.WriteLine("--------------------------------------------------------------");

foreach (var course in courseManager.GetAll())
{
    Console.WriteLine($"{course.CourseName} -> {course.CoursePrice}");
}

Console.WriteLine("--------------------------------------------------------------");

Console.WriteLine(courseManager.GetById(1).CourseName);

Console.WriteLine("--------------------------------------------------------------");

var course1 = courseManager.GetById(5);
Console.WriteLine($"Kurs Id: {course1.CourseId} Kurs İsmi: {course1.CourseName} Kurs Fiyatı: {course1.CoursePrice} Kurs Açıklaması: {course1.Description} Kurs Kategori: {course1.CategoryId} Eğitmen Id: {course1.InstructorId}");
courseManager.Update(new Course { CourseId = 5, CategoryId = 1, InstructorId = 3, CourseName = "C+++", CoursePrice = 20, Description = "C++ 14" });
Console.WriteLine($"Kurs Id: {course1.CourseId} Kurs İsmi: {course1.CourseName} Kurs Fiyatı: {course1.CoursePrice} Kurs Açıklaması: {course1.Description} Kurs Kategori: {course1.CategoryId} Eğitmen Id: {course1.InstructorId}");

Console.WriteLine("--------------------------------------------------------------");

courseManager.Delete(new Course { CourseId = 5 });

foreach (var course in courseManager.GetAll())
{
    Console.WriteLine($"{course.CourseName} -> {course.CoursePrice}");
}

Console.WriteLine("--------------------------------------------------------------");

foreach (var category in categoryManager.GetAll())
{
    Console.WriteLine(category.CategoryName);
}

Console.WriteLine("--------------------------------------------------------------");

foreach (var instructor in instructorManager.GetAll())
{
    Console.WriteLine(instructor.InstructorName);
}