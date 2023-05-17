public class MinStack
{

    public node top;

    public List<int> min = new List<int>();
    public MinStack()
    {

    }

    public void Push(int val)
    {
        if (this.top != null)
        {
            node n = new node(val);
            var temp = this.top;
            this.top = n;
            this.top.next = temp;
            min.Add(Math.Min(val, min[min.Count - 1]));
        }
        else
        {
            this.top = new node(val);
            this.top.next = null;
            min.Add(val);
        }
    }

    public void Pop()
    {
        this.top = this.top.next;

    }

    public int Top()
    {
        return top.value;
    }

    public int GetMin()
    {
        return min[min.Count - 1];
    }
}

public class node
{
    public int value;
    public node next;
    public node(int val)
    {
        this.value = val;
        this.next = null;
    }
}
