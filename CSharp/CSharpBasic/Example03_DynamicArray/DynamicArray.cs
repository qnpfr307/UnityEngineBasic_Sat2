using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03_DynamicArray
{
    internal class DynamicArray<T> : IEnumerable<T>
    {
        private const int DEFAULT_SIZE = 1;
        private T[] _data = new T[DEFAULT_SIZE];

        public T Count; // 실제 데이터 개수

        // 프로퍼티(Property)
        // set / get 접근자를 멤버로 가질 수 있는 필드

        public T Capacity
        {
            get 
            { 
                return _data.Length;
            }     
        }

        // 삽입 알고리즘
        // 일반적으로 O(1)
        // Capacity 가 모자랄 때는 : O(N)

        public void Add(T item)
        {
            // Capacity 가 모자라면 배열 크기를 늘림
            if(Count >= Capacity)
            {
                T[] tmp = new T[Capacity * 2];
                for(int i = 0; i < Count; i++)
                {
                    tmp[i] = _data[i];
                }
                _data = tmp;
            }                   
            
            _data[Count] = item;
            Count ++;
        }

        // 탐색 알고리즘
        public i FindIndex(T item)
        {
            for(int i = 0; i < Count; i++)
            {
                if (Comparer<T>.Default.Compare(_data[i], item) == 0)
                    return i;
            }
            return -1;
        }

        // 삭제 알고리즘
        public bool RemoveAt(int index)
        {
            if(index < 0 || index >= Count -1)
                return false;

           for(int i = index; i < Count -1; i++)
            {
                _data[i] = _data[i + 1];
            }
            _data[Count - 1] = default(T);
            Count--;

            return true;
        }

        public bool Remove(T item)
        {
            return RemoveAt(FindIndex(item));
        }
        public IEnumerator<T> GetEnumerator()
        {
            return new DynamicArrayEnum<T>(_data);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public class DynamicArrayEnum<T> : IEnumerator<T>
    {
        private readonly T[] _data;
        private int _index = -1;
        public T Current
        {
            get
            {
                try
                {
                    return _data[_index];
                }
                catch
                {
                    throw new InvalidOperationException();
                }
            }
        }

        object IEnumerator.Current { get => Current; }

        public DynamicArray(T[] data)
            => _data = data;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            _index++;
            return (_index >= 0) && (_index < _data.Length);
        }

        public void Reset()
        {
            _index = -1;
        }
    }
}
