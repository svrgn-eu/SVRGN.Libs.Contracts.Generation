using SVRGN.Libs.Contracts.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVRGN.Libs.Contracts.Generation
{
    public interface IContentGenerationRule : IName
    {
        #region Properties

        bool IsSyntacticallyOk { get; }

        List<string> Conditions { get; }
        string Order { get; }
        string Choice { get; }
        List<IContentGenerationRuleLogicItem> LogicItems { get; }

        #endregion Properties

        #region Methods

        string GetOriginalText();

        #endregion Methods
    }
}
