using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrometheusAI;

namespace UnitTests.tests
{
    class FakeState : State
    {

        public bool ApplyCalled { get; private set; }
        public bool ContainsCalled { get; private set; }

        private readonly bool ContainsReturns; 

        public FakeState(bool ContainsReturns = true)
        {
            ApplyCalled = false;
            ContainsCalled = false;

            this.ContainsReturns = ContainsReturns;
        }

        public object GetProperty(string key)
        {
            throw new NotImplementedException();
        }

        public void SetProperty(string key, object value)
        {
            throw new NotImplementedException();
        }

        public bool TryGetProperty(string key, out object value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<KeyValuePair<string, object>> GetProperties()
        {
            throw new NotImplementedException();
        }

        public void ClearProperties()
        {
            throw new NotImplementedException();
        }

        public bool ClearProperty(string key)
        {
            throw new NotImplementedException();
        }

        public bool HasProperty(string key)
        {
            throw new NotImplementedException();
        }

        public State Differences(State state)
        {
            throw new NotImplementedException();
        }

        public bool Contains(State subState)
        {
            ContainsCalled = true;
            return ContainsReturns;
        }

        public void Apply(State applyState)
        {
            ApplyCalled = true;
        }
    }
}
