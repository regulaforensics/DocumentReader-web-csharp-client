using System;
using System.Collections.Generic;
using System.Text;

namespace Regula.DocumentReader.WebClient.Model.Ext.Autheticity
{
    public class OCRSecurityTextChecks : AuthenticityResult<OCRSecurityTextResult>
    {
        public OCRSecurityTextChecks(AuthenticityCheckResult authenticityCheckResult) : base(authenticityCheckResult)
        {

        }
    }
}
