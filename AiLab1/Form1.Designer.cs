namespace AiLab1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sectorsLabel = new System.Windows.Forms.Label();
            this.sectorsTextBox = new System.Windows.Forms.TextBox();
            this.convertToGrayScaleButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.blackPixelLabel = new System.Windows.Forms.Label();
            this.blackPixelText = new System.Windows.Forms.TextBox();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(753, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripMenuItem1,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(143, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 280);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // sectorsLabel
            // 
            this.sectorsLabel.AutoSize = true;
            this.sectorsLabel.Location = new System.Drawing.Point(616, 98);
            this.sectorsLabel.Name = "sectorsLabel";
            this.sectorsLabel.Size = new System.Drawing.Size(43, 13);
            this.sectorsLabel.TabIndex = 2;
            this.sectorsLabel.Text = "Sectors";
            // 
            // sectorsTextBox
            // 
            this.sectorsTextBox.Location = new System.Drawing.Point(587, 114);
            this.sectorsTextBox.Name = "sectorsTextBox";
            this.sectorsTextBox.Size = new System.Drawing.Size(100, 20);
            this.sectorsTextBox.TabIndex = 3;
            // 
            // convertToGrayScaleButton
            // 
            this.convertToGrayScaleButton.Location = new System.Drawing.Point(573, 150);
            this.convertToGrayScaleButton.Name = "convertToGrayScaleButton";
            this.convertToGrayScaleButton.Size = new System.Drawing.Size(133, 23);
            this.convertToGrayScaleButton.TabIndex = 4;
            this.convertToGrayScaleButton.Text = "Convert to Grayscale";
            this.convertToGrayScaleButton.UseVisualStyleBackColor = true;
            this.convertToGrayScaleButton.Click += new System.EventHandler(this.convertToGrayScaleButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Location = new System.Drawing.Point(573, 179);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(133, 23);
            this.divideButton.TabIndex = 5;
            this.divideButton.Text = "Divide";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // blackPixelLabel
            // 
            this.blackPixelLabel.AutoSize = true;
            this.blackPixelLabel.Location = new System.Drawing.Point(595, 38);
            this.blackPixelLabel.Name = "blackPixelLabel";
            this.blackPixelLabel.Size = new System.Drawing.Size(84, 13);
            this.blackPixelLabel.TabIndex = 6;
            this.blackPixelLabel.Text = "Black pixel color";
            // 
            // blackPixelText
            // 
            this.blackPixelText.Location = new System.Drawing.Point(587, 64);
            this.blackPixelText.Name = "blackPixelText";
            this.blackPixelText.Size = new System.Drawing.Size(100, 20);
            this.blackPixelText.TabIndex = 7;
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(439, 37);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(13, 13);
            this.xLabel.TabIndex = 8;
            this.xLabel.Text = "0";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(439, 64);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(13, 13);
            this.yLabel.TabIndex = 9;
            this.yLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 357);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.blackPixelText);
            this.Controls.Add(this.blackPixelLabel);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.convertToGrayScaleButton);
            this.Controls.Add(this.sectorsTextBox);
            this.Controls.Add(this.sectorsLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Pixel Count";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label sectorsLabel;
        private System.Windows.Forms.TextBox sectorsTextBox;
        private System.Windows.Forms.Button convertToGrayScaleButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Label blackPixelLabel;
        private System.Windows.Forms.TextBox blackPixelText;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label yLabel;
    }
}

