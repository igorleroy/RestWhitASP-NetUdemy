using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using RestWhitAspCoreUdemy.Model;
using RestWhitAspCoreUdemy.Model.Context;
using RestWhitAspCoreUdemy.Repository;

namespace RestWhitAspCoreUdemy.Business.Implemetation
{
    public class PersonBusinessImpl : IPersonBusiness
    {
        private IPersonRepository _repository;

        public PersonBusinessImpl(IPersonRepository repository)
        {
            _repository = repository;
        }

        public Person Create(Person person)
        {
            return _repository.Create(person);
        }

        public Person Update(Person person)
        {
            return _repository.Update(person);
        }

        public Person FindById(long id)
        {
            return _repository.FindById(id);
        }

        public List<Person> FindAll()
        {
            return _repository.FindAll();
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
