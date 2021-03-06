﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupDocs.Signature.Examples.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uncomment the below line to apply license
            Utilities.ApplyLicense();

            #region WorkingWithTextSignature

            //Signatures.SignPdfDocumentWithText("text.pdf");

            //Signatures.SignCellDocumentWithText("pie chart.xlsx");

            //Signatures.SignSlideDocumentWithText("butterfly effect.pptx");

            //Signatures.SignWordDocumentWithText("getting started.docx");

            #endregion

            #region WorkingWithImageSignature

            //Signatures.SignPdfDocumentWithImage("digital signatures.pdf");

            //Signatures.SignCellDocumentWithImage("pie chart.xlsx");

            //Signatures.SignSlideDocumentWithImage("butterfly effect.pptx");

            //Signatures.SignWordDocumentWithImage("getting started.docx");

            //Signatures.SetOpacityImageSignature("getting started.docx");

            #endregion

            #region WorkingWithDigitalSignature

            //Signatures.SignPdfDocumentDigitally("digital signatures.pdf");

            //Signatures.SignCellDocumentDigitally("pie chart.xlsx");

            //Signatures.SignWordDocumentDigitally("getting started.docx");

            //digital signatures are not supported yet for slides documents 
            //Signatures.SignSlideDocumentDigitally("butterfly effect.pptx");

            #endregion

            #region Azure

            //Signatures.CustomInputHandler("digital signatures.pdf");
            //Signatures.CustomOutputHandler("digital signatures.pdf");

            #endregion

            #region GetPasswordProtectedDocs
            //Signatures.GetPasswordProtectedDocs("getting started.docx");
            //Signatures.ManipulatePasswordWithSaveOptions("pie chart.xlsx");
            #endregion

            //Following feature is supported in GroupDocs.Signature for .NET 16.10.0 version or greater
            #region SaveTextSignedFormatOptions

            //Signatures.SignPdfDocumentWithTextWithSaveFormat("digital signatures.pdf");

            //Signatures.SignCellDocumentWithTextWithSaveFormat("pie chart.xlsx");

            //Signatures.SignSlideDocumentWithTextWithSaveFormat("butterfly effect.pptx");

            //Signatures.SignWordDocumentWithTextWithSaveFormat("getting started.docx");

            #endregion

            #region SaveImageSignedFormatOptions

            //Signatures.SignPdfDocumentWithImageWithSaveFormat("digital signatures.pdf");

            //Signatures.SignCellDocumentWithImageWithSaveFormat("pie chart.xlsx");

            //Signatures.SignSlideDocumentWithImageWithSaveFormat("butterfly effect.pptx");

            //Signatures.SignWordDocumentWithImageWithSaveFormat("getting started.docx");

            #endregion

            #region SaveDigitalSignedFormatOptions

            //Signatures.SignPdfDocumentDigitallyWithSaveFormat("digital signatures.pdf");

            //Signatures.SignCellDocumentDigitallyWithSaveFormat("pie chart.xlsx");

            //Signatures.SignWordDocumentDigitallyWithSaveFormat("getting started.docx");

            //digital signatures are not supported yet for slides documents 
            //Signatures.SignSlideDocumentDigitallyWithSaveFormat("butterfly effect.pptx");

            #endregion

            #region SetupMultipleSignatureOptionsInPdf
            //Signatures.MultiplePdfSignOptions("digital signatures.pdf");
            //Signatures.MultipleCellSignOptions("pie chart.xlsx");
            //Signatures.MultipleWordSignOptions("getting started.docx");
            //Signatures.MultipleSlideSignOptions("butterfly effect.pptx");
            #endregion

            #region VerificationOptions
            //Signatures.TextVerificationOfPdfDocument("text.pdf");
            //Signatures.DigitalVerificationOfCellsDocWithCerCertificateContainer("digital signatures.xlsx");
            //Signatures.DigitalVerificationOfCellsDocWithPfxCertificateContainer("digital signatures.xlsx");
            //Signatures.DigitalVerificationOfPdfWithCerContainer("digital signatures.pdf");
            //Signatures.DigitalVerificationOfPdfWithPfxCertificateContainer("digital signatures.pdf");
            //Signatures.DigitalVerificationOfWordDocWithCerCertificateContainer("digital signatures.docx");
            //Signatures.DigitalVerificationOfWordDocWithPfxCertificateContainer("digital signatures.docx");
            //Signatures.VerifyPdfDocumentSignedWithTextSignatureAnnotation("test_text_annotation.pdf");
            //Signatures.VerifyPdfDocumentSignedWithTextSignatureSticker("test_text_sticker.pdf");
            //Signatures.VerifyCellDocumentSignedWithTextSignature("digital signatures.xlsx");
            //Signatures.VerifySlidesDocumentSignedWithTextSignature("butterfly effect.pptx");
            //Signatures.VerifyWordDocumentSignedWithTextSignature("getting started.docx");
            //Signatures.VerifyWordsDocWithTextSignatureToFormTextField("getting started.docx");
            #endregion

            #region SignatureAppearnaceoptions
            //Signatures.SignPdfDocWithTextSignAsImage("text.pdf");
            //Signatures.SignPdfDocWithTextSignAsAnnotation("text.pdf");
            //Signatures.SignPdfDocWithTextSignatureAsSticker("text.pdf");
            //Signatures.AddRotationToTextSignatureAppearance("text.pdf");
            //Signatures.AddTransparencyRotationToTextSignatureForSlides("butterfly effect.pptx");
            //Signatures.AddRotationToImageSignatureAppearance("text.pdf");
            //Signatures.ImageSignatureAppearanceExtendedoptions("getting started.docx");
            //Signatures.SignArbitraryPages("text.pdf");
            //Signatures.SpecifyDifferentMeasureUnitsForPDFTextSignature("text.pdf");
            //Signatures.SignPDFDocsWithTextSignatureAsWatermark("text.pdf");
            //Signatures.SignWordsDocsWithTextSignToFormTextField("getting started.docx");
            #endregion

            #region WorkingWithBarcodeSignatures
            //Signatures.UsingBarCodeTypes("text.pdf");
            //Signatures.SignCellsDocumentWithBarCodeOptions("pie chart.xlsx");
            //Signatures.SignPdfDocumentWithBarCodeOptions("text.pdf");
            //Signatures.SignSlidesDocumentWithBarCodeOptions("butterfly effect.pptx");
            //Signatures.SignWordsDocumentWithBarCodeOptions("getting started.docx");
            //Signatures.VerifyCellsDocumentsSignedWithBarcodeSignature("pie chart.xlsx");
            //Signatures.VerifyPdfDocumentsSignedWithBarcodeSignature("text.pdf");
            //Signatures.VerifySlidesDocumentsSignedWithBarcodeSignature("butterfly effect.pptx");
            //Signatures.VerifyWordsDocumentsSignedWithBarcodeSignature("getting started.docx");
            #endregion

            #region WorkingWithQRcodeSignatures
            //Signatures.AddingQRCode("text.pdf");
            //Signatures.SignCellsDocumentWithQrCodeSignature("pie chart.xlsx");
            //Signatures.SignPdfDocumentWithQrCodeSignature("text.pdf");
            //Signatures.SignSlidesDocumentWithQrCodeSignature("butterfly effect.pptx");
            //Signatures.SignWordsDocumentWithQrCodeSignature("getting started.docx");
            //Signatures.VerifyCellsDocumentSignedWithQrCodeSignature("pie chart.xlsx");
            //Signatures.VerifySlidesDocumentSignedWithQrCodeSignature("butterfly effect.pptx");
            //Signatures.VerifyPdfDocumentSignedWithQrCodeSignature("text.pdf");
            //Signatures.VerifyWordsDocumentSignedWithQrCodeSignature("getting started.docx");
            #endregion

            #region WorkingWithStampSignatures
            //Signatures.AddingStampSignature("text.pdf");
            //Signatures.SignCellsDocumentWithStampSignature("pie chart.xlsx");
            //Signatures.SignPdfDocumentWithStampSignature("text.pdf");
            //Signatures.SignSlidesDocumentWithStampSignature("butterfly effect.pptx");
            //Signatures.SignWordsDocumentWithStampSignature("getting started.docx");
            #endregion

            //Signatures.SetOutputFileName();
            //Signatures.GetDocumentInfo("text.pdf");
            Console.ReadKey();
        }
    }
}
