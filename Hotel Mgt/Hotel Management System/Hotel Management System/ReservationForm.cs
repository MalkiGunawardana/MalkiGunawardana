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
    public partial class ReservationForm : Form
    {
        RoomClass room = new RoomClass();
        ReservationClass reservation = new ReservationClass();
        public ReservationForm()
        {
            InitializeComponent();
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            cmbResevRoomType.DataSource = room.getRoomType();
            cmbResevRoomType.DisplayMember = "Label";
            cmbResevRoomType.ValueMember = "CategoryId";

            int type = Convert.ToInt32(cmbResevRoomType.SelectedValue.ToString());
            cmbResevRoomNo.DataSource = reservation.roomByType(type);
            cmbResevRoomNo.DisplayMember = "RoomId";
            cmbResevRoomNo.ValueMember = "RoomId";

            dataGridViewReserv.DefaultCellStyle.ForeColor = Color.Black;
            //To show Reservation list in DatagridView
            getReservTable();
        }

        public void getReservTable()
        {
            dataGridViewReserv.DataSource = reservation.getReserv();
        }

        private void cmbResevRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int type = Convert.ToInt32(cmbResevRoomType.SelectedValue.ToString());
                cmbResevRoomNo.DataSource = reservation.roomByType(type);
                cmbResevRoomNo.DisplayMember = "RoomId";
                cmbResevRoomNo.ValueMember = "RoomId";
            }
            catch (Exception)
            {
                //Nothing
            }
        }

        private void btnResevAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string guestId = txtResevGuestId.Text;
                string roomNo = cmbResevRoomNo.SelectedValue.ToString();
                DateTime dIn = dateTimePickerIn.Value;
                DateTime dOut = dateTimePickerOut.Value;

                
                if (dIn < DateTime.Today)
                {
                    MessageBox.Show("Reservation Date In must be Today Or After", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dOut < dIn)
                {
                    MessageBox.Show("Reservation Date Out must be same Date In and After", "invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (reservation.addReserv(guestId, roomNo, dIn, dOut) && reservation.setReservRoom(roomNo, "Busy"))
                    {
                        getReservTable();
                        MessageBox.Show("New Reservation add Successfuly", "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Reservation Not add Successfuly", "Error Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Reservation Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuestDelete_Click(object sender, EventArgs e)
        {
            int reserId = Convert.ToInt32(txtResevId.Text);
            string rno = cmbResevRoomNo.Text;

            try
            {
                if (reservation.removeReserv(reserId) && reservation.setReservRoom(rno, "Free"))
                {
                    getReservTable();
                    MessageBox.Show("Delete Reservatoin Successfuly", "Deleted Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewReserv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtResevId.Text = dataGridViewReserv.CurrentRow.Cells[0].Value.ToString();
            txtResevGuestId.Text = dataGridViewReserv.CurrentRow.Cells[1].Value.ToString();

            string rno = dataGridViewReserv.CurrentRow.Cells[2].Value.ToString();
            cmbResevRoomType.SelectedValue = reservation.typeByRoomNo(rno);
            cmbResevRoomNo.Text = rno;
            //comboBox_roomType
            dateTimePickerIn.Text = dataGridViewReserv.CurrentRow.Cells[3].Value.ToString();
            dateTimePickerOut.Text = dataGridViewReserv.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnGuestClean_Click(object sender, EventArgs e)
        {
            txtResevId.Clear();
            txtResevGuestId.Clear();
            cmbResevRoomType.SelectedValue = 1;
            dateTimePickerIn.Value = DateTime.Now;
            dateTimePickerOut.Value = DateTime.Now;
        }

        private void btnGuestUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int reservId = Convert.ToInt32(txtResevId.Text);
                string guestId = txtResevGuestId.Text;
                string roomNo = cmbResevRoomNo.SelectedValue.ToString();
                DateTime dIn = dateTimePickerIn.Value;
                DateTime dOut = dateTimePickerOut.Value;

                
                if (dIn < DateTime.Today)
                {
                    MessageBox.Show("Reservation Date In must be Today Or After", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dOut < dIn)
                {
                    MessageBox.Show("Reservation Date Out must be same Date In and After", "invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (reservation.editReserv(reservId, guestId, roomNo, dIn, dOut) && reservation.setReservRoom(roomNo, "Busy"))
                    {
                        getReservTable();
                        MessageBox.Show("Reservation edit Successfuly", "Update Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Reservation Not edit Successfuly", "Error Update", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Reservation Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
        private void lblClose_MouseEnter(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.Red;
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.Black;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnResevAdd_MouseEnter(object sender, EventArgs e)
        {
            btnResevAdd.ForeColor = Color.RoyalBlue;
        }

        private void btnResevAdd_MouseLeave(object sender, EventArgs e)
        {
            btnResevAdd.ForeColor = Color.Black;
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




