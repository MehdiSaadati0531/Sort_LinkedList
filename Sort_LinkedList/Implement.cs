namespace Sort_LinkedList
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
    }

    public class NodeOperation
    {
        Node head = null;

        private bool IsNull()
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Insert(int val)
        {
            Node newNode = new Node();
            newNode.Value = val;
            if (IsNull())
            {
                head = newNode;
                head.Next = null;
            }
            else
            {
                Node finde = head;
                while (finde != null)
                {
                    if (val >= finde.Value)
                    {
                        if (finde.Next != null)
                        {
                            if (val <= finde.Next.Value)
                            {
                                newNode.Next = finde.Next;
                                finde.Next = newNode;
                                break;
                            }
                            finde = finde.Next;
                            continue;
                        }
                        else
                        {
                            finde.Next = newNode;
                            newNode.Next = null;
                            break;
                        }
                    }
                    else if (finde.Value >= val)
                    {
                        newNode.Next = finde;
                        head = newNode;
                        break;
                    }
                    else if (finde.Next == null)
                    {
                        finde.Next = newNode;
                        newNode.Next = null;
                        break;
                    }
                    finde = finde.Next;
                }
            }
        }

        public void Print()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.Value);
                temp = temp.Next;
            }
        }
    }
}
