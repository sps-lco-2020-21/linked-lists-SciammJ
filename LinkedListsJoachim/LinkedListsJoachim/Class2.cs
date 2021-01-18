using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListsJoachim
{
    public class IntegerLinkedList
    {
        int _value;
        IntegerLinkedList _next;

        public IntegerLinkedList(int value)
        {
            _value = value;
            _next = null;
        }
        public void Append(int value)
        {
            if (_next == null)
            {
                _next = new IntegerLinkedList(value);
                return;
            }
            _next.Append(value);
        }
        public int Value
        {
            get { return _value; }
        }
        public IntegerLinkedList Next
        {
            get { return _next; }
        }
        public IntegerLinkedList NextSetter
        {
            set { _next = value; }
        }
        public void Remove(int pointer)
        {
            if (pointer == 1)
            {
                _next = _next.Next;
            }
            _next.Remove(pointer - 1);
        }
        public int Count
        {
            get
            {
                if (_next == null)
                {
                    return 1;
                }
                return _next.Count + 1; 
            }
        }
        public int Sum
        {
            get
            {
                if (_next == null)
                {
                    return _value;
                }
                return _next.Sum + _value;
            }
        }
        public bool Delete(int value)
        {
            if (_value == value)
            {
                _next = _next.Next;
                return true;
            }
            _next.Delete(value);
            return false;
        }
        public void RemoveDuplicates(int value)
        {
            bool booler = true;
            while (booler){
                booler = _next.Delete(value);
            }
            if(_next == null)
            {
                return;
            }
            _next.RemoveDuplicates(value);
        }
        public void AlternateMerge(IntegerLinkedList ill)
        {
            if(_next == null)
            {
                _next = ill;
                return;
            }
            ill.NextSetter = _next.Next;
            _next = ill;
            _next.AlternateMerge(ill.Next);
        }
        
    }
}
