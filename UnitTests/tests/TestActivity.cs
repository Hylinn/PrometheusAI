using System;
using PrometheusAI;

namespace UnitTests.tests
{
    class TestActivity : Activity
    {
        public bool IsValidContextPreconditionCalled { get; private set; }
        public bool IsValidPreconditionCalled { get; private set; }
        public bool ApplyContextEffectCalled { get; private set; }
        public bool ApplyEffectCalled { get; private set; }

        private readonly bool ValidContextPrecondition;
        private readonly bool ValidPrecondition;

        public TestActivity(bool ValidContextPrecondition = true, bool ValidPrecondition = true)
        {
            this.ValidContextPrecondition = ValidContextPrecondition;
            this.ValidPrecondition = ValidPrecondition;

            IsValidContextPreconditionCalled = false;
            IsValidPreconditionCalled = false;
            ApplyContextEffectCalled = false;
            ApplyEffectCalled = false;
        }

        protected override State Precondition
        {
            get { return new FakeState(); }
        }

        protected override State Effect
        {
            get { return new FakeState(); }
        }

        protected override bool IsValidContextPrecondition(State startState)
        {
            IsValidContextPreconditionCalled = true;
            return ValidContextPrecondition;
        }

        protected override bool IsValidPrecondition(State startState)
        {
            IsValidPreconditionCalled = true;
            return ValidPrecondition;
        }

        protected override void ApplyContextEffect(State startState)
        {
            ApplyContextEffectCalled = true;
        }

        protected override void ApplyEffect(State startState)
        {
            ApplyEffectCalled = true;
        }
    }
}
