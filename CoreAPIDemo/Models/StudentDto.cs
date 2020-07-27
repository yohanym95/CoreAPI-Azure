using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAPIDemo.Models
{
    public class StudentDto
    {

        public Guid StudentId { get; set; }
   
        public string FirstName { get; set; }
 
        public string LastName { get; set; }
 
        public string City { get; set; }

        public string MobileNumber { get; set; }

        public string Email { get; set; }

    }
}
