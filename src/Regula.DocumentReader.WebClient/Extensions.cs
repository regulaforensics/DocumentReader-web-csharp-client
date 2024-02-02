using System;
using System.Collections.Generic;

namespace Regula.DocumentReader.WebClient
{
    public static class CollectionExtensions
    {
        public static Dictionary<TKey, TElement> ToDictionarySafe<TSource, TKey, TElement>(this IEnumerable<TSource> collection,
            Func<TSource, TKey> keySelector,
            Func<TSource, TElement> elementSelector)
            where TKey : notnull
        {
            var result = new Dictionary<TKey, TElement>();
            foreach (var value in collection)
            {
                result[keySelector(value)] = elementSelector(value);
            }
            return result;
        }
    }
}