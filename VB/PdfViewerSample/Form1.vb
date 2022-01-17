Imports System
Imports System.Windows.Forms

Namespace PdfViewerSample

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            pdfViewer1.LoadDocument("..\..\Report.pdf")
        End Sub
    End Class
End Namespace
