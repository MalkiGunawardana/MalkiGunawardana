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
    public partial class selectionNewYr4 : UserControl
    {
        private CsYr4 csFormInstance;
        private ChemYr4 chemFormInstance;
        private PhyYr4 phyFormInstance;

        public selectionNewYr4()
        {
            InitializeComponent();

            //for CS
            csFormInstance = new CsYr4();
            csFormInstance.TopLevel = false;
            csFormInstance.FormBorderStyle = FormBorderStyle.None;
            panelYr4.Controls.Add(csFormInstance);
            csFormInstance.Hide();

            //for Chemistry
            chemFormInstance = new ChemYr4();
            chemFormInstance.TopLevel = false;
            chemFormInstance.FormBorderStyle = FormBorderStyle.None;
            panelYr4.Controls.Add(chemFormInstance);
            chemFormInstance.Hide();

            //for Physics
            phyFormInstance = new PhyYr4();
            phyFormInstance.TopLevel = false;
            phyFormInstance.FormBorderStyle = FormBorderStyle.None;
            panelYr4.Controls.Add(phyFormInstance);
            phyFormInstance.Hide();
        }

        private void selectionCs_Click(object sender, EventArgs e)
        {
            panelYr4.BringToFront();
            csFormInstance.Show();
        }

        private void selectionPhy_Click(object sender, EventArgs e)
        {
            panelYr4.BringToFront();
            phyFormInstance.Show();
        }

        private void selectionChem_Click(object sender, EventArgs e)
        {
            panelYr4.BringToFront();
            chemFormInstance.Show();
        }
    }
}
