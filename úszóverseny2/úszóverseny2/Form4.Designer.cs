namespace úszóverseny2
{
    partial class ZaszloForm
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
            this.pnlOrszagok = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlOrszagok
            // 
            this.pnlOrszagok.Location = new System.Drawing.Point(12, 12);
            this.pnlOrszagok.Name = "pnlOrszagok";
            this.pnlOrszagok.Size = new System.Drawing.Size(423, 286);
            this.pnlOrszagok.TabIndex = 0;
            // 
            // ZaszloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(447, 310);
            this.Controls.Add(this.pnlOrszagok);
            this.Name = "ZaszloForm";
            this.Text = "Résztvevő országok";
            this.Load += new System.EventHandler(this.ZaszloForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOrszagok;
    }
}