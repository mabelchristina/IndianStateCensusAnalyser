using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IndianStateCensusAnalyser
{
    public class StateCensusAnalyser
    {
        public string CountLines(string CSVPath)
        {
            int Count = 0;

            foreach (string line in File.ReadLines(CSVPath))
            {
                Console.WriteLine(line);
                Count++;
            }
            return Count.ToString();
        }
    }
}
