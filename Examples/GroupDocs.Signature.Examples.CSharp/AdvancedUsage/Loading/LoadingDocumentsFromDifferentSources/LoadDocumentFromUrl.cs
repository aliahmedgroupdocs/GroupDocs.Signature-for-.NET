﻿using System;
using System.IO;
using System.Net;


namespace GroupDocs.Signature.Examples.CSharp.AdvancedUsage
{ 
    using GroupDocs.Signature.Options;
    /// <summary>
    /// This example demonstrates how to download and render document.
    /// </summary>
    class LoadDocumentFromUrl
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Advanced Usage] # LoadDocumentFromUrl : Load document from Url\n");


            string url = "https://github.com/groupdocs-signature/GroupDocs.Signature-for-.NET/blob/master/Examples/Resources/SampleFiles/sample.pdf?raw=true";

            string outputFilePath = Path.Combine(Constants.OutputPath, "SignedWithTextFromUrl", "sample.pdf");

            try
            {
                using (Stream stream = GetRemoteFile(url))
                {
                    using (Signature signature = new Signature(stream))
                    {
                        TextSignOptions options = new TextSignOptions("John Smith")
                        {
                            // set signature position
                            Left = 100,
                            Top = 100
                        };

                        // sign document to file
                        signature.Sign(outputFilePath, options);
                    }
                }
                Console.WriteLine("\nSource document signed successfully.\nFile saved at " + outputFilePath);
            }
            catch
            {
                // skipe any exception and show the error
                Helper.WriteError("\nThis example requires valid network resource Url to download the document. " +
                                  "\nProbably following resource are not available. " +
                                  $"\n{url}");
            }
            
        }
                
        private static Stream GetRemoteFile(string url)
        {
            WebRequest request = WebRequest.Create(url);

            using (WebResponse response = request.GetResponse())
                return GetFileStream(response);
        }

        private static Stream GetFileStream(WebResponse response)
        {
            MemoryStream fileStream = new MemoryStream();

            using (Stream responseStream = response.GetResponseStream())
                responseStream.CopyTo(fileStream);

            fileStream.Position = 0;
            return fileStream;
        }
    }
}
