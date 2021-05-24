using System;
using System.Collections.Generic;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            var Dir= "C:\\Users\\Professional\\source\\repos\\Testing\\Lab9\\Lab9\\bin\\Debug\\netcoreapp3.1\\OutFiles\\";

            TestSequenceProcesor sequenceProcesor = new TestSequenceProcesor();


            var SeqListIns = sequenceProcesor.Process(Dir);
         
    
            Console.ReadKey();

        }
       

    }
}
