using System;
using System.Collections.Generic;

namespace Regula.DocumentReader.WebClient.Model.Ext
{
    public class RecognitionParams : ProcessParams
    {
        public RecognitionParams WithResultTypeOutput(List<int> resultTypes) {
            ResultTypeOutput = resultTypes;
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
    }
}
