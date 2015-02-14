using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrometheusAI
{
    public interface Planner<out T>
    {
        T Plan(State startState, State endState);
    }
}
