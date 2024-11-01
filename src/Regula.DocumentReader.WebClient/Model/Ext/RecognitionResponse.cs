using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using Regula.DocumentReader.WebClient.Client;

namespace Regula.DocumentReader.WebClient.Model.Ext
{
    public class RecognitionResponse
    {
        private readonly ApiResponse<ProcessResponse> _apiResponse;
        
        public RecognitionResponse(ApiResponse<ProcessResponse> apiResponse)
        {
            _apiResponse = apiResponse;
        }

        public ProcessResponse OriginalResponse => this._apiResponse.Data;

        public string Json => this._apiResponse.RawResponse;
        
        public AuthenticityResult PortraitComparison()
        {
            var result = ResultByType<AuthenticityResult>(Result.PORTRAIT_COMPARISON, null);
            return result;
        }
        
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

            using (var compressedStream = new MemoryStream(buffer))
            using (var zipStream = new InflaterInputStream(compressedStream))
            using (var resultStream = new MemoryStream())
            {
                zipStream.CopyTo(resultStream);
                return Encoding.UTF8.GetString(resultStream.ToArray());
            }
        }

        public T ResultByType<T>(int type, int? pageIdx=0) where T: ResultItem
        {
            foreach(var item in OriginalResponse.ContainerList.List) 
            {
                if (item.ResultType == type) {
                    
                    if (pageIdx == null)
                        return (T) item;
                    
                    if (item.PageIdx == pageIdx)
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
