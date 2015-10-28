namespace YahtzeeTeerling
{
    partial class TeerlingView
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
            this.lbl_teerling = new System.Windows.Forms.Label();
            this.btn_werp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_teerling
            // 
            this.lbl_teerling.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_teerling.Location = new System.Drawing.Point(16, 13);
            this.lbl_teerling.Name = "lbl_teerling";
            this.lbl_teerling.Size = new System.Drawing.Size(177, 172);
            this.lbl_teerling.TabIndex = 0;
            this.lbl_teerling.Text = "teerling";
            this.lbl_teerling.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_teerling.Click += new System.EventHandler(this.lbl_teerling_Click);
            // 
            // btn_werp
            // 
            this.btn_werp.Location = new System.Drawing.Point(16, 200);
            this.btn_werp.Name = "btn_werp";
            this.btn_werp.Size = new System.Drawing.Size(177, 47);
            this.btn_werp.TabIndex = 1;
            this.btn_werp.Text = "Werp";
            this.btn_werp.UseVisualStyleBackColor = true;
            this.btn_werp.Click += new System.EventHandler(this.btn_werp_Click);
            // 
            // TeerlingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_werp);
            this.Controls.Add(this.lbl_teerling);
            this.Name = "TeerlingView";
            this.Size = new System.Drawing.Size(210, 260);
            this.Load += new System.EventHandler(this.TeerlingView_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_werp;
        private System.Windows.Forms.Label lbl_teerling;
    }
}
