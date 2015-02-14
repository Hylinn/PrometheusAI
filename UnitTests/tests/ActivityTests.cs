using System;
using NUnit.Framework;

namespace UnitTests.tests
{
    [TestFixture]
    public class ActivityTests
    {
        [Test]
        public void PerformCallsApplyContextEffect()
        {
            var activity = new TestActivity();

            activity.Perform(null);

            Assert.IsTrue(activity.ApplyContextEffectCalled);
        }

        [Test]
        public void PerformCallsApplyEffect()
        {
            var activity = new TestActivity();

            activity.Perform(null);

            Assert.IsTrue(activity.ApplyEffectCalled);
        }

        [Test]
        public void CanPerformCallsIsValidContextPrecondition()
        {
            var activity = new TestActivity();

            activity.CanPerform(null);

            Assert.IsTrue(activity.IsValidContextPreconditionCalled);
        }

        [Test]
        public void CanPerformCallsIsValidPrecondition()
        {
            var activity = new TestActivity();

            activity.CanPerform(null);

            Assert.IsTrue(activity.IsValidPreconditionCalled);
        }

        [Test]
        public void CanPerformIsFalseIfContextPreconditionIsFalse()
        {
            var activity = new TestActivity(ValidContextPrecondition: false);

            bool result = activity.CanPerform(null);

            Assert.IsFalse(result);
        }

        [Test]
        public void CanPerformIsFalseIfPreconditionIsFalse()
        {
            var activity = new TestActivity(ValidPrecondition: false);

            bool result = activity.CanPerform(null);

            Assert.IsFalse(result);
        }

        [Test]
        public void CanPerformIsTrueIfBothPreconditionsAreTrue()
        {
            var activity = new TestActivity();

            bool result = activity.CanPerform(null);

            Assert.IsTrue(result);
        }

        [Test]
        public void CanPerformIsFalseIfBothPreconditionsAreFalse()
        {
            var activity = new TestActivity(false, false);

            bool result = activity.CanPerform(null);

            Assert.IsFalse(result);
        }

        [Test]
        public void OutcomeCallsApplyContextEffect()
        {
            var activity = new TestActivity();

            activity.Outcome(new FakeState());

            Assert.IsTrue(activity.ApplyContextEffectCalled);
        }

        [Test]
        public void OutcomeCallApplyEffect()
        {
            var activity = new TestActivity();

            activity.Outcome(new FakeState());

            Assert.IsTrue(activity.ApplyEffectCalled);
        }

        [Test]
        public void OutcomeThrowsArgumentNullExceptionWithNullState()
        {
            var activity = new TestActivity();

            Assert.Throws<ArgumentNullException>(() => activity.Outcome(null));
        }

        [Test]
        public void OutcomeDoesNotChangeContentsOfPassedState()
        {
            Assert.Fail();
        }
    }
}
