using System;

using System.Collections.Generic;

namespace MyCompiler {
    
    class queue {
        public List<int> array = new List<int>();
        public void enqueue(int value){
            this.array.Add(value);
            
        }
        
        public void dequeue(){
            this.array.RemoveAt(0);
        }
    }
    
    class node{
        public int value;
        public node next;
        public node(int value){
            this.value = value;
            this.next = null;
        }
    }
    
    class queueUsingLinkedList{
        public node element;
        public queueUsingLinkedList(int value){
            node newNode = new node(value);
            this.element = newNode;
        }
        
        public void enqueue(int value){
            node newNode = new node(value);
            node current = this.element;
            while(current.next != null){
                //var temp = current;
                current = current.next;
            }
            current.next = newNode;
        }
        
        public void dequeue(){
            this.element = this.element.next;
        }
        
        public void print(){
            node current = this.element;
            while(current != null){
                Console.WriteLine(current.value);
                current = current.next;
            }
        }
        
    }
    
    
    class Program {
        public static void Main(string[] args) {
            queueUsingLinkedList q = new queueUsingLinkedList(1);
            q.enqueue(2);
            q.enqueue(3);
            q.enqueue(4);
            q.dequeue();
            q.dequeue();
            q.print();
            
        }
    }
}