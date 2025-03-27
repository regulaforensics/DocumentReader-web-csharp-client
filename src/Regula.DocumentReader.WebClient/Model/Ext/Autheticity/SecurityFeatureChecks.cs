using System.Linq;

namespace Regula.DocumentReader.WebClient.Model.Ext.Autheticity
{
    public class SecurityFeatureChecks : AuthenticityResult<SecurityFeatureResult>
    {
        public SecurityFeatureChecks(AuthenticityCheckResult authenticityResult) : base(authenticityResult)
        { }

        public SecurityFeatureResult ChecksByElement(SecurityFeatureType type)
        {
            return this.Items()?.FirstOrDefault(t => t.ElementType == type);
        }
    }
}
