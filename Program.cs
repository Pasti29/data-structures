using DataStructuresDotNet.DataStructures;

LinkedList list = new LinkedList();
list.Print();
list.PushFront(5);      // 5 -> null
list.PushFront(6);      // 6 -> 5 -> null
list.PushFront(1);      // 1 -> 6 -> 5 -> null
list.Print();
list.PushFront(7);      // 7 -> 1 -> 6 -> 5 -> null
list.Print();
list.PushBack(8);       // 7 -> 1 -> 6 -> 5 -> 8 -> null
list.PushBack(2);       // 7 -> 1 -> 6 -> 5 -> 8 -> 2 -> null
list.Print();
