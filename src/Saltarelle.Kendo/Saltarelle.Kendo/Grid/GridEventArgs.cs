using System;
using System.Collections.Generic;
using System.Html;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Saltarelle.Kendo.Grid
{
    [Imported]
    [IgnoreNamespace]
    public sealed class GridEventArgs : EventArgs
    {
        public Element CurrentTarget;
        public Element DelegateTarget;

        public bool AltKey;
        public bool Bubbles;
        public bool Cancelable;
        public bool ClientX;
        public bool ClientY;
        public bool CtrlKey;

        public string BaseURI;
    }
}
