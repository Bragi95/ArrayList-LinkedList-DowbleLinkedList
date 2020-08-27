using System;
using HomeWorkFive;


namespace HWLinkedList
{
    public class LinkedList 
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        private int Count;


        public void AddFirst(int value)
        {
            Node node = new Node(value);
            if (Head == null)
            {
                Head = node;
                Tail = node;
            }

            node.Next = Head;
            Head = node;
            Count++;
        }
        public void AddFirst(int[] value)
        {
            if (value.Length < 1)
            {
                return;
            }

            for (int i = 0; i < value.Length; i++)
            {
                AddFirst(value[i]);
            }
        }

        public void AddLast(int value)
        {
            Node node = new Node(value);
            if (Head == null)
            {
                Head = node;                
            }

            if (Tail != null)
            {
                Tail.Next = node;                
            }
            Tail = node;
            Count++;
        }

        public void AddLast(int[] value)
        {
            
            for (int i = 0; i < value.Length; i++)
            {
                AddLast(value[i]);
            }
        }

        public void AddAt(int index, int value)
        {
            if(index>Count-1 || index<0)
            {
                throw new Exception("Хуй тебе");
            }

            int count = 0;
            Node currentNode = Head;
            Node prevNode = null;       
            while (currentNode != null)
            {                
                if(index==count)
                {
                    Node node = new Node(value);
                    if (prevNode == null)
                    {
                        AddFirst(value);
                    }                                                      
                    prevNode.Next = node;
                    node.Next = currentNode;
                    Count++;
                    break;
                }
                prevNode = currentNode;
                currentNode = currentNode.Next;
                count++;
            }            
        }


        public void AddAt(int index, int[] value)
        {
            if (index > Count - 1 || index < 0)
            {
                throw new Exception("Error");
            }

            for (int i = 0; i < value.Length; i++)
            {
                int count = 0;
                Node currentNode = Head;
                Node prev = null;
                while (currentNode != null)
                {
                    if (index == count)
                    {
                        Node node = new Node(value[i]);
                        if (prev == null)
                        {
                            AddFirst(value);
                        }
                        prev.Next = node;
                        node.Next = currentNode;
                        Count++;
                        break;
                    }
                    prev = currentNode;
                    currentNode = currentNode.Next;
                    count++;
                }
            }
        }
        public void Print()
        {
            Node con = Head;
            while(con!=null)
            {
                Console.WriteLine(con.Value);
                con = con.Next;
            }
        }
        public int GetSize()
        {
            return Count;
        }

