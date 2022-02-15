using System.Collections.Generic;

namespace Regula.DocumentReader.WebClient.Model.Ext
{
    public class RecognitionRequest : ProcessRequest
    {
        public RecognitionRequest(ProcessParams param, ProcessRequestImage image)
            :base(param, new List<ProcessRequestImage> { image })
        { }
        
        public RecognitionRequest(ProcessParams param, byte[] image)
            :base(param, new List<ProcessRequestImage> {new ProcessRequestImage(image)})
        { }
        
        public RecognitionRequest(ProcessParams param, List<ProcessRequestImage> images)
            :base(param, images)
        { }

        public RecognitionRequest(ProcessParams param, ContainerList containerList)
            : base(param, null, containerList)
        { }
    }
}
