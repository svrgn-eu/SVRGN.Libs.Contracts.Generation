using SVRGN.Libs.Contracts.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVRGN.Libs.Contracts.Generation
{
    public interface IContentGenerationResultReadOnly<out T> : IBaseObject, IName
    {
        #region Properties

        bool IsFinal { get; }

        T Value { get; }

        IList<IError> Errors { get; }

        #endregion Properties

        #region Methods

        void SetFinalized();
        void AddError(IError Error);

        #endregion Methods
    }
}
