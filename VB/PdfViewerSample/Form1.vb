Imports System.IO
Imports DevExpress.XtraBars

Namespace PdfViewerSample

    Public Partial Class Form1
        Inherits Ribbon.RibbonForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub btnLoadFile_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            pdfViewer1.LoadDocument("..\..\Report.pdf")
        End Sub

        Private stream As FileStream

        Private Sub btnLoadStream_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If stream Is Nothing Then stream = New FileStream("..\..\Report2.pdf", FileMode.Open)
            pdfViewer1.LoadDocument(stream)
        End Sub

        Private Sub btnClose_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            pdfViewer1.CloseDocument()
        End Sub
    End Class
End Namespace
