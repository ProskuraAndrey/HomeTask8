using System;
using System.Collections;
using System.Collections.Generic;

namespace HomeTask8
{
   public class DoublyLinkedList<T> : IEnumerable<T>
    {
            DoulbyUnit<T> head;
            DoulbyUnit<T> tail;
            int count;

            public void Add(T data)
            {
                DoulbyUnit<T> _doulbyUnit = new DoulbyUnit<T>(data);
                if (head == null)
                    head = _doulbyUnit;
                else
                {
                    tail.Next = _doulbyUnit;
                    tail.Previous = tail;
                }
                tail = _doulbyUnit;
                count++;
            }

            public void AddFirst(T data)
            {
                DoulbyUnit<T> _unit = new DoulbyUnit<T>(data);
                DoulbyUnit<T> temp = head;
                _unit.Next = temp;
                head = _unit;
                if (count == 0)
                    tail = head;
                else
                    temp.Previous = _unit;
                count++;
            }

            public bool Remove(T data)
            {
                DoulbyUnit<T> actual = head;
                DoulbyUnit<T> prior = null;

                //search element for delete - method Contains
                while (actual != null)
                {
                    if (actual.Data.Equals(data))
                    {
                        break;
                    }
                    actual = actual.Next;
                }
                if (actual != null)
                {
                    //if element not last
                    if (actual.Next != null)
                    {
                        actual.Next.Previous = actual.Previous;
                    }
                    else
                    {
                        //if element last
                        tail = actual.Previous;
                    }

                    //if element not first
                    if (actual.Previous != null)
                    {
                        actual.Previous.Next = actual.Next;
                    }
                    else
                    {
                        //if - first
                        head = actual.Next;
                    }

                    count--;
                    return true;
                }
                return false;
            }

            public int Count { get { return count; } }

            public bool IsEmpty
            {
                get
                {
                    if (count == 0)
                        return true;
                    return false;
                }
            }

            public bool Contains(T data)
            {
                DoulbyUnit<T> actual = head;
                while (actual != null)
                {
                    if (actual.Data.Equals(data))
                        return true;
                    actual = actual.Next;
                }
                return false;
            }

            public void Clear()
            {
                head = null;
                tail = null;
                count = 0;
            }

            //way in one side
            public IEnumerator<T> GetEnumerator()
            {
                DoulbyUnit<T> actual = head;
                while (actual != null)
                {
                    yield return actual.Data;
                    actual = actual.Next;
                }
            }

            //way in other side
            public IEnumerator<T> BackEnumerator()
            {
                DoulbyUnit<T> actual = tail;
                while (actual != null)
                {
                    yield return actual.Data;
                    actual = actual.Previous;
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
    }