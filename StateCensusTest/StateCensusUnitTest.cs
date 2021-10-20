using IndianStateCensusAnalyser;
using NUnit.Framework;
using static IndianStateCensusAnalyser.StateCensusException;

namespace StateCensusTest
{
    public class Tests
    {
        string correctFilePath = @"D:\my git\IndianStateCensusAnalyser\IndianStateCensusAnalyser\StateCensusData.csv";
        string wrongFilePath = @"D:\my git\IndianStateCensusAnalyser\StateCensusData.csv";
        string typeWrongFilePath = @"D:\my git\IndianStateCensusAnalyser\IndianStateCensusAnalyser\StateCensusData.txt";
        string headerFilePath = @"D:\my git\IndianStateCensusAnalyser\IndianStateCensusAnalyser\StateCensusDataInvalid.csv";
        StateCensusAnalyser state = new StateCensusAnalyser();
        CSVStateCensus cSVState = new CSVStateCensus();
        //TC1.1
        [Test]
        public void GivenCSVFilePathProper_whenAnalyse_ItMatchesTheRecord()
        {

            string expected = state.CountLines(correctFilePath);
            string actual = cSVState.CSVDataUsingEnumerator(correctFilePath, ',');
            Assert.AreEqual(expected, actual);
        }
        //TC 1.2
        [Test]
        public void GivenCSVFilePath_Imroper_whenAnalyse_ItThrowsException()
        {

            var actual = Assert.Throws<StateCensusException>(() => cSVState.CSVDataUsingEnumerator(wrongFilePath, ','));
            string expected = Exception_Type.wrong_path_Exception.ToString();
            Assert.AreEqual(actual.Message, expected);
        }
        //TC 1.3
        [Test]
        public void GivenCSVFilePathCorrect_TypeIsIncorrect_whenAnalyse_ItThrowsException()
        {
            var actual = Assert.Throws<StateCensusException>(() => cSVState.CSVDataUsingEnumerator(typeWrongFilePath, ','));
            string expected = Exception_Type.Wrong_Type_Exception.ToString();
            Assert.AreEqual(actual.Message, expected);
        }
        // TC 1.4
        [Test]
        public void GivenCSVFilePathCorrect_DelimiterIsIncorrect_whenAnalyse_ItThrowsException()
        {
            var actual = Assert.Throws<StateCensusException>(() => cSVState.CSVDataUsingEnumerator(correctFilePath, ';'));
            var expected = Exception_Type.delimeter_exception.ToString();
            Assert.AreEqual(actual.Message, expected);
        }
        //TC 1.5
        [Test]
        public void GivenCSVFilePathCorrect_CSVHeaderIsIncorrect_whenAnalyse_ItThrowsException()
        {
            var actual = Assert.Throws<StateCensusException>(() => cSVState.CSVDataUsingEnumerator(headerFilePath, ','));
            var expected = Exception_Type.Wrong_Header_Exception.ToString();
            Assert.AreEqual(actual.Message, expected);
        }
    }
}