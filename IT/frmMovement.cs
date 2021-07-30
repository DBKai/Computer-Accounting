using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace IT
{
    public partial class frmMovement : Form
    {
        private readonly BindingSource _bindingSource; // Создаем экземпляр класса привязки DataSet к DGV
        public Card CardMove;
        public Movement Movement;

        public frmMovement()
        {
            InitializeComponent();
            CardMove = new Card();
            Movement = new Movement();
            _bindingSource = new BindingSource();
        }
        
        private void frmMovement_Load(object sender, EventArgs e)
        {
            var frmCard = Owner as frmCard;
            if (frmCard == null) return;
            CardMove = frmCard.Card;
            DgvInitialize();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GetForMoveId();
            var frmSub = new frmSubMovement
            {
                Owner = this,
                Text = @"ДОБАВЛЕНИЕ ДВИЖЕНИЯ",
                btnApply = { Text = @"ДОБАВИТЬ" }
            };
            frmSub.ShowDialog();
            DgvInitialize(); // Инициализация DataGridView (DGV)
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (!GetRecords()) return;
            if (MessageBox.Show(
                    string.Format("Хотите удалить движение за дату {1} по карточке № {0}?",
                                  Movement.card_id, Movement.dt_move.Value.ToShortDateString()), @"Удаление движения",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                MovementAction.Del(Movement);
            }
            DgvInitialize(); // Инициализация DataGridView (DGV)
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!GetRecords()) return;
            var frmSub = new frmSubMovement
            {
                Owner = this,
                Text = @"РЕДАКТИРОВАНИЕ ДВИЖЕНИЯ",
                btnApply = { Text = @"ИЗМЕНИТЬ" }
            };
            frmSub.ShowDialog();
            DgvInitialize(); // Инициализация DataGridView (DGV)
        }

        // Инициализация DataGridView (DGV)
        private void DgvInitialize()
        {
            // Заполняем DataTable значениями из таблицы Card
            DataTable tables = MovementAction.FillMovement(CardMove.id_card).Tables[0];
            // Привязываем полученную таблицу к BindingSource
            _bindingSource.DataSource = tables;
            // Привязка заполненого DataSource к DGV
            dgvMovement.DataSource = _bindingSource;
            dgvMovement.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            // Установка ширины колонок
            dgvMovement.Columns[0].Width = 50; //card_id
            dgvMovement.Columns[1].Width = 90; //dt_move
            dgvMovement.Columns[2].Width = 100; //for_move_id
            dgvMovement.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; //subdiv_name
            dgvMovement.Columns[4].Width = 100; //acc_id
            dgvMovement.Columns[5].Width = 100; //acc_name
            dgvMovement.Columns[6].Width = 100; //from_move_id
            dgvMovement.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // subdiv_name
            dgvMovement.Columns[8].Width = 100;// event_id
            dgvMovement.Columns[9].Width = 120;// event_name
            // Установка названия колонок
            dgvMovement.Columns[0].HeaderText = @"ИД"; //card_id
            dgvMovement.Columns[1].HeaderText = @"Дата"; //dt_move
            dgvMovement.Columns[2].HeaderText = @"ИД_КудаПеремещ"; //for_move_id
            dgvMovement.Columns[3].HeaderText = @"Куда"; //subdiv_name
            dgvMovement.Columns[4].HeaderText = @"ИД_Ответств"; //acc_id
            dgvMovement.Columns[5].HeaderText = @"Ответственный"; //acc_name
            dgvMovement.Columns[6].HeaderText = @"ИД_ОткудаПеремещ"; //from_move_id
            dgvMovement.Columns[7].HeaderText = @"Откуда"; // subdiv_name
            dgvMovement.Columns[8].HeaderText = @"ИД_Событие";// event_id
            dgvMovement.Columns[9].HeaderText = @"Событие";// event_name
            // Скрытие столбцов с id
            dgvMovement.Columns[0].Visible = false;
            dgvMovement.Columns[2].Visible = false;
            dgvMovement.Columns[4].Visible = false;
            dgvMovement.Columns[6].Visible = false;
            dgvMovement.Columns[8].Visible = false;
            dgvMovement.Columns[10].Visible = false; // id_key_move
        }

        private void GetForMoveId()
        {
            Movement = new Movement();
            // Если в DGV есть выделенные ячейки
            if (dgvMovement.SelectedCells.Count > 0)
            {
                if (dgvMovement.CurrentRow != null)
                {
                    Movement.for_move_id = dgvMovement.CurrentRow.Cells[2].Value.ToString() != ""
                                                    ? Convert.ToInt32(dgvMovement.CurrentRow.Cells[2].Value)
                                                    : 0;
                }
            }
        }

        private bool GetRecords()
        {
            try
            {
                Movement = new Movement();
                // Если в DGV есть выделенные ячейки
                if (dgvMovement.SelectedCells.Count > 0)
                {
                    if (dgvMovement.CurrentRow != null)
                    {
                        Movement.id_move = dgvMovement.CurrentRow.Cells[10].Value.ToString() != ""
                                               ? Convert.ToInt32(dgvMovement.CurrentRow.Cells[10].Value)
                                               : 0;
                        Movement.card_id = dgvMovement.CurrentRow.Cells[0].Value.ToString() != ""
                                               ? Convert.ToInt32(dgvMovement.CurrentRow.Cells[0].Value)
                                               : 0;
                        Movement.dt_move = dgvMovement.CurrentRow.Cells[1].Value.ToString() != ""
                                               ? Convert.ToDateTime(dgvMovement.CurrentRow.Cells[1].Value)
                                               : (DateTime?) null;
                        Movement.for_move_id = dgvMovement.CurrentRow.Cells[2].Value.ToString() != ""
                                                   ? Convert.ToInt32(dgvMovement.CurrentRow.Cells[2].Value)
                                                   : 0;
                        Movement.acc_id = dgvMovement.CurrentRow.Cells[4].Value.ToString() != ""
                                              ? Convert.ToInt32(dgvMovement.CurrentRow.Cells[4].Value)
                                              : 0;
                        Movement.from_move_id = dgvMovement.CurrentRow.Cells[6].Value.ToString() != ""
                                                    ? Convert.ToInt32(dgvMovement.CurrentRow.Cells[6].Value)
                                                    : 0;
                        Movement.event_id = dgvMovement.CurrentRow.Cells[8].Value.ToString() != ""
                                                ? Convert.ToInt32(dgvMovement.CurrentRow.Cells[8].Value)
                                                : 0;
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        private void frmMovement_Activated(object sender, EventArgs e)
        {
            dgvMovement.ClearSelection();
        }
    }
}
