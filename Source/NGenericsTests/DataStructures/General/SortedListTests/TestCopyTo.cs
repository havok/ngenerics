/*  
  Copyright 2007-2010 The NGenerics Team
 (http://code.google.com/p/ngenerics/wiki/Team)

 This program is licensed under the GNU Lesser General Public License (LGPL).  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at http://www.gnu.org/copyleft/lesser.html.
*/
using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.General.SortedListTests
{
    [TestFixture]
    public class TestCopyTo
    {

        [Test]
        public void Simple()
        {
            var sortedList = SortedListTest.GetTestList();
            var array = new int[sortedList.Count];
            sortedList.CopyTo(array, 0);

            var list = new List<int>(array);

            for (var i = 0; i <= 50; i++)
            {
                Assert.IsTrue(list.Contains(i * 2));
            }
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ExceptionNullArray()
        {
            var sortedList = SortedListTest.GetTestList();
            sortedList.CopyTo(null, 0);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void ExceptionInvalidCopyTo1()
        {
            var sortedList = SortedListTest.GetTestList();
            var array = new int[sortedList.Count - 1];
            sortedList.CopyTo(array, 0);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void ExceptionInvalidCopyTo2()
        {
            var sortedList = SortedListTest.GetTestList();
            var array = new int[sortedList.Count];
            sortedList.CopyTo(array, 1);
        }

    }
}