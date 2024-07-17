namespace telefonkonyvwinforms
{
    partial class torlesForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtSzemely = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTorol = new System.Windows.Forms.Button();
            this.btnKilep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // txtSzemely
            // 
            this.txtSzemely.Location = new System.Drawing.Point(12, 38);
            this.txtSzemely.Name = "txtSzemely";
            this.txtSzemely.Size = new System.Drawing.Size(231, 20);
            this.txtSzemely.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Írd be a keresett személy nevét";
            // 
            // btnTorol
            // 
            this.btnTorol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTorol.Location = new System.Drawing.Point(170, 108);
            this.btnTorol.Name = "btnTorol";
            this.btnTorol.Size = new System.Drawing.Size(75, 23);
            this.btnTorol.TabIndex = 21;
            this.btnTorol.Text = "Törlés";
            this.btnTorol.UseVisualStyleBackColor = true;
            this.btnTorol.Click += new System.EventHandler(this.btnTorol_Click);
            // 
            // btnKilep
            // 
            this.btnKilep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKilep.Location = new System.Drawing.Point(251, 108);
            this.btnKilep.Name = "btnKilep";
            this.btnKilep.Size = new System.Drawing.Size(75, 23);
            this.btnKilep.TabIndex = 22;
            this.btnKilep.Text = "Kilépés";
            this.btnKilep.UseVisualStyleBackColor = true;
            this.btnKilep.Click += new System.EventHandler(this.btnKilep_Click);
            // 
            // torlesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(338, 143);
            this.Controls.Add(this.btnKilep);
            this.Controls.Add(this.btnTorol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSzemely);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Lime;
            this.Name = "torlesForm";
            this.Text = "torlesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSzemely;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTorol;
        private System.Windows.Forms.Button btnKilep;
    }
}