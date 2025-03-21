namespace week7
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
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstShoes = new System.Windows.Forms.ListBox();
            this.chkSize36 = new System.Windows.Forms.CheckBox();
            this.chkSize37 = new System.Windows.Forms.CheckBox();
            this.chkSize38 = new System.Windows.Forms.CheckBox();
            this.chkSize41 = new System.Windows.Forms.CheckBox();
            this.chkSize40 = new System.Windows.Forms.CheckBox();
            this.chkSize39 = new System.Windows.Forms.CheckBox();
            this.chkSize43 = new System.Windows.Forms.CheckBox();
            this.chkSize44 = new System.Windows.Forms.CheckBox();
            this.lstCity = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstDistrict = new System.Windows.Forms.ListBox();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lstOrders = new System.Windows.Forms.ListBox();
            this.chkSize42 = new System.Windows.Forms.CheckBox();
            this.chkSize45 = new System.Windows.Forms.CheckBox();
            this.mtxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFullName.Location = new System.Drawing.Point(103, 76);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(219, 33);
            this.txtFullName.TabIndex = 0;
            this.txtFullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFullName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(98, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Müşteri Ad-Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(98, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Müşteri Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(98, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ayakkabı Marka/Model";
            // 
            // lstShoes
            // 
            this.lstShoes.FormattingEnabled = true;
            this.lstShoes.ItemHeight = 16;
            this.lstShoes.Location = new System.Drawing.Point(103, 283);
            this.lstShoes.Name = "lstShoes";
            this.lstShoes.Size = new System.Drawing.Size(219, 228);
            this.lstShoes.TabIndex = 5;
            // 
            // chkSize36
            // 
            this.chkSize36.AutoSize = true;
            this.chkSize36.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkSize36.Location = new System.Drawing.Point(79, 533);
            this.chkSize36.Name = "chkSize36";
            this.chkSize36.Size = new System.Drawing.Size(49, 24);
            this.chkSize36.TabIndex = 6;
            this.chkSize36.Text = "36";
            this.chkSize36.UseVisualStyleBackColor = true;
            // 
            // chkSize37
            // 
            this.chkSize37.AutoSize = true;
            this.chkSize37.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkSize37.Location = new System.Drawing.Point(138, 533);
            this.chkSize37.Name = "chkSize37";
            this.chkSize37.Size = new System.Drawing.Size(49, 24);
            this.chkSize37.TabIndex = 7;
            this.chkSize37.Text = "37";
            this.chkSize37.UseVisualStyleBackColor = true;
            // 
            // chkSize38
            // 
            this.chkSize38.AutoSize = true;
            this.chkSize38.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkSize38.Location = new System.Drawing.Point(194, 533);
            this.chkSize38.Name = "chkSize38";
            this.chkSize38.Size = new System.Drawing.Size(49, 24);
            this.chkSize38.TabIndex = 8;
            this.chkSize38.Text = "38";
            this.chkSize38.UseVisualStyleBackColor = true;
            // 
            // chkSize41
            // 
            this.chkSize41.AutoSize = true;
            this.chkSize41.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkSize41.Location = new System.Drawing.Point(79, 563);
            this.chkSize41.Name = "chkSize41";
            this.chkSize41.Size = new System.Drawing.Size(49, 24);
            this.chkSize41.TabIndex = 11;
            this.chkSize41.Text = "41";
            this.chkSize41.UseVisualStyleBackColor = true;
            // 
            // chkSize40
            // 
            this.chkSize40.AutoSize = true;
            this.chkSize40.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkSize40.Location = new System.Drawing.Point(309, 533);
            this.chkSize40.Name = "chkSize40";
            this.chkSize40.Size = new System.Drawing.Size(49, 24);
            this.chkSize40.TabIndex = 10;
            this.chkSize40.Text = "40";
            this.chkSize40.UseVisualStyleBackColor = true;
            // 
            // chkSize39
            // 
            this.chkSize39.AutoSize = true;
            this.chkSize39.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkSize39.Location = new System.Drawing.Point(254, 533);
            this.chkSize39.Name = "chkSize39";
            this.chkSize39.Size = new System.Drawing.Size(49, 24);
            this.chkSize39.TabIndex = 9;
            this.chkSize39.Text = "39";
            this.chkSize39.UseVisualStyleBackColor = true;
            // 
            // chkSize43
            // 
            this.chkSize43.AutoSize = true;
            this.chkSize43.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkSize43.Location = new System.Drawing.Point(194, 563);
            this.chkSize43.Name = "chkSize43";
            this.chkSize43.Size = new System.Drawing.Size(49, 24);
            this.chkSize43.TabIndex = 13;
            this.chkSize43.Text = "43";
            this.chkSize43.UseVisualStyleBackColor = true;
            // 
            // chkSize44
            // 
            this.chkSize44.AutoSize = true;
            this.chkSize44.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkSize44.Location = new System.Drawing.Point(254, 563);
            this.chkSize44.Name = "chkSize44";
            this.chkSize44.Size = new System.Drawing.Size(49, 24);
            this.chkSize44.TabIndex = 12;
            this.chkSize44.Text = "44";
            this.chkSize44.UseVisualStyleBackColor = true;
            // 
            // lstCity
            // 
            this.lstCity.FormattingEnabled = true;
            this.lstCity.ItemHeight = 16;
            this.lstCity.Location = new System.Drawing.Point(420, 76);
            this.lstCity.Name = "lstCity";
            this.lstCity.Size = new System.Drawing.Size(219, 180);
            this.lstCity.TabIndex = 14;
            this.lstCity.SelectedIndexChanged += new System.EventHandler(this.lstCity_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(486, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Adres İl";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(729, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Adres İlçe";
            // 
            // lstDistrict
            // 
            this.lstDistrict.FormattingEnabled = true;
            this.lstDistrict.ItemHeight = 16;
            this.lstDistrict.Location = new System.Drawing.Point(678, 76);
            this.lstDistrict.Name = "lstDistrict";
            this.lstDistrict.Size = new System.Drawing.Size(219, 180);
            this.lstDistrict.TabIndex = 16;
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCreateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateOrder.Location = new System.Drawing.Point(103, 622);
            this.btnCreateOrder.Margin = new System.Windows.Forms.Padding(0);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(208, 56);
            this.btnCreateOrder.TabIndex = 18;
            this.btnCreateOrder.Text = "SİPARİŞ OLUŞTUR";
            this.btnCreateOrder.UseVisualStyleBackColor = false;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(596, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Siparişlerim";
            // 
            // lstOrders
            // 
            this.lstOrders.FormattingEnabled = true;
            this.lstOrders.ItemHeight = 16;
            this.lstOrders.Location = new System.Drawing.Point(513, 356);
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(301, 212);
            this.lstOrders.TabIndex = 19;
            // 
            // chkSize42
            // 
            this.chkSize42.AutoSize = true;
            this.chkSize42.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkSize42.Location = new System.Drawing.Point(138, 563);
            this.chkSize42.Name = "chkSize42";
            this.chkSize42.Size = new System.Drawing.Size(49, 24);
            this.chkSize42.TabIndex = 22;
            this.chkSize42.Text = "42";
            this.chkSize42.UseVisualStyleBackColor = true;
            // 
            // chkSize45
            // 
            this.chkSize45.AutoSize = true;
            this.chkSize45.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkSize45.Location = new System.Drawing.Point(309, 563);
            this.chkSize45.Name = "chkSize45";
            this.chkSize45.Size = new System.Drawing.Size(49, 24);
            this.chkSize45.TabIndex = 21;
            this.chkSize45.Text = "45";
            this.chkSize45.UseVisualStyleBackColor = true;
            // 
            // mtxtPhone
            // 
            this.mtxtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtxtPhone.Location = new System.Drawing.Point(103, 185);
            this.mtxtPhone.Name = "mtxtPhone";
            this.mtxtPhone.Size = new System.Drawing.Size(219, 33);
            this.mtxtPhone.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1101, 749);
            this.Controls.Add(this.mtxtPhone);
            this.Controls.Add(this.chkSize42);
            this.Controls.Add(this.chkSize45);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstOrders);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstDistrict);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstCity);
            this.Controls.Add(this.chkSize43);
            this.Controls.Add(this.chkSize44);
            this.Controls.Add(this.chkSize41);
            this.Controls.Add(this.chkSize40);
            this.Controls.Add(this.chkSize39);
            this.Controls.Add(this.chkSize38);
            this.Controls.Add(this.chkSize37);
            this.Controls.Add(this.chkSize36);
            this.Controls.Add(this.lstShoes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFullName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstShoes;
        private System.Windows.Forms.CheckBox chkSize36;
        private System.Windows.Forms.CheckBox chkSize37;
        private System.Windows.Forms.CheckBox chkSize38;
        private System.Windows.Forms.CheckBox chkSize41;
        private System.Windows.Forms.CheckBox chkSize40;
        private System.Windows.Forms.CheckBox chkSize39;
        private System.Windows.Forms.CheckBox chkSize43;
        private System.Windows.Forms.CheckBox chkSize44;
        private System.Windows.Forms.ListBox lstCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstDistrict;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstOrders;
        private System.Windows.Forms.CheckBox chkSize42;
        private System.Windows.Forms.CheckBox chkSize45;
        private System.Windows.Forms.MaskedTextBox mtxtPhone;
    }
}

