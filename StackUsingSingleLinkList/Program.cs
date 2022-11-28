namespace StackUsingSingleLinkList
{
    class node
    {
        public int info;
        public node next;
        public node(int i, node n)
        {
            info = i;
            next = n;
        }
    }
    class Stack
    {
        node top;
        public Stack()
        {
            top = null;
        }
        bool empty()
        {
            if(top == null)
                return (true);
            else
                return (false);
        }
        public void push(int element)
        {
            node fresh;
        }
    }
}