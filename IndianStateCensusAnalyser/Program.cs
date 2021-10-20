using System;

namespace IndianStateCensusAnalyser
{
    class Program
    {
        static void Main(string[] args)
        {
            string CorrectFilePath = @"D:\my git\IndianStateCensusAnalyser\IndianStateCensusAnalyser\StateCensusData.csv";
            StateCensusAnalyser state = new StateCensusAnalyser();
            state.CountLines(CorrectFilePath);
        }
    }
}
