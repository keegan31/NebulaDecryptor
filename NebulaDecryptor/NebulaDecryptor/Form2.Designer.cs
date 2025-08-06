namespace NebulaDecryptor
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkGithub;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkGithub = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(481, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 115);
            this.label1.TabIndex = 0;
            this.label1.Text = "NebulaDecryptor\n\nNebulaRun Decrypt Tool\n\nMade by keegan31";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.MediumPurple;
            this.label2.Location = new System.Drawing.Point(2, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(434, 161);
            this.label2.TabIndex = 1;
            this.label2.Text = "Not Decrypting?\n\nContact Us Via Discord Provide Your Details\n\nThis Only Works For" +
    " 2nd Variant Of NebulaRunsomware\n\n1st Variant Has password as \'\'test\'\' ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.MediumPurple;
            this.label3.Location = new System.Drawing.Point(12, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact Via Discord:  yessir063332\r\n";
            // 
            // linkGithub
            // 
            this.linkGithub.ActiveLinkColor = System.Drawing.Color.Lavender;
            this.linkGithub.AutoSize = true;
            this.linkGithub.LinkColor = System.Drawing.Color.MediumPurple;
            this.linkGithub.Location = new System.Drawing.Point(12, 200);
            this.linkGithub.Name = "linkGithub";
            this.linkGithub.Size = new System.Drawing.Size(66, 16);
            this.linkGithub.TabIndex = 0;
            this.linkGithub.TabStop = true;
            this.linkGithub.Text = "My Github\r\n";
            this.linkGithub.Click += new System.EventHandler(this.linkGithub_Click);
            // 
            // Form2
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.Controls.Add(this.linkGithub);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.MediumPurple;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Contact Details & About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
