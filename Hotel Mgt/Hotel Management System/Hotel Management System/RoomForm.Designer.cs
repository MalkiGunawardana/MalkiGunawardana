namespace Hotel_Management_System
{
    partial class RoomForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomForm));
            this.lblClose = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewManageRooms = new System.Windows.Forms.DataGridView();
            this.btnGuestClean = new System.Windows.Forms.Button();
            this.btnGuestDelete = new System.Windows.Forms.Button();
            this.btnGuestUpdate = new System.Windows.Forms.Button();
            this.btnRoomAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.txtRoomPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRoomId = new System.Windows.Forms.TextBox();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.radioFree = new System.Windows.Forms.RadioButton();
            this.radioBusy = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageRooms)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.Location = new System.Drawing.Point(910, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(32, 31);
            this.lblClose.TabIndex = 2;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseEnter += new System.EventHandler(this.lblClose_MouseEnter);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblClose_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewManageRooms);
            this.panel2.Location = new System.Drawing.Point(0, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(954, 307);
            this.panel2.TabIndex = 24;
            // 
            // dataGridViewManageRooms
            // 
            this.dataGridViewManageRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewManageRooms.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewManageRooms.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewManageRooms.ColumnHeadersHeight = 28;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewManageRooms.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewManageRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewManageRooms.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewManageRooms.Name = "dataGridViewManageRooms";
            this.dataGridViewManageRooms.RowTemplate.Height = 24;
            this.dataGridViewManageRooms.Size = new System.Drawing.Size(954, 307);
            this.dataGridViewManageRooms.TabIndex = 0;
            this.dataGridViewManageRooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewManageRooms_CellClick);
            // 
            // btnGuestClean
            // 
            this.btnGuestClean.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuestClean.BackgroundImage")));
            this.btnGuestClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuestClean.FlatAppearance.BorderSize = 0;
            this.btnGuestClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuestClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuestClean.Location = new System.Drawing.Point(604, 0);
            this.btnGuestClean.Margin = new System.Windows.Forms.Padding(0);
            this.btnGuestClean.Name = "btnGuestClean";
            this.btnGuestClean.Size = new System.Drawing.Size(135, 81);
            this.btnGuestClean.TabIndex = 5;
            this.btnGuestClean.Text = "Clean";
            this.btnGuestClean.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuestClean.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuestClean.UseVisualStyleBackColor = true;
            this.btnGuestClean.Click += new System.EventHandler(this.btnGuestClean_Click);
            this.btnGuestClean.MouseEnter += new System.EventHandler(this.btnGuestClean_MouseEnter);
            this.btnGuestClean.MouseLeave += new System.EventHandler(this.btnGuestClean_MouseLeave);
            // 
            // btnGuestDelete
            // 
            this.btnGuestDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuestDelete.BackgroundImage")));
            this.btnGuestDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuestDelete.FlatAppearance.BorderSize = 0;
            this.btnGuestDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuestDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuestDelete.Location = new System.Drawing.Point(469, 0);
            this.btnGuestDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnGuestDelete.Name = "btnGuestDelete";
            this.btnGuestDelete.Size = new System.Drawing.Size(135, 81);
            this.btnGuestDelete.TabIndex = 4;
            this.btnGuestDelete.Text = "Delete";
            this.btnGuestDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuestDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuestDelete.UseVisualStyleBackColor = true;
            this.btnGuestDelete.Click += new System.EventHandler(this.btnGuestDelete_Click);
            this.btnGuestDelete.MouseEnter += new System.EventHandler(this.btnGuestDelete_MouseEnter);
            this.btnGuestDelete.MouseLeave += new System.EventHandler(this.btnGuestDelete_MouseLeave);
            // 
            // btnGuestUpdate
            // 
            this.btnGuestUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuestUpdate.BackgroundImage")));
            this.btnGuestUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuestUpdate.FlatAppearance.BorderSize = 0;
            this.btnGuestUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuestUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuestUpdate.Location = new System.Drawing.Point(341, 0);
            this.btnGuestUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.btnGuestUpdate.Name = "btnGuestUpdate";
            this.btnGuestUpdate.Size = new System.Drawing.Size(135, 81);
            this.btnGuestUpdate.TabIndex = 3;
            this.btnGuestUpdate.Text = "Update";
            this.btnGuestUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuestUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuestUpdate.UseVisualStyleBackColor = true;
            this.btnGuestUpdate.Click += new System.EventHandler(this.btnGuestUpdate_Click);
            this.btnGuestUpdate.MouseEnter += new System.EventHandler(this.btnGuestUpdate_MouseEnter);
            this.btnGuestUpdate.MouseLeave += new System.EventHandler(this.btnGuestUpdate_MouseLeave);
            // 
            // btnRoomAdd
            // 
            this.btnRoomAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRoomAdd.BackgroundImage")));
            this.btnRoomAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRoomAdd.FlatAppearance.BorderSize = 0;
            this.btnRoomAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomAdd.Location = new System.Drawing.Point(213, 0);
            this.btnRoomAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnRoomAdd.Name = "btnRoomAdd";
            this.btnRoomAdd.Size = new System.Drawing.Size(135, 81);
            this.btnRoomAdd.TabIndex = 2;
            this.btnRoomAdd.Text = "Add";
            this.btnRoomAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRoomAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRoomAdd.UseVisualStyleBackColor = true;
            this.btnRoomAdd.Click += new System.EventHandler(this.btnRoomAdd_Click);
            this.btnRoomAdd.MouseEnter += new System.EventHandler(this.btnRoomAdd_MouseEnter);
            this.btnRoomAdd.MouseLeave += new System.EventHandler(this.btnRoomAdd_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(389, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Manage Rooms";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblClose);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 100);
            this.panel1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(548, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Status";
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnGuestClean);
            this.pnlButton.Controls.Add(this.btnGuestDelete);
            this.pnlButton.Controls.Add(this.btnGuestUpdate);
            this.pnlButton.Controls.Add(this.btnRoomAdd);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButton.Location = new System.Drawing.Point(0, 555);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(954, 100);
            this.pnlButton.TabIndex = 12;
            // 
            // txtRoomPhone
            // 
            this.txtRoomPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRoomPhone.Location = new System.Drawing.Point(635, 502);
            this.txtRoomPhone.Name = "txtRoomPhone";
            this.txtRoomPhone.Size = new System.Drawing.Size(172, 22);
            this.txtRoomPhone.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 500);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Room Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(510, 501);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Phone No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Room Id";
            // 
            // txtRoomId
            // 
            this.txtRoomId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRoomId.Location = new System.Drawing.Point(283, 453);
            this.txtRoomId.Name = "txtRoomId";
            this.txtRoomId.Size = new System.Drawing.Size(170, 22);
            this.txtRoomId.TabIndex = 15;
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Location = new System.Drawing.Point(283, 500);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(170, 24);
            this.cmbRoomType.TabIndex = 1;
            // 
            // radioFree
            // 
            this.radioFree.AutoSize = true;
            this.radioFree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFree.Location = new System.Drawing.Point(635, 454);
            this.radioFree.Name = "radioFree";
            this.radioFree.Size = new System.Drawing.Size(63, 22);
            this.radioFree.TabIndex = 1;
            this.radioFree.TabStop = true;
            this.radioFree.Text = "Free";
            this.radioFree.UseVisualStyleBackColor = true;
            // 
            // radioBusy
            // 
            this.radioBusy.AutoSize = true;
            this.radioBusy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBusy.Location = new System.Drawing.Point(741, 454);
            this.radioBusy.Name = "radioBusy";
            this.radioBusy.Size = new System.Drawing.Size(66, 22);
            this.radioBusy.TabIndex = 25;
            this.radioBusy.TabStop = true;
            this.radioBusy.Text = "Busy";
            this.radioBusy.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(283, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(954, 655);
            this.Controls.Add(this.radioBusy);
            this.Controls.Add(this.radioFree);
            this.Controls.Add(this.cmbRoomType);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.txtRoomPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRoomId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoomForm";
            this.Load += new System.EventHandler(this.RoomForm_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageRooms)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewManageRooms;
        private System.Windows.Forms.Button btnGuestClean;
        private System.Windows.Forms.Button btnGuestDelete;
        private System.Windows.Forms.Button btnGuestUpdate;
        private System.Windows.Forms.Button btnRoomAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.TextBox txtRoomPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRoomId;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.RadioButton radioFree;
        private System.Windows.Forms.RadioButton radioBusy;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}