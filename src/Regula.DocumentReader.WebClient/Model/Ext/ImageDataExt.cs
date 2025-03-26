using System;

namespace Regula.DocumentReader.WebClient.Model.Ext
{
    public class ImageDataExt : ImageData
    {
        public ImageDataExt(byte[] imageData)
        {
            string base64Image = Convert.ToBase64String(imageData);
            
            Image = base64Image;
        }
    }
}