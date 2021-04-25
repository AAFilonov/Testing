using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9
{
    class TestSequenceCreator
    {
    
        public List<int> valsIns ;
        public List<int> valsExp ;
        Random rnd = new Random();

        public void createData(int AmountOfVals)
        {
           createInsertSequence(AmountOfVals);
          createExpectedSequence();
        }

        public void createInsertSequence(int AmountOfVals)
        {
            fillInsVals(AmountOfVals);
            mixInsVals();
           
        }
        private void fillInsVals(int AmountOfVals)
        {
            int min =0;
            int max = AmountOfVals;
            valsIns = new List<int>();
            for (int i = 0; i < AmountOfVals; i++)
                valsIns.Add(rnd.Next(min,max));
        }
        private void mixInsVals()
        {
         
           
            for (int i = 0; i < valsIns.Count; i++)
            {
                int n = rnd.Next(valsIns.Count);
                int buf = valsIns[i];
                valsIns[i] = valsIns[n];
                valsIns[n] = buf;
            }
           

        }

        public void createExpectedSequence()
        {
            valsExp  = new List<int>();
            valsExp = SortOddEvenNumber.SortThings(valsIns);
          
        }
       

    }
}


