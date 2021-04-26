using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab10
{
    class SequenceParser
    {
        public  List<List<int>> parse(string path)
        {
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    return DoSmth(sr);
                }
                // асинхронное чтение
              
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
            return null;
        }

        private List<List<int>> DoSmth(System.IO.StreamReader Reader)
        {
            var ListOFSequences = new List<List<int>>();
            
            while (!Reader.EndOfStream)
            {
                var seqString = Reader.ReadLine();
                var seq = convertToSeq(seqString);
                ListOFSequences.Add(seq);
            }         
             
           
            return ListOFSequences;
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
