using jQueryApi;
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
    public sealed class GridObject
    {

        #region [Methods]

        /// <summary>
        /// return dataitem of the current row
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tr"> current row </param>
        /// <returns></returns>
        public T DataItem<T>(jQueryObject tr)
            where T:class
        {
            return null;
        }
        public object DataItem(jQueryObject tr)
        {
            return null;
        }

        #endregion

        #region [properies]
        public GridColumn[] Columns;

        #region [jQuery Elements]
        public jQueryObject Element;
        public jQueryObject Footer;
        public jQueryObject Table;
        public jQueryObject Tbody;
        public jQueryObject Thead;
        public jQueryObject Wrapper;

        #endregion


        #endregion
    }
}
