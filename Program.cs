using System;

using ceTe.DynamicPDF;
using ceTe.DynamicPDF.Imaging;

using ceTe.DynamicPDF.Conversion;

namespace example_tiff_to_pdf_dotnet
{
    // This example shows how to convert a TIFF image to PDF documents.
    // It references the ceTe.DynamicPDF.CoreSuite.NET NuGet package.
    class Program
    {
        static void Main(string[] args)
        {
            ConvertExampleOne();
            ConvertExampleTwo();
        }

        // Convert a multipage TIFF image to a PDF document.
        // This code uses the DynamicPDF Core Suite for .NET product.
        // It used the following namespace from the ceTe.DynamicPDF.CoreSuite.NET NuGet package:
        //  * ceTe.DynamicPDF namespace for the Document class
        //  * ceTe.DynamicPDF.Imaging namespace for the TiffFile class
        static void ConvertExampleOne()
        {
            TiffFile tiffFile = new TiffFile("../../../Resources/fw9_18.tif");
            Document document = tiffFile.GetDocument();
            document.Draw("core-suite-output.pdf");
        }

        // Convert a multipage TIFF image to a PDF document.
        // This code uses the DynamicPDF Converter for .NET product.
        // It used the following namespace from the ceTe.DynamicPDF.Converter.NET NuGet package:
        //  * ceTe.DynamicPDF.Conversion for the ImageConverter class
        static void ConvertExampleTwo()
        {
            ImageConverter imageConverter = new ImageConverter("../../../Resources/fw9_18.tif");
            imageConverter.Convert("converter-output.pdf");
        }
    }
}
