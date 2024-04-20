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
    public partial class selectionNew : UserControl
    {
        
        private CsYr3 csFormInstance;
        private ChemYr3 chemFormInstance;
        private PhyYr3 phyFormInstance;

        public selectionNew()
        {
            InitializeComponent();
            
            //for CS
            csFormInstance = new CsYr3();
            csFormInstance.TopLevel = false;
            csFormInstance.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(csFormInstance);
            csFormInstance.Hide();

            //for chemistry
            chemFormInstance = new ChemYr3();
            chemFormInstance.TopLevel = false;
            chemFormInstance.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(chemFormInstance);
            chemFormInstance.Hide();

            //for physics
            phyFormInstance = new PhyYr3();
            phyFormInstance.TopLevel = false;
            phyFormInstance.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(phyFormInstance);
            phyFormInstance.Hide();

            
        }
        
        private void gunaButton3_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
            csFormInstance.Show();

        }
        
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
            phyFormInstance.Show();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
            chemFormInstance.Show();
        }
        

    }
}
