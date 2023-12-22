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
    public partial class GuestForm : Form
    {
        GuestClass guest = new GuestClass();
        public GuestForm()
        {
            InitializeComponent();
        }

        private void btnGuestClean_Click(object sender, EventArgs e)
        {
            txtGuestId.Clear();
            txtGuestFName.Clear();
            txtGuestLName.Clear();
            txtGuestPhone.Clear();
            txtGuestCity.Clear();
        }
        //save
        private void btnGuestSave_Click(object sender, EventArgs e)
        {
            if (txtGuestId.Text == "" || txtGuestFName.Text == "" || txtGuestPhone.Text == "")
            {
                MessageBox.Show("Required Field - Id no, first name and phone no:", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string id = txtGuestId.Text;
                    string fname = txtGuestFName.Text;
                    string lname = txtGuestLName.Text;
                    string phone = txtGuestPhone.Text;
                    string city = txtGuestCity.Text;

                    Boolean insertGuest = guest.insertGuest(id, fname, lname, phone, city);
                    if (insertGuest)
                    {
                        MessageBox.Show("New guest save successfuly", "Guest Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getTable();
                        btnGuestClean.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("ERROR - guest not inserted", "Error Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GuestForm_Load(object sender, EventArgs e)
        {
            dataGridViewManageGuest.DefaultCellStyle.ForeColor = Color.Black;
            getTable();
        }
        private void getTable()
        {
            dataGridViewManageGuest.DataSource = guest.getGuest();
        }
        //update
        private void btnGuestUpdate_Click(object sender, EventArgs e)
        {
            if (txtGuestId.Text == "" || txtGuestFName.Text == "" || txtGuestPhone.Text == "")
            {
                MessageBox.Show("Required Field - Id no, first name and phone no:", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string id = txtGuestId.Text;
                    string fname = txtGuestFName.Text;
                    string lname = txtGuestLName.Text;
                    string phone = txtGuestPhone.Text;
                    string city = txtGuestCity.Text;

                    Boolean editGuest = guest.editGuest(id, fname, lname, phone, city);
                    if (editGuest)
                    {
                        MessageBox.Show("Guest data Update successfuly", "Update Successfuly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getTable();
                        btnGuestClean.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("ERROR - guest data not update", "Error Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridViewManageGuest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewManageGuest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtGuestId.Text = dataGridViewManageGuest.CurrentRow.Cells[0].Value.ToString();
            txtGuestFName.Text = dataGridViewManageGuest.CurrentRow.Cells[1].Value.ToString();
            txtGuestLName.Text = dataGridViewManageGuest.CurrentRow.Cells[2].Value.ToString();
            txtGuestPhone.Text = dataGridViewManageGuest.CurrentRow.Cells[3].Value.ToString();
            txtGuestCity.Text = dataGridViewManageGuest.CurrentRow.Cells[4].Value.ToString();
        }
        //delete
        private void btnGuestDelete_Click(object sender, EventArgs e)
        {
            if (txtGuestId.Text == "")
            {
                MessageBox.Show("Required Field - Id no", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string id = txtGuestId.Text;
                    Boolean deleteGuest = guest.removeGuest(id);
                    if (deleteGuest)
                    {
                        MessageBox.Show("guest data remove successfuly", "Guest Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getTable();
                        btnGuestClean.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("ERROR - guest not Remove", "Error delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

            private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.White;
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGuestSave_MouseEnter(object sender, EventArgs e)
        {
            btnGuestSave.ForeColor = Color.RoyalBlue;
        }

        private void btnGuestSave_MouseLeave(object sender, EventArgs e)
        {
            btnGuestSave.ForeColor = Color.Black;
        }

        private void btnGuestUpdate_MouseEnter(object sender, EventArgs e)
        {
            btnGuestUpdate.ForeColor = Color.RoyalBlue;
        }

        private void btnGuestUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnGuestUpdate.ForeColor = Color.Black;
        }

        private void btnGuestDelete_MouseEnter(object sender, EventArgs e)
        {
            btnGuestDelete.ForeColor = Color.RoyalBlue;
        }

        private void btnGuestDelete_MouseLeave(object sender, EventArgs e)
        {
            btnGuestDelete.ForeColor = Color.Black;
        }

        private void btnGuestClean_MouseEnter(object sender, EventArgs e)
        {
            btnGuestClean.ForeColor = Color.RoyalBlue;
        }

        private void btnGuestClean_MouseLeave(object sender, EventArgs e)
        {
            btnGuestClean.ForeColor = Color.Black;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblClose_MouseEnter(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.Red;
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.Black;
        }

        
    }
  } 
  
    
    



