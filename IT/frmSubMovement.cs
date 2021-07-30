using System;
using System.Data;
using System.Windows.Forms;

namespace IT
{
    public partial class frmSubMovement : Form
    {
        private Movement _movement;
        private DataSet _dataSet;

        public frmSubMovement()
        {
            InitializeComponent();
            _movement = new Movement();
            _dataSet = new DataSet();
        }

        private void frmSubMovement_Load(object sender, EventArgs e)
        {
            LoadCmb();
            SetRecords();
        }
        
        private void btnApply_Click(object sender, EventArgs e)
        {
            if (!GetRecords()) return;
            if (Text == @"РЕДАКТИРОВАНИЕ ДВИЖЕНИЯ")
                MovementAction.Edit(_movement);
            else
                MovementAction.Add(_movement);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chbForMove_CheckedChanged(object sender, EventArgs e)
        {
            cmbForMove.Enabled = chbForMove.Checked;
        }

        private void chbAccountable_CheckedChanged(object sender, EventArgs e)
        {
            cmbAccountable.Enabled = chbAccountable.Checked;
        }

        private void chbFromMove_CheckedChanged(object sender, EventArgs e)
        {
            cmbFromMove.Enabled = chbFromMove.Checked;
        }

        // Получаем данные из контролов и записываем их в класс Movement
        private bool GetRecords()
        {
            try
            {
                if (cmbEvent == null) return false;
                switch (cmbEvent.SelectedIndex)
                {
                    case 0: // Ликвидирован 
                        if (!chbForMove.Checked || !chbFromMove.Checked)
                        {
                            MessageBox.Show(
                                @"При событии ""Перемещение"", ""Ликвидирован"" или ""Списан с баланса"", необходимо выбрать подразделение, откуда и куда оно совершается");
                            chbFromMove.Checked = true;
                            chbForMove.Checked = true;
                            return false;
                        }
                        break;
                    case 1: // Перемещение
                        goto case 0;
                    case 2: // Приход
                        if (!chbForMove.Checked)
                        {
                            MessageBox.Show(
                                @"При событии ""Приход"", необходимо выбрать подразделение, куда оно совершается");
                            chbForMove.Checked = true;
                            chbFromMove.Checked = false;
                            return false;
                        }
                        chbFromMove.Checked = false;
                        break;
                   
                    case 3: // Списан с баланса
                        goto case 0;
                }

                if (_movement == null) return false;
                _movement.dt_move = dtpDateMove.Checked ? dtpDateMove.Value : (DateTime?)null;
                _movement.for_move_id = chbForMove.Checked ? Convert.ToInt32(cmbForMove.SelectedValue) : 0;
                _movement.acc_id = chbAccountable.Checked ? Convert.ToInt32(cmbAccountable.SelectedValue) : 0;
                _movement.from_move_id = chbFromMove.Checked ? Convert.ToInt32(cmbFromMove.SelectedValue) : 0;
                _movement.event_id = Convert.ToInt32(cmbEvent.SelectedValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return true;
        }

        // Присваиваем значения контролам из полученного класса Movement
        private void SetRecords()
        {
            try
            {
                // Объявляем владельца формы frmSubMovement
                var frmMovement = Owner as frmMovement;
                if (frmMovement == null) return;
                // Присваиваем значения переданного класса Movement классу Movement текущей формы
                _movement = frmMovement.Movement;
                _movement.card_id = frmMovement.CardMove.id_card;                
                if (_movement.id_move == 0)
                {
                    if (_movement.for_move_id != null)
                        cmbFromMove.SelectedValue = _movement.for_move_id;
                    return;
                }
                // Заполняем контролы значениями переданного класса Movement
                dtpDateMove.Value = Convert.ToDateTime(_movement.dt_move);
                if (_movement.for_move_id == 0)
                    chbForMove.Checked = false;
                else
                    cmbForMove.SelectedValue = _movement.for_move_id;
                if (_movement.acc_id == 0)
                    chbAccountable.Checked = false;
                else
                    cmbAccountable.SelectedValue = _movement.acc_id;
                if (_movement.from_move_id == 0)
                    chbFromMove.Checked = false;
                else
                    cmbFromMove.SelectedValue = _movement.from_move_id;
                cmbEvent.SelectedValue = _movement.event_id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadCmb()
        {
            _dataSet = HandbookAction.FillHandbook("subdivision");
            cmbForMove.DataSource = _dataSet.Tables[0];
            cmbForMove.ValueMember = _dataSet.Tables[0].Columns[0].ColumnName;
            cmbForMove.DisplayMember = _dataSet.Tables[0].Columns[1].ColumnName;

            _dataSet = HandbookAction.FillHandbook("accountable");
            cmbAccountable.DataSource = _dataSet.Tables[0];
            cmbAccountable.ValueMember = _dataSet.Tables[0].Columns[0].ColumnName;
            cmbAccountable.DisplayMember = _dataSet.Tables[0].Columns[1].ColumnName;

            _dataSet = HandbookAction.FillHandbook("subdivision");
            cmbFromMove.DataSource = _dataSet.Tables[0];
            cmbFromMove.ValueMember = _dataSet.Tables[0].Columns[0].ColumnName;
            cmbFromMove.DisplayMember = _dataSet.Tables[0].Columns[1].ColumnName;

            _dataSet = HandbookAction.FillHandbook("event");
            cmbEvent.DataSource = _dataSet.Tables[0];
            cmbEvent.ValueMember = _dataSet.Tables[0].Columns[0].ColumnName;
            cmbEvent.DisplayMember = _dataSet.Tables[0].Columns[1].ColumnName;
        }

        private void cmbEvent_TextChanged(object sender, EventArgs e)
        {
            switch (cmbEvent.SelectedIndex)
            {
                case 2: // Приход
                    chbForMove.Checked = true; chbFromMove.Checked = false; break;
                case 0: // Ликвидирован
                    chbFromMove.Checked = true; chbForMove.Checked = false; break;
                case 1: // Перемещение
                    chbForMove.Checked = true; chbFromMove.Checked = true; break;
                case 3: // Списан с баланса
                    goto case 1;
            }
        }
    }
}
