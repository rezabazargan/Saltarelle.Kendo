using jQueryApi;
using Saltarelle.Kendo.Data;
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

        public List<JsDictionary<string,object>> DataItems()
        {
            return null;
        }

        public void Refresh(bool r)
        {

        }

        public void SetOptions(GridOptions op)
        {

        }
        public void SetDataSource(DataSource ds)
        {

        }
        public void SaveAsExcel  (){}
        public void SaveAsPDF    (){} 
        public void SaveChanges  (){}
        public void SaveRow() { }
        public void AddRow() { }
        public void CancelChanges() { }
        public void CancelRow() { }
        public void ClearSelection() { }
        public void Destroy() { }
        public GridOptions GetOptions()
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
        public jQueryObject Content;
        public jQueryObject Scrollables;

        #endregion

        public DataSource DataSource;
        public GridPager Pager;

        
        #endregion


    }
}
