using System;

namespace MyCompiler {
    
    public class stack{
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
    
    public class node{
        public int value;
        public node next;
        public node(int value){
            this.value = value;
            this.next= null;
            
        }
    }
    
    public class queue{
        public stack stack1 = null;
        public stack stack2 = null;
        public queue(int value){
            stack1 = new stack(value);
        }
        
        public void enqueue(int value){
           // node newNode = new node(value);
          while(stack1.top != null){
              if(stack2 == null){ stack2 = new stack(stack1.top.value); }
              else { stack2.push(stack1.top.value);}
              stack1.pop();
          }
          stack1.push(value);
        
        
        while(stack2.top != null){
            stack1.push(stack2.top.value);
            stack2.pop();
        }
            
        }
        
        public void deque(){
            stack1.pop();
        }
        
        public void print(){
            node current = stack1.top;
            while(current.next != null){
                Console.WriteLine(current.value);
                current = current.next;
            }
        }
        
    }
    
    class Program {
        public static void Main(string[] args) {
            queue q = new  queue(1);
            q.enqueue(2);
            q.enqueue(3);
            q.print();
        }
    }
}