namespace úszóverseny2
{
    partial class NevjegyForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNevjegy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNevjegy
            // 
            this.txtNevjegy.Enabled = false;
            this.txtNevjegy.Location = new System.Drawing.Point(12, 12);
            this.txtNevjegy.Name = "txtNevjegy";
            this.txtNevjegy.Size = new System.Drawing.Size(262, 20);
            this.txtNevjegy.TabIndex = 0;
            // 
            // NevjegyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(286, 48);
            this.Controls.Add(this.txtNevjegy);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "NevjegyForm";
            this.Text = "Névjegy";
            this.Load += new System.EventHandler(this.NevjegyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNevjegy;
    }
}