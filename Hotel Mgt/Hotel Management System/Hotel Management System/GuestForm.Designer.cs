namespace Hotel_Management_System
{
    partial class GuestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnGuestClean = new System.Windows.Forms.Button();
            this.btnGuestDelete = new System.Windows.Forms.Button();
            this.btnGuestUpdate = new System.Windows.Forms.Button();
            this.btnGuestSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGuestId = new System.Windows.Forms.TextBox();
            this.txtGuestFName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGuestLName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGuestPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGuestCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblClose = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewManageGuest = new System.Windows.Forms.DataGridView();
            this.pnlButton.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageGuest)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlButton.Controls.Add(this.btnGuestClean);
            this.pnlButton.Controls.Add(this.btnGuestDelete);
            this.pnlButton.Controls.Add(this.btnGuestUpdate);
            this.pnlButton.Controls.Add(this.btnGuestSave);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButton.Location = new System.Drawing.Point(0, 538);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(954, 117);
            this.pnlButton.TabIndex = 0;
            // 
            // btnGuestClean
            // 
            this.btnGuestClean.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuestClean.BackgroundImage")));
            this.btnGuestClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuestClean.FlatAppearance.BorderSize = 0;
            this.btnGuestClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuestClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuestClean.Location = new System.Drawing.Point(601, 17);
            this.btnGuestClean.Margin = new System.Windows.Forms.Padding(0);
            this.btnGuestClean.Name = "btnGuestClean";
            this.btnGuestClean.Size = new System.Drawing.Size(134, 77);
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
            this.btnGuestDelete.Location = new System.Drawing.Point(480, 17);
            this.btnGuestDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnGuestDelete.Name = "btnGuestDelete";
            this.btnGuestDelete.Size = new System.Drawing.Size(134, 77);
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
            this.btnGuestUpdate.Location = new System.Drawing.Point(352, 17);
            this.btnGuestUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.btnGuestUpdate.Name = "btnGuestUpdate";
            this.btnGuestUpdate.Size = new System.Drawing.Size(134, 77);
            this.btnGuestUpdate.TabIndex = 3;
            this.btnGuestUpdate.Text = "Update";
            this.btnGuestUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuestUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuestUpdate.UseVisualStyleBackColor = true;
            this.btnGuestUpdate.Click += new System.EventHandler(this.btnGuestUpdate_Click);
            this.btnGuestUpdate.MouseEnter += new System.EventHandler(this.btnGuestUpdate_MouseEnter);
            this.btnGuestUpdate.MouseLeave += new System.EventHandler(this.btnGuestUpdate_MouseLeave);
            // 
            // btnGuestSave
            // 
            this.btnGuestSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuestSave.BackgroundImage")));
            this.btnGuestSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuestSave.FlatAppearance.BorderSize = 0;
            this.btnGuestSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuestSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuestSave.ForeColor = System.Drawing.Color.Black;
            this.btnGuestSave.Location = new System.Drawing.Point(230, 17);
            this.btnGuestSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnGuestSave.Name = "btnGuestSave";
            this.btnGuestSave.Size = new System.Drawing.Size(134, 77);
            this.btnGuestSave.TabIndex = 2;
            this.btnGuestSave.Text = "Save";
            this.btnGuestSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuestSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnGuestSave.UseVisualStyleBackColor = true;
            this.btnGuestSave.Click += new System.EventHandler(this.btnGuestSave_Click);
            this.btnGuestSave.MouseEnter += new System.EventHandler(this.btnGuestSave_MouseEnter);
            this.btnGuestSave.MouseLeave += new System.EventHandler(this.btnGuestSave_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(235, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id No";
            // 
            // txtGuestId
            // 
            this.txtGuestId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGuestId.Location = new System.Drawing.Point(317, 437);
            this.txtGuestId.Name = "txtGuestId";
            this.txtGuestId.Size = new System.Drawing.Size(154, 22);
            this.txtGuestId.TabIndex = 2;
            // 
            // txtGuestFName
            // 
            this.txtGuestFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGuestFName.Location = new System.Drawing.Point(317, 473);
            this.txtGuestFName.Name = "txtGuestFName";
            this.txtGuestFName.Size = new System.Drawing.Size(154, 22);
            this.txtGuestFName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(192, 471);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "First name";
            // 
            // txtGuestLName
            // 
            this.txtGuestLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGuestLName.Location = new System.Drawing.Point(317, 511);
            this.txtGuestLName.Name = "txtGuestLName";
            this.txtGuestLName.Size = new System.Drawing.Size(154, 22);
            this.txtGuestLName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(191, 509);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Name";
            // 
            // txtGuestPhone
            // 
            this.txtGuestPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGuestPhone.Location = new System.Drawing.Point(613, 437);
            this.txtGuestPhone.Name = "txtGuestPhone";
            this.txtGuestPhone.Size = new System.Drawing.Size(154, 22);
            this.txtGuestPhone.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(523, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phone";
            // 
            // txtGuestCity
            // 
            this.txtGuestCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGuestCity.Location = new System.Drawing.Point(613, 478);
            this.txtGuestCity.Name = "txtGuestCity";
            this.txtGuestCity.Size = new System.Drawing.Size(154, 22);
            this.txtGuestCity.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(549, 478);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "City";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblClose);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 100);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(239, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 84);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(372, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Manage Guests";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewManageGuest);
            this.panel2.Location = new System.Drawing.Point(0, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(954, 307);
            this.panel2.TabIndex = 11;
            // 
            // dataGridViewManageGuest
            // 
            this.dataGridViewManageGuest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewManageGuest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewManageGuest.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewManageGuest.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewManageGuest.ColumnHeadersHeight = 28;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewManageGuest.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewManageGuest.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewManageGuest.Name = "dataGridViewManageGuest";
            this.dataGridViewManageGuest.RowTemplate.Height = 24;
            this.dataGridViewManageGuest.Size = new System.Drawing.Size(954, 307);
            this.dataGridViewManageGuest.TabIndex = 0;
            this.dataGridViewManageGuest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewManageGuest_CellClick);
            this.dataGridViewManageGuest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewManageGuest_CellContentClick);
            // 
            // GuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(954, 655);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtGuestCity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtGuestPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.txtGuestLName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGuestFName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGuestId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuestForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GuestForm_Load);
            this.pnlButton.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageGuest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.TextBox txtGuestCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGuestPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGuestLName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGuestId;
        private System.Windows.Forms.TextBox txtGuestFName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGuestClean;
        private System.Windows.Forms.Button btnGuestDelete;
        private System.Windows.Forms.Button btnGuestUpdate;
        private System.Windows.Forms.Button btnGuestSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewManageGuest;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblClose;
    }
}