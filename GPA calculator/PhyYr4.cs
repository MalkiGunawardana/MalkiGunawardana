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
    public partial class PhyYr4 : Form
    {
        public PhyYr4()
        {
            InitializeComponent();
        }

        private void gunaBtncal1_Click(object sender, EventArgs e)
        {
            // Year 4 Semester 1
            // Store the grades for each subject in an array or list
            string[] grades41 = new string[]
            {
            gunaCmb41001.SelectedItem?.ToString(),
            gunaCmb41202.SelectedItem?.ToString(),
            gunaCmb41203.SelectedItem?.ToString(),
            gunaCmb41204.SelectedItem?.ToString(),
            gunaCmb41205.SelectedItem?.ToString(),
            gunaCmb41206.SelectedItem?.ToString(),
            gunaCmb41207.SelectedItem?.ToString(),
            gunaCmb41208.SelectedItem?.ToString(),
            gunaCmb41209.SelectedItem?.ToString(),
            gunaCmb41210.SelectedItem?.ToString(),
            gunaCmb41211.SelectedItem?.ToString(),
            gunaCmb41212.SelectedItem?.ToString(),
            gunaCmb41113.SelectedItem?.ToString(),
            gunaCmb41214.SelectedItem?.ToString(),
            gunaCmb41215.SelectedItem?.ToString(),
            gunaCmb41116.SelectedItem?.ToString(),

            };

            string[] creditsInput41 = new string[] {
            gunaTxt41001.Text,
            gunaTxt41202.Text,
            gunaTxt41203.Text,
            gunaTxt41204.Text,
            gunaTxt41205.Text,
            gunaTxt41206.Text,
            gunaTxt41207.Text,
            gunaTxt41208.Text,
            gunaTxt41209.Text,
            gunaTxt41210.Text,
            gunaTxt41211.Text,
            gunaTxt41212.Text,
            gunaTxt41113.Text,
            gunaTxt41214.Text,
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
                double gradePoint = GetGradePoint31(grades41[i]);
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
            gunaLblCredit41Phy.Text = $"{totalCredit}";
            gunaLblGPA41Phy.Text = $"{gpa}";
        }

        private double GetGradePoint31(string grade)
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
            gunaCmb42801.SelectedItem?.ToString(),
            
            };

            string[] creditsInput42 = new string[] {
            gunaTxt42801.Text,
            
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
                double gradePoint = GetGradePoint42(grades42[i]);
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
            gunaLblCredit42Phy.Text = $"{totalCredit}";
            gunaLblGPA42Phy.Text = $"{gpa}";
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
    

