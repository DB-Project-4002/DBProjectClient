namespace DBProjectClient {
    partial class MainForm {
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
            this.AvatarPictureBox = new System.Windows.Forms.PictureBox();
            this.AvatarBorderPictureBox = new System.Windows.Forms.PictureBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.FriendsListBox = new System.Windows.Forms.ListBox();
            this.TagLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.TagTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.FriendButton = new System.Windows.Forms.Button();
            this.BlockButton = new System.Windows.Forms.Button();
            this.UnfriendButton = new System.Windows.Forms.Button();
            this.UnblockButton = new System.Windows.Forms.Button();
            this.MatchHistoryButton = new System.Windows.Forms.Button();
            this.ChampionsButton = new System.Windows.Forms.Button();
            this.LootsButton = new System.Windows.Forms.Button();
            this.StickersButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarBorderPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AvatarPictureBox
            // 
            this.AvatarPictureBox.Location = new System.Drawing.Point(12, 12);
            this.AvatarPictureBox.Name = "AvatarPictureBox";
            this.AvatarPictureBox.Size = new System.Drawing.Size(70, 70);
            this.AvatarPictureBox.TabIndex = 0;
            this.AvatarPictureBox.TabStop = false;
            // 
            // AvatarBorderPictureBox
            // 
            this.AvatarBorderPictureBox.Location = new System.Drawing.Point(12, 12);
            this.AvatarBorderPictureBox.Name = "AvatarBorderPictureBox";
            this.AvatarBorderPictureBox.Size = new System.Drawing.Size(70, 70);
            this.AvatarBorderPictureBox.TabIndex = 0;
            this.AvatarBorderPictureBox.TabStop = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(88, 37);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(0, 15);
            this.NameLabel.TabIndex = 1;
            // 
            // FriendsListBox
            // 
            this.FriendsListBox.FormattingEnabled = true;
            this.FriendsListBox.ItemHeight = 15;
            this.FriendsListBox.Location = new System.Drawing.Point(285, 12);
            this.FriendsListBox.Name = "FriendsListBox";
            this.FriendsListBox.Size = new System.Drawing.Size(184, 334);
            this.FriendsListBox.TabIndex = 2;
            // 
            // TagLabel
            // 
            this.TagLabel.AutoSize = true;
            this.TagLabel.Location = new System.Drawing.Point(403, 370);
            this.TagLabel.Name = "TagLabel";
            this.TagLabel.Size = new System.Drawing.Size(14, 15);
            this.TagLabel.TabIndex = 12;
            this.TagLabel.Text = "#";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(285, 349);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(60, 15);
            this.UsernameLabel.TabIndex = 13;
            this.UsernameLabel.Text = "Username";
            // 
            // TagTextBox
            // 
            this.TagTextBox.Location = new System.Drawing.Point(419, 367);
            this.TagTextBox.Name = "TagTextBox";
            this.TagTextBox.Size = new System.Drawing.Size(50, 23);
            this.TagTextBox.TabIndex = 11;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(285, 367);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(116, 23);
            this.NameTextBox.TabIndex = 10;
            // 
            // FriendButton
            // 
            this.FriendButton.Location = new System.Drawing.Point(285, 396);
            this.FriendButton.Name = "FriendButton";
            this.FriendButton.Size = new System.Drawing.Size(89, 23);
            this.FriendButton.TabIndex = 14;
            this.FriendButton.Text = "Friend";
            this.FriendButton.UseVisualStyleBackColor = true;
            this.FriendButton.Click += new System.EventHandler(this.FriendButton_Click);
            // 
            // BlockButton
            // 
            this.BlockButton.Location = new System.Drawing.Point(380, 396);
            this.BlockButton.Name = "BlockButton";
            this.BlockButton.Size = new System.Drawing.Size(89, 23);
            this.BlockButton.TabIndex = 14;
            this.BlockButton.Text = "Block";
            this.BlockButton.UseVisualStyleBackColor = true;
            this.BlockButton.Click += new System.EventHandler(this.BlockButton_Click);
            // 
            // UnfriendButton
            // 
            this.UnfriendButton.Location = new System.Drawing.Point(285, 425);
            this.UnfriendButton.Name = "UnfriendButton";
            this.UnfriendButton.Size = new System.Drawing.Size(89, 23);
            this.UnfriendButton.TabIndex = 14;
            this.UnfriendButton.Text = "Unfriend";
            this.UnfriendButton.UseVisualStyleBackColor = true;
            this.UnfriendButton.Click += new System.EventHandler(this.UnfriendButton_Click);
            // 
            // UnblockButton
            // 
            this.UnblockButton.Location = new System.Drawing.Point(380, 425);
            this.UnblockButton.Name = "UnblockButton";
            this.UnblockButton.Size = new System.Drawing.Size(89, 23);
            this.UnblockButton.TabIndex = 14;
            this.UnblockButton.Text = "Unblock";
            this.UnblockButton.UseVisualStyleBackColor = true;
            this.UnblockButton.Click += new System.EventHandler(this.UnblockButton_Click);
            // 
            // MatchHistoryButton
            // 
            this.MatchHistoryButton.Location = new System.Drawing.Point(12, 134);
            this.MatchHistoryButton.Name = "MatchHistoryButton";
            this.MatchHistoryButton.Size = new System.Drawing.Size(267, 74);
            this.MatchHistoryButton.TabIndex = 15;
            this.MatchHistoryButton.Text = "Match History";
            this.MatchHistoryButton.UseVisualStyleBackColor = true;
            this.MatchHistoryButton.Click += new System.EventHandler(this.MatchHistoryButton_Click);
            // 
            // ChampionsButton
            // 
            this.ChampionsButton.Location = new System.Drawing.Point(12, 214);
            this.ChampionsButton.Name = "ChampionsButton";
            this.ChampionsButton.Size = new System.Drawing.Size(267, 74);
            this.ChampionsButton.TabIndex = 15;
            this.ChampionsButton.Text = "Champions";
            this.ChampionsButton.UseVisualStyleBackColor = true;
            this.ChampionsButton.Click += new System.EventHandler(this.ChampionsButton_Click);
            // 
            // LootsButton
            // 
            this.LootsButton.Location = new System.Drawing.Point(12, 294);
            this.LootsButton.Name = "LootsButton";
            this.LootsButton.Size = new System.Drawing.Size(267, 74);
            this.LootsButton.TabIndex = 15;
            this.LootsButton.Text = "Loots";
            this.LootsButton.UseVisualStyleBackColor = true;
            this.LootsButton.Click += new System.EventHandler(this.LootsButton_Click);
            // 
            // StickersButton
            // 
            this.StickersButton.Location = new System.Drawing.Point(12, 374);
            this.StickersButton.Name = "StickersButton";
            this.StickersButton.Size = new System.Drawing.Size(267, 74);
            this.StickersButton.TabIndex = 15;
            this.StickersButton.Text = "Stickers";
            this.StickersButton.UseVisualStyleBackColor = true;
            this.StickersButton.Click += new System.EventHandler(this.StickersButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 460);
            this.Controls.Add(this.StickersButton);
            this.Controls.Add(this.LootsButton);
            this.Controls.Add(this.ChampionsButton);
            this.Controls.Add(this.MatchHistoryButton);
            this.Controls.Add(this.BlockButton);
            this.Controls.Add(this.UnblockButton);
            this.Controls.Add(this.UnfriendButton);
            this.Controls.Add(this.FriendButton);
            this.Controls.Add(this.TagLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.TagTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.FriendsListBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.AvatarBorderPictureBox);
            this.Controls.Add(this.AvatarPictureBox);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarBorderPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox AvatarPictureBox;
        private PictureBox AvatarBorderPictureBox;
        private Label NameLabel;
        private ListBox FriendsListBox;
        private Label TagLabel;
        private Label UsernameLabel;
        private TextBox TagTextBox;
        private TextBox NameTextBox;
        private Button FriendButton;
        private Button BlockButton;
        private Button UnfriendButton;
        private Button UnblockButton;
        private Button MatchHistoryButton;
        private Button ChampionsButton;
        private Button LootsButton;
        private Button StickersButton;
    }
}