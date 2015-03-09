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
    [Serializable]
    public sealed class WindowOption
    {
	//jQuery(function(){jQuery("#window").kendoWindow({"modal":false,"iframe":true,"draggable":true,"pinned":false,"title":"Rams\u0027s Ten Principles of Good Design","resizable":true,"content":"/razor/web/Window/AjaxContent","actions":["Close"]});});
        public string[] Actions { get; set; }
        public string  Content { get; set; }
        public bool Modal { get; set; }
        public bool Iframe { get; set; }
        public bool Draggable { get; set; }
        public bool Pinned { get; set; }
        public string Title { get; set; }
        public bool Resizable { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public bool AutoFocus { get; set; }
        public bool Visible { get; set; }

    }
}
