using BlazorPdfExample.Data;
using BlazorPdfExample.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorPdfExample.DB;

namespace BlazorPdfExample.Service
{
    public class StudentService : IStudentService
    {
        DatabaseClass oDatabaseClass = new DatabaseClass();

        public Student GetStudent(int studendId)
        {
            return oDatabaseClass.GetStudents().FirstOrDefault(m => m.StudentId.Equals(studendId));
        }

        public List<Student> GetStudents()
        {
            return oDatabaseClass.GetStudents();
        }
    }
}
