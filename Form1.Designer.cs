namespace QRCodeMaker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            stringBox = new TextBox();
            createButton = new Button();
            qrCodeBox = new PictureBox();
            downloadButton = new Button();
            copyButton = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            uploadImageToolStripMenuItem = new ToolStripMenuItem();
            checkForUpdatesToolStripMenuItem = new ToolStripMenuItem();
            checkForUpdatesToolStripMenuItem1 = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            colorPanel = new Panel();
            btnChangeColor = new Button();
            btnUploadLogo = new Button();
            logoPictureBox = new PictureBox();
            clearLogoButton = new Button();
            btnChangeBackgroundColor = new Button();
            backgroundColorPanel = new Panel();
            qrResultBox = new TextBox();
            clearButton = new Button();
            ((System.ComponentModel.ISupportInitialize)qrCodeBox).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // stringBox
            // 
            stringBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            stringBox.ForeColor = SystemColors.ActiveCaptionText;
            stringBox.Location = new Point(25, 29);
            stringBox.Multiline = true;
            stringBox.Name = "stringBox";
            stringBox.Size = new Size(319, 60);
            stringBox.TabIndex = 232;
            stringBox.Text = "Enter your text to be put into QR Code";
            stringBox.TextChanged += textBox1_TextChanged;
            stringBox.Enter += textBox1_Enter;
            // 
            // createButton
            // 
            createButton.BackColor = Color.FromArgb(124, 187, 224);
            createButton.FlatAppearance.BorderSize = 0;
            createButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(83, 166, 214);
            createButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(141, 212, 255);
            createButton.FlatStyle = FlatStyle.Flat;
            createButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            createButton.Location = new Point(12, 433);
            createButton.Name = "createButton";
            createButton.Size = new Size(200, 75);
            createButton.TabIndex = 3;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = false;
            createButton.Click += button1_Click;
            // 
            // qrCodeBox
            // 
            qrCodeBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            qrCodeBox.Location = new Point(366, 27);
            qrCodeBox.Name = "qrCodeBox";
            qrCodeBox.Size = new Size(406, 400);
            qrCodeBox.SizeMode = PictureBoxSizeMode.StretchImage;
            qrCodeBox.TabIndex = 4;
            qrCodeBox.TabStop = false;
            // 
            // downloadButton
            // 
            downloadButton.BackColor = Color.DarkSeaGreen;
            downloadButton.FlatAppearance.BorderSize = 0;
            downloadButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(111, 169, 111);
            downloadButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(191, 217, 191);
            downloadButton.FlatStyle = FlatStyle.Flat;
            downloadButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            downloadButton.Location = new Point(366, 433);
            downloadButton.Name = "downloadButton";
            downloadButton.Size = new Size(200, 75);
            downloadButton.TabIndex = 5;
            downloadButton.Text = "Download";
            downloadButton.UseVisualStyleBackColor = false;
            downloadButton.Click += downloadButton_Click;
            // 
            // copyButton
            // 
            copyButton.BackColor = Color.DarkKhaki;
            copyButton.FlatAppearance.BorderSize = 0;
            copyButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(179, 173, 97);
            copyButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 230, 167);
            copyButton.FlatStyle = FlatStyle.Flat;
            copyButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            copyButton.Location = new Point(572, 433);
            copyButton.Name = "copyButton";
            copyButton.Size = new Size(200, 75);
            copyButton.TabIndex = 6;
            copyButton.Text = "Copy to Clipboard";
            copyButton.UseVisualStyleBackColor = false;
            copyButton.Click += copyButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, checkForUpdatesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(784, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { uploadImageToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // uploadImageToolStripMenuItem
            // 
            uploadImageToolStripMenuItem.Image = (Image)resources.GetObject("uploadImageToolStripMenuItem.Image");
            uploadImageToolStripMenuItem.Name = "uploadImageToolStripMenuItem";
            uploadImageToolStripMenuItem.Size = new Size(148, 22);
            uploadImageToolStripMenuItem.Text = "Upload Image";
            uploadImageToolStripMenuItem.Click += uploadImageToolStripMenuItem_Click;
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            checkForUpdatesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { checkForUpdatesToolStripMenuItem1, aboutToolStripMenuItem });
            checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            checkForUpdatesToolStripMenuItem.Size = new Size(44, 20);
            checkForUpdatesToolStripMenuItem.Text = "Help";
            checkForUpdatesToolStripMenuItem.Click += checkForUpdatesToolStripMenuItem_Click;
            // 
            // checkForUpdatesToolStripMenuItem1
            // 
            checkForUpdatesToolStripMenuItem1.Image = (Image)resources.GetObject("checkForUpdatesToolStripMenuItem1.Image");
            checkForUpdatesToolStripMenuItem1.Name = "checkForUpdatesToolStripMenuItem1";
            checkForUpdatesToolStripMenuItem1.Size = new Size(171, 22);
            checkForUpdatesToolStripMenuItem1.Text = "Check for Updates";
            checkForUpdatesToolStripMenuItem1.Click += checkForUpdatesToolStripMenuItem1_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Image = (Image)resources.GetObject("aboutToolStripMenuItem.Image");
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(171, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // colorPanel
            // 
            colorPanel.BackColor = Color.White;
            colorPanel.Location = new Point(25, 161);
            colorPanel.Name = "colorPanel";
            colorPanel.Size = new Size(50, 50);
            colorPanel.TabIndex = 8;
            // 
            // btnChangeColor
            // 
            btnChangeColor.Location = new Point(81, 161);
            btnChangeColor.Name = "btnChangeColor";
            btnChangeColor.Size = new Size(263, 50);
            btnChangeColor.TabIndex = 9;
            btnChangeColor.Text = "Change QR Color";
            btnChangeColor.UseVisualStyleBackColor = true;
            btnChangeColor.Click += btnChangeColor_Click;
            // 
            // btnUploadLogo
            // 
            btnUploadLogo.Location = new Point(156, 305);
            btnUploadLogo.Name = "btnUploadLogo";
            btnUploadLogo.Size = new Size(188, 50);
            btnUploadLogo.TabIndex = 11;
            btnUploadLogo.Text = "Upload Logo";
            btnUploadLogo.UseVisualStyleBackColor = true;
            btnUploadLogo.Click += btnUploadLogo_Click;
            // 
            // logoPictureBox
            // 
            logoPictureBox.BackColor = Color.White;
            logoPictureBox.Location = new Point(25, 296);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(125, 125);
            logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoPictureBox.TabIndex = 0;
            logoPictureBox.TabStop = false;
            // 
            // clearLogoButton
            // 
            clearLogoButton.BackColor = Color.Transparent;
            clearLogoButton.FlatAppearance.BorderColor = Color.White;
            clearLogoButton.Location = new Point(152, 361);
            clearLogoButton.Name = "clearLogoButton";
            clearLogoButton.Size = new Size(192, 50);
            clearLogoButton.TabIndex = 233;
            clearLogoButton.Text = "Clear Logo";
            clearLogoButton.UseVisualStyleBackColor = false;
            clearLogoButton.Click += clearLogoButton_Click;
            // 
            // btnChangeBackgroundColor
            // 
            btnChangeBackgroundColor.Location = new Point(81, 230);
            btnChangeBackgroundColor.Name = "btnChangeBackgroundColor";
            btnChangeBackgroundColor.Size = new Size(263, 50);
            btnChangeBackgroundColor.TabIndex = 235;
            btnChangeBackgroundColor.Text = "Change Background Color";
            btnChangeBackgroundColor.UseVisualStyleBackColor = true;
            btnChangeBackgroundColor.Click += btnChangeBackgroundColor_Click;
            // 
            // backgroundColorPanel
            // 
            backgroundColorPanel.BackColor = Color.White;
            backgroundColorPanel.Location = new Point(25, 230);
            backgroundColorPanel.Name = "backgroundColorPanel";
            backgroundColorPanel.Size = new Size(50, 50);
            backgroundColorPanel.TabIndex = 234;
            // 
            // qrResultBox
            // 
            qrResultBox.BackColor = Color.OldLace;
            qrResultBox.Enabled = false;
            qrResultBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            qrResultBox.ForeColor = SystemColors.ControlDark;
            qrResultBox.Location = new Point(25, 95);
            qrResultBox.Multiline = true;
            qrResultBox.Name = "qrResultBox";
            qrResultBox.Size = new Size(319, 60);
            qrResultBox.TabIndex = 236;
            qrResultBox.Text = "Import a QR Code and the data will be displayed here!";
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.FromArgb(255, 128, 128);
            clearButton.FlatAppearance.BorderSize = 0;
            clearButton.FlatAppearance.MouseDownBackColor = Color.Red;
            clearButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            clearButton.Location = new Point(218, 433);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(126, 75);
            clearButton.TabIndex = 237;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(784, 517);
            Controls.Add(clearButton);
            Controls.Add(qrResultBox);
            Controls.Add(btnChangeBackgroundColor);
            Controls.Add(backgroundColorPanel);
            Controls.Add(clearLogoButton);
            Controls.Add(logoPictureBox);
            Controls.Add(btnUploadLogo);
            Controls.Add(btnChangeColor);
            Controls.Add(colorPanel);
            Controls.Add(copyButton);
            Controls.Add(downloadButton);
            Controls.Add(qrCodeBox);
            Controls.Add(createButton);
            Controls.Add(stringBox);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QR Code Generator";
            ((System.ComponentModel.ISupportInitialize)qrCodeBox).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox stringBox;
        private Button createButton;
        private PictureBox qrCodeBox;
        private Button downloadButton;
        private Button copyButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private ToolStripMenuItem checkForUpdatesToolStripMenuItem1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Panel colorPanel;
        private Button btnChangeColor;
        private Button btnUploadLogo;
        private PictureBox logoPictureBox;
        private Button clearLogoButton;
        private Button btnChangeBackgroundColor;
        private Panel backgroundColorPanel;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem uploadImageToolStripMenuItem;
        private TextBox qrResultBox;
        private Button clearButton;
    }
}