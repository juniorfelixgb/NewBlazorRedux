using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewBlazorRedux.Store.Counter
{
    public record CounterState
    {
        public int Count { get; init; }
    }
}
