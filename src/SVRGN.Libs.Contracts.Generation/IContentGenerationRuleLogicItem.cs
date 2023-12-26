using SVRGN.Libs.Contracts.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVRGN.Libs.Contracts.Generation
{
    public interface IContentGenerationRuleLogicItem : IBaseObject
    {
        #region Properties

        string Prerequisite { get; }
        string Consequence { get; }

        #endregion Properties
    }
}
