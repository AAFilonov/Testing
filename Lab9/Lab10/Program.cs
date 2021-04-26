using System;
using System.Collections.Generic;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            var pathIns = "C:\\Users\\Professional\\source\\repos\\Testing\\Lab9\\Lab9\\bin\\Debug\\netcoreapp3.1\\OutFiles\\Inserted.txt";
            var pathExp = "C:\\Users\\Professional\\source\\repos\\Testing\\Lab9\\Lab9\\bin\\Debug\\netcoreapp3.1\\OutFiles\\Expected.txt";
            SequenceParser parser = new SequenceParser();


            var SeqListIns = parser.parse(pathIns);
            var SeqListExp = parser.parse(pathExp);
            if (SeqListIns == null || SeqListExp == null)
            {
                Console.WriteLine("Error: fail to parse sequences");
                return;
            }
            if (SeqListIns.Count != SeqListExp.Count)
            {
                Console.WriteLine("Error: wrong amount of test sequences");
            }

            for (int i = 0; i < SeqListIns.Count; i++)
            {
                var SeqActual = SortOddEvenNumber.SortThings(SeqListIns[i]);

                Console.Write("Test sequence " + i.ToString() + " :");
                if (SeqCompare(SeqActual, SeqListExp[i]))
                    Console.WriteLine("Success");
                else
                    Console.Write("Fail\nExpected: " + SeqPrint(SeqListExp[i]) + "; Actual: " + SeqPrint(SeqActual) + "\n");


            }


            Console.ReadKey();

        }
        private static bool SeqCompare(List<int> A, List<int> B)
        {
            if (A.Count!= B.Count)
                return false;

            for (int i = 0; i < A.Count; i++)
            {
               if( A[i] != B[i])
                {
                    return false;
                }
            }

            return true;
        }
        private static string SeqPrint(List<int> seq)
        {
            string output="";
            foreach(var val in seq)
            {
                output += val.ToString() + " ";
            }
            return output;
        }

    }
}
