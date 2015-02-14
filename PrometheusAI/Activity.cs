using System;

namespace PrometheusAI
{
    public abstract class Activity
    {
        public void Perform(State state)
        {
            ApplyContextEffect(state);
            ApplyEffect(state);
        }

        public bool CanPerform(State state)
        {
            return IsValidContextPrecondition(state) &&
                   IsValidPrecondition(state);
        }

        public State Outcome(State state)
        {
            if (state == null) throw new ArgumentNullException("Argument for Activity.Outcome(State) cannot be null");

            State outcome = state;

            ApplyContextEffect(outcome);
            ApplyEffect(outcome);

            return outcome;
        }

        public virtual float GetCost() { return 1.0F; }

        protected abstract State Precondition { get; }
        protected abstract State Effect       { get; }

        protected virtual bool IsValidContextPrecondition(State startState) { return true; }
        protected virtual bool IsValidPrecondition(State startState) { return startState.Contains(Precondition); }

        protected virtual void ApplyContextEffect(State startState) { }
        protected virtual void ApplyEffect(State startState) { startState.Apply(Effect); }
    }
}
