using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example05_MyHashtable
{
    internal class MyHashtable<T, K>
    {
        private const int DEFAULT_SIZE = 1000;
        private LinkedList<K>[] _bukket = new LinkedList<K>[DEFAULT_SIZE];
        private int _tmpHash;

        // 삽입 알고리즘
        // Hash 함수 시간을 무시한 이상적인 경우에 O(1)
        public void Add(T key, K value)
        {
            _tmpHash = Hash(key);
            if(_bukket[_tmpHash] == null)
                _bukket[_tmpHash] = new LinkedList<K>();
            _bukket[_tmpHash].AddLast(value);
        }

        // 탐색 알고리즘
        // Hash 함수 시간을 무시한 이상적인 경우에 O(1)
        public bool ContainsKey(T target)
        {
            _tmpHash = Hash(target);
            if (_bukket [_tmpHash] != null && _bukket[_tmpHash].Count > 0)
                return true;

            return false;
        }

        public bool TryGetValue(T key, out K value)
        {
            bool isOK = true;
            value = default(K);
            _tmpHash = Hash(key);

            try
            {
                value = _bukket[_tmpHash].First();
            }
            catch
            {
                isOK = false;
            }

            return isOK;
        }

        // 삭제 알고리즘
        // Hash 함수 시간을 무시한 이상적인 경우에 O(1)
        public bool Remove(T key)
        {
            _tmpHash = Hash(key);
            if(_bukket[_tmpHash] != null)
            {
                _bukket[_tmpHash].Clear();
                _bukket[_tmpHash] = null;

                return true;
            }
            return false;
        }

        public void Clear()
        {
            for (int i = 0; i < _bukket.Length; i++)
            {
                if (_bukket[i] != null)
                { 
                    _bukket[i].Clear();
                    _bukket[i] = null;
                }
            }
        }

        private int Hash(T key)
        {
            _tmpHash = 0;
            string tmpString = key.ToString();
            for(int i = 0; i < tmpString.Length; i++)
            {
                _tmpHash += tmpString[i];
            }

            _tmpHash %= DEFAULT_SIZE;

            return _tmpHash;
        }
    }
}
