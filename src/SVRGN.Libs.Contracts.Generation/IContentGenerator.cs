using SVRGN.Libs.Contracts.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVRGN.Libs.Contracts.Generation
{
    public interface IContentGenerator : IName
    {
        #region Properties

        #endregion Properties

        #region Methods

        #region AddRule: adds a rule if a rule with the same name does not yet exist
        /// <summary>
        /// adds a rule if a rule with the same name does not yet exist
        /// </summary>
        /// <param name="NewRule">the new rule to be added</param>
        /// <returns>true, if the rule did not exists previously and there was no error adding it</returns>
        bool AddRule(IContentGenerationRule NewRule);
        bool AddStep(IContentGenerationStep NewStep);
        IContentGenerationResult<T> Generate<T>(params object[] Parameters) where T : IEquatable<T>, ICloneable;
        int GetNumberOfSteps();

        #endregion AddRule

        #endregion Methods
    }
}
