using System.Collections.Generic;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BDDSkeleton.GUI.Tests
{
    public static class TestExtensions
    {
        public static void ShouldBe(this object valueToTest, object expected)
        {
            Assert.AreEqual(expected, valueToTest);
        }

        public static void AreTheSame(this object valueToTest, object expected)
        {
            Assert.AreEqual(expected, valueToTest);
        }

        public static void ShouldBeginWith(this string valueToTest, string expected)
        {
            Assert.IsTrue(valueToTest.StartsWith(expected));
        }

        public static void ShouldBeLargerThan(this double verdi, double sammenlign)
        {
            Assert.IsTrue(verdi > sammenlign);
        }

        public static void ShouldBeDifferent(this object valueToTest, object expected)
        {
            Assert.AreNotEqual(expected, valueToTest);
        }


        public static void ShouldNotBeEmptyString(this string valueToTest)
        {
            Assert.AreNotEqual(string.Empty, valueToTest);
        }

        public static void ShouldNotBeNull(this object valueToTest)
        {
            Assert.IsNotNull(valueToTest);
        }

        public static void ShouldBeNull(this object valueToTest)
        {
            Assert.IsNull(valueToTest);
        }

        public static void ShouldBeSameAs(this object valueToTest, object expected)
        {
            Assert.AreSame(valueToTest, expected);
        }

        public static void ShouldNotBeSameAs(this object valueToTest, object expected)
        {
            Assert.AreNotSame(valueToTest, expected);
        }

        public static void ShouldBeTrue(this bool valueToTest)
        {
            Assert.IsTrue(valueToTest);
        }

        public static void BeTrue(this bool valueToTest)
        {
            Assert.IsTrue(valueToTest);
        }

        public static void BeFalse(this bool valueToTest)
        {
            Assert.IsFalse(valueToTest);
        }

        public static void ShouldBeFalse(this bool valueToTest)
        {
            Assert.IsFalse(valueToTest);
        }

        public static void ShouldBeInstanceOfType<T>(this object valueToTest)
        {
            Assert.IsInstanceOfType(valueToTest, typeof(T));
        }

        public static void ShouldNotBeInstanceOfType<T>(this object valueToTest)
        {
            Assert.IsNotInstanceOfType(valueToTest, typeof(T));
        }

        public static void ShouldBeEmpty(this IList list)
        {
            Assert.AreEqual(0, list.Count);
        }

        public static void ShouldContainElements(this IList list)
        {
            Assert.IsTrue(list.Count > 0);
        }

        public static void ShouldNotContainElements(this IList list)
        {
            Assert.AreEqual(0, list.Count);
        }

        public static void DoesNotHoldElements(this IList list)
        {
            Assert.AreEqual(0, list.Count);
        }

        public static void ShouldNotContain(this string text, string textToFind)
        {
            Assert.IsFalse(text.IndexOf(textToFind) >= 0, string.Format("Found \"{0}\" in text \"{1}\"", textToFind, text));
        }

        public static void ShouldContain(this string text, string textToFind)
        {
            Assert.IsTrue(text.IndexOf(textToFind) >= 0, string.Format("Did not find \"{0}\" in text \"{1}\"", textToFind, text));
        }

        public static void ShouldContainElements<T>(this IList<T> list, int antallElementer)
        {
            Assert.AreEqual(antallElementer, list.Count);
        }

        public static void ContainsElements<T>(this IList<T> list, int antallElementer)
        {
            Assert.AreEqual(antallElementer, list.Count);
        }

        public static void ShouldContain(this IList list, object expectedObject)
        {
            var index = list.IndexOf(expectedObject);
            if (index == -1)
            {
                Assert.Fail("Expected object was not in list");
            }
        }

        public static void ShouldHave(this IList list, int expectedCount)
        {
            Assert.AreEqual(expectedCount, list.Count);
        }
    }
}
