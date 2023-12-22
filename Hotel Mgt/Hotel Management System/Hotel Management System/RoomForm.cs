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
    public partial class RoomForm : Form
    {
        RoomClass room = new RoomClass();
        public RoomForm()
        {
            InitializeComponent();
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            cmbRoomType.DataSource = room.getRoomType();
            cmbRoomType.DisplayMember = "Label";
            cmbRoomType.ValueMember = "CategoryId";

            getRoomList();

            dataGridViewManageRooms.DefaultCellStyle.ForeColor = Color.Black;
        }
        //add
        private void btnRoomAdd_Click(object sender, EventArgs e)
        {
            string no = txtRoomId.Text;
            int type = Convert.ToInt32(cmbRoomType.SelectedValue.ToString());
            string ph = txtRoomPhone.Text;
            string status = radioFree.Checked ? "Free" : "Busy";

            try
            {
                if (room.addRoom(no, type, ph, status))
                {
                    MessageBox.Show("Room Added Successfuly", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getRoomList();
                    btnGuestClean.PerformClick();
                }
                else
                {
                    MessageBox.Show("Room Not Added", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    

        private void getRoomList()
        {
            dataGridViewManageRooms.DataSource = room.getRoomList();
        }

        //update
        private void btnGuestUpdate_Click(object sender, EventArgs e)
        {
            string no = txtRoomId.Text;
            int type = Convert.ToInt32(cmbRoomType.SelectedValue.ToString());
            string ph = txtRoomPhone.Text;
            string status = radioFree.Checked ? "Free" : "Busy";

            try
            {
                if (room.editRoom(no, type, ph, status))
                {
                    MessageBox.Show("Room Update Successfuly", "Update Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getRoomList();
                    btnGuestClean.PerformClick();
                }
                else
                {
                    MessageBox.Show("Room Not Update", "Update Room", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewManageRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRoomId.Text = dataGridViewManageRooms.CurrentRow.Cells[0].Value.ToString();
            cmbRoomType.SelectedValue = dataGridViewManageRooms.CurrentRow.Cells[1].Value.ToString();
            txtRoomPhone.Text = dataGridViewManageRooms.CurrentRow.Cells[2].Value.ToString();

            string rButton = dataGridViewManageRooms.CurrentRow.Cells[3].Value.ToString();
            if (rButton.Equals("Free"))
            {
                radioFree.Checked = true;
            }
            else
            {
                radioBusy.Checked = true;
            }
        }

        //delete
        private void btnGuestDelete_Click(object sender, EventArgs e)
        {
            if (txtRoomId.Text == "")
            {
                MessageBox.Show("Required Field - Room No", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string id = txtRoomId.Text;
                    Boolean deleteGuest = room.removeRoom(id);
                    if (deleteGuest)
                    {
                        MessageBox.Show("Room remove successfuly", "Room Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getRoomList();

                        btnGuestClean.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("ERROR - room not Remove", "Error delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        
        private void btnGuestClean_Click(object sender, EventArgs e)
        {
            txtRoomId.Clear();
            cmbRoomType.SelectedIndex = 0;
            txtRoomPhone.Clear();
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

        private void btnRoomAdd_MouseEnter(object sender, EventArgs e)
        {
            btnRoomAdd.ForeColor = Color.RoyalBlue;
        }

        private void btnRoomAdd_MouseLeave(object sender, EventArgs e)
        {
            btnRoomAdd.ForeColor = Color.Black;
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
    }
   }
  

