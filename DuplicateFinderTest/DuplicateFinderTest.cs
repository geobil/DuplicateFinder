using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using DuplicateFinder;

namespace DuplicateFinderTest
{
    [TestClass]
    public class DuplicateFinderTest
    {
        [TestMethod]
        public void n100000Duplicate8ShouldReturn8()
        {
            DuplicateFinder.DuplicateFinder duplicateTest = new DuplicateFinder.DuplicateFinder();
            int n = 100000;
            List<int> array = new List<int>(Enumerable.Range(1, n - 1));
            // Duplicate 8
            array.Add(8);
            var res = duplicateTest.FindTheDuplicate(array, n);
            Assert.AreEqual(8, res);
        }
    }
}
