Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports System.Collections.ObjectModel
Imports DevExpress.Xpf.Grid
Imports System.Collections

Namespace DxSample
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			gridControl1.ItemsSource = DataHelper.GetData()
		End Sub

		Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim button As Button = TryCast(sender, Button)
			Dim column As GridColumnData = TryCast(button.DataContext, GridColumnData)
			TryCast((TryCast(column.View, TableView)).DataControl, GridControl).UngroupBy(TryCast(column.Column, GridColumn))
		End Sub
	End Class

	Public NotInheritable Class DataHelper
		Private Sub New()
		End Sub
		Public Shared Function GetData() As ObservableCollection(Of DetailCityInfo)
			Dim cities As New ObservableCollection(Of DetailCityInfo) (New DetailCityInfo() {New DetailCityInfo("London", "UK", 1), New DetailCityInfo("Glasgow", "UK", 1), New DetailCityInfo("Edinburgh", "UK", 1), New DetailCityInfo("Aberdeen Dundee", "UK", 1), New DetailCityInfo("Washington", "USA", 2), New DetailCityInfo("Chicago", "USA", 2), New DetailCityInfo("Los Angeles", "USA", 2), New DetailCityInfo("New York", "USA", 2), New DetailCityInfo("Hong Kong", "China", 3), New DetailCityInfo("Shanghai", "China", 3), New DetailCityInfo("Beijing", "China", 3), New DetailCityInfo("Tianjin", "China", 3)})
			Return cities
		End Function
	End Class

	Public Class DetailCityInfo
		Private privateCityName As String
		Public Property CityName() As String
			Get
				Return privateCityName
			End Get
			Set(ByVal value As String)
				privateCityName = value
			End Set
		End Property
		Private privateCountryName As String
		Public Property CountryName() As String
			Get
				Return privateCountryName
			End Get
			Set(ByVal value As String)
				privateCountryName = value
			End Set
		End Property
		Private privateID As Integer
		Public Property ID() As Integer
			Get
				Return privateID
			End Get
			Set(ByVal value As Integer)
				privateID = value
			End Set
		End Property

        Public Sub New(ByVal _cityName As String, ByVal _countryName As String, ByVal _id As Integer)
            CityName = _cityName
            CountryName = _countryName
            ID = _id
        End Sub
	End Class
End Namespace
