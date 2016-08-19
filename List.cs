using System;
using System.Collections.Generic;

namespace LabviewAdvancedProgrammingTechniques
{
    class List_String
    {
        private List<String> _myList = new List<string>();

        public int Count {  get { return _myList.Count; } }
        public int Capacity { get { return _myList.Capacity; } }

        /// <summary>
        /// Adds item to end of the list
        /// </summary>
        /// <param name="val">Item to add</param>
        public void Add(string val)
        {
            _myList.Add(val);
        }

        /// <summary>
        /// Adds the array of items to the end of the list
        /// </summary>
        /// <param name="vals"></param>
        public void AddRange(string[] vals)
        {
            _myList.AddRange(vals);
        }

        /// <summary>
        /// Removes all items from the list
        /// </summary>
        public void Clear()
        {
            _myList.Clear();
        }

        /// <summary>
        /// Returns a boolean indicating that the specified item exists in the list; does not indicate where or how many.
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public bool Contains(string val)
        {
            return _myList.Contains(val);
        }

        /// <summary>
        /// Inserts item at specfied index in the list
        /// </summary>
        /// <param name="index"></param>
        /// <param name="val"></param>
        public void Insert(int index, string val)
        {
            _myList.Insert(index, val);
        }

        /// <summary>
        /// Inserts the array of items at the specified index.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="vals"></param>
        public void InsertRange(int index, string[] vals)
        {
            _myList.InsertRange(index, vals);
        }

        /// <summary>
        /// Removes value from the list, returns a boolean indicating if an item was removed. Will *not* remove multiple copies of specified value.
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public bool Remove(string val)
        {
            return _myList.Remove(val);
        }

        /// <summary>
        /// Removes the element at the specified index.
        /// </summary>
        /// <param name="index"></param>
        public void RemoveAt(int index)
        {
            _myList.RemoveAt(index);
        }

        /// <summary>
        /// Removes count elements starting at index
        /// </summary>
        /// <param name="index"></param>
        /// <param name="count"></param>
        public void RemoveRange(int index, int count)
        {
            _myList.RemoveRange(index, count);
        }

        /// <summary>
        /// Reverses the list
        /// </summary>
        public void Reverse()
        {
            _myList.Reverse();
        }

        /// <summary>
        /// Sorts the list using a default sorter
        /// </summary>
        public void Sort()
        {
            _myList.Sort();
        }

        /// <summary>
        /// Converts the list to an array
        /// </summary>
        /// <returns></returns>
        public string[] ToArray()
        {
           return _myList.ToArray();
        }

    }
    class List_Int
    {
        private List<int> _myList = new List<int>();

        public int Count { get { return _myList.Count; } }
        public int Capacity { get { return _myList.Capacity; } }

        /// <summary>
        /// Adds item to end of the list
        /// </summary>
        /// <param name="val">Item to add</param>
        public void Add(int val)
        {
            _myList.Add(val);
        }

        /// <summary>
        /// Adds the array of items to the end of the list
        /// </summary>
        /// <param name="vals"></param>
        public void AddRange(int[] vals)
        {
            _myList.AddRange(vals);
        }

        /// <summary>
        /// Removes all items from the list
        /// </summary>
        public void Clear()
        {
            _myList.Clear();
        }

        /// <summary>
        /// Returns a boolean indicating that the specified item exists in the list; does not indicate where or how many.
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public bool Contains(int val)
        {
            return _myList.Contains(val);
        }

        /// <summary>
        /// Inserts item at specfied index in the list
        /// </summary>
        /// <param name="index"></param>
        /// <param name="val"></param>
        public void Insert(int index, int val)
        {
            _myList.Insert(index, val);
        }

        /// <summary>
        /// Inserts the array of items at the specified index.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="vals"></param>
        public void InsertRange(int index, int[] vals)
        {
            _myList.InsertRange(index, vals);
        }

        /// <summary>
        /// Removes value from the list, returns a boolean indicating if an item was removed. Will *not* remove multiple copies of specified value.
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public bool Remove(int val)
        {
            return _myList.Remove(val);
        }

        /// <summary>
        /// Removes the element at the specified index.
        /// </summary>
        /// <param name="index"></param>
        public void RemoveAt(int index)
        {
            _myList.RemoveAt(index);
        }

        /// <summary>
        /// Removes count elements starting at index
        /// </summary>
        /// <param name="index"></param>
        /// <param name="count"></param>
        public void RemoveRange(int index, int count)
        {
            _myList.RemoveRange(index, count);
        }

        /// <summary>
        /// Reverses the list
        /// </summary>
        public void Reverse()
        {
            _myList.Reverse();
        }

        /// <summary>
        /// Sorts the list using a default sorter
        /// </summary>
        public void Sort()
        {
            _myList.Sort();
        }

