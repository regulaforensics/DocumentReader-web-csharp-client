using System;
using System.Collections;
using System.Collections.Generic;
using RestSharp;

namespace Regula.DocumentReader.WebClient.Model
{
    public class RawResultItem : ResultItem, IDictionary<string, object>
	{
		private readonly Dictionary<string, object> _members;
		
		public RawResultItem()
		{
			_members = new Dictionary<string, object>();
		}

		public void Add(string key, object value)
		{
			_members.Add(key, value);
		}
		
		public bool ContainsKey(string key)
		{
			return _members.ContainsKey(key);
		}

		public ICollection<string> Keys => _members.Keys;

		public bool Remove(string key)
		{
			return _members.Remove(key);
		}

		public bool TryGetValue(string key, out object value)
		{
			return _members.TryGetValue(key, out value);
		}

		public ICollection<object> Values => _members.Values;

		public object this[string key]
		{
			get => _members[key];
			set => _members[key] = value;
		}

		public void Add(KeyValuePair<string, object> item)
		{
			_members.Add(item.Key, item.Value);
		}

		public void Clear()
		{
			_members.Clear();
		}

		public bool Contains(KeyValuePair<string, object> item)
		{
			return _members.TryGetValue(item.Key, out object value) && value == item.Value;
		}

		public void CopyTo(KeyValuePair<string, object>[] array, int arrayIndex)
		{
			if (array == null) throw new ArgumentNullException(nameof(array));
			
			int num = Count;
			foreach (var kvp in this)
			{
				array[arrayIndex++] = kvp;
				if (--num <= 0) return;
			}
		}
		
		public int Count => _members.Count;
		
		public bool IsReadOnly => false;

		public bool Remove(KeyValuePair<string, object> item)
		{
			return _members.Remove(item.Key);
		}

		public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
		{
			return _members.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return _members.GetEnumerator();
		}

		public override string ToString()
		{
			return SimpleJson.SerializeObject(this);
		}
	}
}
