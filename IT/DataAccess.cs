using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IT
{
    public class DataAccess
    {
        private static readonly MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.ConnectionString);
        private static MySqlDataAdapter _adapter;
        private static MySqlCommand _command;
        private static DataSet _dataSet;

        /// <summary>
        /// Заполняет DataSet значениями из указанной таблицы и сортирует по указанному полю
        /// </summary>
        /// <param name="tableName">Название таблицы</param>
        /// <param name="sortField">Поле для сортировки</param>
        /// <returns></returns>
        public static DataSet FillDataSet(string tableName, string sortField)
        {
            return sortField.Length != 0 ? Fill(tableName, string.Format(" ORDER BY {0}", sortField)) : Fill(tableName, "");
        }

        /// <summary>
        /// Получает DataSet из таблиц Card и Equipment
        /// </summary>
        /// <returns></returns>
        protected static DataSet FillCard()
        {
            try
            {
                string query = "SELECT card.id_card, card.inv, equipment.equip_name, card.cost, " +
                               "card.delivery_date, card.writeoff_date, card.equip_id " +
                               "FROM equipment INNER JOIN card ON equipment.id_equip = card.equip_id";
                Connection.Open();
                _command = new MySqlCommand(query, Connection);
                _adapter = new MySqlDataAdapter(_command);
                _adapter.Fill(_dataSet = new DataSet(), "Card");
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return _dataSet;
        }

        /// <summary>
        /// Вставляет запись в таблицу Card
        /// </summary>
        /// <param name="card">Экземпляр объекта Card</param>
        protected static void AddCard(Card card)
        {
            try
            {
                string query = "INSERT INTO card(inv, equip_id, cost, delivery_date, writeoff_date) " +
                               "VALUES(@inv, @equip_id, @cost, @delivery_date, @writeoff_date)";
                Connection.Open();
                _command = new MySqlCommand(query, Connection);
                var inv = new MySqlParameter("@inv", MySqlDbType.String);
                var equip_id = new MySqlParameter("@equip_id", MySqlDbType.Int32);
                var cost = new MySqlParameter("@cost", MySqlDbType.Double);
                var delivery_date = new MySqlParameter("@delivery_date", MySqlDbType.Date);
                var writeoff_date = new MySqlParameter("@writeoff_date", MySqlDbType.Date);

                inv.Value = card.inv;
                equip_id.Value = card.equip_id;
                cost.Value = card.cost;
                delivery_date.Value = card.delivery_date;
                writeoff_date.Value = card.writeoff_date;

                _command.Parameters.Add(inv);
                _command.Parameters.Add(equip_id);
                _command.Parameters.Add(cost);
                _command.Parameters.Add(delivery_date);
                _command.Parameters.Add(writeoff_date);
                
                _command.ExecuteNonQuery();
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Изменяет запись в таблице Card
        /// </summary>
        /// <param name="card">Экземпляр объекта Card</param>
        protected static void EditCard(Card card)
        {
            try
            {
                string query = 
                    "UPDATE card SET inv=@inv, equip_id=@equip_id, cost=@cost, " +
                    "delivery_date=@delivery_date, writeoff_date=@writeoff_date WHERE id_card=@id_card";
                Connection.Open();
                _command = new MySqlCommand(query, Connection);
                var id_card = new MySqlParameter("@id_card", MySqlDbType.Int32);
                var inv = new MySqlParameter("@inv", MySqlDbType.String);
                var equip_id = new MySqlParameter("@equip_id", MySqlDbType.Int32);
                var cost = new MySqlParameter("@cost", MySqlDbType.Double);
                var delivery_date = new MySqlParameter("@delivery_date", MySqlDbType.Date);
                var writeoff_date = new MySqlParameter("@writeoff_date", MySqlDbType.Date);

                id_card.Value = card.id_card;
                inv.Value = card.inv;
                equip_id.Value = card.equip_id;
                cost.Value = card.cost;
                delivery_date.Value = card.delivery_date;
                writeoff_date.Value = card.writeoff_date;

                _command.Parameters.Add(id_card);
                _command.Parameters.Add(inv);
                _command.Parameters.Add(equip_id);
                _command.Parameters.Add(cost);
                _command.Parameters.Add(delivery_date);
                _command.Parameters.Add(writeoff_date);

                _command.ExecuteNonQuery();
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Удаляет запись из таблицы Card и связанные записи из таблицы Movement
        /// </summary>
        /// <param name="card"></param>
        protected static void DeleteCardAndMovement(Card card)
        {
            try
            {
                string query = "DELETE FROM movement WHERE card_id=@id_card; DELETE FROM card WHERE id_card=@id_card;";
                Connection.Open();
                _command = new MySqlCommand(query, Connection); 
                var id_card = new MySqlParameter("@id_card", MySqlDbType.Int32);
                id_card.Value = card.id_card;
                _command.Parameters.Add(id_card);

                _command.ExecuteNonQuery();
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idCard"></param>
        /// <returns></returns>
        protected static DataSet FillMovement(int idCard)
        {
            try
            {
                string query =
                    "SELECT movement.card_id, movement.dt_move, movement.for_move_id, subdivision.subdiv_name, " +
                    "movement.acc_id, accountable.acc_name, movement.from_move_id, " +
                    "subdivision_1.subdiv_name, movement.event_id, event.event_name, movement.id_move " +
                    "FROM subdivision " +
                    "RIGHT JOIN (event " +
                    "RIGHT JOIN (accountable " +
                    "RIGHT JOIN (movement " +
                    "LEFT JOIN subdivision AS subdivision_1 " +
                    "ON movement.from_move_id = subdivision_1.id_subdiv) " +
                    "ON accountable.id_acc = movement.acc_id) " +
                    "ON event.id_event = movement.event_id) " +
                    "ON subdivision.id_subdiv = movement.for_move_id " +
                    "WHERE movement.card_id = @card_id ORDER BY movement.dt_move DESC";
                Connection.Open();
                _command = new MySqlCommand(query, Connection);
                var card_id = new MySqlParameter("@card_id", MySqlDbType.Int32);
                card_id.Value = idCard;
                _command.Parameters.Add(card_id);

                _adapter = new MySqlDataAdapter(_command);
                _adapter.Fill(_dataSet = new DataSet(), "Movement");
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return _dataSet; // Возвращаем заполненный данными DataSet
        }

        protected static void AddMovement(Movement movement)
        {
            try
            {
                string query = "INSERT INTO movement(card_id, dt_move, from_move_id, for_move_id, acc_id, event_id) " +
                               "VALUES(@card_id, @dt_move, @from_move_id, @for_move_id, @acc_id, @event_id)";
                Connection.Open(); // Открываем подключение к БД
                _command = new MySqlCommand(query, Connection); // Инициализируем MySqlCommand

                var card_id = new MySqlParameter("@card_id", MySqlDbType.Int32);
                var dt_move = new MySqlParameter("@dt_move", MySqlDbType.Date);
                var from_move_id = new MySqlParameter("@from_move_id", MySqlDbType.Int32);
                var for_move_id = new MySqlParameter("@for_move_id", MySqlDbType.Int32);
                var acc_id = new MySqlParameter("@acc_id", MySqlDbType.Int32);
                var event_id = new MySqlParameter("@event_id", MySqlDbType.Int32);

                card_id.Value = movement.card_id;
                dt_move.Value = movement.dt_move;
                from_move_id.Value = movement.from_move_id == 0 ? null : movement.from_move_id;
                for_move_id.Value = movement.for_move_id == 0 ? null : movement.for_move_id;
                acc_id.Value = movement.acc_id == 0 ? null : movement.acc_id;
                event_id.Value = movement.event_id;

                _command.Parameters.Add(card_id);
                _command.Parameters.Add(dt_move);
                _command.Parameters.Add(from_move_id);
                _command.Parameters.Add(for_move_id);
                _command.Parameters.Add(acc_id);
                _command.Parameters.Add(event_id);

                _command.ExecuteNonQuery(); // Выполняем переданный запрос query без возврата результата
                Connection.Close(); // Закрываем подключение
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected static void EditMovement(Movement movement)
        {
            try
            {
                string query = "UPDATE movement SET dt_move = @dt_move, from_move_id = @from_move_id, " +
                               "for_move_id = @for_move_id, acc_id = @acc_id, event_id = @event_id WHERE id_move = @id_move";
                Connection.Open(); // Открываем подключение к БД
                _command = new MySqlCommand(query, Connection); // Инициализируем MySqlCommand

                var id_move = new MySqlParameter("@id_move", MySqlDbType.Int32);
                var dt_move = new MySqlParameter("@dt_move", MySqlDbType.Date);
                var from_move_id = new MySqlParameter("@from_move_id", MySqlDbType.Int32);
                var for_move_id = new MySqlParameter("@for_move_id", MySqlDbType.Int32);
                var acc_id = new MySqlParameter("@acc_id", MySqlDbType.Int32);
                var event_id = new MySqlParameter("@event_id", MySqlDbType.Int32);
                
                id_move.Value = movement.id_move;
                dt_move.Value = movement.dt_move;
                from_move_id.Value = movement.from_move_id == 0 ? null : movement.from_move_id;
                for_move_id.Value = movement.for_move_id == 0 ? null : movement.for_move_id;
                acc_id.Value = movement.acc_id == 0 ? null : movement.acc_id;
                event_id.Value = movement.event_id;

                _command.Parameters.Add(id_move);
                _command.Parameters.Add(dt_move);
                _command.Parameters.Add(from_move_id);
                _command.Parameters.Add(for_move_id);
                _command.Parameters.Add(acc_id);
                _command.Parameters.Add(event_id);

                _command.ExecuteNonQuery(); // Выполняем переданный запрос query без возврата результата
                Connection.Close(); // Закрываем подключение
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected static void DelMovement(Movement movement)
        {
            try
            {
                string query = "DELETE FROM movement WHERE id_move=@id_move";
                Connection.Open(); // Открываем подключение к БД
                _command = new MySqlCommand(query, Connection); // Инициализируем MySqlCommand

                var id_move = new MySqlParameter("@id_move", MySqlDbType.Int32);
                id_move.Value = movement.id_move;
                _command.Parameters.Add(id_move);

                _command.ExecuteNonQuery(); // Выполняем переданный запрос query без возврата результата
                Connection.Close(); // Закрываем подключение
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected static DataSet Fill(string tableName, string sortTable)
        {
            try
            {
                string query = "SELECT * FROM " + tableName + sortTable;
                Connection.Open(); // Открываем подключение к БД
                _command = new MySqlCommand(query, Connection); // Инициализируем MySqlCommand
                _adapter = new MySqlDataAdapter(_command); // Передаем команду в MySqlDataAdapter
                _adapter.Fill(_dataSet = new DataSet(), tableName); // Инициализируем и заполняем DataSet данными из DataAdapter
                Connection.Close(); // Закрываем подключение
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return _dataSet; // Возвращаем заполненный данными DataSet
        }

        protected static void AddHandbook(Handbook handbook, string tableName, string handName)
        {
            try
            {
                string query = string.Format("INSERT INTO {0}({1}) VALUES(@hand_name)", tableName, handName);
                Connection.Open(); // Открываем подключение к БД
                _command = new MySqlCommand(query, Connection); // Инициализируем MySqlCommand
                var hand_name = new MySqlParameter("@hand_name", MySqlDbType.String);
                hand_name.Value = handbook.hand_name;
                _command.Parameters.Add(hand_name);
                _command.ExecuteNonQuery(); // Выполняем переданный запрос query без возврата результата
                Connection.Close(); // Закрываем подключение
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected static void EditHandbook(Handbook handbook, string tableName, string handName, string handId)
        {
            try
            {
                string query = string.Format("UPDATE {0} SET {1} = @hand_name WHERE {2} = @id_hand", tableName, handName, handId);
                Connection.Open(); // Открываем подключение к БД
                _command = new MySqlCommand(query, Connection); // Инициализируем MySqlCommand
                var id_hand = new MySqlParameter("@id_hand", MySqlDbType.Int32);
                var hand_name = new MySqlParameter("@hand_name", MySqlDbType.String);
                id_hand.Value = handbook.id_hand;
                hand_name.Value = handbook.hand_name;
                _command.Parameters.Add(id_hand);
                _command.Parameters.Add(hand_name);
                _command.ExecuteNonQuery(); // Выполняем переданный запрос query без возврата результата
                Connection.Close(); // Закрываем подключение
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected static void DelHandbook(Handbook handbook, string tableName, string handId)
        {
            try
            {
                string query = string.Format("DELETE FROM {0} WHERE {1} = @id_hand", tableName, handId);
                Connection.Open(); // Открываем подключение к БД
                _command = new MySqlCommand(query, Connection); // Инициализируем MySqlCommand
                var id_hand = new MySqlParameter("@id_hand", MySqlDbType.Int32);
                id_hand.Value = handbook.id_hand;
                _command.Parameters.Add(id_hand);
                _command.ExecuteNonQuery(); // Выполняем переданный запрос query без возврата результата
                Connection.Close(); // Закрываем подключение
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
