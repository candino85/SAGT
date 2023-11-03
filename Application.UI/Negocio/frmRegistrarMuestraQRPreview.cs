using Application.BE;
using Application.BLL;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.StyledXmlParser.Jsoup.Nodes;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace Application.UI.Negocio
{
    public partial class frmRegistrarMuestraQRPreview : Form
    {
        public frmRegistrarMuestraQRPreview()
        {
            InitializeComponent();
        }
        public frmRegistrarMuestraQRPreview(BE.Muestra muestra)
        {
            InitializeComponent();

            Zen.Barcode.CodeQrBarcodeDraw mGeneradorQR = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pbQR.Image = mGeneradorQR.Draw(muestra.Id.ToString(), 300);
        }

        //private void btnImprimirQR_Click(object sender, System.EventArgs e)
        //{
        //    //código para imprimir el QR
        //    //PrintDocument printDocument = new PrintDocument();
        //    //printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
        //    //printDocument.Print();

        //    var dialog = new OpenFileDialog()
        //    {
        //        Title = "Path de destino",
        //        Filter = "*.pdf",
        //        InitialDirectory = @"C:\Users\andin\OneDrive\Escritorio",
        //    };
        //    if (dialog.ShowDialog() == DialogResult.OK)
        //    {


        //    }
            
            

        //    // Le colocamos el título y el autor
        //    // **Nota: Esto no será visible en el documento
        //    doc.AddTitle("Mi primer PDF");
        //    doc.AddCreator("Roberto Torres");

        //    // Abrimos el archivo
        //    doc.Open();
        //    OpenFileDialog open = new OpenFileDialog();
        //    open.InitialDirectory = "C:\\";
        //    open.Filter = "Imagen Files (*.pdf)| *.pdf|ALL Files(*.*)|*.*";
        //    open.FilterIndex = 1;

        //    if (open.ShowDialog() == DialogResult.OK)
        //    {
        //        if (open.CheckFileExists)
        //        {
        //            string ruta = @"C:\Users\matias\Documents\Visual Studio 2015\Projects\ProyectoFinal\ProyectoFinal\Imagenes\PdfVentas\";

        //            System.IO.File.Copy(open.FileName, ruta + open.SafeFileName);

        //        }

        //    }
        //}

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pbQR.Image, 0, 0);
        }
    }
}
