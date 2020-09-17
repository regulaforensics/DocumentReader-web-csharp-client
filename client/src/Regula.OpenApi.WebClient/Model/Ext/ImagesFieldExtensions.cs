using System.Linq;

namespace Regula.OpenApi.WebClient.Model.Ext
{
    public static class ImagesFieldExtensions
    {
        public static byte[] GetValue(this ImagesField field, string source, bool original = false) 
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
            
            return bestValue.Value;
        }
    }
}
