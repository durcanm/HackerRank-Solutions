//Write your code here
Stack<char> _stack; // represents a variable size last-in-first-out(LIFO) collection of instances of the same specified type
Queue<char> _queue; // represents a first-in, first-out (FIFO) collection of objects

Solution()
{
    _stack = new Stack<char>();
    _queue = new Queue<char>();
}

void pushCharacter(char c)
{
    _stack.Push(c);
}

char popCharacter()
{
    return _stack.Pop();
}

void enqueueCharacter(char c)
{
    _queue.Enqueue(c);
}

char dequeueCharacter()
{
    return _queue.Dequeue();
}