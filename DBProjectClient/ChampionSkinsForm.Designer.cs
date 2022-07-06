﻿namespace DBProjectClient {
    partial class ChampionSkinsForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.OwnedListBox = new System.Windows.Forms.ListBox();
            this.UnownedListBox = new System.Windows.Forms.ListBox();
            this.OwnedLabel = new System.Windows.Forms.Label();
            this.UnownedLabel = new System.Windows.Forms.Label();
            this.BuyChampionSkinButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OwnedListBox
            // 
            this.OwnedListBox.FormattingEnabled = true;
            this.OwnedListBox.ItemHeight = 15;
            this.OwnedListBox.Location = new System.Drawing.Point(12, 27);
            this.OwnedListBox.Name = "OwnedListBox";
            this.OwnedListBox.Size = new System.Drawing.Size(188, 379);
            this.OwnedListBox.TabIndex = 0;
            // 
            // UnownedListBox
            // 
            this.UnownedListBox.FormattingEnabled = true;
            this.UnownedListBox.ItemHeight = 15;
            this.UnownedListBox.Location = new System.Drawing.Point(206, 27);
            this.UnownedListBox.Name = "UnownedListBox";
            this.UnownedListBox.Size = new System.Drawing.Size(188, 379);
            this.UnownedListBox.TabIndex = 0;
            // 
            // OwnedLabel
            // 
            this.OwnedLabel.AutoSize = true;
            this.OwnedLabel.Location = new System.Drawing.Point(12, 9);
            this.OwnedLabel.Name = "OwnedLabel";
            this.OwnedLabel.Size = new System.Drawing.Size(45, 15);
            this.OwnedLabel.TabIndex = 1;
            this.OwnedLabel.Text = "Owned";
            // 
            // UnownedLabel
            // 
            this.UnownedLabel.AutoSize = true;
            this.UnownedLabel.Location = new System.Drawing.Point(206, 9);
            this.UnownedLabel.Name = "UnownedLabel";
            this.UnownedLabel.Size = new System.Drawing.Size(58, 15);
            this.UnownedLabel.TabIndex = 1;
            this.UnownedLabel.Text = "Unowned";
            // 
            // BuyChampionSkinButton
            // 
            this.BuyChampionSkinButton.Location = new System.Drawing.Point(261, 417);
            this.BuyChampionSkinButton.Name = "BuyChampionSkinButton";
            this.BuyChampionSkinButton.Size = new System.Drawing.Size(78, 23);
            this.BuyChampionSkinButton.TabIndex = 2;
            this.BuyChampionSkinButton.Text = "Buy";
            this.BuyChampionSkinButton.UseVisualStyleBackColor = true;
            this.BuyChampionSkinButton.Click += new System.EventHandler(this.BuyChampionSkinButton_Click);
            // 
            // ChampionSkinsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 452);
            this.Controls.Add(this.BuyChampionSkinButton);
            this.Controls.Add(this.UnownedLabel);
            this.Controls.Add(this.OwnedLabel);
            this.Controls.Add(this.UnownedListBox);
            this.Controls.Add(this.OwnedListBox);
            this.Name = "ChampionSkinsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChampionSkins";
            this.Load += new System.EventHandler(this.ChampionSkinsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox OwnedListBox;
        private ListBox UnownedListBox;
        private Label OwnedLabel;
        private Label UnownedLabel;
        private Button BuyChampionSkinButton;
    }
}