namespace IntArrayList
{
    public class IntArrayList
    {
        private int[] _buffer;

        private int _elementsCount;
        private int _realBufferSize;

        private readonly int _defaultBufferSize = 2;

        public IntArrayList()
        {
            _realBufferSize = _defaultBufferSize;
            _buffer = new int[_realBufferSize];
        }

        public IntArrayList(int size)
        {
            _realBufferSize = size;
            _buffer = new int[_realBufferSize];
        }

        public int Count { get { return _elementsCount; } }
        public int Capacity { get { return _realBufferSize; } }

        public int this[int index]
        {
            get { return _buffer[index]; }
            set { _buffer[index] = value; }
        }

        public void PushBack(int value)
        {
            if (_elementsCount == _realBufferSize)
            {
                EncreaseBufferSize(1);
            }

            _buffer[_elementsCount] = value;
            _elementsCount++;
        }

        public void PopBack()
        {
            if (_elementsCount == 0) { return; }

            _buffer[_elementsCount - 1] = 0;
            _elementsCount--;
        }

        public bool TryInsert(int index, int value)
        {
            if (index < 0)
            {
                return false;
            }

            if (index >= _elementsCount)
            {
                if (index >= _realBufferSize)
                {
                    int loops = 0;
                    int newBufferSize = _realBufferSize;

                    while (index >= newBufferSize)
                    {
                        newBufferSize *= 2;
                        loops++;
                    }

                    EncreaseBufferSize(loops);
                }

                _buffer[index] = value;
                _elementsCount = index + 1;
            }
            else
            {
                if (_elementsCount == _realBufferSize)
                {
                    EncreaseBufferSize(1);
                }

                int[] newBuffer = new int[_realBufferSize];

                for (int i = 0; i < index; i++)
                {
                    newBuffer[i] = _buffer[i];
                }

                newBuffer[index] = value;

                for (int i = index; i < _elementsCount; i++)
                {
                    newBuffer[i + 1] = _buffer[i];
                }

                _buffer = newBuffer;
                _elementsCount++;
            }

            return true;
        }

        public bool TryErase(int index)
        {
            if (index < 0 || index >= _elementsCount)
            {
                return false;
            }

            int[] newBuffer = new int[_realBufferSize];

            for (int i = 0; i < index; i++)
            {
                newBuffer[i] = _buffer[i];
            }

            for (int i = index + 1; i < _elementsCount; i++)
            {
                newBuffer[i - 1] = _buffer[i];
            }

            _buffer = newBuffer;
            _elementsCount--;

            return true;
        }

        public bool TryGetAt(int index, out int result)
        {
            if (index < 0 || index >= _elementsCount)
            {
                result = 0;
                return false;
            }

            result = _buffer[index];
            return true;
        }

        public void Clear()
        {
            _realBufferSize = _defaultBufferSize;
            _buffer = new int[_realBufferSize];
            _elementsCount = 0;
        }

        public bool TryForceCapacity(int newCapacity)
        {
            if (newCapacity < 0)
            {
                return false;
            }

            _realBufferSize = newCapacity;

            if (_elementsCount > _realBufferSize)
            {
                _elementsCount = _realBufferSize;
            }

            CreateNewBuffer();

            return true;
        }

        public int Find(int value)
        {
            for (int i = 0; i < _elementsCount; i++)
            {
                if (_buffer[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }

        private void EncreaseBufferSize(int times)
        {
            for (int i = 0; i < times; i++)
            {
                _realBufferSize *= 2;
            }

            CreateNewBuffer();
        }

        private void CreateNewBuffer()
        {
            int[] newBuffer = new int[_realBufferSize];

            for (int i = 0; i < _elementsCount; i++)
            {
                newBuffer[i] = _buffer[i];
            }

            _buffer = newBuffer;
        }
    }
}
