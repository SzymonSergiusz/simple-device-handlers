namespace KARTA_MUZYCZNA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.browseFilesButton = new System.Windows.Forms.Button();
            this.stopPlaysound = new System.Windows.Forms.Button();
            this.pausePlaysound = new System.Windows.Forms.Button();
            this.playPlaysound = new System.Windows.Forms.Button();
            this.axWMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.pathInput = new System.Windows.Forms.TextBox();
            this.wmpPlay = new System.Windows.Forms.Button();
            this.wmpPause = new System.Windows.Forms.Button();
            this.wmpStop = new System.Windows.Forms.Button();
            this.mciPlay = new System.Windows.Forms.Button();
            this.mciPause = new System.Windows.Forms.Button();
            this.mciStop = new System.Windows.Forms.Button();
            this.playWOW = new System.Windows.Forms.Button();
            this.pauseWOW = new System.Windows.Forms.Button();
            this.stopWOW = new System.Windows.Forms.Button();
            this.playDS = new System.Windows.Forms.Button();
            this.pauseDS = new System.Windows.Forms.Button();
            this.stopDS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.recordButton = new System.Windows.Forms.Button();
            this.recordedFile = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).BeginInit();
            this.SuspendLayout();
            // 
            // browseFilesButton
            // 
            this.browseFilesButton.Location = new System.Drawing.Point(29, 54);
            this.browseFilesButton.Name = "browseFilesButton";
            this.browseFilesButton.Size = new System.Drawing.Size(136, 49);
            this.browseFilesButton.TabIndex = 0;
            this.browseFilesButton.Text = "Wybierz plik";
            this.browseFilesButton.UseVisualStyleBackColor = true;
            this.browseFilesButton.Click += new System.EventHandler(this.browseFilesButton_Click);
            // 
            // stopPlaysound
            // 
            this.stopPlaysound.Location = new System.Drawing.Point(427, 233);
            this.stopPlaysound.Name = "stopPlaysound";
            this.stopPlaysound.Size = new System.Drawing.Size(85, 34);
            this.stopPlaysound.TabIndex = 1;
            this.stopPlaysound.Text = "STOP";
            this.stopPlaysound.UseVisualStyleBackColor = true;
            this.stopPlaysound.Click += new System.EventHandler(this.stopPlaysound_Click);
            // 
            // pausePlaysound
            // 
            this.pausePlaysound.Location = new System.Drawing.Point(298, 233);
            this.pausePlaysound.Name = "pausePlaysound";
            this.pausePlaysound.Size = new System.Drawing.Size(94, 34);
            this.pausePlaysound.TabIndex = 2;
            this.pausePlaysound.Text = "PAUSE";
            this.pausePlaysound.UseVisualStyleBackColor = true;
            this.pausePlaysound.Click += new System.EventHandler(this.pausePlaysound_Click);
            // 
            // playPlaysound
            // 
            this.playPlaysound.Location = new System.Drawing.Point(173, 233);
            this.playPlaysound.Name = "playPlaysound";
            this.playPlaysound.Size = new System.Drawing.Size(90, 34);
            this.playPlaysound.TabIndex = 3;
            this.playPlaysound.Text = "PLAY";
            this.playPlaysound.UseVisualStyleBackColor = true;
            this.playPlaysound.Click += new System.EventHandler(this.playPlaysound_Click);
            // 
            // axWMP
            // 
            this.axWMP.Enabled = true;
            this.axWMP.Location = new System.Drawing.Point(529, 303);
            this.axWMP.Name = "axWMP";
            this.axWMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMP.OcxState")));
            this.axWMP.Size = new System.Drawing.Size(559, 46);
            this.axWMP.TabIndex = 4;
            this.axWMP.Enter += new System.EventHandler(this.axWMP_Enter);
            // 
            // pathInput
            // 
            this.pathInput.Enabled = false;
            this.pathInput.Location = new System.Drawing.Point(206, 65);
            this.pathInput.Name = "pathInput";
            this.pathInput.Size = new System.Drawing.Size(444, 26);
            this.pathInput.TabIndex = 5;
            // 
            // wmpPlay
            // 
            this.wmpPlay.Location = new System.Drawing.Point(173, 303);
            this.wmpPlay.Name = "wmpPlay";
            this.wmpPlay.Size = new System.Drawing.Size(90, 34);
            this.wmpPlay.TabIndex = 8;
            this.wmpPlay.Text = "PLAY";
            this.wmpPlay.UseVisualStyleBackColor = true;
            this.wmpPlay.Click += new System.EventHandler(this.wmpPlay_Click);
            // 
            // wmpPause
            // 
            this.wmpPause.Location = new System.Drawing.Point(298, 303);
            this.wmpPause.Name = "wmpPause";
            this.wmpPause.Size = new System.Drawing.Size(94, 34);
            this.wmpPause.TabIndex = 7;
            this.wmpPause.Text = "PAUSE";
            this.wmpPause.UseVisualStyleBackColor = true;
            this.wmpPause.Click += new System.EventHandler(this.wmpPause_Click);
            // 
            // wmpStop
            // 
            this.wmpStop.Location = new System.Drawing.Point(427, 303);
            this.wmpStop.Name = "wmpStop";
            this.wmpStop.Size = new System.Drawing.Size(85, 34);
            this.wmpStop.TabIndex = 6;
            this.wmpStop.Text = "STOP";
            this.wmpStop.UseVisualStyleBackColor = true;
            this.wmpStop.Click += new System.EventHandler(this.wmpStop_Click);
            // 
            // mciPlay
            // 
            this.mciPlay.Location = new System.Drawing.Point(173, 379);
            this.mciPlay.Name = "mciPlay";
            this.mciPlay.Size = new System.Drawing.Size(90, 34);
            this.mciPlay.TabIndex = 11;
            this.mciPlay.Text = "PLAY";
            this.mciPlay.UseVisualStyleBackColor = true;
            this.mciPlay.Click += new System.EventHandler(this.mciPlay_Click);
            // 
            // mciPause
            // 
            this.mciPause.Location = new System.Drawing.Point(298, 379);
            this.mciPause.Name = "mciPause";
            this.mciPause.Size = new System.Drawing.Size(94, 34);
            this.mciPause.TabIndex = 10;
            this.mciPause.Text = "PAUSE";
            this.mciPause.UseVisualStyleBackColor = true;
            this.mciPause.Click += new System.EventHandler(this.mciPause_Click);
            // 
            // mciStop
            // 
            this.mciStop.Location = new System.Drawing.Point(427, 379);
            this.mciStop.Name = "mciStop";
            this.mciStop.Size = new System.Drawing.Size(85, 34);
            this.mciStop.TabIndex = 9;
            this.mciStop.Text = "STOP";
            this.mciStop.UseVisualStyleBackColor = true;
            this.mciStop.Click += new System.EventHandler(this.mciStop_Click);
            // 
            // playWOW
            // 
            this.playWOW.Location = new System.Drawing.Point(173, 446);
            this.playWOW.Name = "playWOW";
            this.playWOW.Size = new System.Drawing.Size(90, 34);
            this.playWOW.TabIndex = 14;
            this.playWOW.Text = "PLAY";
            this.playWOW.UseVisualStyleBackColor = true;
            this.playWOW.Click += new System.EventHandler(this.playWOW_Click);
            // 
            // pauseWOW
            // 
            this.pauseWOW.Location = new System.Drawing.Point(298, 446);
            this.pauseWOW.Name = "pauseWOW";
            this.pauseWOW.Size = new System.Drawing.Size(94, 34);
            this.pauseWOW.TabIndex = 13;
            this.pauseWOW.Text = "PAUSE";
            this.pauseWOW.UseVisualStyleBackColor = true;
            this.pauseWOW.Click += new System.EventHandler(this.pauseWOW_Click);
            // 
            // stopWOW
            // 
            this.stopWOW.Location = new System.Drawing.Point(427, 446);
            this.stopWOW.Name = "stopWOW";
            this.stopWOW.Size = new System.Drawing.Size(85, 34);
            this.stopWOW.TabIndex = 12;
            this.stopWOW.Text = "STOP";
            this.stopWOW.UseVisualStyleBackColor = true;
            this.stopWOW.Click += new System.EventHandler(this.stopWOW_Click);
            // 
            // playDS
            // 
            this.playDS.Location = new System.Drawing.Point(173, 518);
            this.playDS.Name = "playDS";
            this.playDS.Size = new System.Drawing.Size(90, 34);
            this.playDS.TabIndex = 17;
            this.playDS.Text = "PLAY";
            this.playDS.UseVisualStyleBackColor = true;
            // 
            // pauseDS
            // 
            this.pauseDS.Location = new System.Drawing.Point(298, 518);
            this.pauseDS.Name = "pauseDS";
            this.pauseDS.Size = new System.Drawing.Size(94, 34);
            this.pauseDS.TabIndex = 16;
            this.pauseDS.Text = "PAUSE";
            this.pauseDS.UseVisualStyleBackColor = true;
            // 
            // stopDS
            // 
            this.stopDS.Location = new System.Drawing.Point(427, 518);
            this.stopDS.Name = "stopDS";
            this.stopDS.Size = new System.Drawing.Size(85, 34);
            this.stopDS.TabIndex = 15;
            this.stopDS.Text = "STOP";
            this.stopDS.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Playsound";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "WMP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Wave Out";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "MCI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 525);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Direct Sound";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // recordButton
            // 
            this.recordButton.Location = new System.Drawing.Point(39, 718);
            this.recordButton.Name = "recordButton";
            this.recordButton.Size = new System.Drawing.Size(139, 68);
            this.recordButton.TabIndex = 23;
            this.recordButton.Text = "Nagrywaj";
            this.recordButton.UseVisualStyleBackColor = true;
            this.recordButton.Click += new System.EventHandler(this.recordButton_Click);
            // 
            // recordedFile
            // 
            this.recordedFile.Location = new System.Drawing.Point(222, 739);
            this.recordedFile.Name = "recordedFile";
            this.recordedFile.Size = new System.Drawing.Size(271, 26);
            this.recordedFile.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 893);
            this.Controls.Add(this.recordedFile);
            this.Controls.Add(this.recordButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playDS);
            this.Controls.Add(this.pauseDS);
            this.Controls.Add(this.stopDS);
            this.Controls.Add(this.playWOW);
            this.Controls.Add(this.pauseWOW);
            this.Controls.Add(this.stopWOW);
            this.Controls.Add(this.mciPlay);
            this.Controls.Add(this.mciPause);
            this.Controls.Add(this.mciStop);
            this.Controls.Add(this.wmpPlay);
            this.Controls.Add(this.wmpPause);
            this.Controls.Add(this.wmpStop);
            this.Controls.Add(this.pathInput);
            this.Controls.Add(this.axWMP);
            this.Controls.Add(this.playPlaysound);
            this.Controls.Add(this.pausePlaysound);
            this.Controls.Add(this.stopPlaysound);
            this.Controls.Add(this.browseFilesButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseFilesButton;
        private System.Windows.Forms.Button stopPlaysound;
        private System.Windows.Forms.Button pausePlaysound;
        private System.Windows.Forms.Button playPlaysound;
        private AxWMPLib.AxWindowsMediaPlayer axWMP;
        private System.Windows.Forms.TextBox pathInput;
        private System.Windows.Forms.Button wmpPlay;
        private System.Windows.Forms.Button wmpPause;
        private System.Windows.Forms.Button wmpStop;
        private System.Windows.Forms.Button mciPlay;
        private System.Windows.Forms.Button mciPause;
        private System.Windows.Forms.Button mciStop;
        private System.Windows.Forms.Button playWOW;
        private System.Windows.Forms.Button pauseWOW;
        private System.Windows.Forms.Button stopWOW;
        private System.Windows.Forms.Button playDS;
        private System.Windows.Forms.Button pauseDS;
        private System.Windows.Forms.Button stopDS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button recordButton;
        private System.Windows.Forms.TextBox recordedFile;
    }
}