        /// <summary>
        /// Converts the list to an array
        /// </summary>
        /// <returns></returns>
        public int[] ToArray()
        {
            return _myList.ToArray();
        }

    }
    class List_Bool
    {
        private List<bool> _myList = new List<bool>();

        public int Count { get { return _myList.Count; } }
        public int Capacity { get { return _myList.Capacity; } }

        /// <summary>
        /// Adds item to end of the list
        /// </summary>
        /// <param name="val">Item to add</param>
        public void Add(bool val)
        {
            _myList.Add(val);
        }

        /// <summary>
        /// Adds the array of items to the end of the list
        /// </summary>
        /// <param name="vals"></param>
        public void AddRange(bool[] vals)
        {
            _myList.AddRange(vals);
        }

        /// <summary>
        /// Removes all items from the list
        /// </summary>
        public void Clear()
        {
            _myList.Clear();
        }

        /// <summary>
        /// Returns a boolean indicating that the specified item exists in the list; does not indicate where or how many.
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public bool Contains(bool val)
        {
            return _myList.Contains(val);
        }

        /// <summary>
        /// Inserts item at specfied index in the list
        /// </summary>
        /// <param name="index"></param>
        /// <param name="val"></param>
        public void Insert(int index, bool val)
        {
            _myList.Insert(index, val);
        }

        /// <summary>
        /// Inserts the array of items at the specified index.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="vals"></param>
        public void InsertRange(int index, bool[] vals)
        {
            _myList.InsertRange(index, vals);
        }

        /// <summary>
        /// Removes value from the list, returns a boolean indicating if an item was removed. Will *not* remove multiple copies of specified value.
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public bool Remove(bool val)
        {
            return _myList.Remove(val);
        }

        /// <summary>
        /// Removes the element at the specified index.
        /// </summary>
        /// <param name="index"></param>
        public void RemoveAt(int index)
        {
            _myList.RemoveAt(index);
        }

        /// <summary>
        /// Removes count elements starting at index
        /// </summary>
        /// <param name="index"></param>
        /// <param name="count"></param>
        public void RemoveRange(int index, int count)
        {
            _myList.RemoveRange(index, count);
        }

        /// <summary>
        /// Reverses the list
        /// </summary>
        public void Reverse()
        {
            _myList.Reverse();
        }

        /// <summary>
        /// Sorts the list using a default sorter
        /// </summary>
        public void Sort()
        {
            _myList.Sort();
        }

        /// <summary>
        /// Converts the list to an array
        /// </summary>
        /// <returns></returns>
        public bool[] ToArray()
        {
            return _myList.ToArray();
        }

    }
    class List_Double
    {
        private List<double> _myList = new List<double>();

        public int Count { get { return _myList.Count; } }
        public int Capacity { get { return _myList.Capacity; } }

        /// <summary>
        /// Adds item to end of the list
        /// </summary>
        /// <param name="val">Item to add</param>
        public void Add(double val)
        {
            _myList.Add(val);
        }

        /// <summary>
        /// Adds the array of items to the end of the list
        /// </summary>
        /// <param name="vals"></param>
        public void AddRange(double[] vals)
        {
            _myList.AddRange(vals);
        }

        /// <summary>
        /// Removes all items from the list
        /// </summary>
        public void Clear()
        {
            _myList.Clear();
        }

        /// <summary>
        /// Returns a boolean indicating that the specified item exists in the list; does not indicate where or how many.
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public bool Contains(double val)
        {
            return _myList.Contains(val);
        }

        /// <summary>
        /// Inserts item at specfied index in the list
        /// </summary>
        /// <param name="index"></param>
        /// <param name="val"></param>
        public void Insert(int index, double val)
        {
            _myList.Insert(index, val);
        }

        /// <summary>
        /// Inserts the array of items at the specified index.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="vals"></param>
        public void InsertRange(int index, double[] vals)
        {
            _myList.InsertRange(index, vals);
        }

        /// <summary>
        /// Removes value from the list, returns a boolean indicating if an item was removed. Will *not* remove multiple copies of specified value.
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public bool Remove(double val)
        {
            return _myList.Remove(val);
        }

        /// <summary>
        /// Removes the element at the specified index.
        /// </summary>
        /// <param name="index"></param>
        public void RemoveAt(int index)
        {
            _myList.RemoveAt(index);
        }

        /// <summary>
        /// Removes count elements starting at index
        /// </summary>
        /// <param name="index"></param>
        /// <param name="count"></param>
        public void RemoveRange(int index, int count)
        {
            _myList.RemoveRange(index, count);
        }

        /// <summary>
        /// Reverses the list
        /// </summary>
        public void Reverse()
        {
            _myList.Reverse();
        }

        /// <summary>
        /// Sorts the list using a default sorter
        /// </summary>
        public void Sort()
        {
            _myList.Sort();
        }

        /// <summary>
        /// Converts the list to an array
        /// </summary>
        /// <returns></returns>
        public double[] ToArray()
        {
            return _myList.ToArray();
        }

    }
}
