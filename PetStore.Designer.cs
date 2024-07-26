
namespace StoreMangement
{
    partial class PetStore
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
            this.dataGridView_store = new System.Windows.Forms.DataGridView();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeManagementDataSet1 = new StoreMangement.StoreManagementDataSet1();
            this.itemsTableAdapter = new StoreMangement.StoreManagementDataSet1TableAdapters.ItemsTableAdapter();
            this.numericUpDown_quantity = new System.Windows.Forms.NumericUpDown();
            this.Purchase_button = new System.Windows.Forms.Button();
            this.AccountInfo_button = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_store)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeManagementDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_store
            // 
            this.dataGridView_store.AutoGenerateColumns = false;
            this.dataGridView_store.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView_store.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_store.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView_store.DataSource = this.itemsBindingSource;
            this.dataGridView_store.Location = new System.Drawing.Point(12, 24);
            this.dataGridView_store.Name = "dataGridView_store";
            this.dataGridView_store.RowHeadersWidth = 62;
            this.dataGridView_store.RowTemplate.Height = 28;
            this.dataGridView_store.Size = new System.Drawing.Size(514, 336);
            this.dataGridView_store.TabIndex = 0;
            this.dataGridView_store.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_store_CellContentClick);
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.storeManagementDataSet1;
            // 
            // storeManagementDataSet1
            // 
            this.storeManagementDataSet1.DataSetName = "StoreManagementDataSet1";
            this.storeManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // numericUpDown_quantity
            // 
            this.numericUpDown_quantity.Location = new System.Drawing.Point(586, 99);
            this.numericUpDown_quantity.Name = "numericUpDown_quantity";
            this.numericUpDown_quantity.Size = new System.Drawing.Size(146, 26);
            this.numericUpDown_quantity.TabIndex = 1;
            this.numericUpDown_quantity.ValueChanged += new System.EventHandler(this.numericUpDown_quantity_ValueChanged);
            // 
            // Purchase_button
            // 
            this.Purchase_button.Location = new System.Drawing.Point(668, 297);
            this.Purchase_button.Name = "Purchase_button";
            this.Purchase_button.Size = new System.Drawing.Size(109, 63);
            this.Purchase_button.TabIndex = 2;
            this.Purchase_button.Text = "Purchase";
            this.Purchase_button.UseVisualStyleBackColor = true;
            this.Purchase_button.Click += new System.EventHandler(this.Purchase_button_Click);
            // 
            // AccountInfo_button
            // 
            this.AccountInfo_button.Location = new System.Drawing.Point(607, 375);
            this.AccountInfo_button.Name = "AccountInfo_button";
            this.AccountInfo_button.Size = new System.Drawing.Size(170, 63);
            this.AccountInfo_button.TabIndex = 3;
            this.AccountInfo_button.Text = "View Account";
            this.AccountInfo_button.UseVisualStyleBackColor = true;
            this.AccountInfo_button.Click += new System.EventHandler(this.AccountInfo_button_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 332);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(514, 28);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 150;
            // 
            // PetStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.AccountInfo_button);
            this.Controls.Add(this.Purchase_button);
            this.Controls.Add(this.numericUpDown_quantity);
            this.Controls.Add(this.dataGridView_store);
            this.Name = "PetStore";
            this.Text = "PetStore";
            this.Load += new System.EventHandler(this.PetStore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_store)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeManagementDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_store;
        private StoreManagementDataSet1 storeManagementDataSet1;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private StoreManagementDataSet1TableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.NumericUpDown numericUpDown_quantity;
        private System.Windows.Forms.Button Purchase_button;
        private System.Windows.Forms.Button AccountInfo_button;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}