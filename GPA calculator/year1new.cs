using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPA_calculator
{
    public partial class year1new : UserControl
    {
        public year1new()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void year1new_Load(object sender, EventArgs e)
        {

        }

        private void gunaTxt1101_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTxt11210_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTxt11109_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTxt11208_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTxt11207_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTxt11106_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTxt11205_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTxt11204_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTxt11103_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTxt11201_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTxt11202_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTxt12110_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTxt1201_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTxt12211_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTxt12209_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTxt12208_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTxt12107_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTxt12206_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTxt12205_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTxt12104_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTxt12103_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTxt12102_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTxt12201_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaBtncal1_Click(object sender, EventArgs e)
        {
            // Year 1 Semester 1
            // Store the grades for each subject in an array or list
            string[] grades11 = new string[]
            {
            gunaCmb11201.SelectedItem?.ToString(),
            gunaCmb11202.SelectedItem?.ToString(),
            gunaCmb11103.SelectedItem?.ToString(),
            gunaCmb11204.SelectedItem?.ToString(),
            gunaCmb11205.SelectedItem?.ToString(),
            gunaCmb11106.SelectedItem?.ToString(),
            gunaCmb11207.SelectedItem?.ToString(),
            gunaCmb11208.SelectedItem?.ToString(),
            gunaCmb11109.SelectedItem?.ToString(),
            gunaCmb11210.SelectedItem?.ToString(),
            gunaCmb1101.SelectedItem?.ToString(),

            };

            string[] creditsInput11 = new string[] {
            gunaTxt11201.Text,
            gunaTxt11202.Text,
            gunaTxt11103.Text,
            gunaTxt11204.Text,
            gunaTxt11205.Text,
            gunaTxt11106.Text,
            gunaTxt11207.Text,
            gunaTxt11208.Text,
            gunaTxt11109.Text,
            gunaTxt11210.Text,
            gunaTxt1101.Text,

            };

            // Convert credits input to integers
            int[] credits = new int[creditsInput11.Length];
            int totalCredit = 0;

            for (int i = 0; i < creditsInput11.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(creditsInput11[i]))
                {
                    credits[i] = 0; // Set credits as 0 if the input is empty or whitespace
                }
                else if (!int.TryParse(creditsInput11[i], out credits[i]))
                {
                    // Handle invalid input by setting credits to 0
                    credits[i] = 0;
                }
                totalCredit += credits[i];
            }

            // Calculate GPA based on the grades and total credits
            double totalPoints = 0;
            for (int i = 0; i < grades11.Length; i++)
            {
                double gradePoint = GetGradePoint11(grades11[i]);
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
            gunaLblCredit11.Text = $"{totalCredit}";
            gunaLblGPA11.Text = $"{gpa}";
        }

        private double GetGradePoint11(string grade)
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
            // Year 1 Semester 2
            // Store the grades for each subject in an array or list
            string[] grades12 = new string[]
            {
            gunaCmb12201.SelectedItem?.ToString(),
            gunaCmb12102.SelectedItem?.ToString(),
            gunaCmb12103.SelectedItem?.ToString(),
            gunaCmb12104.SelectedItem?.ToString(),
            gunaCmb12205.SelectedItem?.ToString(),
            gunaCmb12206.SelectedItem?.ToString(),
            gunaCmb12107.SelectedItem?.ToString(),
            gunaCmb12208.SelectedItem?.ToString(),
            gunaCmb12209.SelectedItem?.ToString(),
            gunaCmb12110.SelectedItem?.ToString(),
            gunaCmb12211.SelectedItem?.ToString(),
            gunaCmb1201.SelectedItem?.ToString(),


            };

            string[] creditsInput12 = new string[] {
            gunaTxt12201.Text,
            gunaTxt12102.Text,
            gunaTxt12103.Text,
            gunaTxt12104.Text,
            gunaTxt12205.Text,
            gunaTxt12206.Text,
            gunaTxt12107.Text,
            gunaTxt12208.Text,
            gunaTxt12209.Text,
            gunaTxt12110.Text,
            gunaTxt12211.Text,
            gunaTxt1201.Text,

            };

            // Convert credits input to integers
            int[] credits = new int[creditsInput12.Length];
            int totalCredit = 0;

            for (int i = 0; i < creditsInput12.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(creditsInput12[i]))
                {
                    credits[i] = 0; // Set credits as 0 if the input is empty or whitespace
                }
                else if (!int.TryParse(creditsInput12[i], out credits[i]))
                {
                    // Handle invalid input by setting credits to 0
                    credits[i] = 0;
                }
                totalCredit += credits[i];
            }

            // Calculate GPA based on the grades and total credits
            double totalPoints = 0;
            for (int i = 0; i < grades12.Length; i++)
            {
                double gradePoint = GetGradePoint12(grades12[i]);
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
            gunaLblCredit12.Text = $"{totalCredit}";
            gunaLblGPA12.Text = $"{gpa}";
        }

        private double GetGradePoint12(string grade)
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
    }
}
 

