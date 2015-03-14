using jQueryApi;
using Saltarelle.Kendo.Data;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Saltarelle.Kendo.Grid
{
    [Imported]
    [IgnoreNamespace]
    public sealed class GridPager
    {
        public DataSource DataSource;
        public jQueryObject Element;
        public jQueryObject List;
        public PagingOption Options;

        #region [Methods]
        public void Destroy()
        { }

        /// <summary>
        /// Page To
        /// </summary>
        /// <param name="p"></param>
        public void Page(int p) { }

        public int PageSize()
        {
            return 0;
        }
        public int TotalPages()
        {
            return 0;
        }


        #endregion
    }
}
