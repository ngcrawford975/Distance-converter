using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distance_converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            bool hasInput1 = double.TryParse(InputTxt.Text, out double value1);
            bool hasInput2 = double.TryParse(InputTxt2.Text, out double value2);

            if (!hasInput1 && !hasInput2)
            {
                MessageBox.Show("Please enter a number in one of the input fields.");
                return;
            }

            if (FromList.SelectedIndex == -1 || ToList.SelectedIndex == -1)
            {
                MessageBox.Show("Please select units for both fields.");
                return;
            }

            string unit1 = FromList.SelectedItem.ToString();
            string unit2 = ToList.SelectedItem.ToString();

            // User typed in Input 1 → convert to Input 2
            if (hasInput1 && !hasInput2)
            {
                double result = ConvertUnits(value1, unit1, unit2);
                InputTxt2.Text = result.ToString("0.###");
                return;
            }

            // User typed in Input 2 → convert to Input 1
            if (hasInput2 && !hasInput1)
            {
                double result = ConvertUnits(value2, unit2, unit1);
                InputTxt.Text = result.ToString("0.###");
                return;
            }

            // If both have values, default to converting Input 1 → Input 2
            double finalResult = ConvertUnits(value1, unit1, unit2);
            InputTxt2.Text = finalResult.ToString("0.###");
        }

        private double ConvertUnits(double value, string fromUnit, string toUnit)
        {
            // Convert from source unit → inches
            double inches = value;

            if (fromUnit == "Feet")
                inches = value * 12;
            else if (fromUnit == "Yards")
                inches = value * 36;

            // Convert inches → target unit
            if (toUnit == "Feet")
                return inches / 12;
            else if (toUnit == "Yards")
                return inches / 36;
            else
                return inches; // inches → inches
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}