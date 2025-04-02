namespace Regula.DocumentReader.WebClient.Model.Ext.Autheticity
{
    public class FiberChecks : AuthenticityResult<FiberResult>
    {
        public FiberChecks(AuthenticityCheckResult authenticityCheckResult) : base(authenticityCheckResult)
        { }
    }
}
