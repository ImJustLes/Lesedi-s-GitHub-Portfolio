using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312POEPART1
{
    internal class Issue
    {
        //Properties for reporting an issue
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string MediaFilePath { get; set; }

        //Constructor used to store the issues as objects.
        public Issue(string location, string category, string description, string mediaFilePath)
        {
            Location = location;
            Category = category;
            Description = description;
            MediaFilePath = mediaFilePath;
        }
    }
}
