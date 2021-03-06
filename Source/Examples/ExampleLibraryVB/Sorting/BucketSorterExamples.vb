'  
' Copyright 2007-2013 The NGenerics Team
' (https://github.com/ngenerics/ngenerics/wiki/Team)
'
' This program is licensed under the GNU Lesser General Public License (LGPL).  You should 
' have received a copy of the license along with the source code.  If not, an online copy
' of the license can be found at http://www.gnu.org/copyleft/lesser.html.
'


Imports System.Collections.Generic
Imports NGenerics.Sorting
Imports NUnit.Framework

<TestFixture()> _
Public Class BucketSorterExamples
#Region "Sort"
  <Test()> _
  Public Sub SortExample()
        Dim sorter As New BucketSorter()

    Dim list As New List(Of Integer)
    list.Add(13)
    list.Add(5)
    list.Add(77)
    list.Add(9)
    list.Add(12)

    sorter.Sort(list)

    Assert.AreEqual(5, list.Item(0))
    Assert.AreEqual(9, list.Item(1))
    Assert.AreEqual(12, list.Item(2))
    Assert.AreEqual(13, list.Item(3))
    Assert.AreEqual(77, list.Item(4))
  End Sub
#End Region

#Region "SortWithSortOrder"
    <Test()> _
    Public Sub SortWithOrderExample()
        Dim sorter As New BucketSorter()

        Dim list As New List(Of Integer)
        list.Add(13)
        list.Add(5)
        list.Add(77)
        list.Add(9)
        list.Add(12)

        sorter.Sort(list, SortOrder.Descending)

        Assert.AreEqual(77, list.Item(0))
        Assert.AreEqual(13, list.Item(1))
        Assert.AreEqual(12, list.Item(2))
        Assert.AreEqual(9, list.Item(3))
        Assert.AreEqual(5, list.Item(4))
    End Sub
#End Region

End Class






