using System;

namespace KuyrukUygulama
{
    public class Heap
    {
        private Student[] heapArray; // Array to store heap elements
        private int currentSize; // Current size of the heap

        // Constructor
        public Heap(int maxSize)
        {
            heapArray = new Student[maxSize]; // Initialize heap array with the specified maxSize
            currentSize = 0; // Initialize current size to 0
        }

        // Method to insert a new element into the heap
        public bool Insert(Student student)
        {
            if (currentSize == heapArray.Length)
                return false; // If heap is full, return false

            heapArray[currentSize] = student; // Insert the new element at the end of the array
            MoveToUp(currentSize++); // Move the new element up to its correct position
            return true; // Return true to indicate successful insertion
        }

        // Helper method to move an element up to its correct position in the heap
        private void MoveToUp(int index)
        {
            int parent = (index - 1) / 2; // Calculate the parent index of the current element
            Student bottom = heapArray[index]; // Store the current element temporarily
            while (index > 0 && heapArray[parent].CompareTo(bottom) < 0)
            {
                heapArray[index] = heapArray[parent]; // Move the parent element down
                index = parent; // Update the current index
                parent = (parent - 1) / 2; // Calculate the parent index of the current element
            }
            heapArray[index] = bottom; // Place the current element in its correct position
        }

        // Method to remove and return the maximum element from the heap
        public Student RemoveMax()
        {
            if (currentSize == 0)
                throw new Exception("Heap is empty"); // If heap is empty, throw an exception

            Student root = heapArray[0]; // Store the maximum element (root)
            heapArray[0] = heapArray[--currentSize]; // Move the last element to the root position
            MoveToDown(0); // Move the new root element down to its correct position
            return root; // Return the maximum element
        }

        // Helper method to move an element down to its correct position in the heap
        private void MoveToDown(int index)
        {
            int largerChild;
            Student top = heapArray[index]; // Store the current element temporarily
            while (index < currentSize / 2)
            {
                int leftChild = 2 * index + 1; // Calculate the index of the left child
                int rightChild = leftChild + 1; // Calculate the index of the right child
                if (rightChild < currentSize && heapArray[leftChild].CompareTo(heapArray[rightChild]) < 0)
                {
                    largerChild = rightChild; // Determine the index of the larger child
                }
                else
                {
                    largerChild = leftChild; // Determine the index of the larger child
                }
                if (top.CompareTo(heapArray[largerChild]) >= 0)
                    break; // If the current element is larger than its children, break the loop
                heapArray[index] = heapArray[largerChild]; // Move the larger child up
                index = largerChild; // Update the current index
            }
            heapArray[index] = top; // Place the current element in its correct position
        }

        // Method to check if the heap is empty
        public bool IsEmpty()
        {
            return currentSize == 0; // Return true if the heap is empty, otherwise false
        }
    }
}
