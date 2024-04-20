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
    public partial class year2new : UserControl
    {
        public year2new()
        {
            InitializeComponent();
        }

        private void year2new_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gunaBtncal1_Click(object sender, EventArgs e)
        {
            string[] grades21 = new string[]
            {
            gunaCmb21201.SelectedItem?.ToString(),
            gunaCmb21202.SelectedItem?.ToString(),
            gunaCmb21103.SelectedItem?.ToString(),
            gunaCmb21204.SelectedItem?.ToString(),
            gunaCmb21205.SelectedItem?.ToString(),
            gunaCmb21106.SelectedItem?.ToString(),
            gunaCmb21207.SelectedItem?.ToString(),
            gunaCmb21208.SelectedItem?.ToString(),
            gunaCmb21209.SelectedItem?.ToString(),
            gunaCmb21110.SelectedItem?.ToString(),
            gunaCmb2101.SelectedItem?.ToString(),

            };

            string[] creditsInput21 = new string[] {
            gunaTxt21201.Text,
            gunaTxt21202.Text,
            gunaTxt21103.Text,
            gunaTxt21204.Text,
            gunaTxt21205.Text,
            gunaTxt21106.Text,
            gunaTxt21207.Text,
            gunaTxt21208.Text,
            gunaTxt21209.Text,
            gunaTxt21110.Text,
            gunaTxt2101.Text,

            };

            // Convert credits input to integers
            int[] credits = new int[creditsInput21.Length];
            int totalCredit = 0;

            for (int i = 0; i < creditsInput21.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(creditsInput21[i]))
                {
                    credits[i] = 0; // Set credits as 0 if the input is empty or whitespace
                }
                else if (!int.TryParse(creditsInput21[i], out credits[i]))
                {
                    // Handle invalid input by setting credits to 0
                    credits[i] = 0;
                }
                totalCredit += credits[i];
            }

            // Calculate GPA based on the grades and total credits
            double totalPoints = 0;
            for (int i = 0; i < grades21.Length; i++)
            {
                double gradePoint = GetGradePoint21(grades21[i]);
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
            gunaLblCredit21.Text = $"{totalCredit}";
            gunaLblGPA21.Text = $"{gpa}";
        }

        private double GetGradePoint21(string grade)
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
            string[] grades22 = new string[]
            {
            gunaCmb22201.SelectedItem?.ToString(),
            gunaCmb22202.SelectedItem?.ToString(),
            gunaCmb22103.SelectedItem?.ToString(),
            gunaCmb22204.SelectedItem?.ToString(),
            gunaCmb22205.SelectedItem?.ToString(),
            gunaCmb22106.SelectedItem?.ToString(),
            gunaCmb22207.SelectedItem?.ToString(),
            gunaCmb22208.SelectedItem?.ToString(),
            gunaCmb22209.SelectedItem?.ToString(),
            gunaCmb22110.SelectedItem?.ToString(),
            gunaCmb22211.SelectedItem?.ToString(),
            gunaCmb22112.SelectedItem?.ToString(),
            gunaCmb22213.SelectedItem?.ToString(),
            gunaCmb22114.SelectedItem?.ToString(),
            gunaCmb22215.SelectedItem?.ToString(),
            gunaCmb2201.SelectedItem?.ToString(),

            };

            string[] creditsInput22 = new string[] {
            gunaTxt22201.Text,
            gunaTxt22202.Text,
            gunaTxt22103.Text,
            gunaTxt22204.Text,
            gunaTxt22205.Text,
            gunaTxt22106.Text,
            gunaTxt22207.Text,
            gunaTxt22208.Text,
            gunaTxt22209.Text,
            gunaTxt22110.Text,
            gunaTxt22211.Text,
            gunaTxt22112.Text,
            gunaTxt22213.Text,
            gunaTxt22114.Text,
            gunaTxt22215.Text,
            gunaTxt2201.Text,

            };

            // Convert credits input to integers
            int[] credits = new int[creditsInput22.Length];
            int totalCredit = 0;

            for (int i = 0; i < creditsInput22.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(creditsInput22[i]))
                {
                    credits[i] = 0; // Set credits as 0 if the input is empty or whitespace
                }
                else if (!int.TryParse(creditsInput22[i], out credits[i]))
                {
                    // Handle invalid input by setting credits to 0
                    credits[i] = 0;
                }
                totalCredit += credits[i];
            }

            // Calculate GPA based on the grades and total credits
            double totalPoints = 0;
            for (int i = 0; i < grades22.Length; i++)
            {
                double gradePoint = GetGradePoint22(grades22[i]);
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
            gunaLblCredit22.Text = $"{totalCredit}";
            gunaLblGPA22.Text = $"{gpa}";
        }

        private double GetGradePoint22(string grade)
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
   
