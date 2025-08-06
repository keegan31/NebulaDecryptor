namespace NebulaDecryptor
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtIV;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label lblIV;
        private System.Windows.Forms.Button btnShowWeakness;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtIV = new System.Windows.Forms.TextBox();
            this.btnShowWeakness = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblIV = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtKey
            // 
            this.txtKey.BackColor = System.Drawing.Color.Black;
            this.txtKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKey.ForeColor = System.Drawing.Color.MediumPurple;
            this.txtKey.Location = new System.Drawing.Point(12, 102);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(400, 22);
            this.txtKey.TabIndex = 2;
            // 
            // txtIV
            // 
            this.txtIV.BackColor = System.Drawing.Color.Black;
            this.txtIV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIV.ForeColor = System.Drawing.Color.MediumPurple;
            this.txtIV.Location = new System.Drawing.Point(12, 49);
            this.txtIV.Name = "txtIV";
            this.txtIV.Size = new System.Drawing.Size(400, 22);
            this.txtIV.TabIndex = 3;
            // 
            // btnShowWeakness
            // 
            this.btnShowWeakness.BackColor = System.Drawing.Color.Black;
            this.btnShowWeakness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowWeakness.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnShowWeakness.Location = new System.Drawing.Point(12, 257);
            this.btnShowWeakness.Name = "btnShowWeakness";
            this.btnShowWeakness.Size = new System.Drawing.Size(330, 30);
            this.btnShowWeakness.TabIndex = 6;
            this.btnShowWeakness.Text = "Show Key & IV & Weakness of NebulaRunsomware";
            this.btnShowWeakness.UseVisualStyleBackColor = false;
            this.btnShowWeakness.Click += new System.EventHandler(this.btnShowWeakness_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.Black;
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrypt.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnDecrypt.Location = new System.Drawing.Point(330, 168);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(120, 30);
            this.btnDecrypt.TabIndex = 4;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Black;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnAbout.Location = new System.Drawing.Point(12, 158);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(123, 30);
            this.btnAbout.TabIndex = 5;
            this.btnAbout.Text = "Contact Us";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // lblKey
            // 
            this.lblKey.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblKey.Location = new System.Drawing.Point(12, 79);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(100, 20);
            this.lblKey.TabIndex = 0;
            this.lblKey.Text = "Base64 Key:";
            // 
            // lblIV
            // 
            this.lblIV.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblIV.Location = new System.Drawing.Point(12, 26);
            this.lblIV.Name = "lblIV";
            this.lblIV.Size = new System.Drawing.Size(100, 20);
            this.lblIV.TabIndex = 1;
            this.lblIV.Text = "Base64 IV:";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(462, 299);
            this.Controls.Add(this.btnShowWeakness);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.lblIV);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.txtIV);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnAbout);
            this.ForeColor = System.Drawing.Color.MediumPurple;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "NebulaDecryptor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
