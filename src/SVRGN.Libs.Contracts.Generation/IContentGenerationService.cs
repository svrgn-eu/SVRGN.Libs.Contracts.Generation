using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVRGN.Libs.Contracts.Generation
{
    public interface IContentGenerationService
    {
        #region Properties

        #endregion Properties

        #region Methods

        IContentGenerator CreateGenerator(string Name);

        #endregion Methods
    }
}
