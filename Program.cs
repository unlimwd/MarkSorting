using System;
using System.Collections.Generic;

namespace MarkSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] marks = new int[5, 2] { { 101, 1 }, { 102, 2 }, { 103, 3 }, { 104, 4 }, { 105, 5 }, };       //marks[userid,mark]
            int[,] time = new int[5, 2] { { 101, 60 }, { 102, 70 }, { 103, 100 }, { 104, 80 }, { 105, 90 }, };  //time[userid,spent_time_in_seconds]

            int P = 3;
            List<int[]> res = new List<int[]>();

            //Create list of students, which have passed the exam
            for (int i = 0; i<marks.Length/2; i++)
            {
                if (marks[i,1] >= P)
                {
                    res.Add(new int[] { marks[i,0], time[i,1]});
                    
                    Console.WriteLine("Student with id {0} has passed the exam with mark {1}!", marks[i, 0], time[i, 1]);
                }
                
            }
            Console.WriteLine();

            //bubble sort
            for (int j = 0; j < res.Count - 1; j++)
            {
                for (int i = 0; i < res.Count - j - 1; i++)
                {
                    if (res[i][1] > res[i + 1][1])
                    {
                        int[] element = res[i];
                        res[i] = res[i + 1];
                        res[i + 1] = element;
                    }
                }
            }

            //Show sorted list
            for (int i = 0; i < res.Count; i++)
            {
                Console.WriteLine("Student with id {0} has spent {1} seconds.", res[i][0].ToString(), res[i][1].ToString());
            }

            Console.ReadLine();
        }
    }
}
