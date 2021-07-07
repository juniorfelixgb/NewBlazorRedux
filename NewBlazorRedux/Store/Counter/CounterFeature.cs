using Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewBlazorRedux.Store.Counter
{
    public class CounterFeature : Feature<CounterState>
    {
        public override string GetName() => nameof(CounterState);

        protected override CounterState GetInitialState()
        {
            return new CounterState
            {
                Count = 0
            };
        }
    }
}
