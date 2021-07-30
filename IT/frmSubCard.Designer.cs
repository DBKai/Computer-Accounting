namespace IT
{
    partial class frmSubCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubCard));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbEquip = new System.Windows.Forms.ComboBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.nudCost = new System.Windows.Forms.NumericUpDown();
            this.dtpDT_Delivery = new System.Windows.Forms.DateTimePicker();
            this.dtpDT_Writeoff = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txbInv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCost)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Инв";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Матер. ценность";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Стоимость";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Дата установки";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Дата списания";
            // 
            // cmbEquip
            // 
            this.cmbEquip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEquip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbEquip.FormattingEnabled = true;
            this.cmbEquip.Location = new System.Drawing.Point(106, 44);
            this.cmbEquip.Name = "cmbEquip";
            this.cmbEquip.Size = new System.Drawing.Size(376, 28);
            this.cmbEquip.TabIndex = 2;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(378, 223);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(104, 33);
            this.btnApply.TabIndex = 7;
            this.btnApply.Text = "ПРИМЕНИТЬ";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // nudCost
            // 
            this.nudCost.DecimalPlaces = 2;
            this.nudCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudCost.Location = new System.Drawing.Point(106, 78);
            this.nudCost.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudCost.Name = "nudCost";
            this.nudCost.Size = new System.Drawing.Size(135, 26);
            this.nudCost.TabIndex = 4;
            this.nudCost.ThousandsSeparator = true;
            // 
            // dtpDT_Delivery
            // 
            this.dtpDT_Delivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpDT_Delivery.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDT_Delivery.Location = new System.Drawing.Point(106, 110);
            this.dtpDT_Delivery.Name = "dtpDT_Delivery";
            this.dtpDT_Delivery.ShowCheckBox = true;
            this.dtpDT_Delivery.Size = new System.Drawing.Size(135, 26);
            this.dtpDT_Delivery.TabIndex = 5;
            // 
            // dtpDT_Writeoff
            // 
            this.dtpDT_Writeoff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpDT_Writeoff.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDT_Writeoff.Location = new System.Drawing.Point(106, 142);
            this.dtpDT_Writeoff.Name = "dtpDT_Writeoff";
            this.dtpDT_Writeoff.ShowCheckBox = true;
            this.dtpDT_Writeoff.Size = new System.Drawing.Size(135, 26);
            this.dtpDT_Writeoff.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 223);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 33);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "ОТМЕНИТЬ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txbInv
            // 
            this.txbInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbInv.Location = new System.Drawing.Point(106, 12);
            this.txbInv.MaxLength = 7;
            this.txbInv.Name = "txbInv";
            this.txbInv.Size = new System.Drawing.Size(135, 26);
            this.txbInv.TabIndex = 0;
            // 
            // frmSubCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 268);
            this.Controls.Add(this.txbInv);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dtpDT_Writeoff);
            this.Controls.Add(this.dtpDT_Delivery);
            this.Controls.Add(this.nudCost);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.cmbEquip);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSubCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSubCard";
            this.Load += new System.EventHandler(this.frmSubCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbEquip;
        public System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.NumericUpDown nudCost;
        private System.Windows.Forms.DateTimePicker dtpDT_Delivery;
        private System.Windows.Forms.DateTimePicker dtpDT_Writeoff;
        public System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txbInv;
    }
}