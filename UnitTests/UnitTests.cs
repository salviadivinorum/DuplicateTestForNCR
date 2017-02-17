using System;
using System.IO;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using DuplicateSets;


namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Test_Of_Duplicate_Sets()
        {
            //arrange
            string A = "1,2,3";
            string B = "3,2,1";
            bool expected = true;
            DuplicateTest duplicateTest = new DuplicateTest();

            //act
            duplicateTest.Compare(A, B);

            //assert
            bool areEqual = duplicateTest.GetTheyWereTheSame;
            Assert.AreEqual(expected, areEqual, "Sets are not duplicate");

        }

        [TestMethod]
        public void Test_Of_Non_Duplicate_Sets()
        {
            // arrange
            string A = "1,2,3";
            string B = "3,2,3";
            bool expected = false;
            DuplicateTest duplicateTest = new DuplicateTest();

            // act
            duplicateTest.Compare(A, B);

            // assert
            bool areEqual = duplicateTest.GetTheyWereTheSame;
            Assert.AreEqual(expected, areEqual, "Sets are equal");
        }


        [TestMethod]     
        public void Test_Of_Invalid_Input_That_ShouldReport_Human_Readable_Message()
        {
            // arrange
            string A = "1,2,";
            string B = "3,2,1";
            bool expected = true;
            DuplicateTest duplicateTest = new DuplicateTest();

            // act
            duplicateTest.Compare(A, B);

            // assert
            bool outputReportIsNotEmpty = duplicateTest.GetInvalidInputs != null;
            Assert.AreEqual(expected, outputReportIsNotEmpty, "Output Report should contain some text message error");
            
        }


        [TestMethod]
        public void Test_The_Records_From_Test_File()
        {
            // arrange
            bool fileExpectedToPassTest = true;
            bool fileReallyPassed;
            string lineA;
            string lineB;
            DuplicateTest duplicateTest = new DuplicateTest();

            //act
            try
            {
                string path = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
                using (StreamReader file = new StreamReader(string.Format("{0}\\{1}", path, "input.txt")))
                {    
                    lineA = file.ReadLine();
                    lineB = file.ReadLine();  

                    while (lineA != null && lineB != null)
                    {
                        duplicateTest.Compare(lineA, lineB);
                        lineA = file.ReadLine();
                        lineB = file.ReadLine();
                    }                    
                                        
                    fileReallyPassed = true;
                    file.Close();
                }                
            }
            catch (Exception)
            {
                fileReallyPassed = false;
                throw;
            }

            // Assert
            Assert.AreEqual(fileExpectedToPassTest, fileReallyPassed, "Input file has not passed");

        }

    }
}
