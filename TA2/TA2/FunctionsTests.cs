using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Functions
{
    [TestFixture]
    public class FunctionsTests
    {

        [TestCase(null, SortOrder.Ascending)]
        public void IsSorted_NullArgumentArrayAscendingSort_ThrowArgumentException(int[] array, SortOrder order)
        {
            Assert.Throws<ArgumentNullException>(() =>
                    Functions.IsSorted(array, order));
        }

        [TestCase(new int[] { 10, 20, 30 }, SortOrder.Ascending, ExpectedResult = true)]
        [TestCase(new int[] { 30, 20, 10 }, SortOrder.Descending, ExpectedResult = true)]
        [TestCase(new int[] { 30, 30, 30 }, SortOrder.Ascending, ExpectedResult = true)]
        [TestCase(new int[] { 30, 30, 30 }, SortOrder.Descending, ExpectedResult = true)]
        [TestCase(new int[] { 10, 20, 30 }, SortOrder.Descending, ExpectedResult = false)]
        [TestCase(new int[] { 30, 20, 10 }, SortOrder.Ascending, ExpectedResult = false)]
        [TestCase(new int[] { 30, -7, 30 }, SortOrder.Ascending, ExpectedResult = false)]
        [TestCase(new int[] { 90, 30, 100 }, SortOrder.Descending, ExpectedResult = false)]
        public bool IsSorted_NotNullArraySorted_ResultReturned(int[] array, SortOrder order) =>
            Functions.IsSorted(array, order);
    }

}
