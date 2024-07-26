using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreMangement
{
    public partial class AccountInfo : Form
    {

        private readonly DataClasses2DataContext conn = new DataClasses2DataContext();

        private decimal balance;
        private Purchase purchases;
        private User user;


        
        public AccountInfo(User user)
        {
            this.user = user;
            InitializeComponent();
        }

    
        private void AccountInfo_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'purchasesDataSet.Purchases' table. You can move, or remove it, as needed.
            this.purchasesTableAdapter.Fill(this.purchasesDataSet.Purchases);
            LoadAllPurchases();
            InitializeDataGridView();
            

        }

        //add the columns ItemName and TotalPrice to the gridView bec they are not part of Purchases table
        private void InitializeDataGridView()
        {
            if (!dataGridView1.Columns.Contains("ItemName"))
            {
                dataGridView1.Columns.Add("ItemName", "ItemName");
            }
            if (!dataGridView1.Columns.Contains("TotalPrice"))
            {
                dataGridView1.Columns.Add("TotalPrice", "TotalPrice");
            }
        }

        private void LoadAllPurchases()
        {
            var allPurchases = conn.Purchases
                .Where(p => p.UserId == user.UserId)
                .Select(p => new
                {
                    p.PurchaseDate,
                    p.UserId,
                    p.ItemId,
                    ItemName = p.Item.ItemName,
                    p.Quantity,
                    TotalPrice = p.Item.Price * p.Quantity
                }).ToList();

            addDataToDataGridView(allPurchases);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void balance_button_Click(object sender, EventArgs e)
        {
            balance = (decimal)user.Balance;
            MessageBox.Show("Your Balance is: " + balance);
        }

        private void pay_button_Click(object sender, EventArgs e)
        {
            
            {
                //Make sure payment value is valid
                decimal paymentAmount;
                if (!decimal.TryParse(payment_box.Text, out paymentAmount) || paymentAmount <= 0)
                {
                    MessageBox.Show("Please enter a valid payment amount.");
                    return;
                }

                
                User userToUpdate = conn.Users.Single(u => u.UserId == user.UserId);

                // Calculate the new balance by subtracting the payment amount
                userToUpdate.Balance -= (double)paymentAmount;

                
                conn.SubmitChanges();

                // Update the current user's balance in the application
                user.Balance = userToUpdate.Balance;
                MessageBox.Show("Payment successful!");
            }

        }

        private void return_to_store_Click_1(object sender, EventArgs e)
        {
            PetStore petStore = new PetStore(user);
            petStore.Show();
            this.Hide();

        }

        private void payment_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void see_all_purchases_button_Click(object sender, EventArgs e)
        {
            LoadAllPurchases();
        }

        private void filter_button_byPrice_Click(object sender, EventArgs e)
        {

            if (decimal.TryParse(min_input.Text, out decimal minPrice) && decimal.TryParse(max_input.Text, out decimal maxPrice))
            {
                var filteredByPrice = conn.Purchases
                    .Where(p => p.UserId == user.UserId && p.Item.Price * p.Quantity >= minPrice && p.Item.Price * p.Quantity <= maxPrice)
                    .Select(p => new
                    {
                        p.PurchaseDate,
                        p.ItemId,
                        ItemName = p.Item.ItemName,
                        p.Quantity,
                        TotalPrice = p.Item.Price * p.Quantity
                    }).ToList();

                addDataToDataGridView(filteredByPrice);
            }
            else
            {
                MessageBox.Show("Please enter valid price values.");
            }
        }

      private void addDataToDataGridView(IEnumerable<dynamic> purchases)
        {
            dataGridView1.DataSource = purchases.ToList();

            if (dataGridView1.Columns["ItemName"] != null)
                dataGridView1.Columns["ItemName"].DataPropertyName = "ItemName";
            if (dataGridView1.Columns["TotalPrice"] != null)
                dataGridView1.Columns["TotalPrice"].DataPropertyName = "TotalPrice";

            if (dataGridView1.Columns["TotalPrice"] != null)
                dataGridView1.Columns["TotalPrice"].DefaultCellStyle.Format = "N2";
        }

        private void filter_button_byDate_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value.Date;

            var filteredByDate = conn.Purchases
                .Where(p => p.UserId == user.UserId && p.PurchaseDate.Date == selectedDate)
                .Select(p => new
                {
                    p.PurchaseDate,
                    p.ItemId,
                    ItemName = p.Item.ItemName,
                    p.Quantity,
                    TotalPrice = p.Item.Price * p.Quantity
                }).ToList();

            addDataToDataGridView(filteredByDate);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void min_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void max_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

