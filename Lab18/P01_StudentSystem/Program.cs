using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Data;
using P01_StudentSystem.Data.Models;

class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("System starting...");

        using (var context = new StudentSystemContext())
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            Console.WriteLine("Database created successfully.");

            SeedDatabase(context);
            Console.WriteLine("Test data added.");

            Console.WriteLine("\n--- Course List ---");
            var courses = context.Courses
                .Include(c => c.Resources)
                .Include(c => c.StudentCourses)
                .ThenInclude(sc => sc.Student)
                .ToList();

            foreach (var course in courses)
            {
                Console.WriteLine($"ID: {course.CourseId} | Course: {course.Name} | Price: {course.Price}");
                Console.WriteLine($"   > Resources: {course.Resources.Count}");
                Console.WriteLine($"   > Students: {course.StudentCourses.Count}");
                foreach (var sc in course.StudentCourses)
                {
                    Console.WriteLine($"      - {sc.Student.Name}");
                }

                Console.WriteLine("------------------------------------------------");
            }
        }
    }

    public static void SeedDatabase(StudentSystemContext context)
    {
        if (context.Students.Any()) return;

        Console.WriteLine("Generating data...");

        var s1 = new Student { Name = "Ivan Petrenko", RegisteredOn = DateTime.Now, PhoneNumber = "0971112233" };
        var s2 = new Student
            { Name = "Maria Kovalenko", RegisteredOn = DateTime.Now.AddDays(-5), Birthday = new DateTime(2001, 5, 15) };
        var s3 = new Student { Name = "John Smith", RegisteredOn = DateTime.Now, PhoneNumber = "0509998877" };

        context.Students.AddRange(s1, s2, s3);
        context.SaveChanges();

        var c1 = new Course
            { Name = "C# Advanced", StartDate = DateTime.Now, EndDate = DateTime.Now.AddMonths(2), Price = 1200.00m };
        var c2 = new Course
        {
            Name = "Entity Framework Core", StartDate = DateTime.Now.AddMonths(1), EndDate = DateTime.Now.AddMonths(3),
            Price = 1500.00m, Description = "Code First & DB First"
        };

        context.Courses.AddRange(c1, c2);
        context.SaveChanges();

        context.Resources.Add(new Resource
        {
            Name = "Presentation 1", Url = "http://site.com/p1.pptx", ResourceType = ResourceType.Presentation,
            CourseId = c1.CourseId
        });
        context.Resources.Add(new Resource
        {
            Name = "Video Lesson", Url = "http://youtube.com/watch?v=123", ResourceType = ResourceType.Video,
            CourseId = c1.CourseId
        });
        context.Resources.Add(new Resource
        {
            Name = "MSDN Docs", Url = "http://msdn.microsoft.com", ResourceType = ResourceType.Document,
            CourseId = c2.CourseId
        });

        context.SaveChanges();

        context.StudentCourses.Add(new StudentCourse { StudentId = s1.StudentId, CourseId = c1.CourseId });
        context.StudentCourses.Add(new StudentCourse { StudentId = s2.StudentId, CourseId = c1.CourseId });
        context.StudentCourses.Add(new StudentCourse { StudentId = s2.StudentId, CourseId = c2.CourseId });
        context.StudentCourses.Add(new StudentCourse { StudentId = s3.StudentId, CourseId = c2.CourseId });

        context.SaveChanges();

        context.Homeworks.Add(new Homework
        {
            Content = "ivan_hw.zip", ContentType = ContentType.Zip, SubmissionTime = DateTime.Now,
            StudentId = s1.StudentId, CourseId = c1.CourseId
        });
        context.Homeworks.Add(new Homework
        {
            Content = "maria_essay.pdf", ContentType = ContentType.Pdf, SubmissionTime = DateTime.Now.AddDays(1),
            StudentId = s2.StudentId, CourseId = c1.CourseId
        });

        context.SaveChanges();
    } 

}