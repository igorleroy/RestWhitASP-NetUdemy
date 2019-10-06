using System.Collections.Generic;

namespace RestWhitAspCoreUdemy.Data.Converter
{
    public interface IParser<D, O>
    {
        D Parse(O origin);
        List<D> ParseList(List<O> origin);
    }
}
