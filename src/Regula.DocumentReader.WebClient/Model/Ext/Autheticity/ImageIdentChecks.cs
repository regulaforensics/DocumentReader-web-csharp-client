namespace Regula.DocumentReader.WebClient.Model.Ext.Autheticity
{
    public class ImageIdentChecks : AuthenticityResult<PhotoIdentResult>
    {
        public ImageIdentChecks(AuthenticityCheckResult authenticityCheckResult) : base(authenticityCheckResult)
        { }
    
    }
}
