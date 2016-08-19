using System.Collections.Generic;
using System.Linq;


namespace LabviewAdvancedProgrammingTechniques
{
    /// <summary>
    /// Wrapper class around the .NET Queue class for Doubles
    /// </summary>
    public class Queue_Double
    {
        private Queue<double> _myQ = new Queue<double>();

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
        { double[] result=null;
            _myQ.CopyTo(result, startAt);
            return result;
        } 

        public double Dequeue()
        {
            return _myQ.Dequeue();
        }

        public void Enqueue(double val)
        {
            _myQ.Enqueue(val);
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
    public class Queue_String
    {
        private Queue<string> _myQ = new Queue<string>();

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

        public string Dequeue()
        {
            return _myQ.Dequeue();
        }

        public void Enqueue(string val)
        {
            _myQ.Enqueue(val);
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
    public class Queue_Bool
    {
        private Queue<bool> _myQ = new Queue<bool>();

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

        public bool Dequeue()
        {
            return _myQ.Dequeue();
        }

        public void Enqueue(bool val)
        {
            _myQ.Enqueue(val);
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
    public class Queue_Int
    {
        private Queue<int> _myQ = new Queue<int>();

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

        public int Dequeue()
        {
            return _myQ.Dequeue();
        }

        public void Enqueue(int val)
        {
            _myQ.Enqueue(val);
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
