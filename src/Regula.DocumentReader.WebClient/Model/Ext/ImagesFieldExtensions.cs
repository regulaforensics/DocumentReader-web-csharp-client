using System;
using System.Linq;

namespace Regula.DocumentReader.WebClient.Model.Ext
{
    public static class ImagesFieldExtensions
    {
        public static byte[] GetValue(this ImagesField field, string source, bool original = false)
        {
            string strResult;
            foreach (var value in field.ValueList) 
            {
                if (value.Source == source)
                {
                    if (original) 
                    {
                        strResult =  value.OriginalValue;
                    }
                    strResult = value.Value;

                    return Convert.FromBase64String(strResult);
                }
            }
            return null;
        }
        
        
        public static byte[] GetValue(this ImagesField field) 
        {
            var values = field.ValueList;
            if (values == null || !values.Any()) return null;
            
            var bestValue = values.First();
            
            foreach (var value in values) 
            {
                if (bestValue.Source == Source.BARCODE && value.Source == Source.VISUAL)
                    bestValue = value;
                
                if (bestValue.Source == Source.BARCODE && value.Source == Source.RFID)
                    bestValue = value;
                
                if (bestValue.Source == Source.VISUAL && value.Source == Source.RFID)
                    bestValue = value;
            }
            
            return Convert.FromBase64String(bestValue.Value);
        }
    }
}
