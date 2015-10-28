namespace Roulette
{
    partial class SpinView
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
            this.Spin = new System.Windows.Forms.Label();
            this.btn_spin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Spin
            // 
            this.Spin.BackColor = System.Drawing.Color.White;
            this.Spin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Spin.Location = new System.Drawing.Point(16, 13);
            this.Spin.Name = "Spin";
            this.Spin.Size = new System.Drawing.Size(191, 154);
            this.Spin.TabIndex = 0;
            this.Spin.Text = "spin";
            this.Spin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_spin
            // 
            this.btn_spin.Location = new System.Drawing.Point(16, 194);
            this.btn_spin.Name = "btn_spin";
            this.btn_spin.Size = new System.Drawing.Size(191, 42);
            this.btn_spin.TabIndex = 1;
            this.btn_spin.Text = "SPIN";
            this.btn_spin.UseVisualStyleBackColor = true;
            this.btn_spin.Click += new System.EventHandler(this.btn_spin_Click);
            // 
            // SpinView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.Controls.Add(this.btn_spin);
            this.Controls.Add(this.Spin);
            this.Name = "SpinView";
            this.Size = new System.Drawing.Size(226, 262);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Spin;
        private System.Windows.Forms.Button btn_spin;
    }
}
