using System.Data;

namespace IT
{
    public class HandbookAction: DataAccess
    {
        public static DataSet FillHandbook(string tableName)
        {
            return FillDataSet(tableName, GetShortHandbook(tableName));
        }

        public static void Add(string tableName, Handbook handbook)
        {
            switch (tableName)
            {
                case "subdivision": AddSubdiv(handbook); break;
                case "accountable": AddAcc(handbook); break;
                case "equipment": AddEquip(handbook); break;
            }
        }

        public static void Edit(string tableName, Handbook handbook)
        {
            switch (tableName)
            {
                case "subdivision": EditSubdiv(handbook); break;
                case "accountable": EditAcc(handbook); break;
                case "equipment": EditEquip(handbook); break;
            }
        }

        public static void Del(string tableName, Handbook handbook)
        {
            switch (tableName)
            {
                case "subdivision": DelSubdiv(handbook); break;
                case "accountable": DelAcc(handbook); break;
                case "equipment": DelEquip(handbook); break;
            }
        }

        public static string GetShortHandbook(string tableName)
        {
            string shortname = "subdiv_name";
            switch (tableName)
            {
                case "subdivision": shortname = "subdiv_name"; break;
                case "accountable": shortname = "acc_name"; break;
                case "equipment": shortname = "equip_name"; break;
                case "event": shortname = "event_name"; break;
            }
            return shortname;
        }

        private static void AddSubdiv(Handbook handbook)
        {
            AddHandbook(handbook, "subdivision", "subdiv_name");
        }

        private static void AddAcc(Handbook handbook)
        {
            AddHandbook(handbook, "accountable", "acc_name");
        }

        private static void AddEquip(Handbook handbook)
        {
            AddHandbook(handbook, "equipment", "equip_name");
        }

        private static void EditSubdiv(Handbook handbook)
        {
            EditHandbook(handbook, "subdivision", "subdiv_name", "id_subdiv");
        }

        private static void EditAcc(Handbook handbook)
        {
            EditHandbook(handbook, "accountable", "acc_name", "id_acc");
        }

        private static void EditEquip(Handbook handbook)
        {
            EditHandbook(handbook, "equipment", "equip_name", "id_equip");
        }

        private static void DelSubdiv(Handbook handbook)
        {
            DelHandbook(handbook, "subdivision", "id_subdiv");
        }

        private static void DelAcc(Handbook handbook)
        {
            DelHandbook(handbook, "accountable", "id_acc");
        }

        private static void DelEquip(Handbook handbook)
        {
            DelHandbook(handbook, "equipment", "id_equip");
        }
    }
}
