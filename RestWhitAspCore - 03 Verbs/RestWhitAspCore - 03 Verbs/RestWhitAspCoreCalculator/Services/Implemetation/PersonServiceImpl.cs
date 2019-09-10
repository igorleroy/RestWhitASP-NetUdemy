using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using RestWhitAspCoreUdemy.Model;

namespace RestWhitAspCoreUdemy.Services.Implemetation
{
    public class PersonServiceImpl : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for(int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }

        public Person FindById(long id)
        {
            return new Person
            {
                Id = ImplementAndGet(),
                FirstName = "Igor",
                LastName = "Oliveira",
                Gender = "Male",
                Adress = "Belo Horizonte - MG - Brasil"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = ImplementAndGet(),
                FirstName = "Person Name - " + i,
                LastName = "Person Last Name - " + i,
                Gender = "Male",
                Adress = "Some Adress - " + i
            };
        }

        private long ImplementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
