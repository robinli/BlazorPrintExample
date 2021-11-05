using BlazorPdfExample.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPdfExample.IService
{
    public interface IStudentService
    {
        public List<Student> GetStudents();

        public Student GetStudent(int studendId);
    }
}
