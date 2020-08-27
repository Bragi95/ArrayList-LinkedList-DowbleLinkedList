using System;


namespace LinkedListTwo
{
    
    public class LListTwo
    { 
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public  int Lenght = 0;

        public LListTwo(int[] array)
        {
            AddLast(array);
        }

        public LListTwo()
        {
        }

        public void AddFirst(int value)
        {            
            Node node = new Node(value);
            Node tmp = Head;
            if (Head == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                tmp.Previous = node;
                if(Lenght == 1)
                {
                    tmp.Next = null;
                }
            }
            node.Next = tmp;
            Head = node;
            Lenght++;
        }


        public void AddFirst(int[] value)
        {
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
                Tail = node;
                node.Next = null;

            }

            if (Lenght>=1)
            {
                Tail.Next = node;
                node.Previous = Tail;
            }            
            Tail = node;
            
            Lenght++;
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
            if (index < 0)
            {
                throw new Exception("Error");
            }

            if(Head==null)
            {
                AddLast(value);
            }

            int count = 0;
            Node currentNode = Head;
            Node previusNode = Head;
            while (currentNode != null)
            {
                if (index == count)
                {
                    Node node = new Node(value);
                    if (currentNode == Head)
                    {
                        Head = node;
                    }
                    else
                    {
                        previusNode.Next = node;
                        node.Previous = previusNode;
                    }

                    node.Next = currentNode;
                    currentNode.Previous = node;
                    Lenght++;

                    break;
                }
                previusNode = currentNode;
                currentNode = currentNode.Next;
                count++;
            }
        }

        public void AddAt(int index, int[] value)
        {
            if(index> Lenght-1)
            {
                return;
                //throw new Exception("таких индексов нету");
            }

            if (Head == null)
            {
                AddLast(value);
            }
            else
            {
                for (int i = 0; i < value.Length; i++)
                {
                    AddAt(index, value[i]);
                    index++;
                }
            }
        }

        public int GetSize()
        {
            return Lenght;
        }

        public void Set(int index, int value)
        {
            if ( index < 0 || index > Lenght - 1)
            {
                return;
                //throw new Exception("Error");
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
            if (Head == null)
            {
                return;
                //throw new Exception("Список пустой");
            }        
            Head = Head.Next;
            int count = 0;
            Node currentNode = Head;
            while (currentNode != null)
            {
                if (count == 1)
                {
                    currentNode.Previous = Head.Previous;
                    break;
                }
                currentNode = currentNode.Next;
                count++;
            }
            Lenght--;
        }

        public void RemoveLast()
        {
            if (Head == null)
            {
                return;
                //throw new Exception("Список пустой");
            }
            int count = 0;
            Node currentNode = Head;
            while (currentNode != null)
            {
                if (Lenght - 2 == count)
                {
                    currentNode.Next = Tail.Next;
                    Tail.Previous = currentNode.Previous;
                    Tail = currentNode;
                    Lenght--;
                    break;
                }
                currentNode = currentNode.Next;
                count++;
            }
        }

        public void RemoveAt(int index)
        {
            int count = 0;
            Node currentNode = Head;
            Node previusNode = Head;
            while (currentNode != null)
            {
                if (index == count)
                {
                    previusNode.Next = currentNode.Next;
                    currentNode.Next.Previous = currentNode.Previous;
                    Lenght--;
                    break;
                }
                previusNode = currentNode;
                currentNode = currentNode.Next;
                count++;
            }
        }

        public void RemoveAll()
        {
            Head = null;
            Tail = null;
            Lenght = 0;
        }

        public void RemoveAll(int value)
        {
            Node currentNode = Head;
            Node previusNode = null;
            while (currentNode != null)
            {
                if (currentNode.Value == value)
                {
                    previusNode.Next = currentNode.Next;
                    currentNode.Next.Previous = currentNode;
                    currentNode = currentNode.Next;
                    Lenght--;
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
            Node currwnrNode = Head;
            while (currwnrNode != null)
            {
                if (currwnrNode.Value == value)
                {
                    return true;
                }
                currwnrNode = currwnrNode.Next;
            }
            return false;
        }

        public int IndexOf(int value)
        {
            int count = 0;
            Node currentNode = Head;
            while (currentNode != null)
            {
                if (currentNode.Value == value)
                {
                    return count;
                }
                currentNode = currentNode.Next;
                count++;
            }
            return -1;
        }

        public void Reverse()
        {
            if(Head==null)
            {
                return;
            }
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
            int[] arrayLink = new int[Lenght];
            Node con = Head;
            int i = 0;
            while (con != null)
            {
                arrayLink[i++] = con.Value;
                con = con.Next;
            }
            return arrayLink;
        }

        public int GetFirst()
        {
            if(Head==null)
            {
                throw new Exception("error");
            }
            return Head.Value;
        }

        public int GetLast()
        {
            if (Head == null)
            {
                throw new Exception("error");
            }
            return Tail.Value;
        }

        public int Get(int index)
        {
            if (index < 0 || index > Lenght - 1)
            {
                return 0;
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
            if (Head == null)
            {
                return 0;
            }
            int max = Head.Value;
            Node currentNode = Head;
            while (currentNode != null)
            {
                if (currentNode.Value > max)
                {
                    max = currentNode.Value;
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
            Node con = Head;
            while (con != null)
            {
                if (con.Value < min)
                {
                    min = con.Value;
                }
                con = con.Next;
            }
            return min;
        }

        public int IndexOfMax()
        {
            int count = 0;
            int max = Max();
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
                    if (conA.Value > conB.Value)
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

        public void Print()
        {
            Node con = Head;
            while (con != null)
            {
                Console.WriteLine(con.Value);
                con = con.Next;
            }
        }

        public void PrintRevers()
        {
            Node con = Tail;
            while (con != null)
            {
                Console.WriteLine(con.Value);
                con = con.Previous;
            }
        }
    }
}
