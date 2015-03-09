using jQueryApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Saltarelle.Kendo.Window
{
    [Imported]
    [IgnoreNamespace]
    public sealed class WindowObject
    {
        #region [Properties]
        public WindowOption Options
        {
            get;
            set;
        }


        public jQueryObject Wrapper { get; set; }


        #endregion

        #region [Methods]
        public WindowObject Title(string t)
        {
            return null;
        }
        public WindowObject Restore()
        {
            return null;
        }

        public WindowObject Refresh()
        {
            return null;
        }
        public WindowObject Refresh(object o)
        {
            return null;
        }

        public WindowObject Open()
        {
            return null;
        }

        public WindowObject Maximize()
        {
            return null;
        }
        public WindowObject Minimize()
        {
            return null;
        }

        public WindowObject Close()
        {
            return null;
        }

        public WindowObject Destroy()
        {
            return null;
        }

        public WindowObject Content(string c)
        {
            return null;
        }
        public WindowObject Center()
        {
            return null;
        }
        #endregion
    }
}
