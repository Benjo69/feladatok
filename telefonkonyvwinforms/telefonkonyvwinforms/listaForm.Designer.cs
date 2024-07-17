namespace telefonkonyvwinforms
{
    partial class listaForm
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
            this.lblNev = new System.Windows.Forms.Label();
            this.lblCim = new System.Windows.Forms.Label();
            this.lblApa = new System.Windows.Forms.Label();
            this.lblAnya = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblNem = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSzemely = new System.Windows.Forms.Label();
            this.btnKovetkezo = new System.Windows.Forms.Button();
            this.btnKilep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "A REKORDOD";
            // 
            // lblNev
            // 
            this.lblNev.AutoSize = true;
            this.lblNev.ForeColor = System.Drawing.Color.Lime;
            this.lblNev.Location = new System.Drawing.Point(12, 84);
            this.lblNev.Name = "lblNev";
            this.lblNev.Size = new System.Drawing.Size(35, 13);
            this.lblNev.TabIndex = 1;
            this.lblNev.Text = "label2";
            // 
            // lblCim
            // 
            this.lblCim.AutoSize = true;
            this.lblCim.ForeColor = System.Drawing.Color.Lime;
            this.lblCim.Location = new System.Drawing.Point(12, 121);
            this.lblCim.Name = "lblCim";
            this.lblCim.Size = new System.Drawing.Size(35, 13);
            this.lblCim.TabIndex = 2;
            this.lblCim.Text = "label3";
            // 
            // lblApa
            // 
            this.lblApa.AutoSize = true;
            this.lblApa.ForeColor = System.Drawing.Color.Lime;
            this.lblApa.Location = new System.Drawing.Point(12, 155);
            this.lblApa.Name = "lblApa";
            this.lblApa.Size = new System.Drawing.Size(35, 13);
            this.lblApa.TabIndex = 3;
            this.lblApa.Text = "label4";
            // 
            // lblAnya
            // 
            this.lblAnya.AutoSize = true;
            this.lblAnya.ForeColor = System.Drawing.Color.Lime;
            this.lblAnya.Location = new System.Drawing.Point(12, 193);
            this.lblAnya.Name = "lblAnya";
            this.lblAnya.Size = new System.Drawing.Size(35, 13);
            this.lblAnya.TabIndex = 4;
            this.lblAnya.Text = "label5";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.ForeColor = System.Drawing.Color.Lime;
            this.lblTelefon.Location = new System.Drawing.Point(12, 226);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(35, 13);
            this.lblTelefon.TabIndex = 5;
            this.lblTelefon.Text = "label6";
            // 
            // lblNem
            // 
            this.lblNem.AutoSize = true;
            this.lblNem.ForeColor = System.Drawing.Color.Lime;
            this.lblNem.Location = new System.Drawing.Point(12, 262);
            this.lblNem.Name = "lblNem";
            this.lblNem.Size = new System.Drawing.Size(35, 13);
            this.lblNem.TabIndex = 6;
            this.lblNem.Text = "label7";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.Lime;
            this.lblEmail.Location = new System.Drawing.Point(12, 295);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "label8";
            // 
            // lblSzemely
            // 
            this.lblSzemely.AutoSize = true;
            this.lblSzemely.ForeColor = System.Drawing.Color.Lime;
            this.lblSzemely.Location = new System.Drawing.Point(12, 332);
            this.lblSzemely.Name = "lblSzemely";
            this.lblSzemely.Size = new System.Drawing.Size(35, 13);
            this.lblSzemely.TabIndex = 8;
            this.lblSzemely.Text = "label9";
            // 
            // btnKovetkezo
            // 
            this.btnKovetkezo.BackColor = System.Drawing.Color.Transparent;
            this.btnKovetkezo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKovetkezo.Location = new System.Drawing.Point(211, 375);
            this.btnKovetkezo.Name = "btnKovetkezo";
            this.btnKovetkezo.Size = new System.Drawing.Size(75, 23);
            this.btnKovetkezo.TabIndex = 10;
            this.btnKovetkezo.Text = "Következő";
            this.btnKovetkezo.UseVisualStyleBackColor = false;
            this.btnKovetkezo.Click += new System.EventHandler(this.btnKovetkezo_Click);
            // 
            // btnKilep
            // 
            this.btnKilep.BackColor = System.Drawing.Color.Transparent;
            this.btnKilep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKilep.Location = new System.Drawing.Point(292, 375);
            this.btnKilep.Name = "btnKilep";
            this.btnKilep.Size = new System.Drawing.Size(75, 23);
            this.btnKilep.TabIndex = 11;
            this.btnKilep.Text = "Kilépés";
            this.btnKilep.UseVisualStyleBackColor = false;
            this.btnKilep.Click += new System.EventHandler(this.btnKilep_Click);
            // 
            // listaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(379, 410);
            this.Controls.Add(this.btnKilep);
            this.Controls.Add(this.btnKovetkezo);
            this.Controls.Add(this.lblSzemely);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNem);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblAnya);
            this.Controls.Add(this.lblApa);
            this.Controls.Add(this.lblCim);
            this.Controls.Add(this.lblNev);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Lime;
            this.Name = "listaForm";
            this.Text = "listaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNev;
        private System.Windows.Forms.Label lblCim;
        private System.Windows.Forms.Label lblApa;
        private System.Windows.Forms.Label lblAnya;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblNem;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSzemely;
        private System.Windows.Forms.Button btnKovetkezo;
        private System.Windows.Forms.Button btnKilep;
    }
}