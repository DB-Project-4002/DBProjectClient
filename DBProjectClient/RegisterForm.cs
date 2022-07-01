using DBProjectClient.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBProjectClient {
    public partial class RegisterForm : Form {
        public RegisterForm() {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e) {
            if (EmailTextBox.Text == "" || NameTextBox.Text == "" || TagTextBox.Text == "" || PasswordTextBox.Text == "") {
                MessageBox.Show("Enter all parts");
                return;
            }
            if (!Regex.IsMatch(EmailTextBox.Text, ".+@.+[.].+")) {
                MessageBox.Show("Email is invalid");
                return;
            }
            if (TagTextBox.Text.Length < 3 || TagTextBox.Text.Length > 5) {
                MessageBox.Show("Tag must be 3 to 5 characters");
                return;
            }
            try {
                Server.Register(EmailTextBox.Text, $"{NameTextBox.Text}#{TagTextBox.Text}", PasswordTextBox.Text);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
