using System;
using System.Collections.Generic;
using System.Linq;

namespace DuplicateSets
{
    /// <summary>
    /// Instance this class to start tests of two sets A,B: Compare(string A, string B)
    /// </summary>
    public class DuplicateTest
    {
        #region Fields
        private RepeatedLists repeatedLists = new RepeatedLists();
        private List<int> inputA = new List<int>();
        private List<int> inputB = new List<int>();
        private string invalidInputs;

        #endregion

        #region Constructor        
        public DuplicateTest()
        { }
        #endregion

        #region Public Getters to Access library functionality

        public string GetInvalidInputs
        {
            get { return invalidInputs; }
        }

        public int GetAllSameDuplicateCouples
        {
            get { return repeatedLists.GetAllSameDuplicateCouples; }
        }


        public int GetAllNonDuplicateCouples
        {
            get { return repeatedLists.GetAllNonDuplicateCouples; }
        }


        public int GetNumberOfLastRepeated
        {
            get { return repeatedLists.GetNumberOfLastRepeated; }

        }

        public bool GetTheyWereTheSame
        {
            get { return repeatedLists.GetTheyWereTheSame; }
        }

        public int GetMaxOfRepeated
        {
            get { return repeatedLists.GetMaxOfRepeated; }
        }

        public string GetTheMostFrequentAset
        {
            get { return repeatedLists.GetTheMostFrequentAset; }

        }

        public string GetTheMostFrequentBset
        {
            get { return repeatedLists.GetTheMostFrequentBset; }
        }

        #endregion

        #region Private properties Getters/Setters

        private List<int> SetInputA
        {
            set { inputA = value; }
        }
        private List<int> SetInputB
        {
            set { inputB = value; }
        }

        private List<int> GetInputA
        {
            get { return inputA; }
        }

        private List<int> GetInputB
        {
            get { return inputB; }
        }

        private string SetInvalidInputs
        {
            set { invalidInputs = value; }
        }
        #endregion

        #region Method
        /// <summary>
        /// Compares the specified A, B strings representing 2 sets of integers
        /// </summary>
        /// <param name="A">a.</param>
        /// <param name="B">The b.</param>
        /// 
        public void Compare(string A, string B)
        {
            // splitting string inputs into the lists and catching the exception of invalid input
            try
            {
                SetInputA = A.Split(',').Select(s => int.Parse(s)).ToList();
                SetInputB = B.Split(',').Select(s => int.Parse(s)).ToList();
            }
            catch (Exception e)
            {                
                SetInvalidInputs = GetInvalidInputs + e.Message + " A: " + A + " B: " + B + Environment.NewLine;
                repeatedLists.SetTheyWereTheSame = false;
                repeatedLists.SetNumberOfLastRepeated = 0;
                repeatedLists.SetAllNonDuplicateCouples = repeatedLists.GetAllNonDuplicateCouples + 1;
                return;
            }

            // yes, the core of NCR task is here, and the rest of the code is my tomato souce
            bool areEqual = GetInputA.OrderBy(x => x).SequenceEqual(GetInputB.OrderBy(x => x)); // The time compexity is O(log N)

            if (areEqual)
            {
                repeatedLists.SetTheyWereTheSame = true;
                repeatedLists.SetAllSameDuplicateCouples = repeatedLists.GetAllSameDuplicateCouples + 1;

                bool lastTheSameAisInputA = repeatedLists.GetLastRepeatedListA.SequenceEqual(GetInputA);
                bool lastTheSameBisInputB = repeatedLists.GetLastRepeatedListB.SequenceEqual(GetInputB);

                if (lastTheSameAisInputA && lastTheSameBisInputB)
                {
                    repeatedLists.SetNumberOfLastRepeated = repeatedLists.GetNumberOfLastRepeated + 1;
                    if (repeatedLists.GetNumberOfLastRepeated >= repeatedLists.GetMaxOfRepeated)
                    {
                        repeatedLists.SetMaxOfRepeated = repeatedLists.GetNumberOfLastRepeated;
                        repeatedLists.SetMostRepeatedListA = GetInputA;
                        repeatedLists.SetMostRepeatedListB = GetInputB;
                    }

                }
                else
                {
                    if (repeatedLists.GetMostRepeatedListA.Count() == 0)
                    {
                        repeatedLists.SetMostRepeatedListA = GetInputA;
                        repeatedLists.SetMostRepeatedListB = GetInputB;
                        repeatedLists.SetMaxOfRepeated = 1;
                    }
                    repeatedLists.SetNumberOfLastRepeated = 1;
                    repeatedLists.SetLastRepeatedListA = GetInputA;
                    repeatedLists.SetLastRepeatedListB = GetInputB;

                }

                repeatedLists.SetTheMostFrequentAset = string.Join(",", repeatedLists.GetMostRepeatedListA.ToArray());
                repeatedLists.SetTheMostFrequentBset = string.Join(",", repeatedLists.GetMostRepeatedListB.ToArray());

            }
            else
            {
                repeatedLists.SetTheyWereTheSame = false;
                repeatedLists.SetNumberOfLastRepeated = 0;
                repeatedLists.SetAllNonDuplicateCouples = repeatedLists.GetAllNonDuplicateCouples + 1;
            }

        }
        #endregion

