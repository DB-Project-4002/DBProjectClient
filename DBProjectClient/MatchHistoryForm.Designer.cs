namespace DBProjectClient {
    partial class MatchHistoryForm {
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
            this.MatchesListBox = new System.Windows.Forms.ListBox();
            this.ViewMatchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MatchesListBox
            // 
            this.MatchesListBox.FormattingEnabled = true;
            this.MatchesListBox.ItemHeight = 15;
            this.MatchesListBox.Location = new System.Drawing.Point(12, 12);
            this.MatchesListBox.Name = "MatchesListBox";
            this.MatchesListBox.Size = new System.Drawing.Size(949, 394);
            this.MatchesListBox.TabIndex = 0;
            // 
            // ViewMatchButton
            // 
            this.ViewMatchButton.Location = new System.Drawing.Point(447, 417);
            this.ViewMatchButton.Name = "ViewMatchButton";
            this.ViewMatchButton.Size = new System.Drawing.Size(79, 23);
            this.ViewMatchButton.TabIndex = 2;
            this.ViewMatchButton.Text = "View";
            this.ViewMatchButton.UseVisualStyleBackColor = true;
            this.ViewMatchButton.Click += new System.EventHandler(this.ViewMatchButton_Click);
            // 
            // MatchHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 452);
            this.Controls.Add(this.ViewMatchButton);
            this.Controls.Add(this.MatchesListBox);
            this.Name = "MatchHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MatchHistory";
            this.Load += new System.EventHandler(this.MatchHistoryForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private ListBox MatchesListBox;
        private Button ViewMatchButton;
    }
}