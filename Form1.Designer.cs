namespace GCD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            intATextBox = new TextBox();
            intBTextBox = new TextBox();
            resultTextBox = new TextBox();
            calcButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // intATextBox
            // 
            intATextBox.Location = new Point(54, 57);
            intATextBox.Name = "intATextBox";
            intATextBox.Size = new Size(100, 23);
            intATextBox.TabIndex = 0;
            intATextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // intBTextBox
            // 
            intBTextBox.Location = new Point(257, 57);
            intBTextBox.Name = "intBTextBox";
            intBTextBox.Size = new Size(100, 23);
            intBTextBox.TabIndex = 1;
            intBTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // resultTextBox
            // 
            resultTextBox.Location = new Point(12, 133);
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(405, 23);
            resultTextBox.TabIndex = 2;
            resultTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // calcButton
            // 
            calcButton.Location = new Point(170, 194);
            calcButton.Name = "calcButton";
            calcButton.Size = new Size(75, 23);
            calcButton.TabIndex = 3;
            calcButton.Text = "Calculate";
            calcButton.UseVisualStyleBackColor = true;
            calcButton.Click += calcButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 39);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 4;
            label1.Text = "Int A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(294, 39);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 5;
            label2.Text = "Int B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(170, 115);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 6;
            label3.Text = "GCD Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 264);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(calcButton);
            Controls.Add(resultTextBox);
            Controls.Add(intBTextBox);
            Controls.Add(intATextBox);
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Form1";
            Text = "Greatest Common Divisor Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox intATextBox;
        private TextBox intBTextBox;
        private TextBox resultTextBox;
        private Button calcButton;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
