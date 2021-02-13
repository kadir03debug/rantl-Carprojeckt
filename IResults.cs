using System;
using System.Collections.Generic;
using System.Text;

namespace core.Utilities.Results
{
    public interface IResults
    {
        bool SUCCESS { get; }
        string Message { get; }

    }
}
