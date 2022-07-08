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
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            var account = Server.GetGameAccount(Config.AccountId);
            NameLabel.Text = account.name;
            
            UpdateFriends();
        }

        private void MatchHistoryButton_Click(object sender, EventArgs e) {
            MatchHistoryForm matchHistoryForm = new MatchHistoryForm();
            matchHistoryForm.ShowDialog();
        }

        private void ChampionsButton_Click(object sender, EventArgs e) {
            ChampionsForm championsForm = new ChampionsForm();
            championsForm.ShowDialog();
        }

        private void LootsButton_Click(object sender, EventArgs e) {
            LootsForm lootsForm = new LootsForm();
            lootsForm.ShowDialog();
        }

        private void StickersButton_Click(object sender, EventArgs e) {
            StickersForm stickersForm = new StickersForm();
            stickersForm.ShowDialog();
        }

        private void UpdateFriends() {
            var friends = Server.GetFriends(Config.AccountId);

            FriendsListBox.Items.Clear();
            BlockedsListBox.Items.Clear();
            foreach (var friend in friends) {
                if (friend.IsBlocked) {
                    BlockedsListBox.Items.Add(friend);
                }
                else {
                    FriendsListBox.Items.Add(friend);
                }
            }
        }

        private void FriendButton_Click(object sender, EventArgs e) {
            if(NameTextBox.Text == "" || TagTextBox.Text == "") {
                MessageBox.Show("Please fill all the parts");
                return;
            }
            Server.AddFriend($"{NameTextBox.Text}#{TagTextBox.Text}");
            UpdateFriends();
        }

        private void UnfriendButton_Click(object sender, EventArgs e) {
            if (FriendsListBox.SelectedItem != null) {
                var account = (Account)FriendsListBox.SelectedItem;
                Server.DeleteFriend(account.Id);
                UpdateFriends();
            }
        }

        private void BlockButton_Click(object sender, EventArgs e) {
            if (FriendsListBox.SelectedItem != null) {
                var account = (Account)FriendsListBox.SelectedItem;
                Server.BlockFriend(account.Id);
                UpdateFriends();
            }
        }

        private void UnblockButton_Click(object sender, EventArgs e) {
            if (BlockedsListBox.SelectedItem != null) {
                var account = (Account)BlockedsListBox.SelectedItem;
                Server.DeleteFriend(account.Id);
                UpdateFriends();
            }
        }
    }
}
