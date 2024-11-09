using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsConsoleApp
{
    public interface IIterator<T>
    {
        public T GetCurrent();

        public bool MoveNext();

        public void Reset();
    }

    public class MatrixList<T> : IIterator<T>
    {
        private T _current;

        private int _currentX = 0;
        private int _currentY = 0;

        public T[,] values;

        public MatrixList(int n)
        {
            this.values = new T[n, n];
            this._current = this.values[0, 0];
        }

        public T GetCurrent()
        {
            return values[_currentY, _currentX];
        }

        public bool MoveNext()
        {
            if (_currentX != values.GetLength(1) - 1)
            {
                _currentX++;
                this._current = values[_currentY, _currentX];
                return true;
            }
            else if (_currentX == values.GetLength(1) - 1 && _currentY != values.GetLength(0) - 1)
            {
                _currentY++;
                _currentX = 0;
                this._current = values[_currentY, _currentX];
                return true;
            }
     
            return false;
        }

        public void Reset()
        {
            this._currentX = 0;
            this._currentY = 0;
        }
    }
}
