using Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewBlazorRedux.Store.Counter
{
    public static class CounterReducer
    {
        [ReducerMethod]
        public static CounterState OnAddCounter(CounterState state, CounterAction action)
        {
            return state with
            {
                Count = state.Count + 1
            };
        }
    }
}
