using System;
using System.Collections.Generic;

namespace Regula.DocumentReader.WebClient.Model.Ext
{
    public class RecognitionParams : ProcessParams
    {
        public RecognitionParams WithCustomParams(Dictionary<string, object> customParams){
            CustomParams = customParams;
            return this;
        }
        public RecognitionParams WithResultTypeOutput(List<int> resultTypes) {
            ResultTypeOutput = resultTypes;
            return this;
        }
        
        public RecognitionParams WithAuthParam(AuthParams authParams) {
            AuthParams = authParams;
            return this;
        }
        
        public RecognitionParams WithFaceApi(string url) {
            FaceApi = new FaceApi(url);
            UseFaceApi = true;
            return this;
        }

        public RecognitionParams WithScenario(string scenario)
        {
            Scenario = scenario;
            return this;
        }

        public RecognitionParams WithLog(bool log)
        {
            Log = log;
            return this;
        }

        public RecognitionParams WithProcessAuth(int processAuth)
        {
            ProcessAuth = processAuth;
            return this;
        }
    }
}
