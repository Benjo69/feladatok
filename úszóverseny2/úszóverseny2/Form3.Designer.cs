namespace úszóverseny2
{
    partial class EredmenyForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSzoveg = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBezar = new System.Windows.Forms.Button();
            this.btnOrszagok = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdNev = new System.Windows.Forms.RadioButton();
            this.rdEredmeny = new System.Windows.Forms.RadioButton();
            this.txtRajt = new System.Windows.Forms.TextBox();
            this.txtOrszag = new System.Windows.Forms.TextBox();
            this.txtIdo = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Időeredmény:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ország:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rajtszám:";
            // 
            // lblSzoveg
            // 
            this.lblSzoveg.AutoSize = true;
            this.lblSzoveg.Location = new System.Drawing.Point(246, 33);
            this.lblSzoveg.Name = "lblSzoveg";
            this.lblSzoveg.Size = new System.Drawing.Size(35, 13);
            this.lblSzoveg.TabIndex = 3;
            this.lblSzoveg.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(113, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Résztvevők";
            // 
            // btnBezar
            // 
            this.btnBezar.Location = new System.Drawing.Point(364, 457);
            this.btnBezar.Name = "btnBezar";
            this.btnBezar.Size = new System.Drawing.Size(130, 23);
            this.btnBezar.TabIndex = 5;
            this.btnBezar.Text = "Bezár";
            this.btnBezar.UseVisualStyleBackColor = true;
            this.btnBezar.Click += new System.EventHandler(this.btnBezar_Click);
            // 
            // btnOrszagok
            // 
            this.btnOrszagok.Location = new System.Drawing.Point(79, 457);
            this.btnOrszagok.Name = "btnOrszagok";
            this.btnOrszagok.Size = new System.Drawing.Size(144, 23);
            this.btnOrszagok.TabIndex = 6;
            this.btnOrszagok.Text = "Résztvevő országok";
            this.btnOrszagok.UseVisualStyleBackColor = true;
            this.btnOrszagok.Click += new System.EventHandler(this.btnOrszagok_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdEredmeny);
            this.groupBox1.Controls.Add(this.rdNev);
            this.groupBox1.Location = new System.Drawing.Point(329, 360);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 70);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rendezési szempont:";
            // 
            // rdNev
            // 
            this.rdNev.AutoSize = true;
            this.rdNev.Location = new System.Drawing.Point(6, 19);
            this.rdNev.Name = "rdNev";
            this.rdNev.Size = new System.Drawing.Size(92, 17);
            this.rdNev.TabIndex = 0;
            this.rdNev.TabStop = true;
            this.rdNev.Text = "Névsor szerint";
            this.rdNev.UseVisualStyleBackColor = true;
            this.rdNev.CheckedChanged += new System.EventHandler(this.rdNev_CheckedChanged);
            // 
            // rdEredmeny
            // 
            this.rdEredmeny.AutoSize = true;
            this.rdEredmeny.Location = new System.Drawing.Point(6, 42);
            this.rdEredmeny.Name = "rdEredmeny";
            this.rdEredmeny.Size = new System.Drawing.Size(105, 17);
            this.rdEredmeny.TabIndex = 1;
            this.rdEredmeny.TabStop = true;
            this.rdEredmeny.Text = "Eredmény szerint";
            this.rdEredmeny.UseVisualStyleBackColor = true;
            this.rdEredmeny.CheckedChanged += new System.EventHandler(this.rdEredmeny_CheckedChanged);
            // 
            // txtRajt
            // 
            this.txtRajt.Location = new System.Drawing.Point(394, 124);
            this.txtRajt.Name = "txtRajt";
            this.txtRajt.Size = new System.Drawing.Size(100, 20);
            this.txtRajt.TabIndex = 2;
            // 
            // txtOrszag
            // 
            this.txtOrszag.Location = new System.Drawing.Point(394, 179);
            this.txtOrszag.Name = "txtOrszag";
            this.txtOrszag.Size = new System.Drawing.Size(100, 20);
            this.txtOrszag.TabIndex = 3;
            // 
            // txtIdo
            // 
            this.txtIdo.Enabled = false;
            this.txtIdo.Location = new System.Drawing.Point(394, 235);
            this.txtIdo.Name = "txtIdo";
            this.txtIdo.Size = new System.Drawing.Size(100, 20);
            this.txtIdo.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(32, 124);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(249, 303);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // EredmenyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(560, 505);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtRajt);
            this.Controls.Add(this.txtOrszag);
            this.Controls.Add(this.txtIdo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOrszagok);
            this.Controls.Add(this.btnBezar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSzoveg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EredmenyForm";
            this.Text = "Eredmények";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSzoveg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBezar;
        private System.Windows.Forms.Button btnOrszagok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdEredmeny;
        private System.Windows.Forms.RadioButton rdNev;
        private System.Windows.Forms.TextBox txtRajt;
        private System.Windows.Forms.TextBox txtOrszag;
        private System.Windows.Forms.TextBox txtIdo;
        private System.Windows.Forms.ListBox listBox1;
    }
}