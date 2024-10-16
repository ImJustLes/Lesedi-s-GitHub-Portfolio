namespace ATS_System.Models
{
    public class Tutor
    {
        public int UID { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Location { get; set; }
        public List<string> Subjects { get; set; }
        public List<string> Levels { get; set; }
        public List<DateTime> Availability { get; set; }
        public double Payement { get; set; }

        public Tutor(string firstname, string surname, string location, List<string> subjects, List<string> levels, List<DateTime> availability, double payement)
        {
            Firstname = firstname;
            Surname = surname;
            Location = location;
            Subjects = subjects;
            Levels = levels;
            Availability = availability;
            Payement = payement;
        }
    }
}
