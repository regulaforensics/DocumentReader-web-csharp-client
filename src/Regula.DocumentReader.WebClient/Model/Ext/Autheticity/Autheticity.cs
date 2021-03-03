using System;
using System.Collections.Generic;
using System.Text;

namespace Regula.DocumentReader.WebClient.Model.Ext.Autheticity
{
    public static class Authenticity
    {

        public static SecurityFeatureChecks UvLuminescenceChecks(this AuthenticityCheckList auth)
        {
            return auth.securityFeatureOrNull(AuthenticityResultType.UV_LUMINESCENCE);
        }

        public static int IrB900Checks(this AuthenticityCheckList auth)
        {
            return 0;
        }

        public static int ImagePattern(this AuthenticityCheckList auth)
        {
            return 0;
        }

        private static AuthenticityCheckResult resultByType(this AuthenticityCheckList auth, int type)
        {
            var ls = auth.List;
            foreach (var checkRes in ls)
            {
                if (checkRes.Type == type)
                    return checkRes;
            }
            return null;
        }

        private static FiberChecks filberOrNull(this AuthenticityCheckList auth, int type)
        {
            AuthenticityCheckResult result = auth.resultByType(type);
            return null;
        }

        private static IdentChecks identOrNull(this AuthenticityCheckList auth, int type)
        {
            AuthenticityCheckResult result = auth.resultByType(type);
            return null;
        }

        private static ImageIdentChecks imageIdentOrNull(this AuthenticityCheckList auth, int type)
        {
            AuthenticityCheckResult result = auth.resultByType(type);
            return null;
        }

        private static OCRSecurityTextChecks ocrSecurityTextOrNull(this AuthenticityCheckList auth, int type)
        {
            AuthenticityCheckResult result = auth.resultByType(type);
            return null;
        }

        private static SecurityFeatureChecks securityFeatureOrNull(this AuthenticityCheckList auth, int type)
        {
            AuthenticityCheckResult result = auth.resultByType(type);
            return null;
        }

    }

}
