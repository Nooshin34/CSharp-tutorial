using _014___firstWindowsForm.Models;

namespace _014___firstWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool IsSuccess = false;
            List<UserLogin> users = new List<UserLogin>();
            users.Add(new UserLogin() { userName = "admin", Pass = "1234"});
            users.Add(new UserLogin() { userName = "admin2", Pass = "5678" });

            string userName = this.userNameTextBox.Text;
            string password = this.passTextBox.Text;

            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].userName == userName && users[i].Pass == password)
                {
                    IsSuccess = true;
                    break;
                }
            }

            if (IsSuccess)
            {
                MessageBox.Show("Successfull");
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }
    }
}
