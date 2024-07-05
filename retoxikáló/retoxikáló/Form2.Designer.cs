namespace retoxikáló
{
    partial class ItalLapForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.szamlatKerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fizetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRendel = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(298, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Árlista";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(112, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 310);
            this.panel1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szamlatKerToolStripMenuItem,
            this.fizetToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 48);
            // 
            // szamlatKerToolStripMenuItem
            // 
            this.szamlatKerToolStripMenuItem.Name = "szamlatKerToolStripMenuItem";
            this.szamlatKerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.szamlatKerToolStripMenuItem.Text = "Számlát kér";
            this.szamlatKerToolStripMenuItem.Click += new System.EventHandler(this.szamlatKerToolStripMenuItem_Click);
            // 
            // fizetToolStripMenuItem
            // 
            this.fizetToolStripMenuItem.Name = "fizetToolStripMenuItem";
            this.fizetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fizetToolStripMenuItem.Text = "Fizet";
            this.fizetToolStripMenuItem.Click += new System.EventHandler(this.fizetToolStripMenuItem_Click);
            // 
            // btnRendel
            // 
            this.btnRendel.ContextMenuStrip = this.contextMenuStrip1;
            this.btnRendel.Location = new System.Drawing.Point(304, 419);
            this.btnRendel.Name = "btnRendel";
            this.btnRendel.Size = new System.Drawing.Size(75, 23);
            this.btnRendel.TabIndex = 3;
            this.btnRendel.Text = "Rendel";
            this.btnRendel.UseVisualStyleBackColor = true;
            this.btnRendel.Click += new System.EventHandler(this.btnRendel_Click);
            // 
            // ItalLapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(725, 450);
            this.Controls.Add(this.btnRendel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ItalLapForm";
            this.Text = "Ital lap";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnRendel;
        private System.Windows.Forms.ToolStripMenuItem szamlatKerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fizetToolStripMenuItem;
    }
}