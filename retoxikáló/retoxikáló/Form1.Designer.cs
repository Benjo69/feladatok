namespace retoxikáló
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fajlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.megnyitásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mentésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itallapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.galeriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sugoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nevjegyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fajlToolStripMenuItem,
            this.itallapToolStripMenuItem,
            this.galeriaToolStripMenuItem,
            this.sugoToolStripMenuItem,
            this.nevjegyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(725, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fajlToolStripMenuItem
            // 
            this.fajlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.megnyitásToolStripMenuItem,
            this.mentésToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.fajlToolStripMenuItem.Name = "fajlToolStripMenuItem";
            this.fajlToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fajlToolStripMenuItem.Text = "Fájl";
            // 
            // megnyitásToolStripMenuItem
            // 
            this.megnyitásToolStripMenuItem.Name = "megnyitásToolStripMenuItem";
            this.megnyitásToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.megnyitásToolStripMenuItem.Text = "Megnyitás  ";
            this.megnyitásToolStripMenuItem.Click += new System.EventHandler(this.megnyitásToolStripMenuItem_Click);
            // 
            // mentésToolStripMenuItem
            // 
            this.mentésToolStripMenuItem.Name = "mentésToolStripMenuItem";
            this.mentésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mentésToolStripMenuItem.Text = "Mentés";
            this.mentésToolStripMenuItem.Click += new System.EventHandler(this.mentésToolStripMenuItem_Click);
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // itallapToolStripMenuItem
            // 
            this.itallapToolStripMenuItem.Enabled = false;
            this.itallapToolStripMenuItem.Name = "itallapToolStripMenuItem";
            this.itallapToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.itallapToolStripMenuItem.Text = "Itallap";
            // 
            // galeriaToolStripMenuItem
            // 
            this.galeriaToolStripMenuItem.Name = "galeriaToolStripMenuItem";
            this.galeriaToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.galeriaToolStripMenuItem.Text = "Galéria";
            this.galeriaToolStripMenuItem.Click += new System.EventHandler(this.galeriaToolStripMenuItem_Click);
            // 
            // sugoToolStripMenuItem
            // 
            this.sugoToolStripMenuItem.Name = "sugoToolStripMenuItem";
            this.sugoToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.sugoToolStripMenuItem.Text = "Súgó";
            // 
            // nevjegyToolStripMenuItem
            // 
            this.nevjegyToolStripMenuItem.Name = "nevjegyToolStripMenuItem";
            this.nevjegyToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.nevjegyToolStripMenuItem.Text = "Névjegy";
            this.nevjegyToolStripMenuItem.Click += new System.EventHandler(this.nevjegyToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(725, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Nyertes kocsma";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fajlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itallapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem galeriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sugoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nevjegyToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem megnyitásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mentésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
    }
}

