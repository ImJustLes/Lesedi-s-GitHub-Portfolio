using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312POEPART1
{
    internal class Feedback
    {
        //Properties that define feedback
        public string Location { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }

        //Constructor used for storing feedback in objects.
        public Feedback(string location, string email, string description)
        {
            Location = location;
            Email = email;
            Description = description;
        }
    }
}
