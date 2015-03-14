using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Saltarelle.Kendo.Data
{
    [Imported]
    [IgnoreNamespace]
    public sealed class DataSourceOption
    {
        public int Total;
        public int Page;
        public int PageSize;

        public DataSourceSchema Schema;
    }
}
