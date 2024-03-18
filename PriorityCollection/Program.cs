using System;
namespace Priority
{
    internal class PriorityQueueCollection
    {
        static void Main(string[] args)
        {
            // Create the queue
            // The data items are strings. The second type parameter (an int) indicates the priority
            PriorityQueue<string, int> messages = new PriorityQueue<string, int>();

            // Add messages with different priorities to the queue
            messages.Enqueue("one", 1);
            messages.Enqueue("two", 2);
            messages.Enqueue("three", 3);
            messages.Enqueue("four", 4);
            messages.Enqueue("five", 5);
            messages.Enqueue("six", 6);

            // Retrieve the messages in priority and queue order
            while (messages.TryDequeue(out string item, out int priority))
            {
                Console.WriteLine($"Priority number is : {priority}");
            }

            Console.WriteLine($"There are {messages.Count} items in the queue");
        }
    }
}
