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

            // Try to parse the Text from the textBoxes into an Integer
            bool isNumber1Valid = int.TryParse(intATextBox.Text, out A);
            bool isNumber2Valid = int.TryParse(intBTextBox.Text, out B);

            // If both numbers are valid and True do this
            if (isNumber1Valid && isNumber2Valid) {

                // GCD Algorithm
                while (A != B) {
                    if (A > B) {
                        A = A - B;
                    } else {
                        B = B - A;
                    }
                    Result = A;
                    string ResultToString = Result.ToString();

                    // Output to the Result textBox
                    resultTextBox.Text = $"The GCD of {intATextBox.Text} and {intBTextBox.Text} is {ResultToString}";
                }

            } else {

                // Display error if there is not a valid number in both text boxes
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
