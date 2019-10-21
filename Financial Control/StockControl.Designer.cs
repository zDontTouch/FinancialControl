namespace Financial_Control
{
    partial class StockControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTransactionFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioSell = new System.Windows.Forms.RadioButton();
            this.radioPurchase = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelBelowPrice = new System.Windows.Forms.Label();
            this.labelAbovePrice = new System.Windows.Forms.Label();
            this.textNumberOfStocks = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textStockPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textStockCode = new System.Windows.Forms.TextBox();
            this.browserStocks = new System.Windows.Forms.WebBrowser();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegisterTransaction = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.AllowDrop = true;
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Location = new System.Drawing.Point(12, 72);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.Size = new System.Drawing.Size(833, 475);
            this.dgvTransactions.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Operações";
            // 
            // comboBoxTransactionFilter
            // 
            this.comboBoxTransactionFilter.FormattingEnabled = true;
            this.comboBoxTransactionFilter.Items.AddRange(new object[] {
            "Todas",
            "Compras",
            "Vendas"});
            this.comboBoxTransactionFilter.Location = new System.Drawing.Point(724, 45);
            this.comboBoxTransactionFilter.Name = "comboBoxTransactionFilter";
            this.comboBoxTransactionFilter.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTransactionFilter.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(689, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filtro";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRegisterTransaction);
            this.groupBox1.Controls.Add(this.radioSell);
            this.groupBox1.Controls.Add(this.radioPurchase);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.labelBelowPrice);
            this.groupBox1.Controls.Add(this.labelAbovePrice);
            this.groupBox1.Controls.Add(this.textNumberOfStocks);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textStockPrice);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textStockCode);
            this.groupBox1.Location = new System.Drawing.Point(921, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 475);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar Operação";
            // 
            // radioSell
            // 
            this.radioSell.AutoSize = true;
            this.radioSell.Location = new System.Drawing.Point(247, 39);
            this.radioSell.Name = "radioSell";
            this.radioSell.Size = new System.Drawing.Size(56, 17);
            this.radioSell.TabIndex = 14;
            this.radioSell.Text = "Venda";
            this.radioSell.UseVisualStyleBackColor = true;
            this.radioSell.CheckedChanged += new System.EventHandler(this.radioSell_CheckedChanged);
            // 
            // radioPurchase
            // 
            this.radioPurchase.AutoSize = true;
            this.radioPurchase.Checked = true;
            this.radioPurchase.Location = new System.Drawing.Point(75, 39);
            this.radioPurchase.Name = "radioPurchase";
            this.radioPurchase.Size = new System.Drawing.Size(61, 17);
            this.radioPurchase.TabIndex = 13;
            this.radioPurchase.TabStop = true;
            this.radioPurchase.Text = "Compra";
            this.radioPurchase.UseVisualStyleBackColor = true;
            this.radioPurchase.CheckedChanged += new System.EventHandler(this.radioPurchase_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(172, 351);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(172, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "0";
            // 
            // labelBelowPrice
            // 
            this.labelBelowPrice.AutoSize = true;
            this.labelBelowPrice.Location = new System.Drawing.Point(19, 351);
            this.labelBelowPrice.Name = "labelBelowPrice";
            this.labelBelowPrice.Size = new System.Drawing.Size(146, 13);
            this.labelBelowPrice.TabIndex = 10;
            this.labelBelowPrice.Text = "Compras Abaixo deste Preço:";
            // 
            // labelAbovePrice
            // 
            this.labelAbovePrice.AutoSize = true;
            this.labelAbovePrice.Location = new System.Drawing.Point(22, 316);
            this.labelAbovePrice.Name = "labelAbovePrice";
            this.labelAbovePrice.Size = new System.Drawing.Size(143, 13);
            this.labelAbovePrice.TabIndex = 9;
            this.labelAbovePrice.Text = "Compras Acima deste Preço:";
            // 
            // textNumberOfStocks
            // 
            this.textNumberOfStocks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textNumberOfStocks.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNumberOfStocks.Location = new System.Drawing.Point(109, 232);
            this.textNumberOfStocks.Name = "textNumberOfStocks";
            this.textNumberOfStocks.Size = new System.Drawing.Size(173, 47);
            this.textNumberOfStocks.TabIndex = 7;
            this.textNumberOfStocks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Lote";
            // 
            // textStockPrice
            // 
            this.textStockPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textStockPrice.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textStockPrice.Location = new System.Drawing.Point(109, 159);
            this.textStockPrice.Name = "textStockPrice";
            this.textStockPrice.Size = new System.Drawing.Size(173, 47);
            this.textStockPrice.TabIndex = 5;
            this.textStockPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Preço da Ação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Código da Ação";
            // 
            // textStockCode
            // 
            this.textStockCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textStockCode.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textStockCode.Location = new System.Drawing.Point(109, 86);
            this.textStockCode.Name = "textStockCode";
            this.textStockCode.Size = new System.Drawing.Size(173, 47);
            this.textStockCode.TabIndex = 2;
            this.textStockCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textStockCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textStockCode_KeyDown);
            this.textStockCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textStockCode_KeyUp);
            // 
            // browserStocks
            // 
            this.browserStocks.Location = new System.Drawing.Point(1390, 72);
            this.browserStocks.MinimumSize = new System.Drawing.Size(20, 20);
            this.browserStocks.Name = "browserStocks";
            this.browserStocks.ScriptErrorsSuppressed = true;
            this.browserStocks.Size = new System.Drawing.Size(670, 475);
            this.browserStocks.TabIndex = 5;
            this.browserStocks.Url = new System.Uri("", System.UriKind.Relative);
            this.browserStocks.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.browserStocks_DocumentCompleted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1666, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Página da Ação na B3";
            // 
            // btnRegisterTransaction
            // 
            this.btnRegisterTransaction.Location = new System.Drawing.Point(100, 402);
            this.btnRegisterTransaction.Name = "btnRegisterTransaction";
            this.btnRegisterTransaction.Size = new System.Drawing.Size(203, 45);
            this.btnRegisterTransaction.TabIndex = 15;
            this.btnRegisterTransaction.Text = "Registrar";
            this.btnRegisterTransaction.UseVisualStyleBackColor = true;
            this.btnRegisterTransaction.Click += new System.EventHandler(this.btnRegisterTransaction_Click);
            // 
            // StockControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2072, 593);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.browserStocks);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTransactionFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTransactions);
            this.Name = "StockControl";
            this.Text = "StockControl";
            this.Load += new System.EventHandler(this.StockControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTransactionFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textStockCode;
        private System.Windows.Forms.TextBox textNumberOfStocks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textStockPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.WebBrowser browserStocks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelBelowPrice;
        private System.Windows.Forms.Label labelAbovePrice;
        private System.Windows.Forms.RadioButton radioSell;
        private System.Windows.Forms.RadioButton radioPurchase;
        private System.Windows.Forms.Button btnRegisterTransaction;
    }
}