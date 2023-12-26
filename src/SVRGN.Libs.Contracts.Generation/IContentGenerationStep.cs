using SVRGN.Libs.Contracts.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVRGN.Libs.Contracts.Generation
{
    public interface IContentGenerationStep : IOrderBy, IName
    {
        #region Properties

        bool HasBeenUsed { get; }

        #endregion Properties

        #region Methods

        IContentGenerationResult<T> Process<T>(IContentGenerationResult<T> PreviousResult, IContentGenerationRule[] Rules, params object[] Parameters) where T : IEquatable<T>, ICloneable;

        #endregion Methods
    }
}
