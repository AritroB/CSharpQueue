using System;
namespace MyQueue
{
    public class CustomQueue<T> : QueueInterface<T>
    {
        private List<T> items;

        public CustomQueue()
        {
            items = new List<T>();
        }

        public void Enqueue(T item)
        {
            items.Add(item);
        }

        public T Dequeue()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            T item = items[0];
            items.RemoveAt(0);
            return item;
        }

        public int GetSize()
        {
            return items.Count;
        }

        public bool IsEmpty()
        {
            return items.Count == 0;
        }
    }
}

