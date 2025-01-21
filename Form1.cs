using System.CodeDom;
using System.Security.Cryptography.X509Certificates;

namespace GCD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Method to find the GCD of intA & intB and output Result to textBox
        private void FindGCD()
        {
            int A;
            int B;
            int Result;

            // Try to parse the Text into an Integer
            bool isNumber1Valid = int.TryParse(intATextBox.Text, out A);
            bool isNumber2Valid = int.TryParse(intBTextBox.Text, out B);

            // If both numbers are valid
            if (isNumber1Valid && isNumber2Valid) {

                // GCD Algorythm
                while (A != B) {
                    if (A > B) {
                        A = A - B;
                    } else {
                        B = B - A;
                    }
                    Result = A;
                    resultTextBox.Text = Result.ToString();
                }

            } else {

                // Display error if there is no valid numbers in either text boxes
                string err = ("Please enter valid numbers in both text boxes");
                resultTextBox.Text = err;
            }


        }


        private void calcButton_Click(object sender, EventArgs e)
        {

            FindGCD();

        } 

           
    }   // EO Class
}   // EO namespace
