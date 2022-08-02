using System;
using System.Collections.Generic;
using PerformanceReview;
using Xunit;
namespace LINQTesting
{
    public class PersonaMethodTest
    {
       [Fact]
		public void ToEmails_ShouldReturnListOfEmails() {
			// Arrange 
			Persona persona1 = new Persona("pablo","pablo3@mail.com", new DateTime(1998, 11, 25));
			Persona persona2 = new Persona("carlos", "carlos@mail.com",new DateTime(1998, 7, 8));
			Persona persona3 = new Persona("menganito", "menganito@mail.com", new DateTime(1987, 1, 17));
			Persona persona4 = new Persona("pablito", "pablito@mail.com", new DateTime(1988, 5, 19));
			Persona persona5 = new Persona("jorge", "jorge@mail.com", new DateTime(2000, 8, 2));
			Persona persona6 = new Persona("Jose", "jose@mail.com", new DateTime(2002, 9, 25));
			List<Persona> people = new List<Persona>();
			List<string> peopleEmails = new List<string>();
			List<string> emailsExpected = new List<string>();
			
			people.Add(persona1);
			people.Add(persona2);
			people.Add(persona3);
			people.Add(persona4);
			people.Add(persona5);
			people.Add(persona6);

			emailsExpected.Add("pablo3@mail.com");
			emailsExpected.Add("carlos@mail.com");
			emailsExpected.Add("menganito@mail.com");
			emailsExpected.Add("pablito@mail.com");
			emailsExpected.Add("jorge@mail.com");
			emailsExpected.Add("jose@mail.com");
			// Act
			peopleEmails = people.ToEmails();
			
			// Assert
			Assert.Equal(emailsExpected, peopleEmails);
		}

		[Fact]
		public void FirstPersonInDate_ShouldReturnFirstPerson_Given_A_Date() {
			// Arrange 
			Persona persona1 = new Persona("pablo","pablo3@mail.com", new DateTime(1998, 11, 25));
			Persona persona2 = new Persona("carlos", "carlos@mail.com",new DateTime(1998, 7, 8));
			Persona persona3 = new Persona("menganito", "menganito@mail.com", new DateTime(1987, 1, 17));
			Persona persona4 = new Persona("pablito", "pablito@mail.com", new DateTime(1988, 5, 19));
			Persona persona5 = new Persona("jorge", "jorge@mail.com", new DateTime(2000, 8, 2));
			Persona persona6 = new Persona("Jose", "jose@mail.com", new DateTime(2002, 9, 25));
			List<Persona> people = new List<Persona>();
			DateTime fechaFiltro = new DateTime(1998, 6, 15);
			
			people.Add(persona1);
			people.Add(persona2);
			people.Add(persona3);
			people.Add(persona4);
			people.Add(persona5);
			people.Add(persona6);
			
			// Act
			Persona primeraPersona = people.FirstPersonInDate(fechaFiltro);
			
			// Assert
			Assert.Equal(persona1, primeraPersona);
		}
    }
}