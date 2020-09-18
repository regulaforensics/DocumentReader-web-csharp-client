using System;
using System.Collections.Generic;

namespace Regula.OpenApi.WebClient.Model.Ext
{
    public class RecognitionParams : ProcessParams
    {
        public RecognitionParams WithResultTypeOutput(List<int> resultTypes) {
            ResultTypeOutput = resultTypes;
            return this;
        }

        public RecognitionParams WithScenario(String scenario)
        {
            Scenario = scenario;
            return this;
        }
    }
}
