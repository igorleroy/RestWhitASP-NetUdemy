using RestWhitAspCoreUdemy.Data.VO;
using RestWhitAspCoreUdemy.Model;
using System.Collections.Generic;

namespace RestWhitAspCoreUdemy.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO person);
        PersonVO FindById(long id);
        List<PersonVO> FindAll();
        PersonVO Update(PersonVO person);
        void Delete(long id);
    }
}
