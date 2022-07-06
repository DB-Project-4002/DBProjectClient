namespace DBProjectClient {
    partial class LootsForm {
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
            this.AllListBox = new System.Windows.Forms.ListBox();
            this.OwnedLabel = new System.Windows.Forms.Label();
            this.AllLabel = new System.Windows.Forms.Label();
            this.BuyLootButton = new System.Windows.Forms.Button();
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
            // AllListBox
            // 
            this.AllListBox.FormattingEnabled = true;
            this.AllListBox.ItemHeight = 15;
            this.AllListBox.Location = new System.Drawing.Point(206, 27);
            this.AllListBox.Name = "AllListBox";
            this.AllListBox.Size = new System.Drawing.Size(188, 379);
            this.AllListBox.TabIndex = 0;
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
            // AllLabel
            // 
            this.AllLabel.AutoSize = true;
            this.AllLabel.Location = new System.Drawing.Point(206, 9);
            this.AllLabel.Name = "AllLabel";
            this.AllLabel.Size = new System.Drawing.Size(21, 15);
            this.AllLabel.TabIndex = 1;
            this.AllLabel.Text = "All";
            // 
            // BuyLootButton
            // 
            this.BuyLootButton.Location = new System.Drawing.Point(261, 417);
            this.BuyLootButton.Name = "BuyLootButton";
            this.BuyLootButton.Size = new System.Drawing.Size(78, 23);
            this.BuyLootButton.TabIndex = 2;
            this.BuyLootButton.Text = "Buy";
            this.BuyLootButton.UseVisualStyleBackColor = true;
            this.BuyLootButton.Click += new System.EventHandler(this.BuyLootButton_Click);
            // 
            // LootsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 452);
            this.Controls.Add(this.BuyLootButton);
            this.Controls.Add(this.AllLabel);
            this.Controls.Add(this.OwnedLabel);
            this.Controls.Add(this.AllListBox);
            this.Controls.Add(this.OwnedListBox);
            this.Name = "LootsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Loots";
            this.Load += new System.EventHandler(this.LootsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox OwnedListBox;
        private ListBox AllListBox;
        private Label OwnedLabel;
        private Label AllLabel;
        private Button BuyLootButton;
    }
}