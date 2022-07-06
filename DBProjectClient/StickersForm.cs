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
    public partial class StickersForm : Form {
        public StickersForm() {
            InitializeComponent();
        }

        private void StickersForm_Load(object sender, EventArgs e) {
            UpdateLists();
        }

        private void UpdateLists() {
            var allStickers = Server.GetAllStickers();
            var ownedStickers = Server.GetStickers(Config.AccountId);
            var unownedStickers = allStickers.Where(sticker => ownedStickers.Find(ownedSticker => sticker.Name == ownedSticker.Name) == null);

            UnownedListBox.Items.Clear();
            OwnedListBox.Items.Clear();
            foreach (var sticker in unownedStickers) {
                UnownedListBox.Items.Add(sticker);
            }
            foreach (var sticker in ownedStickers) {
                OwnedListBox.Items.Add(sticker);
            }
        }

        private void BuyStickerButton_Click(object sender, EventArgs e) {
            if (UnownedListBox.SelectedItem != null) {
                var sticker = (Sticker)UnownedListBox.SelectedItem;
                Server.BuySticker(Config.AccountId, sticker.Name);
                UpdateLists();
            }
        }
    }
}
