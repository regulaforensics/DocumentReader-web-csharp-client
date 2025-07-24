using System.Collections.Generic;

namespace Regula.DocumentReader.WebClient.Model.Ext
{
    public static class ImagesExtensions
    {
        public static ImagesField GetField(this Images imgs, GraphicFieldType fieldType) 
        {
            foreach (var field in imgs.FieldList) 
            {
                if (field.FieldType == fieldType) return field;
            }
            
            return null;
        }
        
        public static List<ImagesField> GetFields(this Images imgs, GraphicFieldType fieldType) 
        {
            var fields = new List<ImagesField>();
            
            foreach (var field in imgs.FieldList) 
            {
                if (field.FieldType == fieldType)
                    fields.Add(field);
            }
            
            return fields;
        }
    }
}
