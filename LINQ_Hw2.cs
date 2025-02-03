namespace LINQ;

internal class Program
{
    static void Main(string[] args)
    {
        // 1. Fill Students
        var students = new List<Student>
        {
            new Student { StudentID = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", DateOfBirth = new DateTime(2000, 5, 15) },
            new Student { StudentID = 2, FirstName = "Jane", LastName = "Smith", Email = "jane.smith@example.com", DateOfBirth = new DateTime(1998, 8, 20) },
            new Student { StudentID = 3, FirstName = "Michael", LastName = "Brown", Email = "michael.brown@example.com", DateOfBirth = new DateTime(1995, 12, 1) },
            new Student { StudentID = 4, FirstName = "Emily", LastName = "Clark", Email = "emily.clark@example.com", DateOfBirth = new DateTime(1997, 7, 25) },
            new Student { StudentID = 5, FirstName = "David", LastName = "Johnson", Email = "david.johnson@example.com", DateOfBirth = new DateTime(1999, 3, 10) },
            new Student { StudentID = 6, FirstName = "Sophia", LastName = "Martinez", Email = "sophia.martinez@example.com", DateOfBirth = new DateTime(2001, 6, 18) },
            new Student { StudentID = 7, FirstName = "Daniel", LastName = "Lee", Email = "daniel.lee@example.com", DateOfBirth = new DateTime(1996, 9, 5) },
            new Student { StudentID = 8, FirstName = "Olivia", LastName = "Anderson", Email = "olivia.anderson@example.com", DateOfBirth = new DateTime(2002, 11, 30) },
            new Student { StudentID = 9, FirstName = "James", LastName = "White", Email = "james.white@example.com", DateOfBirth = new DateTime(1994, 4, 22) },
            new Student { StudentID = 10, FirstName = "Isabella", LastName = "Harris", Email = "isabella.harris@example.com", DateOfBirth = new DateTime(1997, 2, 14) }
        };

        // 2. Fill Courses
        var courses = new List<Course>
        {
            new Course { CourseID = 1, CourseName = "Introduction to C#", Category = "Programming", DifficultyLevel = "Beginner", Price = 99.99m },
            new Course { CourseID = 2, CourseName = "Data Science Basics", Category = "Data Science", DifficultyLevel = "Intermediate", Price = 199.99m },
            new Course { CourseID = 3, CourseName = "Advanced Web Development", Category = "Web Development", DifficultyLevel = "Advanced", Price = 299.99m },
            new Course { CourseID = 4, CourseName = "Introduction to Python", Category = "Programming", DifficultyLevel = "Beginner", Price = 79.99m },
            new Course { CourseID = 5, CourseName = "Machine Learning Fundamentals", Category = "Data Science", DifficultyLevel = "Advanced", Price = 349.99m },
            new Course { CourseID = 6, CourseName = "React and Modern UI Design", Category = "Web Development", DifficultyLevel = "Intermediate", Price = 149.99m },
            new Course { CourseID = 7, CourseName = "Database Management Systems", Category = "Databases", DifficultyLevel = "Intermediate", Price = 129.99m },
            new Course { CourseID = 8, CourseName = "Cybersecurity Essentials", Category = "Security", DifficultyLevel = "Advanced", Price = 199.99m },
            new Course { CourseID = 9, CourseName = "Cloud Computing with AWS", Category = "Cloud", DifficultyLevel = "Intermediate", Price = 249.99m },
            new Course { CourseID = 10, CourseName = "Game Development with Unity", Category = "Game Development", DifficultyLevel = "Beginner", Price = 179.99m }
        };


            // 3. Fill Instructors
        var instructors = new List<Instructor>
        {
            new Instructor {
                InstructorID = 1, FirstName = "Emma", LastName = "Williams",
                Email = "emma.williams@example.com", HireDate = new DateTime(2015, 6, 1),
                Courses = new List<Course>
                {
                    courses[0], // Introduction to C#
                    courses[3], // Introduction to Python
                    courses[5]  // React and Modern UI Design
                }
            },
            new Instructor {
                InstructorID = 2, FirstName = "Liam", LastName = "Taylor",
                Email = "liam.taylor@example.com", HireDate = new DateTime(2018, 9, 15),
                Courses = new List<Course>
                {
                    courses[1], // Data Science Basics
                    courses[4]  // Machine Learning Fundamentals
                }
            },
            new Instructor {
                InstructorID = 3, FirstName = "Noah", LastName = "Walker",
                Email = "noah.walker@example.com", HireDate = new DateTime(2017, 3, 10),
                Courses = new List<Course>
                {
                    courses[2], // Advanced Web Development
                    courses[6], // Database Management Systems
                    courses[7]  // Cybersecurity Essentials
                }
            },
            new Instructor {
                InstructorID = 4, FirstName = "Sophia", LastName = "Lopez",
                Email = "sophia.lopez@example.com", HireDate = new DateTime(2016, 11, 25),
                Courses = new List<Course>
                {
                    courses[0], // Introduction to C#
                    courses[9]  // Game Development with Unity
                }
            },
            new Instructor {
                InstructorID = 5, FirstName = "Ethan", LastName = "Scott",
                Email = "ethan.scott@example.com", HireDate = new DateTime(2014, 5, 30),
                Courses = new List<Course>
                {
                    courses[4], // Machine Learning Fundamentals
                    courses[8]  // Cloud Computing with AWS
                }
            },
            new Instructor {
                InstructorID = 6, FirstName = "Olivia", LastName = "Baker",
                Email = "olivia.baker@example.com", HireDate = new DateTime(2019, 7, 12),
                Courses = new List<Course>
                {
                    courses[5], // React and Modern UI Design
                    courses[7]  // Cybersecurity Essentials
                }
            },
            new Instructor {
                InstructorID = 7, FirstName = "Lucas", LastName = "Carter",
                Email = "lucas.carter@example.com", HireDate = new DateTime(2020, 1, 5),
                Courses = new List<Course>
                {
                    courses[1], // Data Science Basics
                    courses[6]  // Database Management Systems
                }
            },
            new Instructor {
                InstructorID = 8, FirstName = "Ava", LastName = "Mitchell",
                Email = "ava.mitchell@example.com", HireDate = new DateTime(2013, 10, 18),
                Courses = new List<Course>
                {
                    courses[2], // Advanced Web Development
                    courses[8]  // Cloud Computing with AWS
                }
            },
            new Instructor {
                InstructorID = 9, FirstName = "Mason", LastName = "Perez",
                Email = "mason.perez@example.com", HireDate = new DateTime(2012, 8, 21),
                Courses = new List<Course>
                {
                    courses[3], // Introduction to Python
                    courses[9]  // Game Development with Unity
                }
            },
            new Instructor {
                InstructorID = 10, FirstName = "Ella", LastName = "Hill",
                Email = "ella.hill@example.com", HireDate = new DateTime(2021, 6, 14),


                Courses = new List<Course>
                {
                    courses[0], // Introduction to C#
                    courses[5], // React and Modern UI Design
                    courses[6]  // Database Management Systems
                }
            }
        };

        // 4. Fill Enrollments
        var enrollments = new List<Enrollment>
        {
            new Enrollment { EnrollmentID = 1, StudentID = 1, CourseID = 1, EnrollmentDate = DateTime.Now.AddMonths(-2), CompletionStatus = "Completed", Score = 85.5m },
            new Enrollment { EnrollmentID = 2, StudentID = 2, CourseID = 2, EnrollmentDate = DateTime.Now.AddMonths(-1), CompletionStatus = "In Progress", Score = 70.0m },
            new Enrollment { EnrollmentID = 3, StudentID = 3, CourseID = 3, EnrollmentDate = DateTime.Now.AddMonths(-3), CompletionStatus = "Dropped", Score = 50.0m },
            new Enrollment { EnrollmentID = 4, StudentID = 1, CourseID = 4, EnrollmentDate = DateTime.Now.AddMonths(-1), CompletionStatus = "Completed", Score = 90.0m },
            new Enrollment { EnrollmentID = 5, StudentID = 2, CourseID = 1, EnrollmentDate = DateTime.Now.AddMonths(-3), CompletionStatus = "Completed", Score = 95.0m },
            new Enrollment { EnrollmentID = 6, StudentID = 4, CourseID = 5, EnrollmentDate = DateTime.Now.AddMonths(-2), CompletionStatus = "In Progress", Score = 88.0m },
            new Enrollment { EnrollmentID = 7, StudentID = 5, CourseID = 6, EnrollmentDate = DateTime.Now.AddMonths(-4), CompletionStatus = "Completed", Score = 78.5m },
            new Enrollment { EnrollmentID = 8, StudentID = 6, CourseID = 7, EnrollmentDate = DateTime.Now.AddMonths(-5), CompletionStatus = "Completed", Score = 91.0m },
            new Enrollment { EnrollmentID = 9, StudentID = 7, CourseID = 8, EnrollmentDate = DateTime.Now.AddMonths(-3), CompletionStatus = "Dropped", Score = 55.0m },
            new Enrollment { EnrollmentID = 10, StudentID = 8, CourseID = 9, EnrollmentDate = DateTime.Now.AddMonths(-1), CompletionStatus = "In Progress", Score = 80.0m },
            new Enrollment { EnrollmentID = 11, StudentID = 8, CourseID = 1, EnrollmentDate = DateTime.Now.AddMonths(-2), CompletionStatus = "In Progress", Score = 80.0m },
            new Enrollment { EnrollmentID = 12, StudentID = 8, CourseID = 1, EnrollmentDate = DateTime.Now.AddMonths(-3), CompletionStatus = "In Progress", Score = 80.0m }

        };


        // A
        // 1.
        var eEnroll = enrollments
            .Join(courses, e => e.CourseID, c => c.CourseID, (e, c) => new { e.CourseID, e.EnrollmentDate })
            .OrderBy(e => e.EnrollmentDate)
            .FirstOrDefault();

        Console.WriteLine("A.1:");
        Console.WriteLine($"{eEnroll.CourseID} - {eEnroll.EnrollmentDate}");

        // 2
        var sInstructor = instructors
            .SingleOrDefault(i => i.Email == "emma.williams@example.com");

        Console.WriteLine("A.2:");
        Console.WriteLine($"{sInstructor.InstructorID} - {sInstructor.Email}");

        // 3
        var lEnroll = enrollments
            .Join(courses, e => e.CourseID, c => c.CourseID, (e, c) => new { e.CourseID, e.EnrollmentDate })
            .OrderBy(e => e.EnrollmentDate)
            .LastOrDefault();

        Console.WriteLine("A.3:");
        Console.WriteLine($"{lEnroll.CourseID} - {lEnroll.EnrollmentDate}");

        // 4
        var sCourse = courses
            .OrderBy(c => c.Price)
            .ElementAtOrDefault(2);

        Console.WriteLine("A.4:");
        Console.WriteLine(sCourse.Price);

        // B
        // 1
        var topScores = enrollments
            .Join(courses, e => e.CourseID, c => c.CourseID, (e, c) => new { e.CourseID, e.Score })
            .Where(e => e.CourseID == 1)
            .OrderByDescending(e => e.Score)
            .Take(5);

        Console.WriteLine("B.1:");
        foreach(var item in topScores)
        {
            Console.WriteLine($"{item.CourseID} - {item.Score}");
        }

        // 2
        var sEnroll = enrollments
            .Where(e => e.CourseID == 1)
            .OrderBy(e => e.EnrollmentDate)
            .Skip(3);

        Console.WriteLine("B.2:");
        foreach (var item in sEnroll)
        {
            Console.WriteLine(item.EnrollmentID);
        }

        // 3
        var sPrice = courses
            .OrderBy(c => c.Price)
            .TakeWhile(c => c.Price < 150);

        Console.WriteLine("B.3:");
        foreach (var item in sPrice)
        {
            Console.WriteLine(item.Price);
        }

        // 4
        var sDifficulty = courses
            .SkipWhile(c => c.DifficultyLevel != "Intermediate");

        Console.WriteLine("B.4:");
        foreach(var item in sDifficulty)
        {
            Console.WriteLine(item.CourseID);
        }

        // C
        // 1
        var eDetails = enrollments
            .Join(courses, e => e.CourseID, c => c.CourseID, (e, c) => new { e, c })
            .Join(students, e => e.e.StudentID, s => s.StudentID, (e, s) => new { e, s })
            .Select(e => new
            {
                StudentName = e.s.FullName,
                CourseName = e.e.c.CourseName,
                IsHighScore = (e.e.e.Score >= 90) ? true : false
            });

        Console.WriteLine("C.1:");
        foreach (var item in eDetails)
        {
            Console.WriteLine($"{item.StudentName}: {item.CourseName}, Score - {item.IsHighScore}");
        }

        // 2
        var fStudents = enrollments
            .Join(students, e => e.StudentID, s => s.StudentID, (e, s) => new { s.FullName })
            .SelectMany(e => new[] { $"{e.FullName}" });

        Console.WriteLine("C.2:");
        foreach (var item in fStudents)
        {
            Console.WriteLine(item);
        }

        // 3
        var gEnroll = enrollments
            .Join(courses, e => e.CourseID, c => c.CourseID, (e, c) => new { e.CourseID, e.Score, c.CourseName })
            .GroupBy(e => new { e.CourseID, e.CourseName })
            .Select(g => new
            {
                CourseName = g.Key.CourseName,
                AvarageScore = g.Average(g => g.Score),
                TotalEnrollments = g.Count()
            });

        Console.WriteLine("C.3:");
        foreach(var item in gEnroll)
        {
            Console.WriteLine($"{item.CourseName} - {item.TotalEnrollments}: {item.AvarageScore}");
        }

        // 4
        var gLastNames = students
            .OrderBy(s => s.LastName[0])
            .GroupBy(s => s.LastName[0])
            .Select(g => new
            {
                Initial = g.Key,
                Students = g.Select(s => $"{s.FullName}").ToList()
            });

        Console.WriteLine("C.4:");
        foreach(var item in gLastNames)
        {
            Console.WriteLine(item.Initial);
            foreach(var student in item.Students)
            {
                Console.WriteLine(student);
            }
        }
    }
}

public class Student
{
    public int StudentID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public DateTime DateOfBirth { get; set; }

    // Full name property for convenience
    public string FullName => $"{FirstName} {LastName}";
}
public class Course
{
    public int CourseID { get; set; }
    public string CourseName { get; set; }
    public string Category { get; set; }
    public string DifficultyLevel { get; set; } // Beginner, Intermediate, Advanced
    public decimal Price { get; set; }

    // Optional: Add a list of enrollments for this course
    public List<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
}
public class Enrollment
{
    public int EnrollmentID { get; set; }
    public int StudentID { get; set; }
    public int CourseID { get; set; }
    public DateTime EnrollmentDate { get; set; }
    public string CompletionStatus { get; set; } // "In Progress", "Completed", "Dropped"
    public decimal Score { get; set; }

    // Navigation properties
    public Student Student { get; set; }
    public Course Course { get; set; }
}
public class Instructor
{
    public int InstructorID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public DateTime HireDate { get; set; }

    // Full name property for convenience
    public string FullName => $"{FirstName} {LastName}";

    // Optional: Add a list of courses taught by this instructor
    public List<Course> Courses { get; set; } = new List<Course>();
}

