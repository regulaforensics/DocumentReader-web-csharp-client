﻿using System.Linq;

namespace Regula.DocumentReader.WebClient.Model.Ext.Autheticity
{
    public static class Authenticity
    {

        public static SecurityFeatureChecks UvLuminescenceChecks(this AuthenticityCheckList auth)
        {
            return auth.securityFeatureOrNull(AuthenticityResultType.UV_LUMINESCENCE);
        }

        public static SecurityFeatureChecks IrB900Checks(this AuthenticityCheckList auth)
        {
            return auth.securityFeatureOrNull(AuthenticityResultType.IR_B900);
        }

        public static IdentChecks ImagePatternChecks(this AuthenticityCheckList auth)
        {
            return auth.identOrNull(AuthenticityResultType.IMAGE_PATTERN);
        }

        public static SecurityFeatureChecks AxialProtectionChecks(this AuthenticityCheckList auth)
        {
            return auth.securityFeatureOrNull(AuthenticityResultType.AXIAL_PROTECTION);
        }

        public static FiberChecks UVFiberChecks(this AuthenticityCheckList auth)
        {
            return auth.filberOrNull(AuthenticityResultType.UV_FIBERS);
        }

        public static IdentChecks IRVisibilityChecks(this AuthenticityCheckList auth)
        {
            return auth.identOrNull(AuthenticityResultType.IR_VISIBILITY);
        }

        public static OCRSecurityTextChecks OCRSecurityTextChecks(this AuthenticityCheckList auth)
        {
            return auth.ocrSecurityTextOrNull(AuthenticityResultType.OCR_SECURITY_TEXT);
        }

        public static ImageIdentChecks IpiChecks(this AuthenticityCheckList auth)
        {
            return auth.imageIdentOrNull(AuthenticityResultType.IPI);
        }

        public static SecurityFeatureChecks EmbededImageChecks(this AuthenticityCheckList auth)
        {
            return auth.securityFeatureOrNull(AuthenticityResultType.PHOTO_EMBED_TYPE);
        }

        public static SecurityFeatureChecks HologramsChecks(this AuthenticityCheckList auth)
        {
            return auth.securityFeatureOrNull(AuthenticityResultType.HOLOGRAMS);
        }
        
        public static SecurityFeatureChecks OVIChecks(this AuthenticityCheckList auth)
        {
            return auth.securityFeatureOrNull(AuthenticityResultType.OVI);
        }

        public static SecurityFeatureChecks ImageAreaChecks(this AuthenticityCheckList auth)
        {
            return auth.securityFeatureOrNull(AuthenticityResultType.PHOTO_AREA);
        }

        public static IdentChecks portraitComparisonChecks(this AuthenticityCheckList auth)
        {
            return auth.identOrNull(AuthenticityResultType.PORTRAIT_COMPARISON);
        }

        public static SecurityFeatureChecks BarcodeFormatCheckChecks(this AuthenticityCheckList auth)
        {
            return auth.securityFeatureOrNull(AuthenticityResultType.BARCODE_FORMAT_CHECK);
        }

        public static IdentChecks KinegramChecks(this AuthenticityCheckList auth)
        {
            return auth.identOrNull(AuthenticityResultType.KINEGRAM);
        }

        public static IdentChecks LetterScreenChecks(this AuthenticityCheckList auth)
        {
            return auth.identOrNull(AuthenticityResultType.LETTER_SCREEN);
        }


        private static AuthenticityCheckResult resultByType(this AuthenticityCheckList auth, AuthenticityResultType type)
        {
            return auth?.List.FirstOrDefault(t => t.Type == type);
        }

        private static FiberChecks filberOrNull(this AuthenticityCheckList auth, AuthenticityResultType type)
        {
            AuthenticityCheckResult result = auth.resultByType(type);
            return result != null ? new FiberChecks(result) : null;
        }

        private static IdentChecks identOrNull(this AuthenticityCheckList auth, AuthenticityResultType type)
        {
            AuthenticityCheckResult result = auth.resultByType(type);
            return result != null ? new IdentChecks(result) : null;
        }

        private static ImageIdentChecks imageIdentOrNull(this AuthenticityCheckList auth, AuthenticityResultType type)
        {
            AuthenticityCheckResult result = auth.resultByType(type);
            return result != null ? new ImageIdentChecks(result) : null;
        }

        private static OCRSecurityTextChecks ocrSecurityTextOrNull(this AuthenticityCheckList auth, AuthenticityResultType type)
        {
            AuthenticityCheckResult result = auth.resultByType(type);
            return result != null ? new OCRSecurityTextChecks(result) : null;
        }

        private static SecurityFeatureChecks securityFeatureOrNull(this AuthenticityCheckList auth, AuthenticityResultType type)
        {
            AuthenticityCheckResult result = auth.resultByType(type);
            return result != null ? new SecurityFeatureChecks(result) : null;
        }

    }

}
