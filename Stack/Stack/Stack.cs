using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack
{
    public class Stack
    {
        private readonly List<object> _stack = new List<object>();

        public void Push(object obj)
        {
            if (_stack == null)
                throw new InvalidOperationException("Object can not be Null");

            _stack.Add(obj);

        }

        public object Pop()
        {
            if (_stack.Count < 1)
                throw new InvalidOperationException("Stack is Empty");

            object last = _stack.Last();
            _stack.RemoveAt(_stack.Count - 1);
            return last;
        }

        public void Clear()
        {
            _stack.Clear();
        }
    }
}
