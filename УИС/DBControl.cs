using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;

namespace УИС
{
    static class DBControl
    {
        static OleDbConnection connection;
        static Properties.Settings settings = Properties.Settings.Default;
        const int MAX_ERRORS = 10;
        static List<string> errors = new List<string>(MAX_ERRORS);
        public static string[] Errors { get { return errors.ToArray(); } }
        static public string LastError
        {
            get
            {
                return errors.Count != 0 ? errors[errors.Count - 1] : null;
            }
            set
            {
                if (errors.Count == errors.Capacity) errors.RemoveAt(0);
                errors.Add(value);
                if (Error != null) Error(value);
            }
        }
        static public event Action<string> Error;

        static public bool Connected { get; private set; }
        static public string[] Tables = { }, Views = { };
        private static DataTable foreignKeys;
        static public DataTable ForeignKeys
        {
            get { return foreignKeys; }
        }


        public static DbDataAdapter Adapter(string sql)
        {
            if (!Connected)
            {
                LastError = "Нет подключения!";
                return null;
            }
            var com = connection.CreateCommand();
            com.CommandText = sql;
            var ad = new OleDbDataAdapter(com);
            try
            {
                var b = new OleDbCommandBuilder(ad);
                ad.UpdateCommand = b.GetUpdateCommand();
                ad.InsertCommand = b.GetInsertCommand();
            }
            catch { }
            return ad;
        }
        public static DataTable Select(string sql)
        {
            var ad = Adapter(sql);
            DataTable table = new DataTable();
            try { ad.Fill(table); }
            catch (Exception e)
            {
                table = null;
                LastError = e.Message;
            }
            return table;
        }
        public static bool Connect()
        {
            try
            {
                connection = new OleDbConnection("Provider=" + settings.providers.Split('|')[settings.curProvider] + ";Data Source=" + settings.path);
                connection.Open();
                Connected = true;
                FillViews();
            }
            catch (Exception e)
            {
                LastError = e.Message;
                Connected = false;
            }
            return Connected;
        }
        public static void FillViews()
        {
            if (!Connected) { LastError = "Не подключено!"; return; }
            DataTable temp = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
            Tables = new string[temp.Rows.Count];
            for (int i = temp.Rows.Count - 1; i >= 0; i--) Tables[i] = (string)temp.Rows[i]["TABLE_NAME"];
            temp = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "VIEW" });
            Views = new string[temp.Rows.Count];
            for (int i = temp.Rows.Count - 1; i >= 0; i--) Views[i] = (string)temp.Rows[i]["TABLE_NAME"];
            foreignKeys = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Foreign_Keys, null);
        }//TODO!
        public static DataTable Schema(string name, string[] arr = null)
        {
            if (name == "") return connection.GetSchema();
            if (name == "info") return connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables_Info, arr);
            try
            {
                if (!name.StartsWith("#")) return connection.GetSchema(name, arr);
                var f = typeof(OleDbSchemaGuid).GetField(name.Substring(1));
                return connection.GetOleDbSchemaTable((Guid)f.GetValue(null), arr);
            }
            catch (Exception e)
            { LastError = e.Message; }
            return new DataTable();
        }
        public static void Close() { connection.Close(); }
    }
}