        /// <summary>
        /// The secondary class holding variables to assert
        /// </summary>
        private class RepeatedLists
        {
            #region Fields
            private bool wereTheSame;
            private int lastRepeatedCouple;
            private int maxRepeatedCouple;
            private int allDuplicateCouples;
            private int allNonDuplicateCouples;
            private List<int> lastRepetedListA = new List<int>();
            private List<int> lastRepeatedListB = new List<int>();
            private List<int> mostRepeatedListA = new List<int>();
            private List<int> mostRepeatedListB = new List<int>();
            private string mostFrequentAset;
            private string mostFrequentBset;

            #endregion

            #region Constructor
            public RepeatedLists()
            { }
            #endregion

            #region Internal properties


            internal string SetTheMostFrequentAset
            {
                set { mostFrequentAset = value; }
            }

            internal string SetTheMostFrequentBset
            {
                set { mostFrequentBset = value; }
            }


            internal string GetTheMostFrequentAset
            {
                get { return mostFrequentAset; }

            }

            internal string GetTheMostFrequentBset
            {
                get { return mostFrequentBset; }
            }


            internal int SetAllSameDuplicateCouples
            {
                set { allDuplicateCouples = value; }
            }

            internal int GetAllSameDuplicateCouples
            {
                get { return allDuplicateCouples; }
            }

            internal int SetAllNonDuplicateCouples
            {
                set { allNonDuplicateCouples = value; }
            }

            internal int GetAllNonDuplicateCouples
            {
                get { return allNonDuplicateCouples; }
            }


            internal bool SetTheyWereTheSame
            {
                set { wereTheSame = value; }
            }

            internal bool GetTheyWereTheSame
            {
                get { return wereTheSame; }
            }

            internal int SetNumberOfLastRepeated
            {
                set { lastRepeatedCouple = value; }
            }

            internal int GetNumberOfLastRepeated
            {
                get { return lastRepeatedCouple; }
            }

            internal int GetMaxOfRepeated
            {
                get { return maxRepeatedCouple; }
            }

            internal int SetMaxOfRepeated
            {
                set { maxRepeatedCouple = value; }
            }

            internal List<int> SetLastRepeatedListA
            {
                set { lastRepetedListA = value; }
            }

            internal List<int> GetLastRepeatedListA
            {
                get { return lastRepetedListA; }
            }

            internal List<int> SetLastRepeatedListB
            {
                set { lastRepeatedListB = value; }
            }

            internal List<int> GetLastRepeatedListB
            {
                get { return lastRepeatedListB; }
            }

            internal List<int> SetMostRepeatedListA
            {
                set { mostRepeatedListA = value; }
            }

            internal List<int> GetMostRepeatedListA
            {
                get { return mostRepeatedListA; }
            }

            internal List<int> SetMostRepeatedListB
            {
                set { mostRepeatedListB = value; }
            }

            internal List<int> GetMostRepeatedListB
            {
                get { return mostRepeatedListB; }
            }
            #endregion
        }
    }
}

