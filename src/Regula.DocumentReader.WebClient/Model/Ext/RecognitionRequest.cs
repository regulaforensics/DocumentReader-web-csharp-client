using System.Collections.Generic;

namespace Regula.DocumentReader.WebClient.Model.Ext
{
    public class RecognitionRequest : ProcessRequest
    {
        public RecognitionRequest(ProcessParams param, ProcessRequestImage image, string tag = null)
            : base(param, new List<ProcessRequestImage> { image }, tag)
        {
        }

        public RecognitionRequest(ProcessParams param, byte[] image, string tag = null)
            : base( param, new List<ProcessRequestImage> { new ProcessRequestImage(image) }, tag)
        {
        }

        public RecognitionRequest(ProcessParams param, List<ProcessRequestImage> images, string tag = null)
            : base(param, images, tag)
        {
        }

        public RecognitionRequest(ProcessParams param, ContainerList containerList, string tag = null)
            : base(tag:tag, processParam:param, containerList:containerList)
        {
        }

        public string Json => Newtonsoft.Json.JsonConvert.SerializeObject(this);
    }
}
