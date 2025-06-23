using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entities;
using DLL;
using System.Data.SQLite;
using static DLL.FileConnection;

namespace BAL
{
    public partial class functions
    {
        List<Student> students;
        List<Teacher> teachers;
        List<string> classes;

        FileConnection connection;
        public functions()
        {
        }
        public List<Student> readAllStudents()
        {
            students = new List<Student>();
            connection = new FileConnection();

            var reader = connection.DBConnection("Students");

            while (reader.Read())
            {
                Student student = new Student
                {
                    Id = (int)reader["ID"],
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    HomePhone = reader["HomePhone"].ToString(),
                    BirthdayYear = (int)reader["BirthdayYear"],
                    Class = reader["Class"].ToString(),
                    Address = reader["Address"].ToString()
                };
                students.Add(student);
            }
            reader.Close();
            return students;
        }
        public List<Teacher> readAllTeachers()
        {
            teachers = new List<Teacher>();

            connection = new FileConnection();
            var reader = connection.DBConnection("Teachers");

            while (reader.Read())
            {
                Teacher teacher = new Teacher
                {
                    Id = (int)reader["ID"],
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    Phone = reader["Phone"].ToString(),
                    MailAddress = reader["MailAddress"].ToString()
                };
                teachers.Add(teacher);
            }
            reader.Close();
            return teachers;
        } public List<string> readAllClasses()
        {
            classes = new List<string>();
            string c = "ALL";
            classes.Add(c);
            connection = new FileConnection();
            var reader = connection.DBConnection("HomeroomTeacherOfClass");

            while (reader.Read())
            {
                classes.Add(reader["Class"].ToString());
            }
            reader.Close();
            return classes;
        }
    }
}
