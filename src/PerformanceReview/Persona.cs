using System;
using System.Collections.Generic;
using System.Linq;

namespace PerformanceReview
{
    public class Persona
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }

        List<string> ToEmails(List<Persona> people)
        {
            var myEmailList = from person in people
                select person.Email;
            return myEmailList.ToList();
        }

        Persona DateGreaterThan(List<Persona> people, DateTime date)
        {
            var query = people.Where(p => p.Birthday > date);
            var firstOne = query.First();
            return firstOne;
        }
        
    }
}