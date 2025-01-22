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

        // Method to find the GCD of intA & intB and output Result to textBox with basic error reporting
        private void FindGCD()
        {
            int A;
            int B;
            int Result;

            // Numbers have to be Positive or program crashes
            // Try to parse the Text from the textBoxes into an Integer
            bool isNumber1Valid = int.TryParse(intATextBox.Text, out A);
            bool isNumber2Valid = int.TryParse(intBTextBox.Text, out B);

            // If both intA & intB are Numbers, therefore True, do this else display error message
            if (isNumber1Valid && isNumber2Valid == true) {

                // If A & B are Positive Numbers do this, else display error message
                if (A > 0 && B > 0) {

                    // GCD Algorithm
                    while (A != B) {
                        if (A > B) {
                            A = A - B;
                        } else {
                            B = B - A;
                        }
                        Result = A;
                        string ResultToString = Result.ToString();

                        // Output GCD Result textBox
                        resultTextBox.ForeColor = Color.Black;
                        resultTextBox.Text = $"The GCD of {intATextBox.Text} and {intBTextBox.Text} is {ResultToString}";
                    }

                } else {

                    // Display error in Red if there in a Negative Number entered into a text box
                    string err = ("Please enter Positive numbers in both text boxes");
                    resultTextBox.ForeColor = Color.Red;
                    resultTextBox.Text = err;
                }
            } else {

                // Display error in Red if there is not a Valid Number in both text boxes
                string err = ("Please enter Numbers in both text boxes");
                resultTextBox.ForeColor = Color.Red;
                resultTextBox.Text = err;
            }
        }


        private void calcButton_Click(object sender, EventArgs e)
        {
            FindGCD();
        } 

           
    }   // EO Class
}   // EO namespace
