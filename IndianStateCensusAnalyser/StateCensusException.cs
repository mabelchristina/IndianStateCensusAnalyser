using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStateCensusAnalyser
{
    public class StateCensusException : Exception
    {
        public enum Exception_Type
        {
            wrong_path_Exception,
            delimeter_exception,
            Wrong_Type_Exception,
            Wrong_Header_Exception,
        }
        public StateCensusException(string msg) : base(msg)
            {
           
            }
    }
}
