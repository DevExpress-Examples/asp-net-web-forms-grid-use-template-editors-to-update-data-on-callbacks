Imports System
Imports DevExpress.Xpo

Public Class MyObject
	Inherits XPObject

	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal session As Session)
		MyBase.New(session)
	End Sub

	Public Overrides Sub AfterConstruction()
		MyBase.AfterConstruction()
	End Sub

	Protected _Title As String
	Public Property Title() As String
		Get
			Return _Title
		End Get
		Set(ByVal value As String)
			SetPropertyValue(Of String)("Title", _Title, value)
		End Set
	End Property

	Private _Item As Int32
	Public Property Item() As Int32
		Get
			Return _Item
		End Get
		Set(ByVal value As Int32)
			SetPropertyValue("Item", _Item, value)
		End Set
	End Property

	Private _SomeDate As DateTime
	Public Property SomeDate() As DateTime
		Get
			Return _SomeDate
		End Get
		Set(ByVal value As DateTime)
			SetPropertyValue("SomeDate", _SomeDate, value)
		End Set
	End Property
End Class

