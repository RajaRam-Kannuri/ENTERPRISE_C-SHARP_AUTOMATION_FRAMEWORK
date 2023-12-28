using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace SoftAssertion
{
    public class SoftAssert
    {
        private readonly Dictionary<int, FailedAssert> _failedAsserts;

        private int _counter = 0;

        public SoftAssert()
        {
            _failedAsserts = new Dictionary<int, FailedAssert>();
        }

        public void That(bool expression)
        {
            try
            {
                _counter++;
                Assert.That(expression);
            }
            catch(AssertionException)
            {}
        }

        public void That(Action action)
        {
            try
            {
                _counter++;
                action();
            }
            catch(AssertionException)
            {}
        }

        public void That(Func<bool> expression)
        {
            try
            {
                _counter++;
                Assert.That(expression);
            }
            catch(AssertionException)
            {}
        }

        public void Null(object obj)
        {
            try
            {
                _counter++;
                Assert.Null(obj);
            }
            catch(AssertionException)
            {}
        }

        public void NotNull(object obj)
        {
            try
            {
                _counter++;
                Assert.NotNull(obj);
            }
            catch(AssertionException)
            {}
        }

        public void AreEqual(object expected, object actual)
        {
            try
            {
                _counter++;
                Assert.AreEqual(expected, actual);
            }
            catch(AssertionException)
            {}
        }

        public void AreNotEqual(object expected, object actual)
        {
            try
            {
                _counter++;
                Assert.AreNotEqual(expected, actual);
            }
            catch(AssertionException)
            {}
        }

        public void True(bool expression)
        {
            try
            {
                _counter++;
                Assert.True(expression);
            }
            catch(AssertionException)
            {}
        }

        public void IsTrue(bool expression)
        {
            try
            {
                _counter++;
                Assert.IsTrue(expression);
            }
            catch(AssertionException)
            {}
        }

        public void False(bool expression)
        {
            try
            {
                _counter++;
                Assert.False(expression);
            }
            catch(AssertionException)
            {}
        }

        public void IsFalse(bool expression)
        {
            try
            {
                _counter++;
                Assert.IsFalse(expression);
            }
            catch(AssertionException)
            {}
        }

        public void Throws<TActual>(TestDelegate code) where TActual : Exception
        {
            try
            {
                _counter++;
                Assert.Throws<TActual>(code);
            }
            catch(AssertionException)
            {}
        }

        public void VerifyAll()
        {
            if(_failedAsserts.Count == 0)
            {
                return;
            }

            int num = 1;
            StringBuilder StringBuilder = new StringBuilder().AppendLine("Test failed because one or more assertions failed: ");
            foreach(KeyValuePair<int, FailedAssert> failedAssert in _failedAsserts)
            {
                StringBuilder.Append($"{failedAssert.Key})\t{failedAssert.Value.Message}{Environment.NewLine}");
                _failedAsserts.Remove(num);
            }
            _failedAsserts.Clear();
            throw new AssertionException(StringBuilder.ToString());
        }

        public void ClearFailedAsserts()
        {
            _failedAsserts.Clear();
            _counter = 0;

        }
    }
}