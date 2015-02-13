using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrometheusAI
{
    public interface State
    {
        object GetProperty(string key);
        void SetProperty(string key, object value);
        bool TryGetProperty(string key, out object value);
        IEnumerable<KeyValuePair<string, object>> GetProperties();

        void ClearProperties();
        bool ClearProperty(string key);

        bool HasProperty(string key);
        
        State Differences(State state);
    }
}
