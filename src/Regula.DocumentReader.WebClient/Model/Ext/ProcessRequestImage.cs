using System;

// ReSharper disable once CheckNamespace
namespace Regula.DocumentReader.WebClient.Model
{
    public partial class ProcessRequestImage
    {
        public ProcessRequestImage(byte[] image, int lightIndex = -1) 
        {
            if (image == null) 
            {
                throw new Exception("No image provided");
            }
            
            ImageData = new ImageData(image);

            if (lightIndex >= 0)
                Light = lightIndex;
        }
    }
}
