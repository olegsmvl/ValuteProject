using System;
using System.Collections.Generic;
using System.Text;

namespace ModelCourse
{
    public class Course
    {
        public Guid Id { get; set; }
        public string Date { get; set; }
        public string PreviousDate { get; set; }
        public string PreviousURL { get; set; }
        public string Timestamp { get; set; }
        public Valute Valute { get; set; }
    }
}
