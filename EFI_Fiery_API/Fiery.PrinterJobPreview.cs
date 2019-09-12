using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EFI_Fiery_API
{
    public class FieryPrinterJobPreview
    {
        public byte[] PreviewBytes { get; set; }
        public FileStream File
        {
            get
            {
                if (PreviewBytes == null)
                {
                    return null;
                }
                else
                {
                    string tempPath = Path.Combine(System.IO.Path.GetTempPath(), Guid.NewGuid() + ".jpeg");
                    using (FileStream fileStream = System.IO.File.Create(tempPath))
                    {
                        fileStream.Write(PreviewBytes, 0, PreviewBytes.Length);
                        return fileStream;
                    }
                }
            }
        }
    }
}
