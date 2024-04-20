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
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }
        int startPoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint += 2;
            gunaProgressBar1.Value = startPoint;
            if (gunaProgressBar1.Value == 100)
            {
                timer1.Stop();
                gunaProgressBar1.Value = 0;
                Dash dash = new Dash();
                this.Hide();
                dash.Show();
            }
        }

        private void splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
