using System.Collections.Generic;

namespace Regula.DocumentReader.WebClient.Model.Ext
{
    public class RecognitionResponse
    {
        public RecognitionResponse(ProcessResponse originalResponse)
        {
            OriginalResponse = originalResponse;
        }
        
        public ProcessResponse OriginalResponse { get; }
        
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
        
        public AuthenticityCheckList Authenticity() 
        {
            var result = ResultByType<AuthenticityResult>(Result.AUTHENTICITY);
            return result?.AuthenticityCheckList;
        }

        public T ResultByType<T>(int type) where T: ResultItem
        {
            foreach(var item in OriginalResponse.ContainerList.List) 
            {
                if (item.ResultType == type) {
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
