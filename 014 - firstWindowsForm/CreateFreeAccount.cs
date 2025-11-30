using _014___firstWindowsForm.Models;
using System.Text.Json;

namespace _014___firstWindowsForm
{
    public partial class CreateFreeAccount : Form
    {
        public CreateFreeAccount()
        {
            InitializeComponent();
        }

        private void createFreeAccount_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void createFreeAccountButton_Click(object sender, EventArgs e)
        {
            UserData.Users.Add(new UserLogin()
            {
                userName = userNameTextBox.Text,
                Pass = passTextBox.Text
            });


            string json = JsonSerializer.Serialize(UserData.Users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("users.json", json);

            MessageBox.Show("User added!");
        }
    }
}
