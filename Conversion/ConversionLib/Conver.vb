Imports System.Drawing
Public Class Conver
    Public Function polarToCartesian(r As Double, theta As Double) As Point
        If (theta = 90) Then
            Return New Point(0, r * Math.Sin(theta))
        Else
            Return New Point(r * Math.Cos((theta * Math.PI) / 180), r * Math.Sin((theta * Math.PI) / 180))
        End If
    End Function
End Class
