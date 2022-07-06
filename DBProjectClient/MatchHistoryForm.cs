using DBProjectClient.Types;
using DBProjectClient.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBProjectClient {
    public partial class MatchHistoryForm : Form {
        public MatchHistoryForm() {
            InitializeComponent();
        }

        private void MatchHistoryForm_Load(object sender, EventArgs e) {
            UpdateList();
        }

        private void UpdateList() {
            var matches = Server.GetMatchHistory(Config.AccountId);
            //var accountIds = matches.Select(match => match.AccountId).Distinct();
            //var accountUsernames = accountIds.Select(accountId => Server.GetAccount(accountId)).ToDictionary(account => account.id, account => $"{account.name}#{account.tag}");
            //matches.ForEach(match => { match.AccountUsername = accountUsernames[match.AccountId]; });
            
            MatchesListBox.Items.Clear();
            foreach (var match in matches) {
                MatchesListBox.Items.Add(match);
            }
        }

        private void ViewMatchButton_Click(object sender, EventArgs e) {
            if (MatchesListBox.SelectedItem is MatchParticipation match) {
                MatchForm matchForm = new MatchForm {
                    Time = match.Time
                };
                matchForm.ShowDialog();
            }

        }
    }
}
