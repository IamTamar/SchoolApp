using System;
using System.Collections.Generic;

namespace entities
{
    public partial class TeacherOfSubjectInClass
    {
        public int? IdTeacher { get; set; }

        public int? IdSubject { get; set; }

        public string Class { get; set; }
    }
}

