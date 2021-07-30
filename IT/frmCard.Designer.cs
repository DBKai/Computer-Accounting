namespace IT
{
    partial class frmCard
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCard));
            this.dgvCard = new IT.CustomDataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.report1 = new FastReport.Report();
            this.expFilter = new DevComponents.DotNetBar.ExpandablePanel();
            this.btnFilterClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbFilterEquip_Name = new System.Windows.Forms.TextBox();
            this.txbFilterInv = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnHandbook = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.lblCountRecord = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report1)).BeginInit();
            this.expFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCard
            // 
            this.dgvCard.AllowUserToAddRows = false;
            this.dgvCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCard.Location = new System.Drawing.Point(12, 24);
            this.dgvCard.MultiSelect = false;
            this.dgvCard.Name = "dgvCard";
            this.dgvCard.ReadOnly = true;
            this.dgvCard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCard.Size = new System.Drawing.Size(868, 481);
            this.dgvCard.TabIndex = 0;
            this.dgvCard.TabStop = false;
            this.dgvCard.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCard_CellDoubleClick);
            this.dgvCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvCard_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(12, 521);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 33);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "ДОБАВИТЬ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.Location = new System.Drawing.Point(122, 521);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(114, 33);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "РЕДАКТИРОВАТЬ";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // report1
            // 
            this.report1.ReportResourceString = resources.GetString("report1.ReportResourceString");
            // 
            // expFilter
            // 
            this.expFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.expFilter.Controls.Add(this.btnFilterClear);
            this.expFilter.Controls.Add(this.label4);
            this.expFilter.Controls.Add(this.label3);
            this.expFilter.Controls.Add(this.txbFilterEquip_Name);
            this.expFilter.Controls.Add(this.txbFilterInv);
            this.expFilter.Location = new System.Drawing.Point(12, -2);
            this.expFilter.Name = "expFilter";
            this.expFilter.Size = new System.Drawing.Size(868, 48);
            this.expFilter.TabIndex = 6;
            this.expFilter.TabStop = true;
            this.expFilter.Text = "expFilter";
            this.expFilter.TitleText = "Фильтр";
            this.expFilter.ExpandedChanged += new DevComponents.DotNetBar.ExpandChangeEventHandler(this.expFilter_ExpandedChanged);
            // 
            // btnFilterClear
            // 
            this.btnFilterClear.Location = new System.Drawing.Point(3, 18);
            this.btnFilterClear.Name = "btnFilterClear";
            this.btnFilterClear.Size = new System.Drawing.Size(85, 26);
            this.btnFilterClear.TabIndex = 10;
            this.btnFilterClear.Text = "ОЧИСТИТЬ";
            this.btnFilterClear.UseVisualStyleBackColor = true;
            this.btnFilterClear.Click += new System.EventHandler(this.btnFilterClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Инв";
            // 
            // txbFilterEquip_Name
            // 
            this.txbFilterEquip_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbFilterEquip_Name.Location = new System.Drawing.Point(163, 18);
            this.txbFilterEquip_Name.MaxLength = 300;
            this.txbFilterEquip_Name.Name = "txbFilterEquip_Name";
            this.txbFilterEquip_Name.Size = new System.Drawing.Size(391, 26);
            this.txbFilterEquip_Name.TabIndex = 8;
            this.txbFilterEquip_Name.TextChanged += new System.EventHandler(this.txbFilterEquip_Name_TextChanged);
            // 
            // txbFilterInv
            // 
            this.txbFilterInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbFilterInv.Location = new System.Drawing.Point(91, 18);
            this.txbFilterInv.MaxLength = 6;
            this.txbFilterInv.Name = "txbFilterInv";
            this.txbFilterInv.Size = new System.Drawing.Size(70, 26);
            this.txbFilterInv.TabIndex = 7;
            this.txbFilterInv.TextChanged += new System.EventHandler(this.txbFilterInv_TextChanged);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDel.Location = new System.Drawing.Point(242, 521);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(104, 33);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "УДАЛИТЬ";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnHandbook
            // 
            this.btnHandbook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHandbook.Location = new System.Drawing.Point(352, 521);
            this.btnHandbook.Name = "btnHandbook";
            this.btnHandbook.Size = new System.Drawing.Size(104, 33);
            this.btnHandbook.TabIndex = 4;
            this.btnHandbook.Text = "СПРАВОЧНИК";
            this.btnHandbook.UseVisualStyleBackColor = true;
            this.btnHandbook.Click += new System.EventHandler(this.btnHandbook_Click);
            // 
            // btnReport
            // 
            this.btnReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReport.Location = new System.Drawing.Point(462, 521);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(104, 33);
            this.btnReport.TabIndex = 5;
            this.btnReport.Text = "ОТЧЕТ";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // lblCountRecord
            // 
            this.lblCountRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCountRecord.BackColor = System.Drawing.SystemColors.Control;
            this.lblCountRecord.Location = new System.Drawing.Point(706, 505);
            this.lblCountRecord.Name = "lblCountRecord";
            this.lblCountRecord.Size = new System.Drawing.Size(174, 23);
            this.lblCountRecord.TabIndex = 8;
            this.lblCountRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 566);
            this.Controls.Add(this.lblCountRecord);
            this.Controls.Add(this.expFilter);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnHandbook);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvCard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "КАРТОЧКИ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCard_FormClosed);
            this.Load += new System.EventHandler(this.frmCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report1)).EndInit();
            this.expFilter.ResumeLayout(false);
            this.expFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomDataGridView dgvCard;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private FastReport.Report report1;
        private DevComponents.DotNetBar.ExpandablePanel expFilter;
        private System.Windows.Forms.TextBox txbFilterInv;
        private System.Windows.Forms.TextBox txbFilterEquip_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFilterClear;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnHandbook;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label lblCountRecord;
    }
}

