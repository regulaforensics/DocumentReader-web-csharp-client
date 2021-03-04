using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Regula.DocumentReader.WebClient.Model.Ext.Autheticity
{
    public abstract class AuthenticityResult<T> where T : class
    {
        AuthenticityCheckResult authenticityCheckResult;

        public AuthenticityResult(AuthenticityCheckResult authenticityCheckResult)
        {
            this.authenticityCheckResult = authenticityCheckResult;
        }

        public AuthenticityCheckResult Payload()
        {
            return this.authenticityCheckResult;
        }

        public List<T> Items()
        {
            var ls = this.authenticityCheckResult.List;

            return (ls as IEnumerable<T>).Cast<T>().ToList();
        }        
    }
}
