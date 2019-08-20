using ceTe.DynamicPDF;
using ceTe.DynamicPDF.Imaging;
using System;
using System.Text.RegularExpressions;

namespace example_tiff_to_pdf_dotnet
{
    // This example shows how to convert a TIFF image to PDF documents.
    // It references the ceTe.DynamicPDF.CoreSuite.NET NuGet package.
    class Program
    {
        // Convert a multipage TIFF image to a PDF document.
        // This code uses the DynamicPDF Generator for .NET product.
        // Use the ceTe.DynamicPDF namespace for the Document class.
        // Use the ceTe.DynamicPDF.Imaging namespace for the TiffFile class
        static void Main(string[] args)
        {
            //Create a TiffFile object using the TIFF file
            TiffFile tiffFile = new TiffFile(GetResourcePath("fw9_14.tif"));

            //Get document from the TiffFile
            Document document = tiffFile.GetDocument();

            //Save document
            document.Draw("output.pdf");
        }

        // This is a helper function to get the full path to a file in the Resources folder.
        public static string GetResourcePath(string inputFileName)
        {
            var exePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
            Regex appPathMatcher = new Regex(@"(?<!fil)[A-Za-z]:\\+[\S\s]*?(?=\\+bin)");
            var appRoot = appPathMatcher.Match(exePath).Value;
            return System.IO.Path.Combine(appRoot, "Resources", inputFileName);
        }
    }
}
