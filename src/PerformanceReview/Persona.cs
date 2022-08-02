using System;

namespace PerformanceReview
{
    public class Persona
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }

        public Persona(string name, string email, DateTime birthday) {
            Name = name;
            Email = email;
            Birthday = birthday;
        }
    }
}