using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace NET_L2v2_Zad1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(dividendTextBox.Text) || string.IsNullOrWhiteSpace(divisorTextBox.Text))
                {
                    MessageBox.Show("Wprowadź wartości dla dzielnej i dzielnika.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double dividend = double.Parse(dividendTextBox.Text);
                double divisor = double.Parse(divisorTextBox.Text);

                if (divisor == 0)
                {
                    throw new DivideByZeroException("Dzielnik nie może być zerem.");
                }

                double result = dividend / divisor;
                resultTextBox.Text = result.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Wprowadzono niepoprawny format liczby.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogError(ex);
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("Dzielenie przez zero jest niedozwolone.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogError(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogError(ex);
            }
        }

        private void LogError(Exception ex)
        {
            if (!EventLog.SourceExists("DivisionApp"))
            {
                EventLog.CreateEventSource("DivisionApp", "Application");
            }

            EventLog eventLog = new EventLog();
            eventLog.Source = "DivisionApp";
            eventLog.Log = "Application";
            eventLog.WriteEntry($"Wystąpił błąd: {ex.Message}", EventLogEntryType.Error);
        }
    }
}
