public class Solution {
    public bool IsValid(string s) {
        stack st = new stack();
        foreach(char c in s)
        {
            switch(c)
            {
                case '(':
                    st.push(')');
                    break;
                case '{':
                    st.push('}');
                    break;
                case '[':
                    st.push(']');
                    break;
                default:
                    if(st.pop() != c){ return false; }
                    break;
            }

        }
        return st.top == null;
        
    }
}

public class node
{
    public char value;
    public node next;
    public node(char val)
    {
        this.value = val;
        this.next = null;

    }
}

public class stack 
{
    public node top =null;
    public void push(char val)
    {
       
        if(this.top != null) 
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

    public char pop()
    {
        if(this.top == null) { return 'c'; }
        var ret = this.top.value;
        this.top = this.top.next;
        return ret;
    }
}