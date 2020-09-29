using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prb.BMICalculator.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            int length = int.Parse(txtHeight.Text);
            double weight = double.Parse(txtWeight.Text);
            tblReport.Text = GenerateReport(txtFirstName.Text, txtLastName.Text, length, weight);
        }

        private string GenerateReport(string firstName, string lastName, int lengthInCm, double weight)
        {
            string report = $"Naam = {lastName} {firstName}\n"
                + $"Lengte = {lengthInCm} cm\n"
                + $"Gewicht = {weight} kg\n"
                + $"BMI = {CalculateBMI(lengthInCm, weight).ToString("0.00")}";
            return report;
        }
        private double CalculateBMI(int lengthInCm, double weight)
        {
            double lengthInM = ((double)lengthInCm) / 100;
            double bmi = weight / (lengthInM * lengthInM);
            return bmi;
        }
    }
}
