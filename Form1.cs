using Newtonsoft.Json;
using QRCoder;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Net;
using System.Reflection;
using System.Windows.Forms;

namespace QRCodeMaker
{
    public partial class Form1 : Form
    {

#pragma warning disable CS8601 // Possible null reference assignment.
        private readonly Version _version = Assembly.GetExecutingAssembly().GetName().Version;
#pragma warning restore CS8601 // Possible null reference assignment.
        private string currentVersion;
        private string repoOwner = "PackJC"; // Replace with your GitHub username
        private string repoName = "QRCodeMaker"; // Replace with your repository name
#pragma warning disable CS0169 // The field 'Form1.logo' is never used
        private string logo;
#pragma warning restore CS0169 // The field 'Form1.logo' is never used
        Color qrCodeColor = Color.Black; // Default color
        Color qrCodeBackgroundColor = Color.White; // Default color

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Form1()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            InitializeComponent();
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            currentVersion = _version.ToString();
#pragma warning restore CS8602 // Dereference of a possibly null reference.

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
            // Assuming qrCodeColor is your user-selected color for the QR code and is defined elsewhere

            try
            {
                using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
                {
                    QRCodeData qrCodeData = qrGenerator.CreateQrCode(inputString, QRCodeGenerator.ECCLevel.Q);
                    using (QRCode qrCode = new QRCode(qrCodeData))
                    {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                        Bitmap qrCodeImage = null;
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

                        // Check if a logo has been selected and loaded into pictureBoxLogo
                        if (logoPictureBox.Image != null)
                        {
                            // Assuming pictureBoxLogo contains the logo
                            Bitmap logoImage = new Bitmap(logoPictureBox.Image);

                            // Generate QR code with logo. Adjust logo size ratio as needed.
                            qrCodeImage = qrCode.GetGraphic(20, qrCodeColor, qrCodeBackgroundColor, logoImage, 15);
                        }
                        else
                        {
                            // Generate QR code without a logo, but with custom color
                            qrCodeImage = qrCode.GetGraphic(20, qrCodeColor, qrCodeBackgroundColor, true);
                        }

                        // Ensure previous QR code image is disposed
                        if (qrCodeBox.Image != null)
                        {
                            qrCodeBox.Image.Dispose(); // Dispose directly as we're going to replace it immediately
                        }

                        qrCodeBox.Image = qrCodeImage; // Assign the newly created QR code image
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating QR code: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public string CleanFileName(string fileName)
        {
            // Remove http:// or https:// from the string
            string cleanedFileName = fileName.Replace("http://", "").Replace("https://", "");

            // Replace invalid filename characters with underscores
            char[] invalidChars = System.IO.Path.GetInvalidFileNameChars();
            foreach (char c in invalidChars)
            {
                cleanedFileName = cleanedFileName.Replace(c, '_');
            }

            // Replace multiple consecutive underscores with a single underscore
            while (cleanedFileName.Contains("__")) // Two underscores
            {
                cleanedFileName = cleanedFileName.Replace("__", "_");
            }

            return cleanedFileName;
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
                saveFileDialog.FileName = "QRCode_" + CleanFileName(stringBox.Text);
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

        private void checkForUpdatesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string latestReleaseUrl = $"https://api.github.com/repos/{repoOwner}/{repoName}/releases/latest";
            string json;

            using (WebClient wc = new WebClient())
            {
                wc.Headers.Add("User-Agent", "request"); // GitHub API requires a user-agent
                json = wc.DownloadString(latestReleaseUrl);
            }

            var release = JsonConvert.DeserializeObject<dynamic>(json);
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            string latestVersion = release.tag_name;
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            string downloadUrl = release.assets[0].browser_download_url;

            if (Version.Parse(latestVersion) > Version.Parse(currentVersion))
            {
                if (MessageBox.Show($"Update available: {latestVersion}\nDo you want to download it?", "Update Available", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Process.Start(new ProcessStartInfo(downloadUrl) { UseShellExecute = true });
                }
            }
            else
            {
                MessageBox.Show("Your application is up to date.");
            }

        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.AllowFullOpen = true;
            cd.Color = colorPanel.BackColor;
            cd.FullOpen = true;
            cd.AnyColor = true;
            if (cd.ShowDialog() == DialogResult.OK)
            {
                colorPanel.BackColor = cd.Color;
                qrCodeColor = cd.Color;
            }
        }

        private void btnUploadLogo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select a logo";
                openFileDialog.Filter = "Image files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Load and display the selected image in the PictureBox
                    logoPictureBox.ImageLocation = openFileDialog.FileName;
                }
            }

        }

        private void clearLogoButton_Click(object sender, EventArgs e)
        {
            // Check if there's currently an image displayed in the pictureBoxLogo
            if (logoPictureBox.Image != null)
            {
                logoPictureBox.Image.Dispose(); // Dispose the image to free resources
                logoPictureBox.Image = null; // Remove the image from the PictureBox
            }
        }

        private void btnChangeBackgroundColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.AllowFullOpen = true;
            cd.Color = colorPanel.BackColor;
            cd.FullOpen = true;
            cd.AnyColor = true;
            if (cd.ShowDialog() == DialogResult.OK)
            {
                backgroundColorPanel.BackColor = cd.Color;
                qrCodeBackgroundColor = cd.Color;
            }
        }
    }
}