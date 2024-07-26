
namespace StoreMangement
{
    partial class AccountInfo
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchasesDataSet = new StoreMangement.purchasesDataSet();
            this.purchasesTableAdapter = new StoreMangement.purchasesDataSetTableAdapters.PurchasesTableAdapter();
            this.balance_button = new System.Windows.Forms.Button();
            this.payment_box = new System.Windows.Forms.TextBox();
            this.pay_button = new System.Windows.Forms.Button();
            this.pay_label = new System.Windows.Forms.Label();
            this.pay_here_label = new System.Windows.Forms.Label();
            this.return_to_store = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.min_input = new System.Windows.Forms.TextBox();
            this.max_input = new System.Windows.Forms.TextBox();
            this.filter_button_byPrice = new System.Windows.Forms.Button();
            this.see_all_purchases_button = new System.Windows.Forms.Button();
            this.filter_button_byDate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIdDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.purchaseDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.purchasesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1036, 201);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // itemIdDataGridViewTextBoxColumn
            // 
            this.itemIdDataGridViewTextBoxColumn.DataPropertyName = "ItemId";
            this.itemIdDataGridViewTextBoxColumn.HeaderText = "ItemId";
            this.itemIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.itemIdDataGridViewTextBoxColumn.Name = "itemIdDataGridViewTextBoxColumn";
            this.itemIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 150;
            // 
            // purchaseDateDataGridViewTextBoxColumn
            // 
            this.purchaseDateDataGridViewTextBoxColumn.DataPropertyName = "PurchaseDate";
            this.purchaseDateDataGridViewTextBoxColumn.HeaderText = "PurchaseDate";
            this.purchaseDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.purchaseDateDataGridViewTextBoxColumn.Name = "purchaseDateDataGridViewTextBoxColumn";
            this.purchaseDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // purchasesBindingSource
            // 
            this.purchasesBindingSource.DataMember = "Purchases";
            this.purchasesBindingSource.DataSource = this.purchasesDataSet;
            // 
            // purchasesDataSet
            // 
            this.purchasesDataSet.DataSetName = "purchasesDataSet";
            this.purchasesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchasesTableAdapter
            // 
            this.purchasesTableAdapter.ClearBeforeFill = true;
            // 
            // balance_button
            // 
            this.balance_button.Location = new System.Drawing.Point(2, 439);
            this.balance_button.Name = "balance_button";
            this.balance_button.Size = new System.Drawing.Size(191, 65);
            this.balance_button.TabIndex = 1;
            this.balance_button.Text = "View Balance";
            this.balance_button.UseVisualStyleBackColor = true;
            this.balance_button.Click += new System.EventHandler(this.balance_button_Click);
            // 
            // payment_box
            // 
            this.payment_box.Location = new System.Drawing.Point(762, 557);
            this.payment_box.Name = "payment_box";
            this.payment_box.Size = new System.Drawing.Size(135, 26);
            this.payment_box.TabIndex = 2;
            this.payment_box.TextChanged += new System.EventHandler(this.payment_box_TextChanged);
            // 
            // pay_button
            // 
            this.pay_button.ForeColor = System.Drawing.Color.Fuchsia;
            this.pay_button.Location = new System.Drawing.Point(923, 522);
            this.pay_button.Name = "pay_button";
            this.pay_button.Size = new System.Drawing.Size(100, 65);
            this.pay_button.TabIndex = 3;
            this.pay_button.Text = "Pay";
            this.pay_button.UseVisualStyleBackColor = true;
            this.pay_button.Click += new System.EventHandler(this.pay_button_Click);
            // 
            // pay_label
            // 
            this.pay_label.AutoSize = true;
            this.pay_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay_label.Location = new System.Drawing.Point(480, 557);
            this.pay_label.Name = "pay_label";
            this.pay_label.Size = new System.Drawing.Size(245, 29);
            this.pay_label.TabIndex = 4;
            this.pay_label.Text = "Enter Amount To Pay:";
            // 
            // pay_here_label
            // 
            this.pay_here_label.AutoSize = true;
            this.pay_here_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay_here_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pay_here_label.Location = new System.Drawing.Point(527, 458);
            this.pay_here_label.Name = "pay_here_label";
            this.pay_here_label.Size = new System.Drawing.Size(370, 46);
            this.pay_here_label.TabIndex = 5;
            this.pay_here_label.Text = "Pay Balance Here:";
            // 
            // return_to_store
            // 
            this.return_to_store.Location = new System.Drawing.Point(2, 522);
            this.return_to_store.Name = "return_to_store";
            this.return_to_store.Size = new System.Drawing.Size(191, 61);
            this.return_to_store.TabIndex = 6;
            this.return_to_store.Text = "Return To Store";
            this.return_to_store.UseVisualStyleBackColor = true;
            this.return_to_store.Click += new System.EventHandler(this.return_to_store_Click_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(23, 59);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(390, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Filter Purchases:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter Min:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Enter Max:";
            // 
            // min_input
            // 
            this.min_input.Location = new System.Drawing.Point(376, 136);
            this.min_input.Name = "min_input";
            this.min_input.Size = new System.Drawing.Size(113, 26);
            this.min_input.TabIndex = 11;
            this.min_input.TextChanged += new System.EventHandler(this.min_input_TextChanged);
            // 
            // max_input
            // 
            this.max_input.Location = new System.Drawing.Point(612, 139);
            this.max_input.Name = "max_input";
            this.max_input.Size = new System.Drawing.Size(113, 26);
            this.max_input.TabIndex = 12;
            this.max_input.TextChanged += new System.EventHandler(this.max_input_TextChanged);
            // 
            // filter_button_byPrice
            // 
            this.filter_button_byPrice.Location = new System.Drawing.Point(742, 114);
            this.filter_button_byPrice.Name = "filter_button_byPrice";
            this.filter_button_byPrice.Size = new System.Drawing.Size(116, 71);
            this.filter_button_byPrice.TabIndex = 14;
            this.filter_button_byPrice.Text = "Filter Price";
            this.filter_button_byPrice.UseVisualStyleBackColor = true;
            this.filter_button_byPrice.Click += new System.EventHandler(this.filter_button_byPrice_Click);
            // 
            // see_all_purchases_button
            // 
            this.see_all_purchases_button.Location = new System.Drawing.Point(888, 114);
            this.see_all_purchases_button.Name = "see_all_purchases_button";
            this.see_all_purchases_button.Size = new System.Drawing.Size(120, 68);
            this.see_all_purchases_button.TabIndex = 15;
            this.see_all_purchases_button.Text = "See All Purchases";
            this.see_all_purchases_button.UseVisualStyleBackColor = true;
            this.see_all_purchases_button.Click += new System.EventHandler(this.see_all_purchases_button_Click);
            // 
            // filter_button_byDate
            // 
            this.filter_button_byDate.Location = new System.Drawing.Point(50, 114);
            this.filter_button_byDate.Name = "filter_button_byDate";
            this.filter_button_byDate.Size = new System.Drawing.Size(117, 68);
            this.filter_button_byDate.TabIndex = 17;
            this.filter_button_byDate.Text = "Filter Date";
            this.filter_button_byDate.UseVisualStyleBackColor = true;
            this.filter_button_byDate.Click += new System.EventHandler(this.filter_button_byDate_Click);
            // 
            // AccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 616);
            this.Controls.Add(this.filter_button_byDate);
            this.Controls.Add(this.see_all_purchases_button);
            this.Controls.Add(this.filter_button_byPrice);
            this.Controls.Add(this.max_input);
            this.Controls.Add(this.min_input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.return_to_store);
            this.Controls.Add(this.pay_here_label);
            this.Controls.Add(this.pay_label);
            this.Controls.Add(this.pay_button);
            this.Controls.Add(this.payment_box);
            this.Controls.Add(this.balance_button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AccountInfo";
            this.Text = "AccountInfo";
            this.Load += new System.EventHandler(this.AccountInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private purchasesDataSet purchasesDataSet;
        private System.Windows.Forms.BindingSource purchasesBindingSource;
        private purchasesDataSetTableAdapters.PurchasesTableAdapter purchasesTableAdapter;
        private System.Windows.Forms.Button balance_button;
        private System.Windows.Forms.TextBox payment_box;
        private System.Windows.Forms.Button pay_button;
        private System.Windows.Forms.Label pay_label;
        private System.Windows.Forms.Label pay_here_label;
        private System.Windows.Forms.Button return_to_store;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox min_input;
        private System.Windows.Forms.TextBox max_input;
        private System.Windows.Forms.Button filter_button_byPrice;
        private System.Windows.Forms.Button see_all_purchases_button;
        private System.Windows.Forms.Button filter_button_byDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseDateDataGridViewTextBoxColumn;
    }
}