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
    public partial class Dash : Form
    {
        // Instance of selectionNew form
        //private selectionNew selectionForm; 
        public Dash()
        {
            InitializeComponent();
            InitializeDefaultMainForm();

        }

        private void InitializeDefaultMainForm()
        {
            // Hide other UserControls
            year1new1.Visible = false;
            year2new1.Visible = false;
            selectionNewYr41.Visible = false;
            selectionNew1.Visible = false;

            // Show mainform1 UserControl
            mainform1.Visible = true;
            mainform1.Dock = DockStyle.Fill;
            mainform1.BringToFront();
        }


        private void gunaBtnYr1_Click(object sender, EventArgs e)
        {
            year1new1.Visible = true;
            year2new1.Visible = false;
            selectionNew1.Visible = false;
            mainform1.Visible = false;
            selectionNewYr41.Visible = false;
            

        }

        private void gunaBtnYr2_Click(object sender, EventArgs e)
        {
            
            year1new1.Visible = false;
            year2new1.Visible = true;
            selectionNewYr41.Visible = false;
            selectionNew1.Visible = false;
            mainform1.Visible = false;
        }

        private void gunaBtnYr3_Click(object sender, EventArgs e)
        {
            year1new1.Visible = false;
            year2new1.Visible = false;
            selectionNew1.Visible = true;
            selectionNewYr41.Visible = false;
            mainform1.Visible = false;
        }

        private void gunaBtnYr4_Click(object sender, EventArgs e)
        {
            year1new1.Visible = false;
            year2new1.Visible = false;
            selectionNewYr41.Visible = true;
            selectionNew1.Visible = false;
            mainform1.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaBtnDashboard_Click(object sender, EventArgs e)
        {
            year1new1.Visible = false;
            year2new1.Visible = false;
            selectionNewYr41.Visible = false;
            selectionNew1.Visible = false;
            mainform1.Visible = true;
        }

        private void gunaBtnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }
}