        public void Set(int index, int value)
        {
            if (index > Count - 1 || index < 0)
            {
                throw new Exception("Хуй тебе");
            }

            int count = 0;
            Node currentNode = Head;
            while (currentNode != null)
            {
                if (index == count)
                {
                    currentNode.Value = value;
                    break;
                }               
                currentNode = currentNode.Next;
                count++;
            }
        }
        public void RemoveFirst()
        {
            if (Head==null)
            {
                return;
                //throw new Exception("Список пустой");
            }
            if (Count == 1)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Head = Head.Next;
            }
            Count--;
        }

        public void RemoveLast()
        {
            if (Count == 1)
            {
                Head = null;
                Tail = null;
                
                Count--;
            }
            int count = 0;
            Node currentNode = Head;
            while (currentNode != null)
            {
                if (Count-2 == count)
                {
                    currentNode.Next = Tail.Next;
                    Tail = currentNode;
                    Count--;
                    break;
                }
                currentNode = currentNode.Next;
                count++;
            }
        }


        public void RemoveAt(int index)
        {
            if (Count == 1)
            {
                Head = null;
                Tail = null;

                Count--;
            }

            int count = 0;
            Node currentNode = Head;
            Node previousNode = Head;
            while (currentNode != null)
            {
                if (index == count)
                {
                    previousNode.Next = currentNode.Next;                                        
                    Count--;
                    break;
                }
                previousNode = currentNode;
                currentNode = currentNode.Next;
                count++;
            }
        }

        public void RemoveAll()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public void RemoveAll(int value)
        {
            Node currentNode = Head;
            Node previusNode = null;
            while (currentNode != null)
            {
                if(currentNode.Value==value)
                {
                    
                    previusNode.Next = currentNode.Next;
                    currentNode = currentNode.Next;
                    Count--;
                }
                else
                {
                    previusNode = currentNode;
                    currentNode = currentNode.Next;

                }
            }
        }

        public bool Contains(int value)
        {           
            Node currentNode = Head;            
            while (currentNode != null)
            {
                if (currentNode.Value == value)
                {
                    return true;                               
                }                
                currentNode = currentNode.Next;               
            }
            return false;
        }

        public int IndexOf(int value)
        {
            int count = 0;
            Node con = Head;
            while (con != null)
            {
                if (con.Value == value)
                {
                    return count;
                }
                con = con.Next;
                count++;
            }
            return -1;
        }
        public void Reverse()
        {
            Node preHead = Head;
            Node tmp;
            while (preHead.Next != null)
            {
                tmp = preHead.Next;
                preHead.Next = preHead.Next.Next;
                tmp.Next = Head;
                Head = tmp;
            }
            Tail = preHead;

            //Node current=Head ;
            //Node next;
            //Node previous=null;

            //while (current!=null)
            //{
            //    next = current.Next;
            //    current.Next = previous;
            //    previous = current;
            //    current = next;               
            //}
            //Node c = Head;
            //Head = Tail;
            //Tail = c;
        }

        public int[] ToArray()
        {
            int[] arrayLink = new int[Count];
            Node con = Head;
            int i = 0;
            while(con!=null)
            {
                arrayLink[i++] = con.Value;
                con = con.Next;
            }
            return arrayLink;
        }

        public int GetFirst()
        {
            return Head.Value;
        }

        public int GetLast()
        {
            return Tail.Value;
        }

        public int Get(int index)
        {
            if(index<0 || index>Count-1)
            {
                throw new IndexOutOfRangeException();
            }

            int count = 0;
            Node currentNode = Head;
            while (currentNode != null)
            {
                if (index == count)
                {
                    return currentNode.Value;
                }
                currentNode = currentNode.Next;
                count++;
            }
            return 0;
        }

        public int Max()
        {
            if(Head==null)
            {
                return 0;
            }
            int max = Head.Value;            
            Node currentNode = Head;
            while (currentNode != null)
            {
                if (currentNode.Value > max)
                {
                    max= currentNode.Value;
                }
                currentNode = currentNode.Next;                
            }
            return max;
        }

        public int Min()
        {
            if (Head == null)
            {
                return 0;
            }
            int min = Head.Value;
            Node currentNode = Head;
            while (currentNode != null)
            {
                if (currentNode.Value < min)
                {
                    min = currentNode.Value;
                }
                currentNode = currentNode.Next;
            }
            return min;
        }

        public int IndexOfMax()
        {

            if(Count == 0)
            {
                return -1;
            }
            int count = 0;
            int max =Max();
            Node con = Head;
            while (con != null)
            {
                if (con.Value == max)
                {
                    return count;
                }
                con = con.Next;
                count++;
            }
            return count;
        }

        public int IndexOfMin()
        {
            if (Count == 0)
            {
                return -1;
            }

            int count = 0;
            int min = Min();
            Node con = Head;
            while (con != null)
            {
                if (con.Value == min)
                {
                    return count;
                }
                con = con.Next;
                count++;
            }
            return count;
        }

        public void Sort()
        {            
            Node conA = Head;
            while (conA != null)
            {
                Node conB = conA.Next;
                while (conB != null)
                {
                    if(conA.Value>conB.Value)
                    {
                        int val = conB.Value;
                        conB.Value = conA.Value;
                        conA.Value = val;
                    }
                    conB = conB.Next;
                }
                conA = conA.Next;
            }
        }

        public void SortDesc()
        {
            Node conA = Head;
            while (conA != null)
            {
                Node conB = conA.Next;
                while (conB != null)
                {
                    if (conA.Value < conB.Value)
                    {
                        int val = conB.Value;
                        conB.Value = conA.Value;
                        conA.Value = val;
                    }
                    conB = conB.Next;
                }
                conA = conA.Next;
            }
        }        
    }
}
