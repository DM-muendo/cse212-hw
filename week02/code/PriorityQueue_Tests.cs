using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue items with different priorities and dequeue them.
    // Expected Result: The highest priority item is returned first, then lower priorities.
    // Defect(s) Found: 
    public void TestPriorityQueue_DequeueHighestPriority()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Medium", 5);
        priorityQueue.Enqueue("High", 10);

        Assert.AreEqual("High", priorityQueue.Dequeue());
        Assert.AreEqual("Medium", priorityQueue.Dequeue());
        Assert.AreEqual("Low", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue multiple items with the same highest priority.
    // Expected Result: The item closest to the front of the queue is removed first.
    // Defect(s) Found: 
    public void TestPriorityQueue_DequeueHighestPriority_FIFO()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("FirstHigh", 10);
        priorityQueue.Enqueue("SecondHigh", 10);
        priorityQueue.Enqueue("Lower", 5);

        Assert.AreEqual("FirstHigh", priorityQueue.Dequeue());
        Assert.AreEqual("SecondHigh", priorityQueue.Dequeue());
        Assert.AreEqual("Lower", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Dequeue from an empty queue.
    // Expected Result: InvalidOperationException with message "The queue is empty." is thrown.
    // Defect(s) Found: 
    public void TestPriorityQueue_EmptyThrows()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail(string.Format("Unexpected exception of type {0} caught: {1}", e.GetType(), e.Message));
        }
    }
}
