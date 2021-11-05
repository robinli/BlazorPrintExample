using BlazorPdfExample.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPdfExample.DB
{
    public class DatabaseClass
    {
        public List<Student> _oStudent { get; set; } = new List<Student>();
        public List<MarkSheet> _oMarkSheet { get; set; } = new List<MarkSheet>();

        public DatabaseClass()
        {
            _oStudent = new List<Student>();

            for (int i = 0; i <= 9; i++)
            {
                _oStudent.Add(new Student()
                {
                    StudentId = i,
                    Name = "Stu" + i,
                    Roll = "100" + i,
                    Section = "S" + i,
                    Group = "G" + i,
                    MarkSheets = this.GetMarkSheets(i)
                });
            }
        }

        private List<MarkSheet> GetMarkSheets(int studendId)
        {
            Random rnd = new Random();
            _oMarkSheet = new List<MarkSheet>();
            for (int m = 0; m <= 5; m++)
            {
                _oMarkSheet.Add(new MarkSheet()
                {
                    MarkSheetId = m,
                    Subject = "Sub" + rnd.Next(1, 100),
                    Mark = rnd.Next(1, 100),
                    StudentId = studendId
                });
            }
            return _oMarkSheet;
        }

        public List<Student> GetStudents()
        {
            return _oStudent;
        }
    }
}
