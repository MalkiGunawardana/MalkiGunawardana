namespace Hotel_Management_System
{
    partial class ReservationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationForm));
            this.cmbResevRoomType = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewReserv = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblClose = new System.Windows.Forms.Label();
            this.btnGuestClean = new System.Windows.Forms.Button();
            this.btnGuestDelete = new System.Windows.Forms.Button();
            this.btnGuestUpdate = new System.Windows.Forms.Button();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnResevAdd = new System.Windows.Forms.Button();
            this.txtResevGuestId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResevId = new System.Windows.Forms.TextBox();
            this.cmbResevRoomNo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerIn = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerOut = new System.Windows.Forms.DateTimePicker();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReserv)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbResevRoomType
            // 
            this.cmbResevRoomType.FormattingEnabled = true;
            this.cmbResevRoomType.Location = new System.Drawing.Point(257, 513);
            this.cmbResevRoomType.Name = "cmbResevRoomType";
            this.cmbResevRoomType.Size = new System.Drawing.Size(204, 24);
            this.cmbResevRoomType.TabIndex = 27;
            this.cmbResevRoomType.SelectedIndexChanged += new System.EventHandler(this.cmbResevRoomType_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewReserv);
            this.panel2.Location = new System.Drawing.Point(0, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(954, 307);
            this.panel2.TabIndex = 36;
            // 
            // dataGridViewReserv
            // 
            this.dataGridViewReserv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReserv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewReserv.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewReserv.ColumnHeadersHeight = 28;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewReserv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewReserv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewReserv.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewReserv.Name = "dataGridViewReserv";
            this.dataGridViewReserv.RowTemplate.Height = 24;
            this.dataGridViewReserv.Size = new System.Drawing.Size(954, 307);
            this.dataGridViewReserv.TabIndex = 0;
            this.dataGridViewReserv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReserv_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 100);
            this.panel1.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(359, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(264, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Manage Reservation";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(269, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            // btnGuestClean
            // 
            this.btnGuestClean.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuestClean.BackgroundImage")));
            this.btnGuestClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuestClean.FlatAppearance.BorderSize = 0;
            this.btnGuestClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuestClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuestClean.ForeColor = System.Drawing.Color.Black;
            this.btnGuestClean.Location = new System.Drawing.Point(596, 0);
            this.btnGuestClean.Margin = new System.Windows.Forms.Padding(0);
            this.btnGuestClean.Name = "btnGuestClean";
            this.btnGuestClean.Size = new System.Drawing.Size(139, 81);
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
            this.btnGuestDelete.ForeColor = System.Drawing.Color.Black;
            this.btnGuestDelete.Location = new System.Drawing.Point(475, 0);
            this.btnGuestDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnGuestDelete.Name = "btnGuestDelete";
            this.btnGuestDelete.Size = new System.Drawing.Size(139, 81);
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
            this.btnGuestUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnGuestUpdate.Location = new System.Drawing.Point(347, 0);
            this.btnGuestUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.btnGuestUpdate.Name = "btnGuestUpdate";
            this.btnGuestUpdate.Size = new System.Drawing.Size(139, 81);
            this.btnGuestUpdate.TabIndex = 3;
            this.btnGuestUpdate.Text = "Update";
            this.btnGuestUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuestUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuestUpdate.UseVisualStyleBackColor = true;
            this.btnGuestUpdate.Click += new System.EventHandler(this.btnGuestUpdate_Click);
            this.btnGuestUpdate.MouseEnter += new System.EventHandler(this.btnGuestUpdate_MouseEnter);
            this.btnGuestUpdate.MouseLeave += new System.EventHandler(this.btnGuestUpdate_MouseLeave);
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnGuestClean);
            this.pnlButton.Controls.Add(this.btnGuestDelete);
            this.pnlButton.Controls.Add(this.btnGuestUpdate);
            this.pnlButton.Controls.Add(this.btnResevAdd);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButton.Location = new System.Drawing.Point(0, 555);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(954, 100);
            this.pnlButton.TabIndex = 28;
            // 
            // btnResevAdd
            // 
            this.btnResevAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnResevAdd.BackgroundImage")));
            this.btnResevAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnResevAdd.FlatAppearance.BorderSize = 0;
            this.btnResevAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResevAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResevAdd.ForeColor = System.Drawing.Color.Black;
            this.btnResevAdd.Location = new System.Drawing.Point(225, 0);
            this.btnResevAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnResevAdd.Name = "btnResevAdd";
            this.btnResevAdd.Size = new System.Drawing.Size(139, 81);
            this.btnResevAdd.TabIndex = 2;
            this.btnResevAdd.Text = "Add";
            this.btnResevAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnResevAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnResevAdd.UseVisualStyleBackColor = true;
            this.btnResevAdd.Click += new System.EventHandler(this.btnResevAdd_Click);
            this.btnResevAdd.MouseEnter += new System.EventHandler(this.btnResevAdd_MouseEnter);
            this.btnResevAdd.MouseLeave += new System.EventHandler(this.btnResevAdd_MouseLeave);
            // 
            // txtResevGuestId
            // 
            this.txtResevGuestId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResevGuestId.Location = new System.Drawing.Point(257, 475);
            this.txtResevGuestId.Name = "txtResevGuestId";
            this.txtResevGuestId.Size = new System.Drawing.Size(204, 22);
            this.txtResevGuestId.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "Guest Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 513);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 33;
            this.label3.Text = "Room Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "Reserve Id";
            // 
            // txtResevId
            // 
            this.txtResevId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResevId.Location = new System.Drawing.Point(257, 437);
            this.txtResevId.Name = "txtResevId";
            this.txtResevId.Size = new System.Drawing.Size(204, 22);
            this.txtResevId.TabIndex = 31;
            // 
            // cmbResevRoomNo
            // 
            this.cmbResevRoomNo.FormattingEnabled = true;
            this.cmbResevRoomNo.Location = new System.Drawing.Point(619, 435);
            this.cmbResevRoomNo.Name = "cmbResevRoomNo";
            this.cmbResevRoomNo.Size = new System.Drawing.Size(204, 24);
            this.cmbResevRoomNo.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(506, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 24);
            this.label4.TabIndex = 38;
            this.label4.Text = "Room No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(529, 472);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 39;
            this.label5.Text = "Date In";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(514, 509);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 24);
            this.label7.TabIndex = 40;
            this.label7.Text = "Date Out";
            // 
            // dateTimePickerIn
            // 
            this.dateTimePickerIn.CustomFormat = "dd/mm/yyyy";
            this.dateTimePickerIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerIn.Location = new System.Drawing.Point(619, 474);
            this.dateTimePickerIn.Name = "dateTimePickerIn";
            this.dateTimePickerIn.Size = new System.Drawing.Size(204, 22);
            this.dateTimePickerIn.TabIndex = 1;
            // 
            // dateTimePickerOut
            // 
            this.dateTimePickerOut.CustomFormat = "dd/mm/yyyy";
            this.dateTimePickerOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerOut.Location = new System.Drawing.Point(619, 511);
            this.dateTimePickerOut.Name = "dateTimePickerOut";
            this.dateTimePickerOut.Size = new System.Drawing.Size(204, 22);
            this.dateTimePickerOut.TabIndex = 41;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(954, 655);
            this.Controls.Add(this.dateTimePickerOut);
            this.Controls.Add(this.dateTimePickerIn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbResevRoomNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbResevRoomType);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.txtResevGuestId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResevId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReservationForm";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReserv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbResevRoomType;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewReserv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGuestClean;
        private System.Windows.Forms.Button btnGuestDelete;
        private System.Windows.Forms.Button btnGuestUpdate;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnResevAdd;
        private System.Windows.Forms.TextBox txtResevGuestId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResevId;
        private System.Windows.Forms.ComboBox cmbResevRoomNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerIn;
        private System.Windows.Forms.DateTimePicker dateTimePickerOut;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}