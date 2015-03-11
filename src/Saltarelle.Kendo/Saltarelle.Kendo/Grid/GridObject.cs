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
        public GridColumn[] Columns 
        { 
            get 
            { 
                return null; 
            } 
        }

        #region [jQuery Elements]
        public jQueryObject Element 
        { 
            get 
            { 
                return null; 
            } 
        }
        public jQueryObject Footer 
        { 
            get 
            { 
                return null; 
            } 
        }
        public jQueryObject Table 
        { 
            get 
            { 
                return null; 
            } 
        }
        public jQueryObject Tbody 
        { 
            get 
            { 
                return null;
            }
        }
        public jQueryObject Thead 
        { 
            get 
            { 
                return null; 
            } 
        }
        public jQueryObject Wrapper 
        { 
            get 
            { 
                return null; 
            } 
        }

        #endregion


        #endregion
    }
}
