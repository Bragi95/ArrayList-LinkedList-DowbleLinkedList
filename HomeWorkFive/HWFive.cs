using System;
using System.Globalization;

namespace HomeWorkFive
{
    public class HWFive
    {

        private int[] _array;
        public HWFive(int[]_array)
        {
            this._array = _array;
        }
        
        public HWFive()
        {
            
        }
        public int[] AddFirst(int value)
        {
            int[] newArray = new int[_array.Length + 1];
            newArray[0] = value;
            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i+1] = _array[i];
            }
            _array = newArray;

            return _array;

        }
        public int[] AddFirstArr(int[] values)
        {
            int[] newArray = new int[_array.Length + values.Length];

            for (int i = 0; i < values.Length; i++)
            {
                newArray[i] = values[i];
            }
            for (int i = 0; i < _array.Length; i++)
            {
                newArray[values.Length + i] = _array[i];
            }
            _array = newArray;
            return _array;

        }
        public int[] AddLast(int value)
        {
            int[] newArray = new int[_array.Length + 1];
            newArray[newArray.Length - 1] = value;
            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;

            return _array;

        }

        public int[] AddLast(int[] values)
        {
            int[] newArray = new int[_array.Length + values.Length];

            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }
            for (int i = 0; i < values.Length; i++)
            {
                newArray[_array.Length+i] = values[i];
            }
            _array = newArray;
            return _array;

        }

        public int[] AddAt(int value, int idx)
        {
            
            int[] newArray = new int[_array.Length + 1];
            if (idx < 0 || idx > newArray.Length)
            {
                return new int[] { };
            }
            newArray[idx] = value;
            for (int i = 0; i < idx; i++)
            {
                newArray[i] = _array[i];
            }
            for (int i = idx; i < newArray.Length-1; i++)
            {
                newArray[i + 1] = _array[i];
            }

            _array = newArray;

            return _array;

        }
        public int[] AddAt(int[] value, int idx)
        {
           
            int[] newArray = new int[_array.Length + value.Length];
            if (idx < 0 || idx > newArray.Length)
            {
                return new int[] { };
            }
            for (int i = 0; i < idx; i++)
            {
                newArray[i] = _array[i];
            }
            for (int i = 0; i < value.Length; i++)
            {
                newArray[i+idx] = value[i];
            }
            for (int i = 0; i < _array.Length-idx; i++)
            {
                newArray[i + value.Length+idx] = _array[idx+i];
            }

            _array = newArray;

            return _array;

        }
        public int GetSize(int[] value)
        {
            return value.Length;
        }

        public int[] Set(int idx, int value)
        {
            if (idx < 0 || idx > _array.Length)
            {
                return new int[] { };
            }
            for (int i = 0; i < _array.Length; i++)
            {
                if (i == idx)
                {
                    _array[i] = value;
                }
            }
            return _array;
        }

        public int[] RemoveFirst(int[] _array)
        {
            if (_array.Length < 1)
            {
                return new int[] { };
            }

            int[] newArray = new int[_array.Length - 1];

            
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = _array[i + 1];
            }
            _array = newArray;

            return _array;
        }

        public int[] RemoveLast(int[] _array)
        {
            if (_array.Length < 1)
            {
                return new int[] { };
            }
            int[] newArray = new int[_array.Length - 1];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;

            return _array;
        }

        public int[] RemoveAtt(int idx)
        {
            
            int[] newArray = new int[_array.Length - 1];
            if (idx < 0 || idx > newArray.Length)
            {
                return new int[] { };
            }
            for (int i = 0; i < idx; i++)
            {
                newArray[i] = _array[i];
            }
            for (int i = idx ; i < newArray.Length; i++)
            {
                newArray[i] = _array[i+1];
            }
            _array = newArray;

            return _array;
        }
        public int[] RemoveAll(int value)
        {

            int Count = 0;
            for (int i = 0; i < _array.Length; i++)
            {

                if (_array[i] == value)
                {
                    Count++;

                }
            }
            int[] newArray = new int[_array.Length - Count];
            int q = 0;

            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] != value)
                {
                    newArray[q] = _array[i];
                    q++;
                }

            }
            _array = newArray;

            return _array;
        }

        public bool Contains(int value)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] == value)
                {
                    return true;
                }
            }
            return false;
        }

        public int IndexOf(int value)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }

        public int[] ToArray(int[]_array)
        {
            return _array;
        }

        public int GetFirst(int[] _array)
        {
            if(_array.Length<1)
            {
                return 0;
            }
            return _array[0];
        }

        public int GetLast(int[] _array)
        {
            if (_array.Length < 1)
            {
                return 0;
            }
            return _array[_array.Length - 1];
        }

        public int Get(int idx)
        {
            if (idx < 0 || idx > _array.Length)
            {
                return 0;
            }
            return _array[idx];
        }

        public int[] Reverse(int[] _array)
        {
            int f;
            for (int i = 0; i < _array.Length/2; i++)
            {
                f = _array[_array.Length - i - 1];
                _array[_array.Length - i - 1] = _array[i];
                _array[i] = f;
            }
            return _array;
        }

        public int Max(int[] _array)
        {

            if (_array.Length < 1)
            {
                return 0;
            }
            int max = _array[0];
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] > max)
                {
                    max = _array[i];

                }
            }
            return max;
        }
        public int Min(int[] _array)
        {
            if (_array.Length < 1)
            {
                return 0;
            }
            int min = _array[0];
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] < min)
                {
                    min = _array[i];

                }
            }
            return min;
        }

        public int IndexOfMax(int[] _array)
        {
            if (_array.Length < 1)
            {
                return -1;
            }
            int maxI = 0;
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] > maxI)
                {
                    maxI = i;

                }
            }
            return maxI;
        }

        public int IndexOfMin(int[] _array)
        {
            if (_array.Length < 1)
            {
                return -1;
            }
            int minI = 0;
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] < minI)
                {
                    minI = i;

                }
            }
            return minI;
        }

        public int[] Sort(int[] _array)
        {
            if (_array.Length < 1)
            {
                return new int[] { };
            }
            for (int i = 0; i < _array.Length - 1; i++)
            {
                for (int j = 0 + i; j < _array.Length; j++)
                {
                    if (_array[j] < _array[i])
                    {
                        int c = _array[i];
                        _array[i] = _array[j];
                        _array[j] = c;
                    }
                }
            }
            return _array;
        }

        public int[] SortDesc(int[] _array)
        {
            if (_array.Length < 1)
            {
                return new int[] { };
            }
            for (int i = 0; i < _array.Length - 1; i++)
            {

                for (int j = 0 + i; j < _array.Length; j++)
                {
                    if (_array[j] > _array[i])
                    {
                        int c = _array[i];
                        _array[i] = _array[j];
                        _array[j] = c;
                    }
                }

            }
            return _array;
        }
    }
}
