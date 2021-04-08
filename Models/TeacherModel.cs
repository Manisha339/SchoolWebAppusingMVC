using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class TeacherModel : BaseModel
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime DateOfJoining { get; set; }

    }
}
