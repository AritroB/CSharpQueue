using System;
namespace MyQueue
{
	public interface QueueInterface<T>
	{
		void Enqueue(T item);

		T Dequeue();

		bool IsEmpty();

		int GetSize();
    }
}

