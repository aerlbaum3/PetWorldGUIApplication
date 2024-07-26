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

namespace StoreMangement
{
    public partial class Form1 : Form

    {
        //initialize dbml
        private readonly DataClasses2DataContext db = new DataClasses2DataContext();
       
        public Form1()
        {
            InitializeComponent();
        }
        
  
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)

        {

         
            string username = userName_input.Text;
            string password = password_input.Text;

            // Check if the user exists in the database
            var user = db.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                MessageBox.Show("Login Successful");
                PetStore petStore = new PetStore(user);

                petStore.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password.");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
