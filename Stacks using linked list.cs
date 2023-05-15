using System;

namespace MyCompiler {
    
    class node {
        public int value;
        public node next;
        public node(int value){
            this.value = value;
            this.next = null;
        }
    }
    
    class stack{
        public node top;
        public stack(int value){
            node newNode = new node(value);
            this.top = newNode;
        }
        
        public void push(int value){
            node newNode = new node(value);
            var temp = this.top;
            this.top = newNode;
            newNode.next = temp;
        }
        
        public void peek(){
            Console.WriteLine(this.top.value);
        }
        
        public void pop(){
            this.top = this.top.next;
        }
        
        public void print(){
            var current = this.top;
            while(current != null){
                Console.WriteLine(current.value);
                current = current.next;
            }
        }
    }
    
    class Program {
        public static void Main(string[] args) {
            stack st = new stack(1);
            st.push(2);
            st.push(3);
            st.push(4);
            st.pop();
            st.print();
        }
    }
}