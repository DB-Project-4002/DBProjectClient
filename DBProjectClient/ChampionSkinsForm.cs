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
    public partial class ChampionSkinsForm : Form {
        public string ChampionName { get; set; } = "";

        public ChampionSkinsForm() {
            InitializeComponent();
        }

        private void ChampionSkinsForm_Load(object sender, EventArgs e) {
            UpdateLists();
        }

        private void UpdateLists() {
            var allChampionSkins = Server.GetAllChampionSkins(ChampionName);
            var ownedChampionSkins = Server.GetChampionSkins(Config.AccountId, ChampionName);
            var unownedChampionSkins = allChampionSkins.Where(championSkin => ownedChampionSkins.Find(ownedChampionSkin => championSkin.Name == ownedChampionSkin.Name) == null);

            UnownedListBox.Items.Clear();
            OwnedListBox.Items.Clear();
            foreach (var championSkin in unownedChampionSkins) {
                UnownedListBox.Items.Add(championSkin);
            }
            foreach (var championSkin in ownedChampionSkins) {
                OwnedListBox.Items.Add(championSkin);
            }
        }

        private void BuyChampionSkinButton_Click(object sender, EventArgs e) {
            if (UnownedListBox.SelectedItem != null) {
                var championSkin = (ChampionSkin)UnownedListBox.SelectedItem;
                Server.BuyChampionSkin(Config.AccountId, ChampionName, championSkin.Name);
                UpdateLists();
            }
        }
    }
}
