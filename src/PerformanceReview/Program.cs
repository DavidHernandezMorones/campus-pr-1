using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerformanceReview
{
    class Program
    {
        static List<string> ToEmails(List<Persona> people)
        {
            var myEmailList = from person in people
                select person.Email;
            return myEmailList.ToList();
        }

        static Persona FirstYoungerThan(List<Persona> people, DateTime date)
        {
            var query = people.Where(p => p.Birthday > date);
            var firstOne = query.First();
            return firstOne;
        }

        static List<Persona> people = new List<Persona>()
        {
            new Persona()
            {
                Name = "pablo",
                Email = "pablo3@mail.com",
                Birthday = new DateTime(1998, 11, 25)
            },
            new Persona()
            {
                Name = "carlos",
                Email = "carlos@mail.com",
                Birthday = new DateTime(1998, 7, 8)
            },
            new Persona()
            {
                Name = "menganito",
                Email = "menganito@mail.com",
                Birthday = new DateTime(1987, 1, 17)
            },
            new Persona()
            {
                Name = "pablito",
                Email = "pablito@mail.com",
                Birthday = new DateTime(1988, 5, 19)
            },
            new Persona()
            {
                Name = "jorge",
                Email = "jorge@mail.com",
                Birthday = new DateTime(2000, 8, 2)
            },
            new Persona()
            {
                Name = "Jose",
                Email = "jose@mail.com",
                Birthday = new DateTime(2002, 9, 25)
            }
        };

        static void Main(string[] args)
        {
            var emails = ToEmails(people);
            DateTime fechaFiltro = new DateTime(1998, 6, 15);
            Persona persona = FirstYoungerThan(people, fechaFiltro);
            
            emails.ForEach(x => Console.WriteLine(x));

            Console.WriteLine(persona.Name);
            Console.WriteLine(persona.Birthday);
            Func<double, double, double> suma = (num1, num2) => { return num1 + num2; };

            Func<double, double, double> resta = (num1, num2) => { return num1 - num2; };

            Action throwsDivideByZero = () => throw new DivideByZeroException();

            Func<double, double, Action, double> divide = (num1, num2, action) =>
            {
                if (num2 == 0)
                    action();
                return num1 / num2;
            };

            var cafeTask = PrepararCafe(5);
            var contarTask = Contar(4);

            Task.WaitAll(cafeTask, contarTask);
        }

        static async Task PrepararCafe(int segundos)
        {
            await Task.Delay(segundos * 1000);
            Console.WriteLine("Cafe listo!");
        }

        static async Task Contar(int segundos)
        {
            for (int i = 1; i <= segundos; i++)
            {
                await Task.Delay(i * 1000);
                Console.WriteLine($"Han pasado: {i} segundos");
            }
        }
    }
}