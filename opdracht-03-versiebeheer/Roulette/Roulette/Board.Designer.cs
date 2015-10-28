namespace Roulette
{
    partial class BoardView
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
            this.Number = new System.Windows.Forms.Label();
            this.Bet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Number
            // 
            this.Number.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Number.Cursor = System.Windows.Forms.Cursors.Default;
            this.Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Number.Location = new System.Drawing.Point(0, 0);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(39, 56);
            this.Number.TabIndex = 0;
            this.Number.Text = "1";
            this.Number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Number.Click += new System.EventHandler(this.Number_Click);
            // 
            // Bet
            // 
            this.Bet.AutoSize = true;
            this.Bet.Location = new System.Drawing.Point(13, 0);
            this.Bet.Name = "Bet";
            this.Bet.Size = new System.Drawing.Size(13, 13);
            this.Bet.TabIndex = 1;
            this.Bet.Text = "0";
            this.Bet.Click += new System.EventHandler(this.Bet_Click);
            // 
            // BoardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.Bet);
            this.Controls.Add(this.Number);
            this.Name = "BoardView";
            this.Size = new System.Drawing.Size(42, 56);
            this.Load += new System.EventHandler(this.BoardView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.Label Bet;
    }
}
