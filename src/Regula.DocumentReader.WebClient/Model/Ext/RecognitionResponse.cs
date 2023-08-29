using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace Regula.DocumentReader.WebClient.Model.Ext
{
    public class RecognitionResponse
    {
        public RecognitionResponse(ProcessResponse originalResponse)
        {
            OriginalResponse = originalResponse;
        }
        
        public ProcessResponse OriginalResponse { get; }

        public string Json =>  Newtonsoft.Json.JsonConvert.SerializeObject(this.OriginalResponse);
        
        public Status Status() 
        {
            var result = ResultByType<StatusResult>(Result.STATUS);
            return result?.Status;
        }
        
        public Text Text() {
            var result = ResultByType<TextResult>(Result.TEXT);
            return result?.Text;
        }
        
        public Images Images() 
        {
            var result = ResultByType<ImagesResult>(Result.IMAGES);
            return result?.Images;
        }
        
        public AuthenticityCheckList Authenticity(int pageIdx=0) 
        {
            var result = ResultByType<AuthenticityResult>(Result.AUTHENTICITY, pageIdx);
            return result?.AuthenticityCheckList;
        }
        
        public ImageQualityCheckList ImageQualityChecks(int pageIdx=0)
        {
            var result = ResultByType<ImageQualityResult>(Result.IMAGE_QUALITY, pageIdx);
            return result?.ImageQualityCheckList;
        }

        public OneCandidate DocumentType(int pageIdx = 0)
        {
            var result = ResultByType<ChosenDocumentTypeResult>(Result.DOCUMENT_TYPE, pageIdx);
            return result?.OneCandidate;
        }

        public string Log()
        {
            string logBase64 = this.OriginalResponse.Log;
            if (logBase64 == null)
            {
                return null;
            }
            
            byte[] buffer = Convert.FromBase64String(logBase64);
        
            using (MemoryStream memoryStream = new MemoryStream(buffer))
            using (DeflateStream deflateStream = new DeflateStream(memoryStream, CompressionMode.Decompress))
            using (StreamReader streamReader = new StreamReader(deflateStream, Encoding.UTF8))
            {
                return streamReader.ReadToEnd();
            }
        }

        public T ResultByType<T>(int type, int pageIdx=0) where T: ResultItem
        {
            foreach(var item in OriginalResponse.ContainerList.List) 
            {
                if (item.ResultType == type && item.PageIdx == pageIdx) {
                    return (T) item;
                }
            }
            
            return default;
        }
        
        public List<T> ResultsByType<T>(int type) where T: ResultItem
        {
            var results = new List<T>();
            foreach(var item in OriginalResponse.ContainerList.List) 
            {
                if (item.ResultType == type) {
                    results.Add((T)item);
                }
            }
            return results;
        }
    }
}
