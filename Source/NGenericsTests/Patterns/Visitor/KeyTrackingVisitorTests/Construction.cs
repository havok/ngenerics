/*  
  Copyright 2007-2010 The NGenerics Team
 (http://code.google.com/p/ngenerics/wiki/Team)

 This program is licensed under the GNU Lesser General Public License (LGPL).  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at http://www.gnu.org/copyleft/lesser.html.
*/
using NGenerics.Patterns.Visitor;
using NUnit.Framework;

namespace NGenerics.Tests.Patterns.Visitor.KeyTrackingVisitorTests
{
    [TestFixture]
    public class Construction
    {
        [Test]
        public void Simple()
        {
            var visitor = new KeyTrackingVisitor<int, string>();
            Assert.IsFalse(visitor.HasCompleted);
            Assert.AreEqual(visitor.TrackingList.Count, 0);
        }
    }
}