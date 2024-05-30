using System;

namespace KuyrukUygulama
{
    // Class for performing Heap Sort algorithm
    public class HeapSort
    {
        private Student[] array; // Array to be sorted

        // Constructor to initialize the array
        public HeapSort(Student[] array)
        {
            this.array = array; // Initialize the array
        }

        // Method to perform Heap Sort
        public Student[] Sort()
        {
            Heap heap = new Heap(array.Length); // Create a new heap with the same size as the array
            Student[] sorted = new Student[array.Length]; // Create a new array to store the sorted elements

            // Insert each element of the array into the heap
            foreach (var student in array)
                heap.Insert(student);

            int i = 0;
            // Remove the maximum element from the heap and store it in the sorted array
            while (!heap.IsEmpty())
                sorted[i++] = heap.RemoveMax();

            return sorted; // Return the sorted array
        }
    }
}
