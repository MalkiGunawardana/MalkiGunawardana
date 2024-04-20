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
    public partial class ChemYr3 : Form
    {
        public ChemYr3()
        {
            InitializeComponent();
        }

        private void gunaBtnCal1_Click(object sender, EventArgs e)
        {
            // Year 3 Semester 1
            // Store the grades for each subject in an array or list
            string[] grades31 = new string[]
            {
            gunaCmb31215.SelectedItem?.ToString(),
            gunaCmb31216.SelectedItem?.ToString(),
            gunaCmb31217.SelectedItem?.ToString(),
            gunaCmb31218.SelectedItem?.ToString(),
            gunaCmb31219.SelectedItem?.ToString(),
            gunaCmb31120.SelectedItem?.ToString(),
            gunaCmb31121.SelectedItem?.ToString(),
            gunaCmb31122.SelectedItem?.ToString(),
            gunaCmb31107.SelectedItem?.ToString(),
            gunaCmb31211.SelectedItem?.ToString(),
            gunaCmb31112.SelectedItem?.ToString(),
            gunaCmb31213.SelectedItem?.ToString(),
            gunaCmb31014.SelectedItem?.ToString(),
            gunaCmb31014.SelectedItem?.ToString(),

            };

            string[] creditsInput31 = new string[] {
            gunaTxt31215.Text,
            gunaTxt31216.Text,
            gunaTxt31217.Text,
            gunaTxt31218.Text,
            gunaTxt31219.Text,
            gunaTxt31120.Text,
            gunaTxt31121.Text,
            gunaTxt31122.Text,
            gunaTxt31107.Text,
            gunaTxt31211.Text,
            gunaTxt31112.Text,
            gunaTxt31213.Text,
            gunaTxt31014.Text,
            gunaTxt31014.Text,

            };

            // Convert credits input to integers
            int[] credits = new int[creditsInput31.Length];
            int totalCredit = 0;

            for (int i = 0; i < creditsInput31.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(creditsInput31[i]))
                {
                    credits[i] = 0; // Set credits as 0 if the input is empty or whitespace
                }
                else if (!int.TryParse(creditsInput31[i], out credits[i]))
                {
                    // Handle invalid input by setting credits to 0
                    credits[i] = 0;
                }
                totalCredit += credits[i];
            }

            // Calculate GPA based on the grades and total credits
            double totalPoints = 0;
            for (int i = 0; i < grades31.Length; i++)
            {
                double gradePoint = GetGradePoint31(grades31[i]);
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
            gunaLblCredit31Chem.Text = $"{totalCredit}";
            gunaLblGPA31Chem.Text = $"{gpa}";
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

        private void gunaCmb32228_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gunaBtnCal2_Click(object sender, EventArgs e)
        {
            // Year 3 Semester 2
            // Store the grades for each subject in an array or list
            string[] grades32 = new string[]
            {
            gunaCmb32214.SelectedItem?.ToString(),
            gunaCmb32215.SelectedItem?.ToString(),
            gunaCmb32216.SelectedItem?.ToString(),
            gunaCmb32117.SelectedItem?.ToString(),
            gunaCmb32118.SelectedItem?.ToString(),
            gunaCmb32119.SelectedItem?.ToString(),
            gunaCmb32220.SelectedItem?.ToString(),
            gunaCmb32121.SelectedItem?.ToString(),
            gunaCmb32209.SelectedItem?.ToString(),
            gunaCmb32210.SelectedItem?.ToString(),
            gunaCmb32222.SelectedItem?.ToString(),
            gunaCmb32213.SelectedItem?.ToString(),


            };

            string[] creditsInput32 = new string[] {
            gunaTxt32214.Text,
            gunaTxt32215.Text,
            gunaTxt32216.Text,
            gunaTxt32117.Text,
            gunaTxt32118.Text,
            gunaTxt32119.Text,
            gunaTxt32220.Text,
            gunaTxt32121.Text,
            gunaTxt32209.Text,
            gunaTxt32210.Text,
            gunaTxt32222.Text,
            gunaTxt32213.Text,


            };

            // Convert credits input to integers
            int[] credits = new int[creditsInput32.Length];
            int totalCredit = 0;

            for (int i = 0; i < creditsInput32.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(creditsInput32[i]))
                {
                    credits[i] = 0; // Set credits as 0 if the input is empty or whitespace
                }
                else if (!int.TryParse(creditsInput32[i], out credits[i]))
                {
                    // Handle invalid input by setting credits to 0
                    credits[i] = 0;
                }
                totalCredit += credits[i];
            }

            // Calculate GPA based on the grades and total credits
            double totalPoints = 0;
            for (int i = 0; i < grades32.Length; i++)
            {
                double gradePoint = GetGradePoint31(grades32[i]);
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
            gunaLblCredit32Chem.Text = $"{totalCredit}";
            gunaLblGPA32Chem.Text = $"{gpa}";
        }

        private double GetGradePoint32(string grade)
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
            selectionNew selectionUC = new selectionNew();

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
 

