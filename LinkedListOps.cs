using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace LinkedListOps
{
  
  public class Node<T> {
    
    public T val;
    public Node<T> next;
    
    public Node()
    {
      this.next=null;
    }
    public Node(T data)
    {
      this.val=data;
      this.next=null;
      
    }
   
  }
  public class LinkedList {
    
    public Node<int> head;
    public int count=1;
    
    public LinkedList()
    {
      this.head = null;
    }
    
    public void insertAtHead(int value)
    {
      Node<int> newNode = new Node<int>(value);
      
      if(head==null)
      {
        head = newNode;
        return;
      }
       newNode.next=head;
       head=newNode;
      count++;

    }
     public void insertAtTail(int value)
    {
      Node<int> newNode = new Node<int>(value);
      if(head==null)
      {
        head = newNode;
        return;
      }
      Node<int> temp=head;
      while(temp.next!=null)
      {
        temp=temp.next;
        
      }
       temp.next=newNode;
      count++;

    }
    public void insertAtPosition(int value,int position)
    {
      Node<int> newNode = new Node<int>(value);
      if(position > count )
      {
        Console.WriteLine("invalid ops");
        return;
      }
      else if(position==1)
      {
        insertAtTail(value);
      }

      else if(count==position)
      {
        insertAtTail(value);
      }
      else
      {
      Node<int> temp = head;
      int find=1;
      while(find < position-1 && temp!=null)
      {
        find++;
        temp=temp.next;
      }
      
      newNode.next=temp.next;
      temp.next=newNode;
      }
      count++;

    }
    
    public void deleteHead()
    {
      Node<int> temp = head;
      if(temp!=null && temp.next!=null)
      {
        
        head=head.next;
        temp.next=null;
        count--;
      }
      else
      {
        Console.WriteLine("List is empty...");
      }
     
      
    }
    public void deleteTail()
    {
      //base case
      if(head==null)
      {
        
        Console.WriteLine("List is empty..");
      }
      Node<int> prev=null;
      Node<int> temp = head;
      while(temp!=null && temp.next!=null)
      {
        prev=temp;
        temp=temp.next;
      }
      prev.next=null;
      count--;
      
    }
    
    public void deleteAtPosition(int position)
    {
      if(position>count)
      {
        Console.WriteLine("Invalid input");
      }
      else if(head==null)
      {
        Console.WriteLine("List is empty");
      }
      else if(position==1)
      {
        deleteHead();
      }
      else if(position+1==count)
      {
        deleteTail();
      }
      else
      {
        int findpos=1;
        Node<int> prev= null;
        Node<int> temp= head;
        while(findpos < position && temp.next!=null )
        {
          prev = temp;
          temp= temp.next;
          findpos++;
        }
        prev.next=temp.next;
        count--;
        
      }
      
    }
    public void PrintData()
    {
      Node<int> temp = head;
      while(head != null)
      {
        Console.WriteLine(head.val);
        head=head.next;
        
      }
    }
    
  }
  
  
	public class Program
	{
		public static void Main(string[] args)
		{
		  
		  LinkedList ll= new LinkedList();
		    ll.insertAtHead(7);
		    ll.insertAtHead(9);
		    ll.insertAtHead(10);
		    ll.insertAtTail(12);
		    ll.insertAtTail(15);
		    ll.insertAtPosition(20,3);
		  //ll.insertAtPosition(21,3);
		  //ll.insertAtPosition(23,3);
		  //ll.insertAtPosition(23,7);
		    //ll.deleteTail();
		    //ll.deleteHead();
		    //ll.deleteAtPosition(4);
		    ll.PrintData();
		  
			Console.WriteLine("Hello, World!");
		}
	}
}
