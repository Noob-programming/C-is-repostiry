using System;
using System.Collections;

namespace ConsoleApp5
{

    class FiveInteger : IEnumerable
    {
        private int[] _value;

        public FiveInteger(int[] value)
        {
            _value = value;
        }


        public IEnumerator GetEnumerator()
        {
            foreach (var i in _value)
            {
                yield return i;
            }
        }


        class Enumerator : IEnumerator
        {
            private FiveInteger _integer;
            private int currentIndex = -1;

            public Enumerator(FiveInteger integer)
            {
                _integer = integer;
            }


            public bool MoveNext()
            {
                if (currentIndex >= _integer._value.Length - 1)
                    return false;
                return ++currentIndex < _integer._value.Length;
            }

            public void Reset()
            {
                currentIndex = -1;
            }


            public object Current
            {
                get
                {
                    if (currentIndex == -1)
                        throw new InvalidOperationException("enum does not started");
                    if (currentIndex == _integer._value.Length)
                        throw new InvalidOperationException("enum does not ended");
                    return _integer._value[currentIndex];
                }
            }
        }
    }
}