using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312POEPART1
{
    internal class EventsAndAnnouncements
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date  { get; set; }
        public string Location { get; set; }       
        public string Category { get; set; }

        public EventsAndAnnouncements(string title, string description, DateTime date, string location,string category)
        {
            Title = title;
            Description = description;
            Date = date;
            Location = location;            
            Category = category;
        }
    }
}
