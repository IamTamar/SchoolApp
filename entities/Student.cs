﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entities { 

    public partial class Student
    {
        public int Id { get; set; }
    
        public string FirstName { get; set; }
    
        public string LastName { get; set; }
    
        public string HomePhone { get; set; }
    
        public int BirthdayYear { get; set; }
    
        public string Class { get; set; }
    
        public string Address { get; set; }
    }

}