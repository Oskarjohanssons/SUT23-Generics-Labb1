using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT23_Generics_Labb1
{
    internal class BoxEnumrator:IEnumerator<Box>
    {
        private BoxCollection _boxes;
        private int currentIndex;
        private Box currentBox;

        public BoxEnumrator(BoxCollection box)
        {
            this._boxes = box;
            currentIndex = -1;
            currentBox = default(Box);
        }

        public Box Current
        {
            get { return currentBox; }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public int count
        {
            get { return currentIndex; }
        }


        public void Dispose()
        {
               
        }

        public bool MoveNext()
        {
            if(++currentIndex >= _boxes.Count)
            {
                return false;
            }
            else
            {
                currentBox = _boxes[currentIndex];
            }
            return true;
        }

        public void Reset()
        {
            currentIndex = -1;
        }
    }
}
