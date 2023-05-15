using MyQueue;
using System;
namespace QueueTest;


public class QueueTests
{
    [Fact]
    public void Enqueue_Adds_OneToSize()
    {
        //Arrange
        CustomQueue<String> customQueue = new CustomQueue<string>();
        int size = 1;
        //Act
        customQueue.Enqueue("Lionel");
        //Assert
        Assert.Equal(size, customQueue.GetSize());
        
    }

    // test deque works by comparing size

    [Fact]
    public void Dequeue_Removes_OneFromSize()
    {
        //Arrange
        CustomQueue<String> customQueue = new CustomQueue<string>();
        int size = 2;
        //Act
        customQueue.Enqueue("Lionel");
        customQueue.Enqueue("Lionel");
        customQueue.Enqueue("Lionel");
        customQueue.Dequeue();
        //Assert
        Assert.Equal(size, customQueue.GetSize());

    }

    // test size is zero to begin with
    [Fact]
    public void StartingSize_Is_Zero()
    {
        //Arrange
        CustomQueue<String> customQueue = new CustomQueue<string>();
        int size = 0;
        //Act
        
        //Assert
        Assert.Equal(size, customQueue.GetSize());
    }

    // test that you get an exception if you DQ an empty Q

    // test that you can't add a non string value after adding a string
    /*[Fact]
    public void OnlyStringsAllowed()
    {
        //Arrange
        CustomQueue<String> customQueue = new CustomQueue<string>();
        int size = 0;
        //Act
        customQueue.Enqueue(14);
        //Assert
        Assert.Equal(size, customQueue.getSize());
    }
    */
}
