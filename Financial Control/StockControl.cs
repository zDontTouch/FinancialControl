using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financial_Control
{
    public partial class StockControl : Form
    {

        DataBaseController dbController = new DataBaseController();

        public StockControl()
        {
            InitializeComponent();
        }

        private void textStockCode_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void browserStocks_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.browserStocks.Document.Window.ScrollTo(0, 300);
        }

        private void radioPurchase_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioPurchase.Checked)
            {
                labelAbovePrice.Text = "Compras Acima deste Preço:";
                labelBelowPrice.Text = "Compras Abaixo deste Preço:";
            }
        }

        private void radioSell_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioSell.Checked)
            {
                labelAbovePrice.Text = "Vendas Acima deste Preço:";
                labelBelowPrice.Text = "Vendas Abaixo deste Preço:";
            }
        }

        private void StockControl_Load(object sender, EventArgs e)
        {
            DataTable transactions = this.dbController.queryAllStockTransactions();
            transactions = DataFormatter.FormatStockTransactionMainTable(transactions);
            this.dgvTransactions.DataSource = transactions;
        }

        private void btnRegisterTransaction_Click(object sender, EventArgs e)
        {
            if(this.textStockCode.Text == "" || this.textNumberOfStocks.Text == "" || this.textStockPrice.Text == "")
            {
                MessageBox.Show("Por favor preencha os campos para a transação", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string type = (this.radioPurchase.Checked) ? "Compra" : "Venda";
                string code = this.textStockCode.Text;
                int numberOfStocks = int.Parse(this.textNumberOfStocks.Text);
                string price =  (this.textStockPrice.Text).Replace(',','.');
                Console.WriteLine(price);

                dbController.registerStockPurchase(type, code, numberOfStocks, price);
                this.StockControl_Load(sender, e);
                MessageBox.Show("Transação Registrada", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textStockCode.Clear();
                this.textStockPrice.Clear();
                this.textNumberOfStocks.Clear();
            }
        }

        private void textStockCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Tab)
            {
                this.browserStocks.Url = new Uri("http://www.b3.com.br/pt_br/busca/?query=" + textStockCode.Text);
            }
        }
    }
}
