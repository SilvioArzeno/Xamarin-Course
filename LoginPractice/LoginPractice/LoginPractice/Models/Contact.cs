using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoginPractice.Models
{
    class Contact
    {
        [PrimaryKey , AutoIncrement]
        public int ID { get; set; }
        [MaxLength(100)]
        public string FirstName { get; set; }
        [MaxLength(100)]
        public string LastName  { get; set; }
        [MaxLength(100)]
        public string Company { get; set; }
        [MaxLength(100)]
        public string PhoneNumber { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
    }

}
