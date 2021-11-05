using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPdfExample.Data
{
    public class MarkSheet
    {
        public int MarkSheetId { get; set; } = 0;

        public string Subject { get; set; } = "";

        public int Mark { get; set; } = 0;

        public string Grade => this.CalculateGrade(this.Mark);

        public int StudentId { get; set; } = 0;

        private string CalculateGrade(int mark)
        {
            string grade = "";
            if (mark < 60) return "F";
            else if (mark >= 60 && mark < 70) return "D";
            else if (mark >= 70 && mark < 80) return "C";
            else if (mark >= 80 && mark < 90) return "B";
            else if (mark >= 90 && mark <= 100) return "A";
            return grade;
        }
    }
}
