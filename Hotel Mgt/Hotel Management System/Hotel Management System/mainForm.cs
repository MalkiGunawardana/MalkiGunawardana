using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlDashScroll.Height = btnDashboard.Height;
            pnlDashScroll.Top = btnDashboard.Top;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(panelCover);

        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            pnlDashScroll.Height = btnGuest.Height;
            pnlDashScroll.Top = btnGuest.Top;

            pnlMain.Controls.Clear();
            GuestForm guest = new GuestForm();
            guest.TopLevel = false;
            guest.Dock = DockStyle.Fill;
            guest.FormBorderStyle = FormBorderStyle.None;
            pnlMain.Controls.Add(guest);
            guest.Show();
        }

        private void btnReception_Click(object sender, EventArgs e)
        {
            pnlDashScroll.Height = btnReception.Height;
            pnlDashScroll.Top = btnReception.Top;

            pnlMain.Controls.Clear();
            ReservationForm reservation = new ReservationForm();
            reservation.TopLevel = false;
            reservation.Dock = DockStyle.Fill;
            reservation.FormBorderStyle = FormBorderStyle.None;
            pnlMain.Controls.Add(reservation);
            reservation.Show();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            pnlDashScroll.Height = btnRooms.Height;
            pnlDashScroll.Top = btnRooms.Top;

            pnlMain.Controls.Clear();
            RoomForm room = new RoomForm();
            room.TopLevel = false;
            room.Dock = DockStyle.Fill;
            room.FormBorderStyle = FormBorderStyle.None;
            pnlMain.Controls.Add(room);
            room.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            pnlDashScroll.Height = btnLogout.Height;
            pnlDashScroll.Top = btnRooms.Top;

            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDashboard_MouseEnter(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.White;
            btnDashboard.ForeColor = Color.RoyalBlue;
        }

        private void btnDashboard_MouseLeave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.ForeColor = Color.White;
        }

        private void btnGuest_MouseEnter(object sender, EventArgs e)
        {
            btnGuest.BackColor = Color.White;
            btnGuest.ForeColor = Color.RoyalBlue;
        }

        private void btnGuest_MouseLeave(object sender, EventArgs e)
        {
            btnGuest.BackColor = Color.Transparent;
            btnGuest.ForeColor = Color.White;
        }

        private void btnReception_MouseEnter(object sender, EventArgs e)
        {
            btnReception.BackColor = Color.White;
            btnReception.ForeColor = Color.RoyalBlue;
        }

        private void btnReception_MouseLeave(object sender, EventArgs e)
        {
            btnReception.BackColor = Color.Transparent;
            btnReception.ForeColor = Color.White;
        }

        private void btnRooms_MouseEnter(object sender, EventArgs e)
        {
            btnRooms.BackColor = Color.White;
            btnRooms.ForeColor = Color.RoyalBlue;
        }

        private void btnRooms_MouseLeave(object sender, EventArgs e)
        {
            btnRooms.BackColor = Color.Transparent;
            btnRooms.ForeColor = Color.White;
        }

        private void btnLogout_MouseEnter(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.White;
            btnLogout.ForeColor = Color.Red;
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.Transparent;
            btnLogout.ForeColor = Color.White;
        }

        

        private void lblClose_MouseEnter(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.Red;
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.Black;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

   
    }
}
