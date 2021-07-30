namespace IT
{
    partial class frmHandbook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHandbook));
            this.dgvHandbook = new System.Windows.Forms.DataGridView();
            this.cmbHandbook = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUncheck = new System.Windows.Forms.Button();
            this.txbHandbookName = new System.Windows.Forms.TextBox();
            this.txbFilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHandbook)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHandbook
            // 
            this.dgvHandbook.AllowUserToAddRows = false;
            this.dgvHandbook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHandbook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHandbook.Location = new System.Drawing.Point(11, 76);
            this.dgvHandbook.MultiSelect = false;
            this.dgvHandbook.Name = "dgvHandbook";
            this.dgvHandbook.ReadOnly = true;
            this.dgvHandbook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHandbook.Size = new System.Drawing.Size(538, 308);
            this.dgvHandbook.TabIndex = 1;
            this.dgvHandbook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHandbook_CellClick);
            // 
            // cmbHandbook
            // 
            this.cmbHandbook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbHandbook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHandbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbHandbook.FormattingEnabled = true;
            this.cmbHandbook.Items.AddRange(new object[] {
            "Подразделение",
            "Ответственный",
            "Материальная ценность"});
            this.cmbHandbook.Location = new System.Drawing.Point(11, 42);
            this.cmbHandbook.Name = "cmbHandbook";
            this.cmbHandbook.Size = new System.Drawing.Size(538, 28);
            this.cmbHandbook.TabIndex = 2;
            this.cmbHandbook.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(11, 422);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 33);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "ДОБАВИТЬ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.Location = new System.Drawing.Point(147, 422);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(130, 33);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "РЕДАКТИРОВАТЬ";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDel.Location = new System.Drawing.Point(283, 422);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(130, 33);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "УДАЛИТЬ";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUncheck
            // 
            this.btnUncheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUncheck.Location = new System.Drawing.Point(419, 422);
            this.btnUncheck.Name = "btnUncheck";
            this.btnUncheck.Size = new System.Drawing.Size(130, 33);
            this.btnUncheck.TabIndex = 6;
            this.btnUncheck.Text = "СНЯТЬ ВЫДЕЛЕНИЕ";
            this.btnUncheck.UseVisualStyleBackColor = true;
            this.btnUncheck.Click += new System.EventHandler(this.btnUncheck_Click);
            // 
            // txbHandbookName
            // 
            this.txbHandbookName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbHandbookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbHandbookName.Location = new System.Drawing.Point(11, 390);
            this.txbHandbookName.Name = "txbHandbookName";
            this.txbHandbookName.Size = new System.Drawing.Size(538, 26);
            this.txbHandbookName.TabIndex = 7;
            // 
            // txbFilter
            // 
            this.txbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbFilter.Location = new System.Drawing.Point(11, 10);
            this.txbFilter.Name = "txbFilter";
            this.txbFilter.Size = new System.Drawing.Size(538, 26);
            this.txbFilter.TabIndex = 8;
            this.txbFilter.TextChanged += new System.EventHandler(this.txbFilter_TextChanged);
            this.txbFilter.DoubleClick += new System.EventHandler(this.txbFilter_DoubleClick);
            // 
            // frmHandbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 467);
            this.Controls.Add(this.txbFilter);
            this.Controls.Add(this.txbHandbookName);
            this.Controls.Add(this.btnUncheck);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbHandbook);
            this.Controls.Add(this.dgvHandbook);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHandbook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "СПРАВОЧНИК";
            this.Load += new System.EventHandler(this.frmHandbook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHandbook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHandbook;
        private System.Windows.Forms.ComboBox cmbHandbook;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUncheck;
        private System.Windows.Forms.TextBox txbHandbookName;
        private System.Windows.Forms.TextBox txbFilter;


    }
}