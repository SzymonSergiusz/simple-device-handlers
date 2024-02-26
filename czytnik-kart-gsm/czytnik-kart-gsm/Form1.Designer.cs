namespace czytnik_kart_gsm
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
            this.devicesList = new System.Windows.Forms.ListBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.showContacts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // devicesList
            // 
            this.devicesList.FormattingEnabled = true;
            this.devicesList.ItemHeight = 20;
            this.devicesList.Location = new System.Drawing.Point(12, 12);
            this.devicesList.Name = "devicesList";
            this.devicesList.Size = new System.Drawing.Size(216, 184);
            this.devicesList.TabIndex = 0;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(251, 12);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(97, 37);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "Połącz";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // showContacts
            // 
            this.showContacts.Location = new System.Drawing.Point(251, 280);
            this.showContacts.Name = "showContacts";
            this.showContacts.Size = new System.Drawing.Size(104, 75);
            this.showContacts.TabIndex = 2;
            this.showContacts.Text = "Wypisz kontakty";
            this.showContacts.UseVisualStyleBackColor = true;
            this.showContacts.Click += new System.EventHandler(this.showContacts_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 618);
            this.Controls.Add(this.showContacts);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.devicesList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox devicesList;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button showContacts;
    }
}

