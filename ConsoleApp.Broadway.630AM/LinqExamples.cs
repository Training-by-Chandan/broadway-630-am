using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Broadway._630AM
{
    public class LinqExamples
    {
        public List<string> list = new List<string> { "One", "Two", "Three", "Four", "Twenty One", "Twenty Two", "Twenty Three", "Thiry One", "Thirty Two" };

        public LinqExamples()
        {
            this.GenerateDummyData();
        }

        public void LinqImpl()
        {
            var data = (from l in list select l).ToList();
            data = list.ToList();

            var lengths = (from l in list select l.Length).ToList();
            lengths = list.Select(l => l.Length).ToList();

            var newlist = (from l in list select l.Substring(0, 2)).ToList();
            newlist = list.Select(l => l.Substring(0, 2)).ToList();

            var filtered = (from l in list where l.Contains("One") select l).ToList();
            filtered = list.Where(l => l.Contains("One")).ToList();
        }

        public List<Student> students = new List<Student>();
        public List<StudentSubjectMarks> marks = new List<StudentSubjectMarks>();

        public void GenerateDummyData()
        {
            students.Add(new Student(1, "Pratik", "pratik@gmail.com"));
            students.Add(new Student(2, "Kishor", "kishor@gmail.com"));
            students.Add(new Student(3, "Ruman", "ruman@outlook.com"));
            students.Add(new Student(4, "Bashanta", "bashanta@gmail.com"));
            students.Add(new Student(5, "Chandan", "chandan@gmail.com"));
            students.Add(new Student(6, "Saroj", "saroj@gmail.com"));
            students.Add(new Student(7, "Rebika", "rebika@outlook.com"));
            students.Add(new Student(8, "Ram", "ram@gmail.com"));
            students.Add(new Student(9, "Meghna", "meghna@yahoo.com"));
            students.Add(new Student(10, "Nalina", "nalina@gmail.com"));
            students.Add(new Student(11, "Shyam", "shyam@yahoo.com"));
            students.Add(new Student(12, "Hari", "hari@gmail.com"));
            students.Add(new Student(13, "John", "john@yahoo.com"));
            students.Add(new Student(14, "Tony", "tony@outlook.com"));
            students.Add(new Student(15, "Bruce", "Bruce@gmail.com"));
            students.Add(new Student(16, "Peter", "peter@gmail.com"));

            marks.Add(new StudentSubjectMarks { StudentId = 1, SubjectName = "Math", Marks = 50 });
            marks.Add(new StudentSubjectMarks { StudentId = 1, SubjectName = "Science", Marks = 54 });
            marks.Add(new StudentSubjectMarks { StudentId = 1, SubjectName = "Nepali", Marks = 67 });
            marks.Add(new StudentSubjectMarks { StudentId = 1, SubjectName = "English", Marks = 76 });
            marks.Add(new StudentSubjectMarks { StudentId = 2, SubjectName = "Math", Marks = 56 });
            marks.Add(new StudentSubjectMarks { StudentId = 2, SubjectName = "Science", Marks = 64 });
            marks.Add(new StudentSubjectMarks { StudentId = 2, SubjectName = "Nepali", Marks = 67 });
            marks.Add(new StudentSubjectMarks { StudentId = 2, SubjectName = "English", Marks = 36 });
            marks.Add(new StudentSubjectMarks { StudentId = 3, SubjectName = "Math", Marks = 40 });
            marks.Add(new StudentSubjectMarks { StudentId = 3, SubjectName = "Science", Marks = 64 });
            marks.Add(new StudentSubjectMarks { StudentId = 3, SubjectName = "Nepali", Marks = 67 });
            marks.Add(new StudentSubjectMarks { StudentId = 3, SubjectName = "English", Marks = 56 });
            marks.Add(new StudentSubjectMarks { StudentId = 4, SubjectName = "Math", Marks = 40 });
            marks.Add(new StudentSubjectMarks { StudentId = 4, SubjectName = "Science", Marks = 64 });
            marks.Add(new StudentSubjectMarks { StudentId = 4, SubjectName = "Nepali", Marks = 67 });
            marks.Add(new StudentSubjectMarks { StudentId = 4, SubjectName = "English", Marks = 56 });
        }

        public void LinqImplV2()
        {
            var names = (from s in students select s.Name);
            names = students.Select(s => s.Name);

            var nameandEmail = (from s in students where s.Email.Contains("gmail") select new NameAndEmail { Name = s.Name, Email = s.Email });
            nameandEmail = students.Where(s => s.Email.Contains("gmail")).Select(s => new NameAndEmail { Name = s.Name, Email = s.Email });

            var subjectMarks = (from s in students join m in marks on s.id equals m.StudentId select new { StudentName = s.Name, StudentEmail = s.Email, Subject = m.SubjectName, Marks = m.Marks });

            var total = marks.GroupBy(p => p.StudentId).Select(p => new { Id = p.Key, Total = p.Sum(x => x.Marks), Percentage = p.Sum(x => x.Marks) / 4 });
        }
    }

    public class NameAndEmail
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }

    public class Student
    {
        public Student()
        {
        }

        public Student(int id, string name, string email)
        {
            this.id = id;
            this.Name = name;
            this.Email = email;
        }

        public int id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }

    public class StudentSubjectMarks
    {
        public int StudentId { get; set; }
        public string SubjectName { get; set; }
        public int Marks { get; set; }
    }
}