using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace NET_L2v2_Zad2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // Tutaj inicjalizacja komponentów formularza

            stopwatch.Stop();
            TimeSpan initTime = stopwatch.Elapsed;

            if (initTime.TotalSeconds > 5)
            {
                LogEvent("Czas uruchomienia za długi. Wynosi: " + initTime.TotalSeconds + " sekund");
            }
        }

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

        private void PerformOperation(char operation)
        {
            if (!double.TryParse(textBoxOperand1.Text, out double operand1) || !double.TryParse(textBoxOperand2.Text, out double operand2))
            {
                MessageBox.Show("Nieprawidłowe dane. Proszę podaj poprawne liczby.");
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
                default:
                    MessageBox.Show("Nieobsługiwana operacja.");
                    break;
            }

            textBoxResult.Text = result.ToString();
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
    }
}
