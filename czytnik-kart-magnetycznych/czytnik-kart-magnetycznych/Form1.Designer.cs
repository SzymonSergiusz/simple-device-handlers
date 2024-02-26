namespace czytnik_kart_magnetycznych
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
            this.wyslaneLista = new System.Windows.Forms.ListBox();
            this.odczytLista = new System.Windows.Forms.ListBox();
            this.readButton = new System.Windows.Forms.Button();
            this.isConnected = new System.Windows.Forms.Label();
            this.trybKarty = new System.Windows.Forms.Button();
            this.trybKlawiatury = new System.Windows.Forms.Button();
            this.redButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.yellowButton = new System.Windows.Forms.Button();
            this.odczytKarty = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kodWydzialuText = new System.Windows.Forms.TextBox();
            this.kodKartyText = new System.Windows.Forms.TextBox();
            this.odczytKlawiatura = new System.Windows.Forms.Button();
            this.pinText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wyslaneLista
            // 
            this.wyslaneLista.FormattingEnabled = true;
            this.wyslaneLista.Location = new System.Drawing.Point(83, 207);
            this.wyslaneLista.Name = "wyslaneLista";
            this.wyslaneLista.Size = new System.Drawing.Size(185, 199);
            this.wyslaneLista.TabIndex = 0;
            // 
            // odczytLista
            // 
            this.odczytLista.FormattingEnabled = true;
            this.odczytLista.Location = new System.Drawing.Point(320, 207);
            this.odczytLista.Name = "odczytLista";
            this.odczytLista.Size = new System.Drawing.Size(453, 186);
            this.odczytLista.TabIndex = 1;
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(83, 166);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(75, 23);
            this.readButton.TabIndex = 2;
            this.readButton.Text = "odczyt";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // isConnected
            // 
            this.isConnected.AutoSize = true;
            this.isConnected.Location = new System.Drawing.Point(58, 9);
            this.isConnected.Name = "isConnected";
            this.isConnected.Size = new System.Drawing.Size(66, 13);
            this.isConnected.TabIndex = 3;
            this.isConnected.Text = "isConnected";
            // 
            // trybKarty
            // 
            this.trybKarty.Location = new System.Drawing.Point(83, 102);
            this.trybKarty.Name = "trybKarty";
            this.trybKarty.Size = new System.Drawing.Size(75, 23);
            this.trybKarty.TabIndex = 4;
            this.trybKarty.Text = "Moduł karty";
            this.trybKarty.UseVisualStyleBackColor = true;
            this.trybKarty.Click += new System.EventHandler(this.trybKarty_Click);
            // 
            // trybKlawiatury
            // 
            this.trybKlawiatury.Location = new System.Drawing.Point(182, 102);
            this.trybKlawiatury.Name = "trybKlawiatury";
            this.trybKlawiatury.Size = new System.Drawing.Size(86, 52);
            this.trybKlawiatury.TabIndex = 5;
            this.trybKlawiatury.Text = "Moduł klawiatury";
            this.trybKlawiatury.UseVisualStyleBackColor = true;
            this.trybKlawiatury.Click += new System.EventHandler(this.trybKlawiatury_Click);
            // 
            // redButton
            // 
            this.redButton.Location = new System.Drawing.Point(295, 102);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(111, 23);
            this.redButton.TabIndex = 6;
            this.redButton.Text = "Czerwona dioda";
            this.redButton.UseVisualStyleBackColor = true;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // greenButton
            // 
            this.greenButton.Location = new System.Drawing.Point(295, 131);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(111, 23);
            this.greenButton.TabIndex = 7;
            this.greenButton.Text = "Zielona dioda";
            this.greenButton.UseVisualStyleBackColor = true;
            this.greenButton.Click += new System.EventHandler(this.greenButton_Click);
            // 
            // yellowButton
            // 
            this.yellowButton.Location = new System.Drawing.Point(295, 160);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(111, 23);
            this.yellowButton.TabIndex = 8;
            this.yellowButton.Text = "Żółta dioda";
            this.yellowButton.UseVisualStyleBackColor = true;
            this.yellowButton.Click += new System.EventHandler(this.yellowButton_Click);
            // 
            // odczytKarty
            // 
            this.odczytKarty.Location = new System.Drawing.Point(83, 434);
            this.odczytKarty.Name = "odczytKarty";
            this.odczytKarty.Size = new System.Drawing.Size(123, 39);
            this.odczytKarty.TabIndex = 9;
            this.odczytKarty.Text = "Odczytaj dane z karty";
            this.odczytKarty.UseVisualStyleBackColor = true;
            this.odczytKarty.Click += new System.EventHandler(this.odczytKarty_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Kod wydziału";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Kod karty";
            // 
            // kodWydzialuText
            // 
            this.kodWydzialuText.Location = new System.Drawing.Point(354, 434);
            this.kodWydzialuText.Name = "kodWydzialuText";
            this.kodWydzialuText.ReadOnly = true;
            this.kodWydzialuText.Size = new System.Drawing.Size(169, 20);
            this.kodWydzialuText.TabIndex = 13;
            // 
            // kodKartyText
            // 
            this.kodKartyText.Location = new System.Drawing.Point(354, 477);
            this.kodKartyText.Name = "kodKartyText";
            this.kodKartyText.ReadOnly = true;
            this.kodKartyText.Size = new System.Drawing.Size(169, 20);
            this.kodKartyText.TabIndex = 14;
            // 
            // odczytKlawiatura
            // 
            this.odczytKlawiatura.Location = new System.Drawing.Point(83, 547);
            this.odczytKlawiatura.Name = "odczytKlawiatura";
            this.odczytKlawiatura.Size = new System.Drawing.Size(123, 36);
            this.odczytKlawiatura.TabIndex = 15;
            this.odczytKlawiatura.Text = "Odczytaj dane z klawiatury";
            this.odczytKlawiatura.UseVisualStyleBackColor = true;
            this.odczytKlawiatura.Click += new System.EventHandler(this.odczytKlawiatura_Click);
            // 
            // pinText
            // 
            this.pinText.Location = new System.Drawing.Point(335, 547);
            this.pinText.Name = "pinText";
            this.pinText.ReadOnly = true;
            this.pinText.Size = new System.Drawing.Size(169, 20);
            this.pinText.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 550);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Wpisany pin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 664);
            this.Controls.Add(this.pinText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.odczytKlawiatura);
            this.Controls.Add(this.kodKartyText);
            this.Controls.Add(this.kodWydzialuText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.odczytKarty);
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.trybKlawiatury);
            this.Controls.Add(this.trybKarty);
            this.Controls.Add(this.isConnected);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.odczytLista);
            this.Controls.Add(this.wyslaneLista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox wyslaneLista;
        private System.Windows.Forms.ListBox odczytLista;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Label isConnected;
        private System.Windows.Forms.Button trybKarty;
        private System.Windows.Forms.Button trybKlawiatury;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button yellowButton;
        private System.Windows.Forms.Button odczytKarty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kodWydzialuText;
        private System.Windows.Forms.TextBox kodKartyText;
        private System.Windows.Forms.Button odczytKlawiatura;
        private System.Windows.Forms.TextBox pinText;
        private System.Windows.Forms.Label label5;
    }
}

