using DataStructuresDotNet.DataStructures;

LinkedList list = new();
//list.Print();
//list.PushFront(5);      // 5 -> null
//list.PushFront(6);      // 6 -> 5 -> null
//list.PushFront(1);      // 1 -> 6 -> 5 -> null
//list.Print();
//list.PushFront(7);      // 7 -> 1 -> 6 -> 5 -> null
//list.Print();
//list.PushBack(8);       // 7 -> 1 -> 6 -> 5 -> 8 -> null
//list.PushBack(2);       // 7 -> 1 -> 6 -> 5 -> 8 -> 2 -> null
//list.Print();
//list.PopFront();
//list.Print();
//list.PopBack();
//list.Print();
Console.WriteLine(list.ShowFront());

Random random = new();

for (long i = 0; i < 100_000_000; i++)
    list.PushFront(random.Next());
Thread.Sleep(10000);
for (long i = 0; i < 100_000_000; i++)
    list.PopFront();
GC.Collect();
list.Print();
Thread.Sleep(10000);
