using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Via_Linked
{
    class LinkedList<T>
    {
        class Node<K>
        {

            public Node()
            {

                Data = new K[10];
 
            }

            public K[] Data = new K[10];
            public Node<K> NextNode { get; set; }
        }

        private Node<T>  _head;
        private Node<T>  _tail;
        private int size = 0;
        private int sizeOfNode = 10;

        public int SizeOfNode
        {
            get { return sizeOfNode; }
        }

        public void Add()
        {
            Node<T> addNode = new Node<T>();            

            if (_head == null) 
            {
                _head = addNode;
                _tail = addNode;
                size++;
                return;
            }
                            
                _tail.NextNode = addNode;
                _tail = addNode;            
                size++;
        }

        public int Size
        {
            get { return size; }
        }               

        public T Get(int listIndex)
        {
            int index = (listIndex / SizeOfNode) + 1;
            int elemToInput = (listIndex % SizeOfNode); 
            int counter = 1;
           
            if (Checking(index))
            {
                Node<T> Temp = _head;                
                    if (index == 1)
                    {
                        return _head.Data[elemToInput];
                    }
                    while (counter < index)
                    {
                        Temp = Temp.NextNode;
                        counter++;
                    }
                    return Temp.Data[elemToInput];                                
            }
            
            return default(T);
        }
        public void Insert(T item, int listIndex)
        {
            int index = (listIndex / SizeOfNode)+1;
            int elemToInput = (listIndex % SizeOfNode);            

            int counter = 1;
            if (index <= size)
            {
                Node<T> Temp = _head;
                if (index == 1)
                {
                    _head.Data[elemToInput] = item;
                    return;
                }
                while (counter < index)
                {
                    
                    Temp = Temp.NextNode;
                    counter++;
                }
                Temp.Data[elemToInput] = item;                
                
            }
            
        }

        private bool Checking(int index)
        {
            if (_head == null || index > size)
            {                
                return false;
            }
            return true;
        }

        public void Shrink() 
        {
            int counter = 1;
            Node<T> Temp = _head;
            Node<T> Previous = null;
            while (counter < size)
            {
                Previous = Temp;
                Temp = Temp.NextNode;
                counter++;
            }
            _tail = Previous;
            Previous.NextNode = null;
            size--;
        }
}
}