using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Linq;

namespace StoreMangement
{
    public partial class PetStore : Form
    {

        //initialize dbml connection
        private readonly DataClasses2DataContext conn = new DataClasses2DataContext();

        private Item selectedItem;
        private User currUser;


        public PetStore(User user)
        {
            currUser = user;
            InitializeComponent();
            LoadProductsIntoComboBox();
        }

        
      

        private void LoadProductsIntoComboBox()
        {
            try
            {
                List<Item> items = conn.Items.ToList();
                comboBox1.DataSource = items;
                comboBox1.DisplayMember = "ItemName";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}");
            }

        }
        

        private void PetStore_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeManagementDataSet1.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.storeManagementDataSet1.Items);
            LoadProductsIntoComboBox();


        }

        //not being used products are displayed here just for show
        private void dataGridView_store_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AccountInfo_button_Click(object sender, EventArgs e)
        {
            AccountInfo account = new AccountInfo(currUser);
            account.Show();
            this.Hide();
        }

        private void Purchase_button_Click(object sender, EventArgs e)
        {
            int quantity = (int)numericUpDown_quantity.Value;

            MessageBox.Show("quantity:" + quantity);

            if (selectedItem == null || numericUpDown_quantity.Value <= 0)
            {
                MessageBox.Show("Please select Product");
                return;
            }
             
             decimal totalCost = selectedItem.Price * quantity;
            if ((decimal)currUser.Balance + totalCost > 350) //make sure user doesn't exceed credit limit
            {
                MessageBox.Show("Sorry,you have exceeded your credit limit." +
                    "Pay your balance in order to continue making purchases");
                return;
            }
            
            MessageBox.Show("Total:" + totalCost );
            

            // Retrieve the current user from the database
            User userToUpdate = conn.Users.Single(u => u.UserId == currUser.UserId);

            // Update the user's balance
            userToUpdate.Balance += (double)totalCost;
            double balance = userToUpdate.Balance;

            MessageBox.Show("Balance:" + balance);

            // complete the purchase and add new purchase to the table
            Purchase purchase = new Purchase
            {
                ItemId = selectedItem.ItemId,
                UserId = currUser.UserId,
                Quantity = quantity,
                PurchaseDate = DateTime.Now
            };


            //update the database
            conn.Purchases.InsertOnSubmit(purchase);
            currUser.Balance = userToUpdate.Balance;
            conn.SubmitChanges();

            MessageBox.Show("Successfully purchased by PetWorld!");

            

        }

        private void numericUpDown_quantity_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {

                // Check if an item is selected in the ComboBox
                if (comboBox1.SelectedItem != null)
                {

                    Item item = (Item) comboBox1.SelectedItem;
                    selectedItem = item;

                }
                else
                {
                    MessageBox.Show("Please select an item from the ComboBox.");
                }


                Purchase_button.Enabled = true;

            }
        }

    }
    }

