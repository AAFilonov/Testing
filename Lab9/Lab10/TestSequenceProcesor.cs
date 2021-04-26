using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab10
{
    class TestSequenceProcesor
    {
        public  List<int> Process(string pathDir)
        {       
            try
            {
                string[] TestsSubdirectories = Directory.GetDirectories(pathDir);
                foreach(var TestDir in TestsSubdirectories)
                {
                    TestDirProcess(TestDir);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
            return null;
        }
        void TestDirProcess(string TestDirPath)
        {

          var testFilesArr = Directory.GetFiles(TestDirPath);
          List<string> testFilesList =new List<string>(testFilesArr);
           var TestDirName =  Path.GetFileName(TestDirPath);

            var insFile = testFilesList.Find(x => x.Contains("Inserted"));
            var expFile = testFilesList.Find(x => x.Contains("Expected"));


            var InsSeq = Parse(insFile);
            var ExpSeq = Parse(expFile);


            var SeqActual = SortOddEvenNumber.SortThings(InsSeq);
            var ResultFile = System.IO.File.Create(TestDirPath + "\\" + "Actual" + TestDirName + ".txt");
            var Writer = new System.IO.StreamWriter(ResultFile);

            Writer.WriteLine(SeqPrint(SeqActual));
            Writer.Dispose();


            Console.Write("Test sequence " + TestDirPath + " :");
            if (SeqCompare(SeqActual, ExpSeq))
                Console.WriteLine("Success");
            else 
                Console.Write("Fail\nExpected: " + SeqPrint(ExpSeq) + "; Actual: " + SeqPrint(SeqActual) + "\n");

           


        }


        private static bool SeqCompare(List<int> A, List<int> B)
        {
            if (A.Count != B.Count)
                return false;

            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] != B[i])
                {
                    return false;
                }
            }

            return true;
        }
        private static string SeqPrint(List<int> seq)
        {
            string output = "";
            foreach (var val in seq)
            {
                output += val.ToString() + " ";
            }
            return output;
        }


        List<int> Parse(string filename)
        {
            System.IO.StreamReader Reader = new System.IO.StreamReader(filename);
            var seqString = Reader.ReadLine();
            return convertToSeq(seqString);                    
        }

        private List<int> convertToSeq( string seqString)
        {
            string[] vals = seqString.Split(' ');
            var seq = new List<int>();
            foreach (var val in vals)
            {
                if (val == "") continue;
                seq.Add(Convert.ToInt32(val));
            }
            return seq;
        }
    }
}
