//Complete this method
Node n = new Node(data);
if(head == null) { return n; }
else if(head.next == null){ head.next = n; }
else{ insert(head.next, data); }
      
return head;