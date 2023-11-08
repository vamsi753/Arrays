using System;

namespace YourConsoleAppNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        static void runApp()
        {
            
            string[] studentNames = new string[] { "Alice", "Bob", "Charlie", "David", "Eve" };
            int[] studentMarks = new int[] { 90, 85, 78, 92, 88 };

            Console.WriteLine("List of Students and Their Marks:");
            for (int i = 0; i < studentNames.Length; i++)
            {
                Console.WriteLine($"{studentNames[i]} - Mark: {studentMarks[i]}");
            }

            int totalMarks = 0;
            for (int i = 0; i < studentMarks.Length; i++)
            {
                totalMarks += studentMarks[i];
            }
            double averageMark = (double)totalMarks / studentMarks.Length;

            Console.WriteLine($"Average Mark: {averageMark:F2}");
        }
    }
}
