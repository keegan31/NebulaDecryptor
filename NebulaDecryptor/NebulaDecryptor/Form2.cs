using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace NebulaDecryptor
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void linkGithub_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "https://github.com/keegan31?tab=repositories",
                    UseShellExecute = true
                });
            }
            catch (Exception)
            {
           }
        }
    }
}
