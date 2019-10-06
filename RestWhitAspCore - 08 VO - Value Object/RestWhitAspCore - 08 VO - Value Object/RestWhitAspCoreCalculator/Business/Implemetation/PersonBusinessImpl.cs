using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using RestWhitAspCoreUdemy.Data.Converters;
using RestWhitAspCoreUdemy.Data.VO;
using RestWhitAspCoreUdemy.Model;
using RestWhitAspCoreUdemy.Model.Context;
using RestWhitAspCoreUdemy.Repository;
using RestWhitAspCoreUdemy.Repository.Generic;

namespace RestWhitAspCoreUdemy.Business.Implemetation
{
    public class PersonBusinessImpl : IPersonBusiness
    {
        private IRepository<Person> _repository;

        private readonly PersonConverter _converter;

        public PersonBusinessImpl(IRepository<Person> repository)
        {
            _repository = repository;
            _converter = new PersonConverter();
        }

        public PersonVO Create(PersonVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Create(personEntity);
            return _converter.Parse(personEntity);
        }

        public PersonVO Update(PersonVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Update(personEntity);
            return _converter.Parse(personEntity);
        }

        public PersonVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public List<PersonVO> FindAll()
        {
            return _converter.ParseList(_repository.FindAll());
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
