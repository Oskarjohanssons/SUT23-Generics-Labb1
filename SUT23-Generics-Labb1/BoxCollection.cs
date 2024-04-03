using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT23_Generics_Labb1
{
    internal class BoxCollection : ICollection<Box>
    {
        private List<Box> innerCollection;
        public BoxCollection()
        {
            innerCollection = new List<Box>();
        }
        public int Count {  get { return innerCollection.Count; } }

        public bool IsReadOnly { get { return false; } }

        public Box this[int index]
        {
            get { return innerCollection[index]; }
            set { innerCollection[index] = value;}
        }

        public void Add(Box item)
        {
            if (!Contains(item))
            {
                innerCollection.Add(item);
            }
            else
            {
                Console.WriteLine("This box does allready exist in the collection");
            }
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(Box item)
        {
            bool founded = false;
            foreach (Box b in innerCollection) 
            {
                if (b.Equals(item))
                {
                    founded = true;
                    break;
                }
            }
            return founded;
        }

        public bool Contains(Box item, EqualityComparer<Box> comp)
        {
            bool found = false;
            foreach (Box b in innerCollection)
            {
                if (comp.Equals(b, item))
                {
                    found = true;
                }
            }
            return found;
        }

        public void CopyTo(Box[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Box> GetEnumerator()
        {
            return new BoxEnumrator(this);
        }

        public bool Remove(Box item)
        {
            bool result = false;
            for(int i = 0; i < innerCollection.Count; i++)
            {
                Box currentBox = innerCollection[i];
                if(new BoxProp().Equals(currentBox, item))
                {
                    innerCollection.RemoveAt(i);
                    result = true;
                    Console.WriteLine("Box with these values H= {0} L= {1} W= {2} V= {3} has been removed",
                        item.Height.ToString(), item.Length.ToString(), item.Width.ToString(), item.Volume.ToString());
                    break;
                }
            }
            return result;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
