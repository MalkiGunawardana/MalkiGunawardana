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
    public partial class CsYr3 : Form
    {
        
        public CsYr3()
        {
            InitializeComponent();
           

        }
        
        private void CsYr3_Load(object sender, EventArgs e)
        {

        }

        private void gunaBtncal1_Click(object sender, EventArgs e)
        {
            // Year 3 Semester 1
            // Store the grades for each subject in an array or list
            string[] grades31 = new string[]
            {
            gunaCmb31223.SelectedItem?.ToString(),
            gunaCmb31209.SelectedItem?.ToString(),
            gunaCmb31224.SelectedItem?.ToString(),
            gunaCmb31225.SelectedItem?.ToString(),
            gunaCmb31226.SelectedItem?.ToString(),
            gunaCmb31227.SelectedItem?.ToString(),
            gunaCmb31228.SelectedItem?.ToString(),
            gunaCmb31229.SelectedItem?.ToString(),
            gunaCmb31130.SelectedItem?.ToString(),
            gunaCmb31206.SelectedItem?.ToString(),
            gunaCmb31211.SelectedItem?.ToString(),
            gunaCmb31112.SelectedItem?.ToString(),
            gunaCmb31213.SelectedItem?.ToString(),
            gunaCmb31014.SelectedItem?.ToString(),

            };

            string[] creditsInput31 = new string[] {
            gunaTxt31223.Text,
            gunaTxt31209.Text,
            gunaTxt31224.Text,
            gunaTxt31225.Text,
            gunaTxt31226.Text,
            gunaTxt31227.Text,
            gunaTxt31228.Text,
            gunaTxt31229.Text,
            gunaTxt31130.Text,
            gunaTxt31206.Text,
            gunaTxt31211.Text,
            gunaTxt31112.Text,
            gunaTxt31213.Text,
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
            gunaLblCredit31Cs.Text = $"{totalCredit}";
            gunaLblGPA31Cs.Text = $"{gpa}";
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
            // Year 3 Semester 2
            // Store the grades for each subject in an array or list
            string[] grades32 = new string[]
            {
            gunaCmb32223.SelectedItem?.ToString(),
            gunaCmb32224.SelectedItem?.ToString(),
            gunaCmb32225.SelectedItem?.ToString(),
            gunaCmb32226.SelectedItem?.ToString(),
            gunaCmb32227.SelectedItem?.ToString(),
            gunaCmb32228.SelectedItem?.ToString(),
            gunaCmb32229.SelectedItem?.ToString(),
            gunaCmb32230.SelectedItem?.ToString(),
            gunaCmb32231.SelectedItem?.ToString(),
            gunaCmb32132.SelectedItem?.ToString(),
            gunaCmb32133.SelectedItem?.ToString(),
            gunaCmb32205.SelectedItem?.ToString(),
            gunaCmb32209.SelectedItem?.ToString(),
            gunaCmb32210.SelectedItem?.ToString(),
            gunaCmb32212.SelectedItem?.ToString(),
            gunaCmb32213.SelectedItem?.ToString(),
            

            };

            string[] creditsInput32 = new string[] {
            gunaTxt32223.Text,
            gunaTxt32224.Text,
            gunaTxt32225.Text,
            gunaTxt32226.Text,
            gunaTxt32227.Text,
            gunaTxt32228.Text,
            gunaTxt32229.Text,
            gunaTxt32230.Text,
            gunaTxt32231.Text,
            gunaTxt32132.Text,
            gunaTxt32133.Text,
            gunaTxt32205.Text,
            gunaTxt32209.Text,
            gunaTxt32210.Text,
            gunaTxt32212.Text,
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
                double gradePoint = GetGradePoint32(grades32[i]);
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
            gunaLblCredit32Cs.Text = $"{totalCredit}";
            gunaLblGPA32Cs.Text = $"{gpa}";
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

