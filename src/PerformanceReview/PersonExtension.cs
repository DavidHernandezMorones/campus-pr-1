using System;
using System.Collections.Generic;
using System.Linq;

namespace PerformanceReview {
	public static class PersonExtension {
		public static List<string> ToEmails(this List<Persona> people) {
			return people.Select(p => p.Email).ToList();
		}

		public static Persona FirstPersonInDate(this List<Persona> people, DateTime date) {
			var peopleAfterDate = people.Where(p => p.Birthday > date);
			return peopleAfterDate.FirstOrDefault();
		}
	}
}