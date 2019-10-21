using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Control
{
    static class DataFormatter
    {

        public static DataTable FormatStockTransactionMainTable(DataTable transactions)
        {
            transactions.Columns.Add("Valor Total");
            for(int i=0; i<transactions.Rows.Count; i++)
            {
                transactions.Rows[i]["Valor Total"] = "R$ " + int.Parse(transactions.Rows[i]["Lote"].ToString()) * float.Parse(transactions.Rows[i]["Preço"].ToString());
            }
            transactions.Columns.Add("Rentabilidade");
            return transactions;

        }

    }
}
