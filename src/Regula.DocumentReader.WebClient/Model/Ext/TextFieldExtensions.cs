namespace Regula.DocumentReader.WebClient.Model.Ext
{
    public static class TextFieldExtensions
    {
        public static string GetValue(this TextField field, Source source, bool original = false) 
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
        
        public static CheckResult SourceValidity(this TextField field, Source source) 
        {
            foreach (var sourceValidity in field.ValidityList) 
            {
                if (sourceValidity.Source == source) {
                    return sourceValidity.Status;
                }
            }
            
            return CheckResult.WAS_NOT_DONE;
        }
        
        public static CheckResult CrossSourceComparison(this TextField field, Source one, Source other) 
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
