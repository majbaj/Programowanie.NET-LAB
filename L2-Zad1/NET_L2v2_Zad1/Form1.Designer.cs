using System.Windows.Forms;

namespace NET_L2v2_Zad1
{
    partial class Form1
    {
        private TextBox dividendTextBox;
        private TextBox divisorTextBox;
        private TextBox resultTextBox;
        private Button divideButton;
        private Label dividendLabel;
        private Label divisorLabel;
        private Label resultLabel;

        private void InitializeComponent()
        {
            this.dividendTextBox = new TextBox();
            this.divisorTextBox = new TextBox();
            this.resultTextBox = new TextBox();
            this.divideButton = new Button();
            this.dividendLabel = new Label();
            this.divisorLabel = new Label();
            this.resultLabel = new Label();

            this.SuspendLayout();

            // 
            // dividendTextBox
            // 
            this.dividendTextBox.Location = new System.Drawing.Point(12, 25);
            this.dividendTextBox.Name = "dividendTextBox";
            this.dividendTextBox.Size = new System.Drawing.Size(100, 20);
            this.dividendTextBox.TabIndex = 0;

            // 
            // divisorTextBox
            // 
            this.divisorTextBox.Location = new System.Drawing.Point(12, 65);
            this.divisorTextBox.Name = "divisorTextBox";
            this.divisorTextBox.Size = new System.Drawing.Size(100, 20);
            this.divisorTextBox.TabIndex = 1;

            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(12, 105);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(100, 20);
            this.resultTextBox.TabIndex = 2;

            // 
            // divideButton
            // 
            this.divideButton.Location = new System.Drawing.Point(12, 145);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(100, 23);
            this.divideButton.TabIndex = 3;
            this.divideButton.Text = "Podziel";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);

            // 
            // dividendLabel
            // 
            this.dividendLabel.AutoSize = true;
            this.dividendLabel.Location = new System.Drawing.Point(12, 9);
            this.dividendLabel.Name = "dividendLabel";
            this.dividendLabel.Size = new System.Drawing.Size(44, 13);
            this.dividendLabel.TabIndex = 4;
            this.dividendLabel.Text = "Dzielna";

            // 
            // divisorLabel
            // 
            this.divisorLabel.AutoSize = true;
            this.divisorLabel.Location = new System.Drawing.Point(12, 49);
            this.divisorLabel.Name = "divisorLabel";
            this.divisorLabel.Size = new System.Drawing.Size(45, 13);
            this.divisorLabel.TabIndex = 5;
            this.divisorLabel.Text = "Dzielnik";

            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(12, 89);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(37, 13);
            this.resultLabel.TabIndex = 6;
            this.resultLabel.Text = "Wynik";

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(134, 181);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.divisorLabel);
            this.Controls.Add(this.dividendLabel);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.divisorTextBox);
            this.Controls.Add(this.dividendTextBox);
            this.Name = "Form1";
            this.Text = "DivisionApp";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
