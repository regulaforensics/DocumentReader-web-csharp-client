using System.Collections.Generic;

namespace Regula.DocumentReader.WebClient.Model.Ext
{
    public class RecognitionRequest : ProcessRequest
    {
        public RecognitionRequest(RecognitionParams param, ProcessRequestImage image, string tag = null)
            : base(param, new List<ProcessRequestImage> { image }, tag)
        {
        }

        public RecognitionRequest(RecognitionParams param, byte[] image, string tag = null)
            : base( param, new List<ProcessRequestImage> { new ProcessRequestImage(image) }, tag)
        {
        }

        public RecognitionRequest(RecognitionParams param, List<ProcessRequestImage> images, string tag = null)
            : base(param, images, tag)
        {
        }

        public RecognitionRequest(RecognitionParams param, ContainerList containerList, string tag = null)
            : base(tag:tag, processParam:param, containerList:containerList)
        {
        }

        public RecognitionRequest(RecognitionParams param, List<ProcessRequestImage> images, string extPortrait, string tag = null)
            : base(param, images, tag, extPortrait:extPortrait)
        {
        }

        public string Json => Newtonsoft.Json.JsonConvert.SerializeObject(this);
    }
}
