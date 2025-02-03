namespace C__LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ_Homework
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
            new Enrollment { EnrollmentID = 10, StudentID = 8, CourseID = 9, EnrollmentDate = DateTime.Now.AddMonths(-1), CompletionStatus = "In Progress", Score = 80.0m }
        };

            // Tasks

            // 1
            var fullNameStudents = students.Select(s => s.FullName);

            // 2
            var pCourses = courses
                .Where(c => c.Category == "Programming")
                .Select(c => new { c.CourseName, c.Price });

            // 3
            var sEmails = students
                .Where(s => s.Email.EndsWith("@example.com"))
                .Select(s => s.FullName).ToList();

            // 4
            var spCourses = courses
                .Where(c => c.Price >= 100);

            // 5
            var cEnrollments = enrollments
                .Join(courses, e => e.CourseID, c => c.CourseID, (e, c) => new { c.CourseName, e.EnrollmentID })
                .Count(c => c.CourseName == "Introduction to C#");

            // 6
            var cStudents = enrollments
                .Join(courses, e => e.CourseID, c => c.CourseID, (e, c) => new { e.EnrollmentID, e.StudentID, c.CourseName, e.CourseID })
                .Join(students, e => e.StudentID, s => s.StudentID, (e, s) => new { e.CourseName, e.StudentID, s.FullName })
                .Where(c => c.CourseName == "Data Science Basics")
                .Select(s => s.FullName);

            // 7
            var noEnrollmentsCourse = courses
                .Where(c => !enrollments.Any(e => e.CourseID == c.CourseID))
                .Select(c => c.CourseName);

            // 8
            var aScore = enrollments
                .Join(courses, e => e.CourseID, c => c.CourseID, (e, c) => new { e.Score, c.CourseName })
                .GroupBy(a => a.CourseName)
                .Select(g => new { CourseName = g.Key, AvarageScore = g.Average(a => a.Score) });

            // 9
            var threeInstructors = instructors
                .Where(i => i.Courses.Count() >= 3);

            // 10
            var highScoreStudent = enrollments
                .Join(students, e => e.StudentID, s => s.StudentID, (e, s) => new { Score = e.Score, FullName = s.FullName })
                .Where(a => a.Score >= 70);

            // 11
            var top3Student = enrollments
                .GroupBy(e => e.CourseID)
                .Select(g => new
                {
                    CourseName = courses.First(c => c.CourseID == g.Key).CourseName,
                    TopStudents = g.OrderByDescending(e => e.Score)
                                    .Take(3)
                                    .Select(e => new
                                    {
                                        StudentName = students.First(s => s.StudentID == e.StudentID).FullName,
                                        e.Score
                                    })
                });

            //foreach (var item in top3Student)
            //{
            //    Console.WriteLine($"{item.CourseName}: ");
            //    item.TopStudents.ToList().ForEach(e => Console.WriteLine($"{e.StudentName} - {e.Score}"));
            //}

            // 12
            var totalRevenueByCourse = courses
                .GroupBy(c => c.Category)
                .Select(g => new
                {
                    Category = g.Key,
                    Revenue = g.Sum(c => enrollments.Count(e => e.CourseID == c.CourseID) * c.Price)
                });

            //foreach (var item in totalRevenueByCourse)
            //{
            //    Console.WriteLine($"{item.Category} - {item.Revenue}");
            //}

            // 13
            var notEnrolledStudents = students
                .Where(s => !enrollments.Any(e => e.StudentID == s.StudentID));

            //foreach (var item in notEnrolledStudents)
            //{
            //    Console.WriteLine(item.StudentID);
            //}

            // 14
            var completedStatus = enrollments
                .Join(courses, e => e.CourseID, c => c.CourseID, (e, c) =>
                new
                {
                    c.CourseID,
                    c.CourseName,
                    e.CompletionStatus
                })
                .GroupBy(c => c.CourseID)
                .Select(g => new
                {
                    CourseName = courses.First(c => c.CourseID == g.Key).CourseName,
                    Percentage = ((double)g.Count(e => e.CompletionStatus == "Completed") / g.Count()) * 100
                });

            //foreach (var item in completedStatus)
            //{
            //    Console.WriteLine($"{item.CourseName} - {item.Percentage}");
            //}

            // 15
            var instructorRevenue = instructors
                .Select(i => new
                {
                    i.FullName,
                    TotalRevenue = i.Courses.Sum(c => enrollments.Where(e => e.CourseID == c.CourseID).Count() * c.Price)
                });

            //foreach (var item in instructorRevenue)
            //{
            //    Console.WriteLine($"{item.FullName} - {item.TotalRevenue}");
            //}

            // 16
            var notifications = new List<string>();

            var topAchivers = students
                .Where(s => enrollments.Where(e => e.StudentID == s.StudentID).Sum(e => e.Score) >= 90)
                .Select(s => new
                {
                    s.FullName,
                    Message = "You scored above 90!"
                });

            foreach (var item in topAchivers)
            {
                notifications.Add($"{item.FullName} - {item.Message}");
            }

            // 17
            var topEnrollCourses = enrollments
                .Join(courses, e => e.CourseID, c => c.CourseID, (e, c) =>
                new
                {
                    c.CourseName,
                    e.CourseID
                })
                .GroupBy(j => new { j.CourseID, j.CourseName })
                .Select(g => new
                {
                    CourseName = g.Key.CourseName,
                    TotalCount = g.Count()
                })
                .OrderByDescending(o => o.TotalCount)
                .Take(3);

            //foreach (var item in topEnrollCourses)
            //{
            //    Console.WriteLine($"{item.CourseName} - {item.TotalCount}");
            //}

            // 18
            var studentCompletionPercentage = enrollments
                .Join(students, e => e.StudentID, s => s.StudentID, (e, s) => new
                {
                    s.FullName,
                    e.StudentID,
                    e.CompletionStatus
                })
                .GroupBy(j => new { j.StudentID, j.FullName })
                .Select(g => new
                {
                    StudentName = g.Key.FullName,
                    Percentage = ((double)g.Count(e => e.CompletionStatus == "Completed") / g.Count()) * 100
                });

            //foreach (var item in studentCompletionPercentage)
            //{
            //    Console.WriteLine($"{item.StudentName} - {item.Percentage}");
            //}

            // 19
            var enrollForMonth = enrollments
                .GroupBy(e => e.EnrollmentDate.Month)
                .Select(g => new
                {
                    MonthName = g.Key,
                    EnrollmentsInMonth = g.Count()
                })
                .OrderBy(m => m.EnrollmentsInMonth);

            //foreach (var item in enrollForMonth)
            //{
            //    Console.WriteLine($"{item.MonthName} - {item.EnrollmentsInMonth}");
            //}

            // 20
            var highestEnrollForCategory = courses
                .Join(enrollments, c => c.CourseID, e => e.CourseID, (c, e) => new
                {
                    c.Category,
                    e.CourseID
                })
                .GroupBy(j => new { j.CourseID, j.Category })
                .Select(g => new
                {
                    Category = g.Key.Category,
                    Enrolls = g.Count()
                })
                .OrderByDescending(o => o.Enrolls)
                .First();

            Console.WriteLine($"Top: {highestEnrollForCategory.Category} - {highestEnrollForCategory.Enrolls}");

            #endregion


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
    }
}
