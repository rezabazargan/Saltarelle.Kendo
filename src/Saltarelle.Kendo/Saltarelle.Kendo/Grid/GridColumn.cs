using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Saltarelle.Kendo.Grid
{
    [Imported]
    [IgnoreNamespace]
    public sealed class GridColumn
    {
        #region [properties]
        public bool Encoded { get; set; }
        public string Field { get; set; }
        public string Title { get; set; }
        #endregion
    }
}
