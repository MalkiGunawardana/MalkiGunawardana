using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPA_calculator
{
    public partial class CsYr4 : Form
    {
        public CsYr4()
        {
            InitializeComponent();
        }

        private void gunaBtncal1_Click(object sender, EventArgs e)
        {
            // Year 4 Semester 1
            // Store the grades for each subject in an array or list
            string[] grades41 = new string[]
            {
            gunaCmb41201.SelectedItem?.ToString(),
            gunaCmb41227.SelectedItem?.ToString(),
            gunaCmb41228.SelectedItem?.ToString(),
            gunaCmb41229.SelectedItem?.ToString(),
            gunaCmb41230.SelectedItem?.ToString(),
            gunaCmb41231.SelectedItem?.ToString(),
            gunaCmb41232.SelectedItem?.ToString(),
            gunaCmb41233.SelectedItem?.ToString(),
            gunaCmb41234.SelectedItem?.ToString(),
            gunaCmb41135.SelectedItem?.ToString(),
            gunaCmb41236.SelectedItem?.ToString(),
            gunaCmb41203.SelectedItem?.ToString(),
            gunaCmb41208.SelectedItem?.ToString(),
            gunaCmb41210.SelectedItem?.ToString(),
            gunaCmb41215.SelectedItem?.ToString(),
            gunaCmb41116.SelectedItem?.ToString(),


            };

            string[] creditsInput41 = new string[] {
            gunaTxt41201.Text,
            gunaTxt41227.Text,
            gunaTxt41228.Text,
            gunaTxt41229.Text,
            gunaTxt41230.Text,
            gunaTxt41231.Text,
            gunaTxt41232.Text,
            gunaTxt41233.Text,
            gunaTxt41234.Text,
            gunaTxt41135.Text,
            gunaTxt41236.Text,
            gunaTxt41203.Text,
            gunaTxt41208.Text,
            gunaTxt41210.Text,
            gunaTxt41215.Text,
            gunaTxt41116.Text,

            };

            // Convert credits input to integers
            int[] credits = new int[creditsInput41.Length];
            int totalCredit = 0;

            for (int i = 0; i < creditsInput41.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(creditsInput41[i]))
                {
                    credits[i] = 0; // Set credits as 0 if the input is empty or whitespace
                }
                else if (!int.TryParse(creditsInput41[i], out credits[i]))
                {
                    // Handle invalid input by setting credits to 0
                    credits[i] = 0;
                }
                totalCredit += credits[i];
            }

            // Calculate GPA based on the grades and total credits
            double totalPoints = 0;
            for (int i = 0; i < grades41.Length; i++)
            {
                double gradePoint = GetGradePoint41(grades41[i]);
                totalPoints += gradePoint * credits[i];
            }

            double gpa = 0.0;

            // Check if totalCredit is not 0 to avoid division by zero
            if (totalCredit != 0)
            {
                gpa = (totalPoints / totalCredit);
            }

            // Do something with the calculated GPA (display, store, etc.)
            // For example, show the GPA in a MessageBox:
            gunaLblCredit41Cs.Text = $"{totalCredit}";
            gunaLblGPA41Cs.Text = $"{gpa}";
        }

        private double GetGradePoint41(string grade)
        {
            switch (grade?.ToUpper())
            {
                case "A/A+": return 4.0;
                case "A-": return 3.7;
                case "B+": return 3.3;
                case "B": return 3.0;
                case "B-": return 2.7;
                case "C+": return 2.3;
                case "C": return 2.0;
                case "C-": return 1.7;
                case "D+": return 1.3;
                case "D": return 1.0;
                default: return 0.0;
            }
        }

        private void gunaBtnCal2_Click(object sender, EventArgs e)
        {
            // Year 4 Semester 2
            // Store the grades for each subject in an array or list
            string[] grades42 = new string[]
            {
            gunaCmb42803.SelectedItem?.ToString(),
            
            };

            string[] creditsInput42 = new string[] {
            gunaTxt42803.Text,
            
            };

            // Convert credits input to integers
            int[] credits = new int[creditsInput42.Length];
            int totalCredit = 0;

            for (int i = 0; i < creditsInput42.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(creditsInput42[i]))
                {
                    credits[i] = 0; // Set credits as 0 if the input is empty or whitespace
                }
                else if (!int.TryParse(creditsInput42[i], out credits[i]))
                {
                    // Handle invalid input by setting credits to 0
                    credits[i] = 0;
                }
                totalCredit += credits[i];
            }

            // Calculate GPA based on the grades and total credits
            double totalPoints = 0;
            for (int i = 0; i < grades42.Length; i++)
            {
                double gradePoint = GetGradePoint41(grades42[i]);
                totalPoints += gradePoint * credits[i];
            }

            double gpa = 0.0;

            // Check if totalCredit is not 0 to avoid division by zero
            if (totalCredit != 0)
            {
                gpa = (totalPoints / totalCredit);
            }

            // Do something with the calculated GPA (display, store, etc.)
            // For example, show the GPA in a MessageBox:
            gunaLblCredit42Cs.Text = $"{totalCredit}";
            gunaLblGPA42Cs.Text = $"{gpa}";
        }

        private double GetGradePoint42(string grade)
        {
            switch (grade?.ToUpper())
            {
                case "A/A+": return 4.0;
                case "A-": return 3.7;
                case "B+": return 3.3;
                case "B": return 3.0;
                case "B-": return 2.7;
                case "C+": return 2.3;
                case "C": return 2.0;
                case "C-": return 1.7;
                case "D+": return 1.3;
                case "D": return 1.0;
                default: return 0.0;
            }
        }

        private void gunaBtnBack_Click(object sender, EventArgs e)
        {
            // Hide the current form (selection user control)
            this.Hide();

            // Create a new instance of the selection user control
            selectionNewYr4 selectionUC = new selectionNewYr4();

            // Add the user control to the parent form's `Controls` collection
            this.Parent.Controls.Add(selectionUC);

            // Dock the user control to fill the parent form
            selectionUC.Dock = DockStyle.Fill;

            // Bring the user control to the front
            selectionUC.BringToFront();

            // Show the user control
            selectionUC.Show();
        }
    }
}


