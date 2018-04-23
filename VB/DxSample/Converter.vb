Imports Microsoft.VisualBasic
Imports System
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports System.Windows.Data
Imports DevExpress.Xpf.Grid

Namespace DxSample
	Public Class EnableConverter
		Implements IValueConverter

		Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
			Dim column As GridColumnData = TryCast(value, GridColumnData)
			If column.Column.IsSorted Then
				Return "Visible"
			Else
				Return "Collapsed"
			End If
		End Function

		Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
			Throw New NotImplementedException()
		End Function
	End Class
End Namespace
