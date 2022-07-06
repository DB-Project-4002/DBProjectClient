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
    public partial class LootsForm : Form {
        public LootsForm() {
            InitializeComponent();
        }

        private void LootsForm_Load(object sender, EventArgs e) {
            UpdateLists();
        }

        private void UpdateLists() {
            var allLoots = Server.GetAllLoots();
            var ownedLoots = Server.GetLoots(Config.AccountId);
            //var unownedLoots = allLoots.Where(loot => ownedLoots.Find(ownedLoot => loot.Name == ownedLoot.Name) == null);

            AllListBox.Items.Clear();
            OwnedListBox.Items.Clear();
            foreach (var Loot in allLoots) {
                AllListBox.Items.Add(Loot);
            }
            foreach (var Loot in ownedLoots) {
                OwnedListBox.Items.Add(Loot);
            }
        }

        private void BuyLootButton_Click(object sender, EventArgs e) {
            if (AllListBox.SelectedItem != null) {
                var loot = (Loot)AllListBox.SelectedItem;
                Server.BuyLoot(Config.AccountId, loot.Name);
                UpdateLists();
            }
        }
    }
}
