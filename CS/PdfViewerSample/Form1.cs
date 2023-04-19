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

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.pdfViewer1.LoadDocument(@"..\..\Report.pdf");
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            FileStream stream = new FileStream(@"..\..\Report.pdf", FileMode.Open);
            pdfViewer1.LoadDocument(stream);
        }

        private void btnClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            pdfViewer1.CloseDocument();
        }
    }
}
