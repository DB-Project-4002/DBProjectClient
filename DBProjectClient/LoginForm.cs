using DBProjectClient.Util;

namespace DBProjectClient {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e) {
            Config.Load();
            Server.Initialize();
        }

        private void LoginButton_Click(object sender, EventArgs e) {
            if(NameTextBox.Text == "" || TagTextBox.Text == "" || PasswordTextBox.Text == "") {
                MessageBox.Show("Enter all parts");
                return;
            }
            if(TagTextBox.Text.Length < 3 || TagTextBox.Text.Length > 5) {
                MessageBox.Show("Tag must be 3 to 5 characters");
                return;
            }
            try {
                Server.Login($"{NameTextBox.Text}#{TagTextBox.Text}", PasswordTextBox.Text);

                Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
                mainForm.Closed += (s, args) => Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e) {
            Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            registerForm.Closed += (s, args) => Close();
        }

        private void LoginForm_Shown(object sender, EventArgs e) {
            if (Config.AccountId != 0) {
                Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
                mainForm.Closed += (s, args) => Close();
            }
        }
    }
}