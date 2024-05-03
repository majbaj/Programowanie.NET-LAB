using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace DivisionApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            try
            {
                // czy pola tekstowe są puste
                if (string.IsNullOrWhiteSpace(dividendTextBox.Text) || string.IsNullOrWhiteSpace(divisorTextBox.Text))
                {
                    MessageBox.Show("Wprowadź wartości dla dzielnej i dzielnika.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double dividend = double.Parse(dividendTextBox.Text);
                double divisor = double.Parse(divisorTextBox.Text);

                // dzielnik =0
                if (divisor == 0)
                {
                    throw new DivideByZeroException("Dzielnik nie może być zerem.");
                }

                double result = dividend / divisor;

                resultTextBox.Text = result.ToString();
            }

            // błędy

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

        // dziennik zdarzeń
        private void LogError(Exception ex)
        {
            EventLog eventLog = new EventLog();
            eventLog.Source = "DivisionApp";
            eventLog.Log = "Application";
            eventLog.WriteEntry($"Wystąpił błąd: {ex.Message}", EventLogEntryType.Error);
        }
    }
}