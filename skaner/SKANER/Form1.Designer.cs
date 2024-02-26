using System.Drawing;
using System.Windows.Forms;

namespace SKANER
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
            this.scanButton = new System.Windows.Forms.Button();
            this.saveImage = new System.Windows.Forms.Button();
            this.scanPreview = new System.Windows.Forms.PictureBox();
            this.formatsList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rotateLeft = new System.Windows.Forms.Button();
            this.rotateRightButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.brightnessValue = new System.Windows.Forms.NumericUpDown();
            this.contrastValue = new System.Windows.Forms.NumericUpDown();
            this.Constrast = new System.Windows.Forms.Label();
            this.filenameInput = new System.Windows.Forms.TextBox();
            this.saveSettingsButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.heightValue = new System.Windows.Forms.NumericUpDown();
            this.widthValue = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.colorBox = new System.Windows.Forms.ComboBox();
            this.Connect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scanPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthValue)).BeginInit();
            this.SuspendLayout();
            // 
            // scanButton
            // 
            this.scanButton.Location = new System.Drawing.Point(15, 15);
            this.scanButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(213, 54);
            this.scanButton.TabIndex = 0;
            this.scanButton.Text = "Skanuj podgląd";
            this.scanButton.UseVisualStyleBackColor = true;
            // 
            // saveImage
            // 
            this.saveImage.Location = new System.Drawing.Point(14, 255);
            this.saveImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveImage.Name = "saveImage";
            this.saveImage.Size = new System.Drawing.Size(156, 31);
            this.saveImage.TabIndex = 2;
            this.saveImage.Text = "Skanuj i zapisz jako";
            this.saveImage.UseVisualStyleBackColor = true;
            // 
            // scanPreview
            // 
            this.scanPreview.Location = new System.Drawing.Point(320, 15);
            this.scanPreview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.scanPreview.Name = "scanPreview";
            this.scanPreview.Size = new System.Drawing.Size(681, 822);
            this.scanPreview.TabIndex = 3;
            this.scanPreview.TabStop = false;
            // 
            // formatsList
            // 
            this.formatsList.FormattingEnabled = true;
            this.formatsList.ItemHeight = 20;
            this.formatsList.Items.AddRange(new object[] {
            "png",
            "jpg",
            "bmp",
            "tiff",
            "rle"});
            this.formatsList.Location = new System.Drawing.Point(14, 123);
            this.formatsList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.formatsList.Name = "formatsList";
            this.formatsList.Size = new System.Drawing.Size(152, 124);
            this.formatsList.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Wybierz format";
            // 
            // rotateLeft
            // 
            this.rotateLeft.Location = new System.Drawing.Point(320, 845);
            this.rotateLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rotateLeft.Name = "rotateLeft";
            this.rotateLeft.Size = new System.Drawing.Size(198, 31);
            this.rotateLeft.TabIndex = 6;
            this.rotateLeft.Text = "Obróć w lewo o 90 stopni";
            this.rotateLeft.UseVisualStyleBackColor = true;
            // 
            // rotateRightButton
            // 
            this.rotateRightButton.Location = new System.Drawing.Point(792, 845);
            this.rotateRightButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rotateRightButton.Name = "rotateRightButton";
            this.rotateRightButton.Size = new System.Drawing.Size(208, 31);
            this.rotateRightButton.TabIndex = 7;
            this.rotateRightButton.Text = "Obróć w prawo o 90 stopni";
            this.rotateRightButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 380);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Brightness";
            // 
            // brightnessValue
            // 
            this.brightnessValue.Location = new System.Drawing.Point(15, 405);
            this.brightnessValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.brightnessValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.brightnessValue.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.brightnessValue.Name = "brightnessValue";
            this.brightnessValue.Size = new System.Drawing.Size(154, 26);
            this.brightnessValue.TabIndex = 11;
            // 
            // contrastValue
            // 
            this.contrastValue.Location = new System.Drawing.Point(15, 463);
            this.contrastValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.contrastValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.contrastValue.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.contrastValue.Name = "contrastValue";
            this.contrastValue.Size = new System.Drawing.Size(154, 26);
            this.contrastValue.TabIndex = 12;
            // 
            // Constrast
            // 
            this.Constrast.AutoSize = true;
            this.Constrast.Location = new System.Drawing.Point(16, 438);
            this.Constrast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Constrast.Name = "Constrast";
            this.Constrast.Size = new System.Drawing.Size(70, 20);
            this.Constrast.TabIndex = 13;
            this.Constrast.Text = "Contrast";
            // 
            // filenameInput
            // 
            this.filenameInput.Location = new System.Drawing.Point(176, 257);
            this.filenameInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.filenameInput.Name = "filenameInput";
            this.filenameInput.Size = new System.Drawing.Size(127, 26);
            this.filenameInput.TabIndex = 14;
            this.filenameInput.Text = "scan-name";
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.Location = new System.Drawing.Point(15, 662);
            this.saveSettingsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(154, 48);
            this.saveSettingsButton.TabIndex = 15;
            this.saveSettingsButton.Text = "Zapisz ustawienia";
            this.saveSettingsButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 522);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 589);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Width";
            // 
            // heightValue
            // 
            this.heightValue.Location = new System.Drawing.Point(15, 545);
            this.heightValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.heightValue.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.heightValue.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.heightValue.Name = "heightValue";
            this.heightValue.Size = new System.Drawing.Size(154, 26);
            this.heightValue.TabIndex = 18;
            this.heightValue.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // widthValue
            // 
            this.widthValue.Location = new System.Drawing.Point(16, 614);
            this.widthValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.widthValue.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.widthValue.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.widthValue.Name = "widthValue";
            this.widthValue.Size = new System.Drawing.Size(154, 26);
            this.widthValue.TabIndex = 19;
            this.widthValue.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label5.Location = new System.Drawing.Point(14, 303);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 40);
            this.label5.TabIndex = 20;
            this.label5.Text = "USTAWIENIA";
            // 
            // colorBox
            // 
            this.colorBox.FormattingEnabled = true;
            this.colorBox.Items.AddRange(new object[] {
            "Kolorowy",
            "Szary"});
            this.colorBox.Location = new System.Drawing.Point(16, 340);
            this.colorBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(154, 28);
            this.colorBox.TabIndex = 21;
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(14, 874);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(86, 25);
            this.Connect.TabIndex = 22;
            this.Connect.Text = "Połącz";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 911);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.widthValue);
            this.Controls.Add(this.heightValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.saveSettingsButton);
            this.Controls.Add(this.filenameInput);
            this.Controls.Add(this.Constrast);
            this.Controls.Add(this.contrastValue);
            this.Controls.Add(this.brightnessValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rotateRightButton);
            this.Controls.Add(this.rotateLeft);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formatsList);
            this.Controls.Add(this.scanPreview);
            this.Controls.Add(this.saveImage);
            this.Controls.Add(this.scanButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Skaner";
            ((System.ComponentModel.ISupportInitialize)(this.scanPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button scanButton;
        private Button saveImage;
        private PictureBox scanPreview;
        private ComboBox formatsBox;
        private ListBox formatsList;
        private Label label1;
        private Button rotateLeft;
        private Button rotateRightButton;
        private Label label2;
        private NumericUpDown brightnessValue;
        private NumericUpDown contrastValue;
        private Label Constrast;
        private TextBox filenameInput;
        private Button saveSettingsButton;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown heightValue;
        private NumericUpDown widthValue;
        private Label label5;
        private ComboBox colorBox;
        private Button Connect;
    }
}