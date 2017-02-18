using System;
using System.Windows.Forms;

// requested library connected:
using DuplicateSets;


// the time compexity of my solution is O(log N)
// unit test includedů all NCR tasks completeted !
// my time I have spent on it was 10 hours

namespace NCR
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // creating instance of main library class to evaluate A and B sets
        DuplicateTest duplicateTest = new DuplicateTest();     
        

        private void DuplicateTestBtn_Click(object sender, EventArgs e)
        {
            // to obtain strings from textBoxes:
            string A = textBoxSetA.Text;
            string B = textBoxSetB.Text;

            // A,B asserts - one and only method:
            duplicateTest.Compare(A, B);

            // the WinForms outputs provided by public accesible properties of main library class (gettters)
            textBoxTrueOrFalse.Text = duplicateTest.GetTheyWereTheSame.ToString();
            textBoxHowManyTimesABduplicated.Text = duplicateTest.GetNumberOfLastRepeated.ToString();
            textBoxDuplicatesAll.Text = duplicateTest.GetAllSameDuplicateCouples.ToString();
            textBoxNonDuplicatesAll.Text = duplicateTest.GetAllNonDuplicateCouples.ToString();
            textBoxMaxTimesDuplicated.Text = duplicateTest.GetMaxOfRepeated.ToString();
            textBoxTheMostA.Text = duplicateTest.GetTheMostFrequentAset;
            textBoxTheMostB.Text = duplicateTest.GetTheMostFrequentBset;
            textBoxOutput.Text = duplicateTest.GetInvalidInputs;
        }
    }
}
