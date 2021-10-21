using System;

namespace IndianStateCensusAnalyser
{
    class Program
    {
        static void Main(string[] args)
        {
            //string CorrectFilePath = @"D:\my git\IndianStateCensusAnalyser\IndianStateCensusAnalyser\StateCensusData.csv";
            string FilePath = @"D:\my git\IndianStateCensusAnalyser\IndianStateCensusAnalyser\StateCode.csv";
            StateCensusAnalyser state = new StateCensusAnalyser();
            state.CountLines(FilePath);
        }
    }
}
