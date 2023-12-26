using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVRGN.Libs.Contracts.Generation
{
    public interface IContentGenerationResult<T> : IContentGenerationResultReadOnly<T>, IContentGenerationResultValueSetter<T>
    {

    }
}
