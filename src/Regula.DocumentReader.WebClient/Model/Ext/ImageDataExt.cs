using System;

namespace Regula.DocumentReader.WebClient.Model.Ext
{
    public class ImageDataExt : ImageData
    {
        public ImageDataExt(byte[] imageData)
            : base(Convert.ToBase64String(imageData))
        {
        }
    }
}