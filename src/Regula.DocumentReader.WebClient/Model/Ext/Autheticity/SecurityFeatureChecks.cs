using System;
using System.Collections.Generic;
using System.Linq;

namespace Regula.DocumentReader.WebClient.Model.Ext.Autheticity
{
    public class SecurityFeatureChecks : AuthenticityResult<SecurityFeatureResult>
    {
        public SecurityFeatureChecks(AuthenticityCheckResult authenticityResult) : base(authenticityResult)
        { }

        public SecurityFeatureResult ChecksByElement(int type)
        {
            return this.Items().FirstOrDefault(t => t.Type == type);
        }
    }
}
