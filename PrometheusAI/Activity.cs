using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrometheusAI
{
    public interface Activity
    {
        void Perform(State state);

        bool CanPerform(State state);

        State Outcome(State state);

        float GetCost();
    }
}
