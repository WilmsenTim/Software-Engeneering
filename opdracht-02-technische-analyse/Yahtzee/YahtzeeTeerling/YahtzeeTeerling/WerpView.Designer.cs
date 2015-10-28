namespace YahtzeeTeerling
{
    partial class WerpView
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
            this.btn_werp_alles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_werp_alles
            // 
            this.btn_werp_alles.Location = new System.Drawing.Point(16, 14);
            this.btn_werp_alles.Name = "btn_werp_alles";
            this.btn_werp_alles.Size = new System.Drawing.Size(130, 32);
            this.btn_werp_alles.TabIndex = 0;
            this.btn_werp_alles.Text = "Werp Alles!!";
            this.btn_werp_alles.UseVisualStyleBackColor = true;
            this.btn_werp_alles.Click += new System.EventHandler(this.btn_werp_alles_Click);
            // 
            // WerpView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_werp_alles);
            this.Name = "WerpView";
            this.Size = new System.Drawing.Size(164, 58);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_werp_alles;
    }
}
