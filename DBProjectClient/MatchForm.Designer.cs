namespace DBProjectClient {
    partial class MatchForm {
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
            this.MatchListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // MatchListBox
            // 
            this.MatchListBox.FormattingEnabled = true;
            this.MatchListBox.ItemHeight = 15;
            this.MatchListBox.Location = new System.Drawing.Point(12, 12);
            this.MatchListBox.Name = "MatchListBox";
            this.MatchListBox.Size = new System.Drawing.Size(949, 169);
            this.MatchListBox.TabIndex = 0;
            // 
            // MatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 194);
            this.Controls.Add(this.MatchListBox);
            this.Name = "MatchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Match";
            this.Load += new System.EventHandler(this.MatchForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private ListBox MatchListBox;
    }
}