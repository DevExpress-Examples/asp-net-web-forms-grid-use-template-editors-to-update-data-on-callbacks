Imports Microsoft.VisualBasic
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
Imports DevExpress.Web.ASPxEditors
Imports DevExpress.Web.ASPxGridView

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Private session As Session = XpoHelper.GetNewSession()

	Private Const CallbackArgumentFormat As String = "function (s, e) {{ cb.PerformCallback(""{0}|{1}|"" + {2}); }}" ' key | field | value

	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
		xds.Session = session
	End Sub

	Protected Sub txtTitle_Init(ByVal sender As Object, ByVal e As EventArgs)
		Dim txt As ASPxTextBox = TryCast(sender, ASPxTextBox)
		Dim container As GridViewDataItemTemplateContainer = TryCast(txt.NamingContainer, GridViewDataItemTemplateContainer)

		txt.ClientSideEvents.ValueChanged = String.Format(CallbackArgumentFormat, container.KeyValue, container.Column.FieldName, "s.GetValue()")
	End Sub

	Protected Sub cmbItem_Init(ByVal sender As Object, ByVal e As EventArgs)
		Dim cmb As ASPxComboBox = TryCast(sender, ASPxComboBox)
		Dim container As GridViewDataItemTemplateContainer = TryCast(cmb.NamingContainer, GridViewDataItemTemplateContainer)

		cmb.ClientSideEvents.ValueChanged = String.Format(CallbackArgumentFormat, container.KeyValue, container.Column.FieldName, "s.GetValue()")
	End Sub

	Protected Sub edtDate_Init(ByVal sender As Object, ByVal e As EventArgs)
		Dim edt As ASPxDateEdit = TryCast(sender, ASPxDateEdit)
		Dim container As GridViewDataItemTemplateContainer = TryCast(edt.NamingContainer, GridViewDataItemTemplateContainer)

		edt.ClientSideEvents.ValueChanged = String.Format(CallbackArgumentFormat, container.KeyValue, container.Column.FieldName, "s.GetText()")
	End Sub

	Protected Sub cb_Callback(ByVal source As Object, ByVal e As DevExpress.Web.ASPxCallback.CallbackEventArgs)
		Dim p() As String = e.Parameter.Split("|"c)

		Dim key As Int32 = Convert.ToInt32(p(0))
		Dim field As String = p(1)
		Dim value As Object = p(2)

		Dim obj As MyObject = session.GetObjectByKey(Of MyObject)(key)

		Select Case field
			Case "Title"
				If value.ToString() = "null" Then
					value = String.Empty
				End If

			Case "Item"
				value = Convert.ToInt32(value)

			Case "SomeDate"
				Dim result As DateTime = DateTime.Now
				If DateTime.TryParse(value.ToString(), result) Then
					value = result
				Else
					value = DateTime.Now
				End If
		End Select

		obj.SetMemberValue(field, value)

		obj.Save()
	End Sub
End Class
