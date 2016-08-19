using System.Collections.Generic;


namespace LabviewAdvancedProgrammingTechniques
{
    public class aboutThisLibrary
    {
        public string Author { get { return "Rick Bitter"; } }
    }
    /// <summary>
    /// Wrapper class for the Dictionary object using a String Key and a double as a stored value.
    /// This class is only needed for Langauges like LabVIEW which do not support generics.
    /// </summary>
    public class Dictionary_String2Double
    {
        private Dictionary<string, double> _myDictionary = new Dictionary<string, double>();

        /// <summary>
        /// Adds an element to the dictionary
        /// </summary>
        /// <param name="key">String value to be used as a key for the dictionary</param>
        /// <param name="val">The double that is beign stored.</param>
        public void Add(string key, double val)
        {
            _myDictionary.Add(key, val);
        }
        /// <summary>
        /// Returns the number of items currently stored in the dictionary.
        /// </summary>
        public long Count
        {
            get { return _myDictionary.Count; }          
        }
        /// <summary>
        /// Removes all elements stored in the dictionary
        /// </summary>
        public void Clear()
        {
            _myDictionary.Clear();
        }

        public bool ContainsKey(string key)
        {
            return _myDictionary.ContainsKey(key);
        }

        public bool ContainsValue(double val)
        {
            return _myDictionary.ContainsValue(val);
        }

        public bool Remove(string key)
        {
            return  _myDictionary.Remove(key);
        }

        public bool TryGetValue(string key, out double val)
        {
            return _myDictionary.TryGetValue(key, out val);

        }
    }

    /// <summary>
    /// Wrapper class for the Dictionary object using a String Key and a string as a stored value.
    /// This class is only needed for Langauges like LabVIEW which do not support generics.
    /// </summary>
    public class Dictionary_String2String
    {
        private Dictionary<string, string> _myDictionary = new Dictionary<string, string>();

        /// <summary>
        /// Adds an element to the dictionary
        /// </summary>
        /// <param name="key">String value to be used as a key for the dictionary</param>
        /// <param name="val">The string that is being stored.</param>
        public void Add(string key, string val)
        {
            _myDictionary.Add(key, val);
        }
        /// <summary>
        /// Returns the number of items currently stored in the dictionary.
        /// </summary>
        public long Count
        {
            get { return _myDictionary.Count; }
        }
        /// <summary>
        /// Removes all elements stored in the dictionary
        /// </summary>
        public void Clear()
        {
            _myDictionary.Clear();
        }

        public bool ContainsKey(string key)
        {
            return _myDictionary.ContainsKey(key);
        }

        public bool ContainsValue(string val)
        {
            return _myDictionary.ContainsValue(val);
        }

        public bool Remove(string key)
        {
            return _myDictionary.Remove(key);
        }

        public bool TryGetValue(string key, out string val)
        {
            return _myDictionary.TryGetValue(key, out val);

        }
    }

}
