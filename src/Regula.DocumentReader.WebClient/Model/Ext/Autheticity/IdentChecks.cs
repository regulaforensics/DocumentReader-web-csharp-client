using System.Linq;

namespace Regula.DocumentReader.WebClient.Model.Ext.Autheticity
{
    public class IdentChecks : AuthenticityResult<IdentResult>
    {
        public IdentChecks(AuthenticityCheckResult authenticityCheckResult) : base(authenticityCheckResult)
        { }

        public IdentResult ChecksByElement(SecurityFeatureType type)
        {
            return this.Items()?.FirstOrDefault(t => t.ElementType == type);
        }
    }
}
