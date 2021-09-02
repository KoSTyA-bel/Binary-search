using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Solution.Test
{
    [TestFixture]
    public class SearcherTest
    {
        private static IEnumerable<TestCaseData> testData
        {
            get
            {
                //------------------------------------
                yield return new TestCaseData(new int[] { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15}, 5, 4);
                yield return new TestCaseData(new int[] { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15}, 15, 14);
                yield return new TestCaseData(new int[] { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15}, 0, -1);
                yield return new TestCaseData(new int[] { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15}, -5, -1);
                yield return new TestCaseData(new int[] { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15}, 324, -1);
                //------------------------------------
                yield return new TestCaseData(new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }, 5, 4);
                yield return new TestCaseData(new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }, 15, 14);
                yield return new TestCaseData(new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }, 0, -1);
                yield return new TestCaseData(new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }, -5, -1);
                yield return new TestCaseData(new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }, 324, -1);
                //------------------------------------
                yield return new TestCaseData(new float[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }, 5, 4);
                yield return new TestCaseData(new float[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }, 15, 14);
                yield return new TestCaseData(new float[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }, 0, -1);
                yield return new TestCaseData(new float[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }, -5, -1);
                yield return new TestCaseData(new float[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }, 100, -1);
                //------------------------------------
                yield return new TestCaseData(new string[] { "asd", "asddsa", "as"}, "as", 0);
                yield return new TestCaseData(new string[] { "asd", "asddsa", "as" }, "asdasd", -1);
                yield return new TestCaseData(new string[] { "as", "dasd", "agsfdgf", "qweasdghfhghkhjl", "qweadsfgh", "qwaesgdhfjhk", "qwaesgdhfjhks" }, "qwaesgdhfjhks", 4);
            }
        }

        [TestCaseSource(nameof(testData))]
        public void TestAnytingType<T>(T[] data, T element, int expectedIndex)
        {
            Array.Sort(data);
            Assert.AreEqual(expectedIndex, Searcher.Search(data, element));
        }

        [Test]
        public void TrownArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => Searcher.Search(null, 5));
        }
    }
}
