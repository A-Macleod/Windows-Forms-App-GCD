namespace GCD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {

            //while (!string.IsNullOrWhiteSpace(intABox.Text) && !string.IsNullOrWhiteSpace(intBBox.Text))
            //{

            int A;
            int B;
            int result;

            // Try to parse the text to an integer
            bool isNum1Valid = int.TryParse(intATextBox.Text, out A);
            bool isNum2Valid = int.TryParse(intBTextBox.Text, out B);

            if (isNum1Valid && isNum2Valid)
            {
                // Perform addition if both inputs are valid
                result = A + B;
                resultTextBox.Text = result.ToString();

            }
            else
            {
                // Display error message if the inputs are not a valid number
                string err = ("Please enter valid numbers in both text boxes.");
                resultTextBox.Text = err;

            }





            //}   // EO While
        }   // EO calcButton_click
    


    }   // EO Class
}   // EO namespace
