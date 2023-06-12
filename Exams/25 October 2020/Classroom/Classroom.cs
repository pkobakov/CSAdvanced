using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomProject
{
    public class Classroom
    {
        private int capacity;
        private List<Student> students;
        public Classroom(int capacity)
        {
            this.Capacity = capacity;
            students = new List<Student>(); 
        }

        public int Capacity { get; set; }
        public int Count { get { return this.students.Count; } }

        public string RegisterStudent(Student student) 
        {
            if (this.Capacity <= this.Count) 
            {
                return "No seats in the classroom";
            }

            this.students.Add(student);

            return $"Added student {student.FirstName} {student.LastName}";
        }

        public string DismissStudent(string firstName, string lastName) 
        {
            if (!this.students.Any( s => s.FirstName == firstName && s.LastName == lastName))
            {
                return "Student not found";
            }

            Student student = this.students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);
            this.students.Remove(student);

            return $"Dismissed student {firstName} {lastName}";

        }

        public string GetSubjectInfo(string subject) 
        {
            var sortedStudents = this.students.Where(s => s.Subject == subject).ToList();

            if (sortedStudents.Count == 0)
            {
                return "No students enrolled for the subject";
            }

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Subject: {subject}");
            stringBuilder.AppendLine("Students:");

            foreach (var student in sortedStudents)
            {
                stringBuilder.AppendLine($"{student.FirstName} {student.LastName}");
            }

            return stringBuilder.ToString().TrimEnd();    
        }

        public int GetStudentsCount() => this.students.Count;

        public Student GetStudent(string firstName, string lastName) => this.students.FirstOrDefault(s => s.FirstName == firstName &&
                                                                                                          s.LastName == lastName);
    }
}
