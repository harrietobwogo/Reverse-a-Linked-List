using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }
  public ListNode Reverse(ListNode head){
    ListNode curr=head;
    ListNode prev=null;
    while(curr!=null){
      ListNode temp=curr.next;
      curr.next=prev;
      prev=curr;
      curr=temp;
    }
    return prev;
  }
}