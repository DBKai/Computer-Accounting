using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace IT
{
    public partial class frmSubCard : Form
    {
        private DataSet _dataSet;
        private Card _subcard;

        public frmSubCard()
        {
            InitializeComponent();
            _dataSet = new DataSet();
            _subcard = new Card();
        }

        private void frmSubCard_Load(object sender, EventArgs e)
        {
            LoadCmb();
            SetRecords();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (!GetRecords()) return;
            if (Text == @"РЕДАКТИРОВАНИЕ КАРТОЧКИ")
                CardAction.Edit(_subcard);
            else
                CardAction.Add(_subcard);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Заполняем ComboBox значениями из справочника
        private void LoadCmb()
        {
            _dataSet = DataAccess.FillDataSet("equipment", "equip_name");
            cmbEquip.DataSource = _dataSet.Tables[0];
            cmbEquip.DisplayMember = _dataSet.Tables[0].Columns[1].ColumnName;
            cmbEquip.ValueMember = _dataSet.Tables[0].Columns[0].ColumnName;
        }

        // Получаем данные из контролов и записываем их в класс Card
        private bool GetRecords()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txbInv.Text))
                {
                    MessageBox.Show("Поле с инвентарным номером не заполнено", "Ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                _subcard.inv = !string.IsNullOrWhiteSpace(txbInv.Text) ? txbInv.Text : "";
                _subcard.equip_id = Convert.ToInt32(cmbEquip.SelectedValue);
                _subcard.cost = Convert.ToDouble(nudCost.Text);
                _subcard.delivery_date = dtpDT_Delivery.Checked ? dtpDT_Delivery.Value : (DateTime?) null;
                _subcard.writeoff_date = dtpDT_Writeoff.Checked ? dtpDT_Writeoff.Value : (DateTime?)null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return true;
        }

        // Присваиваем значения контролам из полученного класса Card
        private void SetRecords()
        {
            try
            {
                // Объявляем владельца формы frmSubCard
                var frmCard = Owner as frmCard;
                if (frmCard == null) return;
                // Присваиваем значения переданного класса Card классу Card текущей формы
                _subcard = frmCard.Card;
                // Заполняем контролы значениями переданного класса Card
                txbInv.Text = _subcard.inv;
                cmbEquip.SelectedValue = _subcard.equip_id;
                nudCost.Text = _subcard.cost.ToString(CultureInfo.InvariantCulture);
                
                if (_subcard.delivery_date != null)
                {
                    dtpDT_Delivery.Checked = true;
                    dtpDT_Delivery.Value = Convert.ToDateTime(_subcard.delivery_date);
                }
                else
                {
                    dtpDT_Delivery.Checked = false;
                }

                if (_subcard.writeoff_date != null)
                {
                    dtpDT_Writeoff.Checked = true;
                    dtpDT_Writeoff.Value = Convert.ToDateTime(_subcard.writeoff_date);
                }
                else
                {
                    dtpDT_Writeoff.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
