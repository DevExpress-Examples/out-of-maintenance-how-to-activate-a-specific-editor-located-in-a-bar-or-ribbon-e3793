Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraBars

Namespace WindowsApplication1
	Partial Public Class RibbonForm1
		Inherits DevExpress.XtraBars.Ribbon.RibbonForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub barButtonItem1_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles barButtonItem1.ItemClick
			barEditItem1.Links(0).Focus()
			TryCast(barEditItem1.Links(0), BarEditItemLink).ShowEditor()
		End Sub

		Private Sub barButtonItem2_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles barButtonItem2.ItemClick
			barEditItem2.Links(0).Focus()
			TryCast(barEditItem2.Links(0), BarEditItemLink).ShowEditor()
		End Sub
	End Class
End Namespace