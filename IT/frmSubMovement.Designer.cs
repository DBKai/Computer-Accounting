namespace IT
{
    partial class frmSubMovement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubMovement));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbForMove = new System.Windows.Forms.ComboBox();
            this.dtpDateMove = new System.Windows.Forms.DateTimePicker();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAccountable = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEvent = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbFromMove = new System.Windows.Forms.ComboBox();
            this.chbForMove = new System.Windows.Forms.CheckBox();
            this.chbAccountable = new System.Windows.Forms.CheckBox();
            this.chbFromMove = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата";
            // 
            // cmbForMove
            // 
            this.cmbForMove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbForMove.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbForMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbForMove.FormattingEnabled = true;
            this.cmbForMove.Location = new System.Drawing.Point(113, 53);
            this.cmbForMove.Name = "cmbForMove";
            this.cmbForMove.Size = new System.Drawing.Size(345, 28);
            this.cmbForMove.TabIndex = 1;
            // 
            // dtpDateMove
            // 
            this.dtpDateMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpDateMove.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateMove.Location = new System.Drawing.Point(113, 21);
            this.dtpDateMove.Name = "dtpDateMove";
            this.dtpDateMove.Size = new System.Drawing.Size(135, 26);
            this.dtpDateMove.TabIndex = 0;
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Location = new System.Drawing.Point(378, 223);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(104, 33);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "ПРИМЕНИТЬ";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 223);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 33);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "ОТМЕНИТЬ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Куда";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ответственный";
            // 
            // cmbAccountable
            // 
            this.cmbAccountable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAccountable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccountable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbAccountable.FormattingEnabled = true;
            this.cmbAccountable.Location = new System.Drawing.Point(113, 87);
            this.cmbAccountable.Name = "cmbAccountable";
            this.cmbAccountable.Size = new System.Drawing.Size(345, 28);
            this.cmbAccountable.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Событие";
            // 
            // cmbEvent
            // 
            this.cmbEvent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbEvent.FormattingEnabled = true;
            this.cmbEvent.Location = new System.Drawing.Point(113, 155);
            this.cmbEvent.Name = "cmbEvent";
            this.cmbEvent.Size = new System.Drawing.Size(345, 28);
            this.cmbEvent.TabIndex = 4;
            this.cmbEvent.TextChanged += new System.EventHandler(this.cmbEvent_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Откуда";
            // 
            // cmbFromMove
            // 
            this.cmbFromMove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFromMove.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFromMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbFromMove.FormattingEnabled = true;
            this.cmbFromMove.Location = new System.Drawing.Point(113, 121);
            this.cmbFromMove.Name = "cmbFromMove";
            this.cmbFromMove.Size = new System.Drawing.Size(345, 28);
            this.cmbFromMove.TabIndex = 3;
            // 
            // chbForMove
            // 
            this.chbForMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbForMove.AutoSize = true;
            this.chbForMove.Checked = true;
            this.chbForMove.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbForMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbForMove.Location = new System.Drawing.Point(467, 60);
            this.chbForMove.Name = "chbForMove";
            this.chbForMove.Size = new System.Drawing.Size(15, 14);
            this.chbForMove.TabIndex = 13;
            this.chbForMove.UseVisualStyleBackColor = true;
            this.chbForMove.CheckedChanged += new System.EventHandler(this.chbForMove_CheckedChanged);
            // 
            // chbAccountable
            // 
            this.chbAccountable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbAccountable.AutoSize = true;
            this.chbAccountable.Checked = true;
            this.chbAccountable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbAccountable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbAccountable.Location = new System.Drawing.Point(467, 94);
            this.chbAccountable.Name = "chbAccountable";
            this.chbAccountable.Size = new System.Drawing.Size(15, 14);
            this.chbAccountable.TabIndex = 14;
            this.chbAccountable.UseVisualStyleBackColor = true;
            this.chbAccountable.CheckedChanged += new System.EventHandler(this.chbAccountable_CheckedChanged);
            // 
            // chbFromMove
            // 
            this.chbFromMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbFromMove.AutoSize = true;
            this.chbFromMove.Checked = true;
            this.chbFromMove.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbFromMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbFromMove.Location = new System.Drawing.Point(467, 128);
            this.chbFromMove.Name = "chbFromMove";
            this.chbFromMove.Size = new System.Drawing.Size(15, 14);
            this.chbFromMove.TabIndex = 15;
            this.chbFromMove.UseVisualStyleBackColor = true;
            this.chbFromMove.CheckedChanged += new System.EventHandler(this.chbFromMove_CheckedChanged);
            // 
            // frmSubMovement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 268);
            this.Controls.Add(this.chbFromMove);
            this.Controls.Add(this.chbAccountable);
            this.Controls.Add(this.chbForMove);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbFromMove);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbEvent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbAccountable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.dtpDateMove);
            this.Controls.Add(this.cmbForMove);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSubMovement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSubMovement";
            this.Load += new System.EventHandler(this.frmSubMovement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbForMove;
        private System.Windows.Forms.DateTimePicker dtpDateMove;
        public System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbAccountable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEvent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbFromMove;
        private System.Windows.Forms.CheckBox chbForMove;
        private System.Windows.Forms.CheckBox chbAccountable;
        private System.Windows.Forms.CheckBox chbFromMove;
    }
}