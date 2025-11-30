using _014___firstWindowsForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace _014___firstWindowsForm
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool IsSuccess = false;

            string userName = this.userNameTextBox.Text;
            string password = this.passTextBox.Text;

            if (File.Exists("users.json"))
            {
                string json = File.ReadAllText("users.json");
                UserData.Users = JsonSerializer.Deserialize<List<UserLogin>>(json);
            }

            for (int i = 0; i < UserData.Users.Count; i++)
            {
                if (UserData.Users[i].userName == userName && UserData.Users[i].Pass == password)
                {
                    IsSuccess = true;
                    break;
                }
            }

            if (IsSuccess)
            {
                Products products = new Products();
                products.Show();
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            CreateFreeAccount form1 = new CreateFreeAccount();
            form1.Show();
        }

        
    }
}
