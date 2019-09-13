using System;
using System.Collections.Generic;
using System.Text;

namespace LoginPractice.Models
{
    class Student
    {
        public string matricula { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public bool active { get; set; }
    }
}
