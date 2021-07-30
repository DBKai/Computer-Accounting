using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IT
{
    public partial class frmHandbook : Form
    {
        private Handbook _handbook;
        public string TableName;
        private BindingSource _bindingSource;

        public frmHandbook()
        {
            InitializeComponent();
            _handbook = new Handbook();
            _bindingSource = new BindingSource();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbHandbook.SelectedIndex)
            {
                case 0: TableName = "subdivision"; break; // Подразделение
                case 1: TableName = "accountable"; break; // Ответственный
                case 2: TableName = "equipment"; break; // Материальная ценность
                default: TableName = "subdivision"; break; // Подразделение
            }
            DgvInitialize();
            VarReset();
        }

        private void DgvInitialize()
        {
            _bindingSource = new BindingSource();
            // Заполняем DataTable значениями из таблицы Handbook
            DataTable tables = HandbookAction.FillHandbook(TableName).Tables[0];
            // Привязываем полученную таблицу к BindingSource
            _bindingSource.DataSource = tables;
            // Привязка заполненого DataSource к DGV
            dgvHandbook.DataSource = _bindingSource;
            dgvHandbook.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvHandbook.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            VarReset();
        }

        private void dgvHandbook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetRecords();
            txbHandbookName.Text = _handbook.hand_name;
        }

        private void GetRecords()
        {
            try
            {
                if (dgvHandbook.CurrentRow == null) return;
                _handbook.id_hand = string.IsNullOrEmpty(dgvHandbook.CurrentRow.Cells[0].Value.ToString())
                                        ? 0 : Convert.ToInt32(dgvHandbook.CurrentRow.Cells[0].Value);
                _handbook.hand_name = dgvHandbook.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_handbook != null)
            {
                _handbook.hand_name = string.IsNullOrWhiteSpace(txbHandbookName.Text) ? "" : txbHandbookName.Text;
                HandbookAction.Add(TableName, _handbook);
            }
            DgvInitialize();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvHandbook.SelectedCells.Count > 0)
            {
                _handbook.hand_name = string.IsNullOrWhiteSpace(txbHandbookName.Text) ? "" : txbHandbookName.Text;
                HandbookAction.Edit(TableName, _handbook);
            }
            else
                MessageBox.Show(@"Нет выделенных записей");
            DgvInitialize();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                @"Крайне не рекомендуется удалять записи из справочника. Вы уверены, что хотите удалить запись?",
                @"Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                HandbookAction.Del(TableName, _handbook);
            }
            DgvInitialize();
        }

        private void VarReset()
        {
            dgvHandbook.ClearSelection();
            txbHandbookName.Clear();
            _handbook = new Handbook();
        }

        // Фильтрация данных в BindingSource
        private void txbFilter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txbFilter.Text.Length != 0)
                {
                    // Создаем строку для свойства Filter объекта BindingSource
                    var sb = new StringBuilder(string.Format(" {0} LIKE '%{1}%' ", dgvHandbook.Columns[1].HeaderText, txbFilter.Text));
                    // Присваиваем получившуюся строку к свойству Filter
                    _bindingSource.Filter = sb.ToString();
                }
                else
                {
                    // Иначе обнуляем фильтр у BindingSource
                    _bindingSource.Filter = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUncheck_Click(object sender, EventArgs e)
        {
            VarReset();
        }

        private void frmHandbook_Load(object sender, EventArgs e)
        {
            cmbHandbook.SelectedIndex = 0;
        }

        private void txbFilter_DoubleClick(object sender, EventArgs e)
        {
            txbFilter.Clear();
            _bindingSource.Filter = null;
        }
    }
}