namespace Roulette
{
    partial class MoneyView
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
            this.lbl_money = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_money
            // 
            this.lbl_money.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_money.Location = new System.Drawing.Point(4, 4);
            this.lbl_money.Name = "lbl_money";
            this.lbl_money.Size = new System.Drawing.Size(228, 48);
            this.lbl_money.TabIndex = 0;
            this.lbl_money.Text = "Money : 0";
            this.lbl_money.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MoneyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_money);
            this.Name = "MoneyView";
            this.Size = new System.Drawing.Size(235, 63);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_money;
    }
}
