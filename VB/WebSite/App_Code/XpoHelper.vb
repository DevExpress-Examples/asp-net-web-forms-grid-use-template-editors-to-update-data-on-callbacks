Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports DevExpress.Xpo.Metadata

''' <summary>
''' Summary description for XpoHelper
''' </summary>
Public Module XpoHelper
	Sub New()
		CreateDefaultObjects()
	End Sub

	Public Function GetNewSession() As Session
		Return New Session(DataLayer)
	End Function

	Public Function GetNewUnitOfWork() As UnitOfWork
		Return New UnitOfWork(DataLayer)
	End Function

	Private ReadOnly lockObject As New Object()

	Private fDataLayer As IDataLayer
	Private ReadOnly Property DataLayer() As IDataLayer
		Get
			If fDataLayer Is Nothing Then
				SyncLock lockObject
					fDataLayer = GetDataLayer()
				End SyncLock
			End If
			Return fDataLayer
		End Get
	End Property

	Private Function GetDataLayer() As IDataLayer
		XpoDefault.Session = Nothing

		Dim ds As New InMemoryDataStore()
		Dim dict As XPDictionary = New ReflectionDictionary()
		dict.GetDataStoreSchema(GetType(MyObject).Assembly)

		Return New ThreadSafeDataLayer(dict, ds)
	End Function

	Private Sub CreateDefaultObjects()
		Using uow As UnitOfWork = GetNewUnitOfWork()
			Dim obj As New MyObject(uow)
			obj.Title = "Item 1"
			obj.Item = 0
			obj.SomeDate = DateTime.Now

			obj = New MyObject(uow)
			obj.Title = "Item 2"
			obj.Item = 1
			obj.SomeDate = DateTime.Now.AddMonths(1)

			obj = New MyObject(uow)
			obj.Title = "Item 3"
			obj.Item = 2
			obj.SomeDate = DateTime.Now.AddMonths(2)

			uow.CommitChanges()
		End Using
	End Sub
End Module