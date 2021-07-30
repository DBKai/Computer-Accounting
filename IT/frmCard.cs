using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IT
{
    public partial class frmCard : Form
    {
        private readonly BindingSource _bindingSource;
        public Card Card;
        
        public frmCard()
        {
            InitializeComponent();
            _bindingSource = new BindingSource();
        }

        private void frmCard_Load(object sender, EventArgs e)
        {
            DgvInitialize();
            // Скрываем ExpandablePanel
            expFilter.Expanded = false;
        }
                
        private void dgvCard_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenMovement();
        }

        /// <summary>
        /// Передача заполненного класса Card в форму Movement
        /// </summary>
        private void OpenMovement()
        {
            try
            {
                if (!GetRecords()) return;
                // Создаем экземпляр формы, инициализируем 
                var frmMove = new frmMovement
                {
                    Owner = this,
                    Text = @"ДВИЖЕНИЕ ПО КАРТОЧКЕ №" + Card.id_card
                };
                // Открываем форму в модальном режиме
                frmMove.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frmSub = new frmSubCard
            {
                Text = @"ДОБАВЛЕНИЕ КАРТОЧКИ",
                btnApply = { Text = @"ДОБАВИТЬ" }
            };
            frmSub.ShowDialog();
            DgvInitialize(); // Инициализация DataGridView (DGV)
        }
        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!GetRecords()) return;
            var frmSub = new frmSubCard
            {
                Owner = this,
                Text = @"РЕДАКТИРОВАНИЕ КАРТОЧКИ",
                btnApply = { Text = @"ИЗМЕНИТЬ" }
            };
            frmSub.ShowDialog();
            DgvInitialize();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (!GetRecords()) return;
            if (MessageBox.Show(
                string.Format(
                    "Хотите удалить карточку № {0} Инв № {1} и всё движение по данной карточке?",
                    Card.id_card, Card.inv), @"Удаление карточки", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) == DialogResult.Yes)
            {
                CardAction.Del(Card);
            }
            DgvInitialize();
        }

        /// <summary>
        /// Отчет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReport_Click(object sender, EventArgs e)
        {
            // Загружаем отчет в объект FastReport
            report1.Load(Application.StartupPath + "\\Report.frx");
            // Отправляем строку подключения к БД в отчет
            report1.Dictionary.Connections[0].ConnectionString = Properties.Settings.Default.ReportConnectionString;
            report1.Show();
        }

        /// <summary>
        /// Справочник
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHandbook_Click(object sender, EventArgs e)
        {
            var frmHandbook = new frmHandbook();
            frmHandbook.ShowDialog();
            DgvInitialize(); 
        }
                
        private void btnFilterClear_Click(object sender, EventArgs e)
        {
            txbFilterInv.Clear();
            txbFilterEquip_Name.Clear();
        }

        private void txbFilterInv_TextChanged(object sender, EventArgs e)
        {
            txbFilter_TextChanged();
        }

        private void txbFilterEquip_Name_TextChanged(object sender, EventArgs e)
        {
            txbFilter_TextChanged();
        }


        /// <summary>
        /// Получаем данные из DGV и записываем их в класс Card
        /// </summary>
        /// <returns></returns>
        private bool GetRecords()
        {
            try
            {
                Card = new Card();
                // Если в DGV есть выделенные ячейки
                if (dgvCard.SelectedCells.Count > 0)
                {
                    // то заполняем класс Карточки значениями из DGV
                    if (dgvCard.CurrentRow != null)
                    {
                        Card.id_card = dgvCard.CurrentRow.Cells[0].Value.ToString() != ""
                                           ? Convert.ToInt32(dgvCard.CurrentRow.Cells[0].Value.ToString())
                                           : 0;
                        Card.inv = dgvCard.CurrentRow.Cells[1].Value.ToString();
                        Card.equip_name = dgvCard.CurrentRow.Cells[2].Value.ToString();
                        Card.equip_id = dgvCard.CurrentRow.Cells[6].Value.ToString() != ""
                                            ? Convert.ToInt32(dgvCard.CurrentRow.Cells[6].Value.ToString())
                                            : 0;
                        Card.cost = dgvCard.CurrentRow.Cells[3].Value.ToString() != ""
                                        ? Convert.ToDouble(dgvCard.CurrentRow.Cells[3].Value.ToString())
                                        : 0;
                        Card.delivery_date = dgvCard.CurrentRow.Cells[4].Value.ToString() != ""
                                                 ? Convert.ToDateTime(dgvCard.CurrentRow.Cells[4].Value)
                                                 : (DateTime?) null;
                        Card.writeoff_date = dgvCard.CurrentRow.Cells[5].Value.ToString() != ""
                                                 ? Convert.ToDateTime(dgvCard.CurrentRow.Cells[5].Value)
                                                 : (DateTime?) null;
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"При считывании данных произошла ошибка:\n" + ex.Message);
            }
            return false;
        }

        /// <summary>
        /// Инициализация DataGridView (DGV)
        /// </summary>
        private void DgvInitialize()
        {
            // Заполняем DataTable значениями из таблицы Card
            DataTable tables = CardAction.FillCard().Tables[0];
            // Привязываем полученную таблицу к BindingSource
            _bindingSource.DataSource = tables;
            _bindingSource.Sort = "id_card";
            // Привязка заполненого DataSource к DGV
            dgvCard.DataSource = _bindingSource;
            dgvCard.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            // Установка ширины колонок
            dgvCard.Columns[0].Width = 50; //id_card
            dgvCard.Columns[1].Width = 70; //inv
            dgvCard.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; //equip_name
            dgvCard.Columns[3].Width = 80; //cost
            dgvCard.Columns[4].Width = 90; // delivery_date
            dgvCard.Columns[5].Width = 90; // writeoff_date
            dgvCard.Columns[6].Width = 40; // equip_id
            // Установка названия колонок
            dgvCard.Columns[0].HeaderText = @"ИД"; //id_card
            dgvCard.Columns[1].HeaderText = @"Инв"; //inv
            dgvCard.Columns[2].HeaderText = @"Материальная ценность"; //equip_name
            dgvCard.Columns[3].HeaderText = @"Стоимость"; //cost
            dgvCard.Columns[4].HeaderText = @"ДатаУстан"; //delivery_date
            dgvCard.Columns[5].HeaderText = @"ДатаСписан"; // writeoff_date
            dgvCard.Columns[6].HeaderText = @"EQ_ID"; //equip_id
            // Скрытие столбца с equip_id
            dgvCard.Columns[6].Visible = false;
            // Выводим количество записей в BindingSource
            lblCountRecord.Text = string.Format("ЗАПИСЕЙ В КАРТОТЕКЕ : {0}", _bindingSource.Count);
        }

        /// <summary>
        /// Фильтрация данных в BindingSource
        /// </summary>
        private void txbFilter_TextChanged()
        {
            try
            {
                // Выбираем все контролы типа TextBox, содержащиеся на ExpandablePanel, где текст не пустой 
                // и записываем в класс KeyValuePair, содержащий пары: Имя TextBox, Содержимое TextBox
                var pairs = expFilter.Controls.OfType<TextBox>()
                                     .Where(tb => !string.IsNullOrEmpty(tb.Text))
                                     .Select(tb => new KeyValuePair<string, string>(tb.Name.Remove(0, 9), tb.Text))
                                     .ToArray();
                // Если хотя бы один TextBox существует
                if (pairs.Length != 0)
                {
                    // Создаем строку для свойства Filter объекта BindingSource
                    var sb = new StringBuilder(string.Format(" {0} LIKE '%{1}%' ", pairs[0].Key, pairs[0].Value));
                    // Если существуют еще пары TextBox
                    for (int i = 1; i < pairs.Length; i++)
                    {
                        // то добавляем их в конец к полученной строке 
                        sb.AppendFormat(" AND {0} LIKE '%{1}%' ", pairs[i].Key, pairs[i].Value);
                    }
                    // Присваиваем получившуюся строку к свойству Filter
                    _bindingSource.Filter = sb.ToString();
                }
                else
                {
                    // Иначе обнуляем фильтр у BindingSource
                    _bindingSource.Filter = null;
                }
                // Выводим количество записей в BindingSource
                lblCountRecord.Text = string.Format("ЗАПИСЕЙ В КАРТОТЕКЕ : {0}", _bindingSource.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmCard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Создать копию Базы Данных перед выходом?\n", "Резервное копирование", 
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var cmdArch = new System.Diagnostics.Process
                        {
                            StartInfo =
                                {
                                    FileName = string.Format("{0}\\BackUp.bat", Application.StartupPath),
                                    RedirectStandardInput = true,
                                    RedirectStandardOutput = true,
                                    UseShellExecute = false,
                                    CreateNoWindow = false
                                }
                        };
                    cmdArch.Start();
                    cmdArch.WaitForExit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void expFilter_ExpandedChanged(object sender, DevComponents.DotNetBar.ExpandedChangeEventArgs e)
        {
            expFilter.Width = this.Width - 30;
        }

        private void dgvCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                OpenMovement();
            }
        }
    }
}
