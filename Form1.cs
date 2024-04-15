using QRCoder;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace QRCodeMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (stringBox.Text == "Enter your text to be put into QR Code")
            {
                stringBox.Text = "";
                stringBox.ForeColor = Color.Black;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputString = stringBox.Text;
            try
            {
                using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
                {
                    QRCodeData qrCodeData = qrGenerator.CreateQrCode(inputString, QRCodeGenerator.ECCLevel.Q);
                    using (QRCode qrCode = new QRCode(qrCodeData))
                    {
                        using (Bitmap qrCodeImage = qrCode.GetGraphic(20))
                        {
                            // Debug: Verify the bitmap can be saved - you can remove this line if it works
                            //qrCodeImage.Save("test_qr.png"); // If this works without error, the Bitmap is fine

                            qrCodeBox.Image?.Dispose(); // Dispose any existing image to avoid memory leaks
                            qrCodeBox.Image = (Bitmap)qrCodeImage.Clone(); // Clone and assign the Bitmap to PictureBox
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating QR code: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            // Check if there's an image in the PictureBox
            if (qrCodeBox.Image == null)
            {
                MessageBox.Show("There is no QR code to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                // Configure save file dialog box
                saveFileDialog.FileName = "QRCode_" + stringBox.Text; // Default file name
                saveFileDialog.DefaultExt = ".png"; // Default file extension
                saveFileDialog.Filter = "PNG files (*.png)|*.png|All files (*.*)|*.*"; // Filter files by extension

                // Show save file dialog box
                DialogResult result = saveFileDialog.ShowDialog();

                // Process save file dialog box results
                if (result == DialogResult.OK)
                {
                    // Save Image
                    string filename = saveFileDialog.FileName;
                    qrCodeBox.Image.Save(filename, System.Drawing.Imaging.ImageFormat.Png);
                    MessageBox.Show($"QR Code saved to {filename}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            // Check if there's an image in the PictureBox
            if (qrCodeBox.Image == null)
            {
                MessageBox.Show("There is no QR code to copy.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Copy the image to the clipboard
                Clipboard.SetImage(new Bitmap(qrCodeBox.Image));
                MessageBox.Show("QR Code copied to clipboard.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutBox1();
            aboutForm.Show();

        }
    }
}