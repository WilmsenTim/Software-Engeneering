namespace Roulette
{
    partial class MakeBetView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BetLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BetLabel
            // 
            this.BetLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BetLabel.Location = new System.Drawing.Point(-1, 0);
            this.BetLabel.Name = "BetLabel";
            this.BetLabel.Size = new System.Drawing.Size(38, 35);
            this.BetLabel.TabIndex = 0;
            this.BetLabel.Text = "1";
            this.BetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BetLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // MakeBetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BetLabel);
            this.Name = "MakeBetView";
            this.Size = new System.Drawing.Size(38, 36);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label BetLabel;
    }
}
