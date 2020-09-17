namespace Regula.OpenApi.WebClient.Model.Ext
{
    public static class TextFieldExtensions
    {
        public static string GetValue(this TextField field, string source, bool original = false) 
        {
            foreach (var value in field.ValueList) 
            {
                if (value.Source == source)
                {
                    if (original) 
                    {
                        return value.OriginalValue;
                    }

                    return value.Value;
                }
            }
            return null;
        }
        
        public static int SourceValidity(this TextField field, string source) 
        {
            foreach (var sourceValidity in field.ValidityList) 
            {
                if (sourceValidity.Source == source) {
                    return sourceValidity.Status;
                }
            }
            
            return CheckResult.WAS_NOT_DONE;
        }
        
        public static int CrossSourceComparison(this TextField field, string one, string other) 
        {
            foreach (var comparison in field.ComparisonList) 
            {
                bool a = comparison.SourceLeft == one && comparison.SourceRight == other;
                bool b = comparison.SourceRight == one && comparison.SourceLeft == other;
                
                if (a || b) 
                {
                    return comparison.Status;
                }
            }
            return CheckResult.WAS_NOT_DONE;
        }
    }
}
