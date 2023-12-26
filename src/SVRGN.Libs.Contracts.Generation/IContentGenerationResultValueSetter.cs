using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVRGN.Libs.Contracts.Generation
{
    /// <summary>
    /// <see cref="https://stackoverflow.com/questions/5041664/t-must-be-contravariantly-valid">Covariance vs Contravariance</see>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IContentGenerationResultValueSetter<T>
    {
        #region Properties

        #endregion Properties

        #region Methods

        void SetValue(T NewValue);

        #endregion Methods
    }
}
