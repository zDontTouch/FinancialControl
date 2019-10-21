using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace Financial_Control
{
    class DataBaseController
    {
        private SQLiteConnection connection;

        public DataBaseController()
        {
            connection = new SQLiteConnection("Data Source=G:/SQLite/FinancialControl.db; Version=3; datetimeformat=CurrentCulture;");
        }

        public DataTable queryAllStockTransactions()
        {
            DataTable dt = new DataTable();

            try
            {
                connection.Open();
                SQLiteDataAdapter ad = new SQLiteDataAdapter("SELECT type as Tipo, date as Data, code as Ação, numberOfStocks as Lote, price as Preço FROM StockTransaction", connection);
                ad.Fill(dt);
            }
            catch (SQLiteException ex)
            {
                
            }
            connection.Close();
            return dt;

        }

        public bool registerStockPurchase(string type, string code, int numberofStocks, string price)
        {
            connection.Open();
            SQLiteCommand insertTransactionCmd = connection.CreateCommand();
            insertTransactionCmd.CommandText = "INSERT INTO StockTransaction (type,date,code,numberOfStocks,price) VALUES ('" + type + "','" + DateTime.Now.ToString("yyyy/MM/dd") + "','" + code + "'," + numberofStocks + ",'" + price + "')";
            insertTransactionCmd.ExecuteNonQuery();

            SQLiteCommand selectBalanceCmd = connection.CreateCommand();
            selectBalanceCmd.CommandText = "SELECT numberOfStocks FROM StockBalance WHERE code = '"+code+"'";
            SQLiteDataReader reader = selectBalanceCmd.ExecuteReader();
            SQLiteCommand upsertBalanceCmd = connection.CreateCommand();
            if (reader.HasRows)
            {
                if(type == "Compra")
                {
                    upsertBalanceCmd.CommandText = "UPDATE StockBalance SET numberOfStocks = numberOfStocks + " + numberofStocks + " WHERE code = '" + code + "'";
                }
                else
                {
                    upsertBalanceCmd.CommandText = "UPDATE StockBalance SET numberOfStocks = numberOfStocks - " + numberofStocks + " WHERE code = '" + code + "'";
                }
                
            }
            else
            {
                upsertBalanceCmd.CommandText = "INSERT INTO StockBalance (code,numberOfStocks) VALUES ('"+code+"',"+numberofStocks+")";
            }
            upsertBalanceCmd.ExecuteNonQuery();
            connection.Close();
            return true;

        }

    }
}
