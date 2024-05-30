using System;

namespace KuyrukUygulama
{
    // Class for implementing a PriorityQueue data structure
    public class PriorityQueue
    {
        private Student[] Queue; // Array to store elements of the priority queue
        private int size; // Maximum size of the priority queue
        private int count; // Current number of elements in the priority queue

        // Constructor to initialize the priority queue with the specified size
        public PriorityQueue(int size)
        {
            this.size = size; // Set the maximum size of the priority queue
            Queue = new Student[size]; // Initialize the array with the specified size
            count = 0; // Initialize the count of elements to 0
        }

        // Method to insert a new element into the priority queue
        public void Insert(Student student)
        {
            if (count == size)
                throw new Exception("Queue is full"); // Throw an exception if the queue is full

            int i;
            // Find the correct position to insert the new element based on its priority
            for (i = count - 1; i >= 0; i--)
            {
                if (student.CompareTo(Queue[i]) < 0)
                    Queue[i + 1] = Queue[i];
                else
                    break;
            }
            Queue[i + 1] = student; // Insert the new element at the correct position
            count++; // Increment the count of elements
        }

        // Method to remove and return the highest priority element from the priority queue
        public Student Remove()
        {
            if (IsEmpty())
                throw new Exception("Queue is empty"); // Throw an exception if the queue is empty

            Student temp = Queue[0]; // Store the highest priority element
            for (int i = 0; i < count - 1; i++)
            {
                Queue[i] = Queue[i + 1]; // Shift the elements to the left to remove the highest priority element
            }
            Queue[count - 1] = null; // Set the last element to null
            count--; // Decrement the count of elements
            return temp; // Return the removed element
        }

        // Method to check if the priority queue is empty
        public bool IsEmpty()
        {
            return count == 0; // Return true if the count of elements is 0, otherwise false
        }

        // Method to return the highest priority element without removing it from the priority queue
        public Student Peek()
        {
            if (IsEmpty())
                throw new Exception("Queue is empty"); // Throw an exception if the queue is empty
            return Queue[0]; // Return the highest priority element
        }

        // Method to convert the priority queue to an array
        public Student[] ToArray()
        {
            Student[] result = new Student[count]; // Create a new array to store the elements
            Array.Copy(Queue, result, count); // Copy the elements from the priority queue to the array
            return result; // Return the array
        }
    }
}
