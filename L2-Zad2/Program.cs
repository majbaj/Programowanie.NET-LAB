using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Kalkulatorek
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            stopwatch.Stop();
            TimeSpan initTime = stopwatch.Elapsed;

            if (initTime.TotalSeconds > 5)
            {
                LogEvent("Czas uruchomienia za długi. Wynosi: " + initTime.TotalSeconds + " sekund");
            }
        }

        // rejestr zdarzeń

        private void LogEvent(string message)
        {
            string eventSource = "Kalkulatorek";
            string logName = "Application";

            if (!EventLog.SourceExists(eventSource))
            {
                EventLog.CreateEventSource(eventSource, logName);
            }

            using (EventLog eventLog = new EventLog(logName))
            {
                eventLog.Source = eventSource;
                eventLog.WriteEntry(message, EventLogEntryType.Warning);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            PerformOperation('+');
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            PerformOperation('-');
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            PerformOperation('*');
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            PerformOperation('/');
        }

        private void PerformOperation(char operation)
        {
            if (!double.TryParse(textBoxOperand1.Text, out double operand1) || !double.TryParse(textBoxOperand2.Text, out double operand2))
            {
                MessageBox.Show("Invalid input. Please enter valid numbers.");
                return;
            }

            double result = 0;

            switch (operation)
            {
                case '+':
                    result = operand1 + operand2;
                    break;
                case '-':
                    result = operand1 - operand2;
                    break;
                case '*':
                    result = operand1 * operand2;
                    break;
                case '/':
                    if (operand2 == 0)
                    {
                        MessageBox.Show("Nie dzieli się przez zero.");
                        return;
                    }
                    result = operand1 / operand2;
                    break;
            }

            textBoxResult.Text = result.ToString();
        }
    }
}