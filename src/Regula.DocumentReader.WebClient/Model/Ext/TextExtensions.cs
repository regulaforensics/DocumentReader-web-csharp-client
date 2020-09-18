namespace Regula.DocumentReader.WebClient.Model.Ext
{
    public static class TextExtensions
    {
        public static TextField GetField(this Text txt, int fieldType, int lcid = 0)
        {
            foreach (var field in txt.FieldList)
            {
                if (field.FieldType == fieldType && field.Lcid == lcid)
                    return field;
            }

            return null;
        }
        
        public static string GetFieldValue(this Text txt, int fieldType, int lcid = 0)
        {
            foreach (var field in txt.FieldList)
            {
                if (field.FieldType == fieldType && field.Lcid == lcid)
                    return field.Value;
            }

            return null;
        }
    }
}