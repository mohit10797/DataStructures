public class Solution
{

    int num = 0;
    int num2 = 0;

    public int EvalRPN(string[] tokens)
    {
        MinStack stack = new MinStack();
        foreach (var token in tokens)
        {

            switch (token)
            {
                case "+":
                    this.num = stack.top.value;
                    this.num2 = stack.top.next.value;
                    stack.Pop();
                    stack.Pop();
                    stack.Push(this.num + this.num2);
                    break;
                case "/":
                    num = stack.top.value;
                    num2 = stack.top.next.value;
                    stack.Pop();
                    stack.Pop();
                    stack.Push(num2 / num);
                    break;
                case "*":
                    this.num = stack.top.value;
                    this.num2 = stack.top.next.value;
                    stack.Pop();
                    stack.Pop();
                    stack.Push(num * num2);
                    break;
                case "-":
                    this.num = stack.top.value;
                    this.num2 = stack.top.next.value;
                    stack.Pop();
                    stack.Pop();
                    stack.Push(num2 - num);
                    break;
                default:
                    stack.Push(Convert.ToInt32(token));
                    break;
            }
        }
        return stack.top.value;

    }
}

public class MinStack
{

    public node top;


    public void Push(int val)
    {
        if (this.top != null)
        {
            node n = new node(val);
            var temp = this.top;
            this.top = n;
            this.top.next = temp;
        }
        else
        {
            this.top = new node(val);
            this.top.next = null;
        }
    }

    public void Pop()
    {
        this.top = this.top.next;

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