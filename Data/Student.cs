using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPdfExample.Data
{
    public class Student
    {
        public int StudentId { get; set; } = 0;
        public string Name { get; set; } = "";
        public string Roll { get; set; } = "";
        public string Section { get; set; } = "";
        public string Group { get; set; } = "";

        public List<MarkSheet> MarkSheets { get; set; } = new List<MarkSheet>();

    }
}
