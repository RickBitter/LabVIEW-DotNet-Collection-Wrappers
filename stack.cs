using System;
using System.Collections.Generic;
using System.Linq;


namespace LabviewAdvancedProgrammingTechniques
{
    public class Stack_Double
    {
        private Stack<double> _myQ = new Stack<double>();

        /// <summary>
        /// Returns the number of items in the queue as an int
        /// </summary>
        public int Count { get { return _myQ.Count; } }
        /// <summary>
        /// returns the number of items in the queue as a long
        /// </summary>
        public long LongCount { get { return _myQ.LongCount(); } }

        /// <summary>
        /// removes all the elements in the queue
        /// </summary>
        public void Clear()
        {
            _myQ.Clear();
        }

        /// <summary>
        /// Searches the queue for the specified value
        /// </summary>
        /// <param name="val">Value to be searched for</param>
        /// <returns>boolean indicating if val is present</returns>
        public bool Contains(double val)
        { return _myQ.Contains(val); }

        public double[] CopyTo(int startAt)
        {
            double[] result = null;
            _myQ.CopyTo(result, startAt);
            return result;
        }

        public double Pop()
        {
            return _myQ.Pop();
        }

        public void Push(double val)
        {
            _myQ.Push(val);
        }


        public double Peek()
        {
            return _myQ.Peek();
        }

        public double[] ToArray()
        {
            return _myQ.ToArray();
        }

        public override string ToString()
        {
            return _myQ.ToString();
        }

    }
    public class Stack_String
    {
        private Stack<string> _myQ = new Stack<string>();

        /// <summary>
        /// Returns the number of items in the queue as an int
        /// </summary>
        public int Count { get { return _myQ.Count; } }
        /// <summary>
        /// returns the number of items in the queue as a long
        /// </summary>
        public long LongCount { get { return _myQ.LongCount(); } }

        /// <summary>
        /// removes all the elements in the queue
        /// </summary>
        public void Clear()
        {
            _myQ.Clear();
        }

        /// <summary>
        /// Searches the queue for the specified value
        /// </summary>
        /// <param name="val">Value to be searched for</param>
        /// <returns>boolean indicating if val is present</returns>
        public bool Contains(string val)
        { return _myQ.Contains(val); }

        public string[] CopyTo(int startAt)
        {
            string[] result = null;
            _myQ.CopyTo(result, startAt);
            return result;
        }

        public string Pop()
        {
            return _myQ.Pop();
        }

        public void Push(string val)
        {
            _myQ.Push(val);
        }


        public string Peek()
        {
            return _myQ.Peek();
        }

        public string[] ToArray()
        {
            return _myQ.ToArray();
        }

        public override string ToString()
        {
            return _myQ.ToString();
        }

    }
    public class Stack_Bool
    {
        private Stack<bool> _myQ = new Stack<bool>();

        /// <summary>
        /// Returns the number of items in the queue as an int
        /// </summary>
        public int Count { get { return _myQ.Count; } }
        /// <summary>
        /// returns the number of items in the queue as a long
        /// </summary>
        public long LongCount { get { return _myQ.LongCount(); } }

        /// <summary>
        /// removes all the elements in the queue
        /// </summary>
        public void Clear()
        {
            _myQ.Clear();
        }

        /// <summary>
        /// Searches the queue for the specified value
        /// </summary>
        /// <param name="val">Value to be searched for</param>
        /// <returns>boolean indicating if val is present</returns>
        public bool Contains(bool val)
        { return _myQ.Contains(val); }

        public bool[] CopyTo(int startAt)
        {
            bool[] result = null;
            _myQ.CopyTo(result, startAt);
            return result;
        }

        public bool Pop()
        {
            return _myQ.Pop();
        }

        public void Push(bool val)
        {
            _myQ.Push(val);
        }


        public bool Peek()
        {
            return _myQ.Peek();
        }

        public bool[] ToArray()
        {
            return _myQ.ToArray();
        }

        public override string ToString()
        {
            return _myQ.ToString();
        }

    }
    public class Stack_Int
    {
        private Stack<int> _myQ = new Stack<int>();

        /// <summary>
        /// Returns the number of items in the queue as an int
        /// </summary>
        public int Count { get { return _myQ.Count; } }
        /// <summary>
        /// returns the number of items in the queue as a long
        /// </summary>
        public long LongCount { get { return _myQ.LongCount(); } }

        /// <summary>
        /// removes all the elements in the queue
        /// </summary>
        public void Clear()
        {
            _myQ.Clear();
        }

        /// <summary>
        /// Searches the queue for the specified value
        /// </summary>
        /// <param name="val">Value to be searched for</param>
        /// <returns>boolean indicating if val is present</returns>
        public bool Contains(int val)
        { return _myQ.Contains(val); }

        public int[] CopyTo(int startAt)
        {
            int[] result = null;
            _myQ.CopyTo(result, startAt);
            return result;
        }

        public int Pop()
        {
            return _myQ.Pop();
        }

        public void Push(int val)
        {
            _myQ.Push(val);
        }


        public int Peek()
        {
            return _myQ.Peek();
        }

        public int[] ToArray()
        {
            return _myQ.ToArray();
        }

        public override string ToString()
        {
            return _myQ.ToString();
        }

    }
}
