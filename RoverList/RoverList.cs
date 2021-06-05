using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    public class RoverList<T> : RoverListBase<T>
    {
        // Add any variables you need here

        bool headless = true;

        public RoverList ()
        {

        }

        static Node findParentOf(Node start,int Position)
        {
            Node index = start;
            int indexPos = 1;
            for (; index != null && indexPos < Position; indexPos++)index = index.Next;
            if (index != null)
            {
                return index;
            }
            else
            {
                Console.WriteLine("out of bounds error");
                return null;
            };
        }

        static int getSize(Node start)
        {
            Node index = start;
            int size = 0;
            while (index != null)
            {
                size++;
                index = index.Next;
            }
            return size;
        }

        public override int Count => throw new NotImplementedException();

        public override void Add(T data)
        {
            Add(getSize(head), data);
        }

        public override void Add(int Position, T data)
        {
            if (Position == 0)
            {
                if (headless)
                {
                    head = new Node(data);
                    current = head;
                    headless = false;
                }
                else
                {
                    Node buffer = head;
                    head = new Node(data);
                    head.Next = buffer;
                }
            }
            else
            {
                Node index = findParentOf(head,Position); 
                Node buffer = new Node(data);
                buffer.Next=index.Next;
                index.Next = buffer;
            }
        }

        public override void Clear()
        {
            throw new NotImplementedException();
        }

        public override T ElementAt(int Position)
        {
            throw new NotImplementedException();
        }

        public override void ListNodes()
        {
            Node buffer = head;
            while (buffer != null)
            {
                Console.WriteLine(buffer.Data);
                buffer = buffer.Next;
            }
        }

        public override bool RemoveAt(int Position)
        {
            throw new NotImplementedException();
        }
    }
}
