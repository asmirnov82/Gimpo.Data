﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Gimpo.Data.Analysis
{
    public interface IRowCollection : IDataFrameView
    {
        DataFrameRow this[long rowIndex] { get; }
        long Count { get; }
    }
}
