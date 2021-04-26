using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Lab9
{
   

    class SortOddEvenNumberTestCreator
    {
        static string InsBuffer;
        static string ExpBuffer;
        static int AmountOfVals;
        static string CurrentDirectory;
        static string OutDirectory = "OutFiles";
        static  TestSequenceCreator seqCreator = new TestSequenceCreator();

        public static void Generate(int amountOfVals,int amountOfSequences)
        {
            AmountOfVals = amountOfVals;
            CreateData(amountOfSequences);
         
        
        }

        private static void CreateData(int count)
        {
            for (int i=0; i < count; i++){
                CreateNewSequence();
                InsBuffer = convertSequenseToString(seqCreator.valsIns) +"\r\n";
                ExpBuffer = convertSequenseToString(seqCreator.valsExp) + "\r\n";

                outToFiles(InsBuffer, ExpBuffer,"Test"+i.ToString());
            }

        }
        private static void CreateNewSequence()
        {
            seqCreator.createInsertSequence(AmountOfVals);
            seqCreator.createExpectedSequence();

        }

        private static string convertSequenseToString(List<int> Vals)
        {
            string Out = "";
            foreach (var val in Vals)
                Out += val.ToString() + " ";
            return Out;
        }
        private static void  outToFiles(string InsData,string ExpData,string testname)
        {
            CurrentDirectory = Directory.GetCurrentDirectory();
            writeDataTofile("Inserted"+ testname + ".txt", InsData,  testname);
            writeDataTofile("Expected"+ testname + ".txt", ExpData,  testname);

        }
        private static void  writeDataTofile(string filename,string data, string testname)
        {
            var pathDirs = CurrentDirectory + "\\" + OutDirectory+"\\"+ testname;
            var pathFile = pathDirs + "\\" + filename;

            Console.WriteLine("Data saved to "+ pathFile);
            System.IO.Directory.CreateDirectory(pathDirs);
            var File = System.IO.File.Create(pathFile);
            var Writer = new System.IO.StreamWriter(File);
            Writer.WriteLine(data);
            Writer.Dispose();
        }

    }
}
