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
    public partial class MatchForm : Form {
        public DateTime Time { get; set; }

        public MatchForm() {
            InitializeComponent();
        }

        private void MatchForm_Load(object sender, EventArgs e) {
            UpdateList();
        }

        private void UpdateList() {
            var matches = Server.GetMatch(Config.AccountId, Time);
            //var accountIds = matches.Select(match => match.AccountId).Distinct();
            //var accountUsernames = accountIds.Select(accountId => Server.GetAccount(accountId)).ToDictionary(account => account.id, account => $"{account.name}#{account.tag}");
            //matches.ForEach(match => { match.AccountUsername = accountUsernames[match.AccountId]; });
            
            MatchListBox.Items.Clear();
            foreach (var match in matches.Where(match => match.Team == "BLUE")) {
                MatchListBox.Items.Add(match);
            }
            MatchListBox.Items.Add("--------------------------------------------------------------------------");
            foreach (var match in matches.Where(match => match.Team == "RED")) {
                MatchListBox.Items.Add(match);
            }
        }
    }
}
