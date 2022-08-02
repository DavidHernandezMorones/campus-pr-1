using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PerformanceReview {
	class Program {
		static async Task PrepararCafe(int segundos) {
			await Task.Delay(segundos * 1000);
			Console.WriteLine("Cafe listo!");
		}

		static async Task Contar(int segundos) {
			for (int i = 1; i <= segundos; i++) {
				await Task.Delay(1000);
				Console.WriteLine($"Han pasado: {i} segundos");
			}
		}

		static void Main(string[] args) {
			Func<double, double, double> suma = (num1, num2) => num1 + num2;

			Func<double, double, double> resta = (num1, num2) => num1 - num2;

			Action throwsDivideByZero = () => throw new DivideByZeroException();

			Func<double, double, Action, double> divide = (num1, num2, action) => {
															if (num2 == 0)
																action();
															return num1 / num2;
														};

			// Console.WriteLine(suma(5, 7));
			// Console.WriteLine(resta(5, -16.5));
			// Console.WriteLine(divide(5, 5, throwsDivideByZero));
			//
			Persona persona1 = new Persona("pablo", "pablo3@mail.com", new DateTime(1998, 11, 25));
			Persona persona2 = new Persona("carlos", "carlos@mail.com", new DateTime(1998, 7, 8));
			Persona persona3 = new Persona("menganito", "menganito@mail.com", new DateTime(1987, 1, 17));
			Persona persona4 = new Persona("pablito", "pablito@mail.com", new DateTime(1988, 5, 19));
			Persona persona5 = new Persona("jorge", "jorge@mail.com", new DateTime(2000, 8, 2));
			Persona persona6 = new Persona("Jose", "jose@mail.com", new DateTime(2002, 9, 25));
			List<Persona> people = new List<Persona>();

			people.Add(persona1);
			people.Add(persona2);
			people.Add(persona3);
			people.Add(persona4);
			people.Add(persona5);
			people.Add(persona6);

			List<string> emails = people.ToEmails();
			DateTime fechaFiltro = new DateTime(1998, 6, 15);
			Persona primeraPersona = people.FirstPersonInDate(fechaFiltro);

			//
			// emails.ForEach(x => Console.WriteLine(x));
			//
			// Console.WriteLine($"Primer persona con fecha de nacimiento mayor a una fecha dada {fechaFiltro:d}: ");
			// Console.WriteLine($"Nombre: {primeraPersona.Name}");
			// Console.WriteLine($"Fecha de nacimiento: {primeraPersona.Birthday.ToShortDateString()}");


			Task cafeTask = PrepararCafe(3);
			Task contarTask = Contar(4);

			Task[] taskArray = { PrepararCafe(5), Contar(3) };
			Task.WaitAll(taskArray);
		}
	}
}