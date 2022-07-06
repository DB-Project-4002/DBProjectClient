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
    public partial class ChampionsForm : Form {
        public ChampionsForm() {
            InitializeComponent();
        }

        private void ChampionsForm_Load(object sender, EventArgs e) {
            UpdateLists();
        }

        private void UpdateLists() {
            var allChampions = Server.GetAllChampions();
            var ownedChampions = Server.GetChampions(Config.AccountId);
            var unownedChampions = allChampions.Where(champion => ownedChampions.Find(ownedChampion => champion.Name == ownedChampion.Name) == null);

            UnownedListBox.Items.Clear();
            OwnedListBox.Items.Clear();
            foreach (var champion in unownedChampions) {
                UnownedListBox.Items.Add(champion);
            }
            foreach (var champion in ownedChampions) {
                OwnedListBox.Items.Add(champion);
            }
        }

        private void SkinsButton_Click(object sender, EventArgs e) {
            if (OwnedListBox.SelectedItem != null) {
                ChampionSkinsForm championSkinsForm = new ChampionSkinsForm();
                var champion = (Champion)OwnedListBox.SelectedItem;
                championSkinsForm.ChampionName = champion.Name;
                championSkinsForm.ShowDialog();
            }
        }

        private void BuyChampionButton_Click(object sender, EventArgs e) {
            if (UnownedListBox.SelectedItem != null) {
                var champion = (Champion)UnownedListBox.SelectedItem;
                Server.BuyChampion(Config.AccountId, champion.Name);
                UpdateLists();
            }
        }
    }
}
