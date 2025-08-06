namespace NebulaDecryptor
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.RichTextBox txtInfo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.txtInfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtInfo
            // 
            this.txtInfo.BackColor = System.Drawing.Color.Black;
            this.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtInfo.ForeColor = System.Drawing.Color.MediumPurple;
            this.txtInfo.Location = new System.Drawing.Point(12, 32);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtInfo.Size = new System.Drawing.Size(730, 370);
            this.txtInfo.TabIndex = 0;
            this.txtInfo.Text = resources.GetString("txtInfo.Text");
            // 
            // Form3
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(843, 464);
            this.Controls.Add(this.txtInfo);
            this.ForeColor = System.Drawing.Color.MediumPurple;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Key\'s & IV\'s";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }
    }
}
