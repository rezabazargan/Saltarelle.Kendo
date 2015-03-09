using jQueryApi;
using Saltarelle.Kendo.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Saltarelle.Kendo
{
    [Imported]
    [IgnoreNamespace]
    public static class Extensions
    {
        [InstanceMethodOnFirstArgument]
        [ScriptName("kendoWindow")]
        public static jQueryObject KendoWindow(this jQueryObject obj,WindowOption o)
        {
            return null;
        }
    }
}
