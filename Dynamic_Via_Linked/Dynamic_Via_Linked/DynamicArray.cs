using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Via_Linked
{
    class DynamicArray<T> : Buffer<T>
    {
        
        LinkedList<T> HighBuffer = new LinkedList<T>();

        public int Size { get { return counter; } }

        public void Add(T element)
        {
            if (counter % HighBuffer.SizeOfNode == 0) 
            {
                HighBuffer.Add();                
            }
            HighBuffer.Insert(element, counter);
            counter++;
            
        }

        public void Insert(T element, int index)
        {
            if (counter != 0 && counter % HighBuffer.SizeOfNode == 0)
            {
               HighBuffer.Add();
            }
            HighBuffer.Insert(element, index);
            counter++;
            
        }

        public T Get(int index)
        {
            if (IsEmpty())
            {
                Console.WriteLine("Buffer is enmpty");
                return default(T);
            }

           return HighBuffer.Get(index);

        }

        public void Remove(int index)
        {
            if (index >= counter)
            {
                Console.WriteLine("This index is empty");
                return;
            }
           if (counter*4 < HighBuffer.SizeOfNode*HighBuffer.Size && HighBuffer.Size > 2)
            {
                HighBuffer.Shrink();
            }
            for (int k = index; k < counter; k++)
            {
                HighBuffer.Insert(HighBuffer.Get(k+1), k);
            }
            counter--;
        }

        public void Print() 
        {
            for (int i = 0; i < Size; i++)
            {
                Console.WriteLine(HighBuffer.Get(i));
            }
            
        }

    }
}
