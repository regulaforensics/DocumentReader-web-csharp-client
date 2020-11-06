namespace Regula.DocumentReader.WebClient.Model.Ext
{
    public static class TextExtensions
    {
        
        public static TextField GetField(this Text txt, int fieldType)
        {
            TextField result = null;
            foreach (var field in txt.FieldList)
            {
                if (field.FieldType == fieldType && field.Lcid==0)
                    return field;
                if (result == null && field.FieldType == fieldType)
                    result = field;
            }
            return result;
        }

        public static TextField GetField(this Text txt, int fieldType, int lcid)
        {
            foreach (var field in txt.FieldList)
            {
                if (field.FieldType == fieldType && field.Lcid == lcid)
                    return field;
            }
            return null;
        }
        
        public static TextField GetField(this Text txt, string fieldName)
        {
            TextField result = null;
            foreach (var field in txt.FieldList)
            {
                if (field.FieldName == fieldName && field.Lcid==0)
                    return field;
                if (result == null && field.FieldName == fieldName)
                    result = field;
            }
            return result;
        }
        
        public static TextField GetField(this Text txt, string fieldName, int lcid)
        {
            foreach (var field in txt.FieldList)
            {
                if (field.FieldName == fieldName && field.Lcid == lcid)
                    return field;
            }
            return null;
        }
        
        public static string GetFieldValue(this Text txt, int fieldType)
        {
            return txt.GetField(fieldType)?.Value;
        }
        
        public static string GetFieldValue(this Text txt, int fieldType, int lcid)
        {
            return txt.GetField(fieldType, lcid)?.Value;
        }
        
        public static string GetFieldValue(this Text txt, string fieldName)
        {
            return txt.GetField(fieldName)?.Value;
        }
        
        public static string GetFieldValue(this Text txt, string fieldName, int lcid)
        {
            return txt.GetField(fieldName, lcid)?.Value;
        }
    }
}