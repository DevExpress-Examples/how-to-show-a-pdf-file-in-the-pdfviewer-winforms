Imports System.IO
Imports DevExpress.XtraBars

Namespace PdfViewerSample

    Public Partial Class Form1
        Inherits Ribbon.RibbonForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub btnLoadFile_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btnLoadFile.ItemClick
            pdfViewer1.LoadDocument("..\..\Report.pdf")
        End Sub
        Dim stream As FileStream
        Private Sub btnLoadStream_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btnLoadStream.ItemClick
            If stream Is Nothing Then
                stream = New FileStream("..\..\Report2.pdf", FileMode.Open)
            End If
            pdfViewer1.LoadDocument(stream)
        End Sub

        Private Sub btnClose_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btnClose.ItemClick
            pdfViewer1.CloseDocument()
        End Sub
    End Class
End Namespace
