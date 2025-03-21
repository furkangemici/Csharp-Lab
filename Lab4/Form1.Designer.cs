namespace week6
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblClock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.cmbTimeZones = new System.Windows.Forms.ComboBox();
            this.clbTimeZones = new System.Windows.Forms.CheckedListBox();
            this.txtTimeZoneName = new System.Windows.Forms.TextBox();
            this.nudTimeDiff = new System.Windows.Forms.NumericUpDown();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.btnSetColor = new System.Windows.Forms.Button();
            this.btnAddTimeZone = new System.Windows.Forms.Button();
            this.btnUpdateTimeZone = new System.Windows.Forms.Button();
            this.btnDeleteTimeZone = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.lblDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeDiff)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblClock.Location = new System.Drawing.Point(791, 367);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(64, 25);
            this.lblClock.TabIndex = 0;
            this.lblClock.Text = "label1";
            // 
            // cmbTimeZones
            // 
            this.cmbTimeZones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbTimeZones.FormattingEnabled = true;
            this.cmbTimeZones.Location = new System.Drawing.Point(447, 281);
            this.cmbTimeZones.Name = "cmbTimeZones";
            this.cmbTimeZones.Size = new System.Drawing.Size(177, 33);
            this.cmbTimeZones.TabIndex = 1;
            this.cmbTimeZones.SelectedIndexChanged += new System.EventHandler(this.cmbTimeZones_SelectedIndexChanged_1);
            // 
            // clbTimeZones
            // 
            this.clbTimeZones.FormattingEnabled = true;
            this.clbTimeZones.Location = new System.Drawing.Point(159, 218);
            this.clbTimeZones.Name = "clbTimeZones";
            this.clbTimeZones.Size = new System.Drawing.Size(177, 174);
            this.clbTimeZones.TabIndex = 2;
            // 
            // txtTimeZoneName
            // 
            this.txtTimeZoneName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTimeZoneName.Location = new System.Drawing.Point(70, 93);
            this.txtTimeZoneName.Name = "txtTimeZoneName";
            this.txtTimeZoneName.Size = new System.Drawing.Size(139, 30);
            this.txtTimeZoneName.TabIndex = 3;
            // 
            // nudTimeDiff
            // 
            this.nudTimeDiff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudTimeDiff.Location = new System.Drawing.Point(270, 93);
            this.nudTimeDiff.Name = "nudTimeDiff";
            this.nudTimeDiff.Size = new System.Drawing.Size(139, 30);
            this.nudTimeDiff.TabIndex = 4;
            // 
            // dtpTime
            // 
            this.dtpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTime.Location = new System.Drawing.Point(714, 145);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(214, 30);
            this.dtpTime.TabIndex = 5;
            // 
            // btnSetColor
            // 
            this.btnSetColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSetColor.Location = new System.Drawing.Point(171, 423);
            this.btnSetColor.Name = "btnSetColor";
            this.btnSetColor.Size = new System.Drawing.Size(150, 36);
            this.btnSetColor.TabIndex = 6;
            this.btnSetColor.Text = "Set Color";
            this.btnSetColor.UseVisualStyleBackColor = true;
            this.btnSetColor.Click += new System.EventHandler(this.btnSetColor_Click);
            // 
            // btnAddTimeZone
            // 
            this.btnAddTimeZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddTimeZone.Location = new System.Drawing.Point(464, 90);
            this.btnAddTimeZone.Name = "btnAddTimeZone";
            this.btnAddTimeZone.Size = new System.Drawing.Size(160, 36);
            this.btnAddTimeZone.TabIndex = 7;
            this.btnAddTimeZone.Text = "Add Time Zone";
            this.btnAddTimeZone.UseVisualStyleBackColor = true;
            this.btnAddTimeZone.Click += new System.EventHandler(this.btnAddTimeZone_Click);
            // 
            // btnUpdateTimeZone
            // 
            this.btnUpdateTimeZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateTimeZone.Location = new System.Drawing.Point(24, 476);
            this.btnUpdateTimeZone.Name = "btnUpdateTimeZone";
            this.btnUpdateTimeZone.Size = new System.Drawing.Size(185, 36);
            this.btnUpdateTimeZone.TabIndex = 8;
            this.btnUpdateTimeZone.Text = "Update Time Zone";
            this.btnUpdateTimeZone.UseVisualStyleBackColor = true;
            this.btnUpdateTimeZone.Click += new System.EventHandler(this.btnUpdateTimeZone_Click);
            // 
            // btnDeleteTimeZone
            // 
            this.btnDeleteTimeZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteTimeZone.Location = new System.Drawing.Point(254, 476);
            this.btnDeleteTimeZone.Name = "btnDeleteTimeZone";
            this.btnDeleteTimeZone.Size = new System.Drawing.Size(184, 36);
            this.btnDeleteTimeZone.TabIndex = 9;
            this.btnDeleteTimeZone.Text = "Delete Time Zone";
            this.btnDeleteTimeZone.UseVisualStyleBackColor = true;
            this.btnDeleteTimeZone.Click += new System.EventHandler(this.btnDeleteTimeZone_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(177, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Added Cities";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(465, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Select City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(691, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Current Time for Selected City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(781, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Set Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(314, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "UTC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(90, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Write City";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDate.Location = new System.Drawing.Point(738, 268);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(64, 25);
            this.lblDate.TabIndex = 17;
            this.lblDate.Text = "label7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1013, 599);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeleteTimeZone);
            this.Controls.Add(this.btnUpdateTimeZone);
            this.Controls.Add(this.btnAddTimeZone);
            this.Controls.Add(this.btnSetColor);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.nudTimeDiff);
            this.Controls.Add(this.txtTimeZoneName);
            this.Controls.Add(this.clbTimeZones);
            this.Controls.Add(this.cmbTimeZones);
            this.Controls.Add(this.lblClock);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeDiff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox cmbTimeZones;
        private System.Windows.Forms.CheckedListBox clbTimeZones;
        private System.Windows.Forms.TextBox txtTimeZoneName;
        private System.Windows.Forms.NumericUpDown nudTimeDiff;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Button btnSetColor;
        private System.Windows.Forms.Button btnAddTimeZone;
        private System.Windows.Forms.Button btnUpdateTimeZone;
        private System.Windows.Forms.Button btnDeleteTimeZone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Label lblDate;
    }
}

