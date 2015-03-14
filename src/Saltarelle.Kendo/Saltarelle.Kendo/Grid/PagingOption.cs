using Saltarelle.Kendo.Data;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Saltarelle.Kendo.Grid
{
    [Imported]
    [IgnoreNamespace]
    public sealed class PagingOption
    {
        public bool AutoBind;
        public int ButtonCount;
        public DataSource DataSource;
        public bool Info;
        public bool Input;
        public string LinkTemplate;
        public PagingMessage Messages;
        public string Name;
        public bool Numeric;
        public bool PageSizes;
        public string Prefix;
        public bool PreviousNext;
        public bool Refresh;
        public string SelectTemplate;
    }
}
