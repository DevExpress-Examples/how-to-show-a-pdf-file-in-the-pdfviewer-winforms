using System;
using System.IO;
using DevExpress.XtraBars;

namespace PdfViewerSample
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadFile_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.pdfViewer1.LoadDocument(@"..\..\Report.pdf");
        }
        FileStream stream;
        private void btnLoadStream_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (stream == null)
                stream = new FileStream(@"..\..\Report2.pdf", FileMode.Open);
            pdfViewer1.LoadDocument(stream);
        }

        private void btnClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            pdfViewer1.CloseDocument();
        }
    }
}
