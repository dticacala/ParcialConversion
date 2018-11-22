Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports System.Drawing
Imports ConversionLib

<TestClass()> Public Class UnitTest

    <TestMethod()> Public Sub Test0()
        Dim esperado = New Point(0, 0)
        Dim conv = New Conver

        Assert.AreEqual(esperado.X, conv.polarToCartesian(0, 0).X)
        Assert.AreEqual(esperado.Y, conv.polarToCartesian(0, 0).Y)
    End Sub

    <TestMethod()> Public Sub TestCentroRadio()
        Dim esperado = New Point(4, 0)
        Dim conv = New Conver

        Assert.AreEqual(esperado.X, conv.polarToCartesian(4, 0).X)
        Assert.AreEqual(esperado.Y, conv.polarToCartesian(4, 0).Y)
    End Sub

    <TestMethod()> Public Sub Test1()
        Dim esperado = New Point(1 / Math.Sqrt(2), 1 / Math.Sqrt(2))
        Dim conv = New Conver

        Assert.AreEqual(esperado.X, conv.polarToCartesian(1, 45).X)
        Assert.AreEqual(esperado.Y, conv.polarToCartesian(1, 45).Y)
    End Sub

    <TestMethod()> Public Sub Test2()
        Dim esperado = New Point(0, 3)
        Dim conv = New Conver

        Assert.AreEqual(esperado.X, conv.polarToCartesian(3, 90).X)
        Assert.AreEqual(esperado.Y, conv.polarToCartesian(3, 90).Y)
    End Sub

    <TestMethod()> Public Sub Test3()
        Dim esperado = New Point(-2, 0)
        Dim conv = New Conver

        Assert.AreEqual(esperado.X, conv.polarToCartesian(2, 180).X)
        Assert.AreEqual(esperado.Y, conv.polarToCartesian(2, 180).Y)
    End Sub

    <TestMethod()> Public Sub Test4()
        Dim esperado = New Point(-4, -3)
        Dim conv = New Conver

        Assert.AreEqual(esperado.X, conv.polarToCartesian(5, 217).X)
        Assert.AreEqual(esperado.Y, conv.polarToCartesian(5, 217).Y)
    End Sub

    <TestMethod()> Public Sub Test5()
        Dim esperado = New Point(24, -7)
        Dim conv = New Conver

        Assert.AreEqual(esperado.X, conv.polarToCartesian(25, 344).X)
        Assert.AreEqual(esperado.Y, conv.polarToCartesian(25, 344).Y)
    End Sub

End Class