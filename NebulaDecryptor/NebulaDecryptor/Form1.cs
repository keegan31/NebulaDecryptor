using System;
using System.Windows.Forms;

namespace NebulaDecryptor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Log(string msg)
        {
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtKey.Text) || string.IsNullOrWhiteSpace(txtIV.Text))
                {
                    MessageBox.Show("Enter Key & IV (Base64).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                byte[] key = Convert.FromBase64String(txtKey.Text.Trim());
                byte[] iv = Convert.FromBase64String(txtIV.Text.Trim());

                Decryptor.DecryptAll(key, iv, Log);
            }
            catch (FormatException)
            {
                MessageBox.Show("Key And IV Should Be Base64", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Decryptor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnShowWeakness_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            using (Form2 about = new Form2())
            {
                about.ShowDialog();
            }
        }
    }
}
