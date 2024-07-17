namespace telefonkonyvwinforms
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUj = new System.Windows.Forms.Button();
            this.btnLista = new System.Windows.Forms.Button();
            this.btnKilep = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnKeres = new System.Windows.Forms.Button();
            this.btnTorol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(107, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "**********Üdvözöllek a telefonkönyvben*************";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(203, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Menü";
            // 
            // btnUj
            // 
            this.btnUj.BackColor = System.Drawing.Color.Transparent;
            this.btnUj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUj.ForeColor = System.Drawing.Color.Lime;
            this.btnUj.Location = new System.Drawing.Point(57, 92);
            this.btnUj.Name = "btnUj";
            this.btnUj.Size = new System.Drawing.Size(104, 23);
            this.btnUj.TabIndex = 2;
            this.btnUj.Text = "1. Új hozzáadása";
            this.btnUj.UseVisualStyleBackColor = false;
            this.btnUj.Click += new System.EventHandler(this.btnUj_Click);
            // 
            // btnLista
            // 
            this.btnLista.BackColor = System.Drawing.Color.Transparent;
            this.btnLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLista.ForeColor = System.Drawing.Color.Lime;
            this.btnLista.Location = new System.Drawing.Point(167, 92);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(104, 23);
            this.btnLista.TabIndex = 3;
            this.btnLista.Text = "2. Lista";
            this.btnLista.UseVisualStyleBackColor = false;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // btnKilep
            // 
            this.btnKilep.BackColor = System.Drawing.Color.Transparent;
            this.btnKilep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKilep.ForeColor = System.Drawing.Color.Lime;
            this.btnKilep.Location = new System.Drawing.Point(277, 92);
            this.btnKilep.Name = "btnKilep";
            this.btnKilep.Size = new System.Drawing.Size(104, 23);
            this.btnKilep.TabIndex = 4;
            this.btnKilep.Text = "3. Kilépés";
            this.btnKilep.UseVisualStyleBackColor = false;
            this.btnKilep.Click += new System.EventHandler(this.btnKilep_Click);
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.Color.Transparent;
            this.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMod.ForeColor = System.Drawing.Color.Lime;
            this.btnMod.Location = new System.Drawing.Point(57, 135);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(104, 23);
            this.btnMod.TabIndex = 5;
            this.btnMod.Text = "4. Módosiítás";
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnKeres
            // 
            this.btnKeres.BackColor = System.Drawing.Color.Transparent;
            this.btnKeres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeres.ForeColor = System.Drawing.Color.Lime;
            this.btnKeres.Location = new System.Drawing.Point(167, 135);
            this.btnKeres.Name = "btnKeres";
            this.btnKeres.Size = new System.Drawing.Size(104, 23);
            this.btnKeres.TabIndex = 6;
            this.btnKeres.Text = "5. Keresés";
            this.btnKeres.UseVisualStyleBackColor = false;
            this.btnKeres.Click += new System.EventHandler(this.btnKeres_Click);
            // 
            // btnTorol
            // 
            this.btnTorol.BackColor = System.Drawing.Color.Transparent;
            this.btnTorol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTorol.ForeColor = System.Drawing.Color.Lime;
            this.btnTorol.Location = new System.Drawing.Point(277, 135);
            this.btnTorol.Name = "btnTorol";
            this.btnTorol.Size = new System.Drawing.Size(104, 23);
            this.btnTorol.TabIndex = 7;
            this.btnTorol.Text = "6. Törlés";
            this.btnTorol.UseVisualStyleBackColor = false;
            this.btnTorol.Click += new System.EventHandler(this.btnTorol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(443, 222);
            this.Controls.Add(this.btnTorol);
            this.Controls.Add(this.btnKeres);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnKilep);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.btnUj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUj;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Button btnKilep;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnKeres;
        private System.Windows.Forms.Button btnTorol;
    }
}

