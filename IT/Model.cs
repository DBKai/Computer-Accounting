using System;

namespace IT
{
    /// <summary>
    /// Карточка оборудования
    /// </summary>
    public class Card
    {
        /// <summary>
        /// Идентификатор карточки
        /// </summary>
        public int id_card { get; set; }
        /// <summary>
        /// Инвентарный номер
        /// </summary>
        public string inv { get; set; }
        /// <summary>
        /// Материальная ценность
        /// </summary>
        public string equip_name { get; set; }
        /// <summary>
        /// Идентификатор материальной ценности
        /// </summary>
        public int equip_id { get; set; }
        /// <summary>
        /// Балансовая стоимость
        /// </summary>
        public double cost { get; set; }
        /// <summary>
        /// Дата установки
        /// </summary>
        public DateTime? delivery_date { get; set; }
        /// <summary>
        /// Дата списания
        /// </summary>
        public DateTime? writeoff_date { get; set; }
        /* public string delivery_date_string
        { get { return delivery_date == null ? "" : delivery_date.Value.ToShortDateString(); } }
        */
    }

    /// <summary>
    /// Движение оборудования
    /// </summary>
    public class Movement
    {
        /// <summary>
        /// Идентификатордвижения в картотеке
        /// </summary>
        public int id_move { get; set; }
        /// <summary>
        /// Номер карточки
        /// </summary>
        public int card_id { get; set; }
        /// <summary>
        /// Дата перемещения
        /// </summary>
        public DateTime? dt_move { get; set; }
        /// <summary>
        /// Откуда перемещение
        /// </summary>
        public int? from_move_id { get; set; }
        /// <summary>
        /// Куда перемещение
        /// </summary>
        public int? for_move_id { get; set; }
        /// <summary>
        /// Ответственный
        /// </summary>
        public int? acc_id { get; set; }
        /// <summary>
        /// Событие
        /// </summary>
        public int event_id { get; set; }
    }

    /// <summary>
    /// Справочник
    /// </summary>
    public class Handbook
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int id_hand { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string hand_name { get; set; }
    }
}
