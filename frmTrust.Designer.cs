
namespace BiblePayTrustGenerator
{
    partial class frmTrust
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrust));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPubKey = new System.Windows.Forms.TextBox();
            this.txtPrivKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtMaturityDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerateTrust = new System.Windows.Forms.Button();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.chkTestNet = new System.Windows.Forms.CheckBox();
            this.lnkInfo = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your BiblePay Trust Public Key:";
            // 
            // txtPubKey
            // 
            this.txtPubKey.Location = new System.Drawing.Point(45, 180);
            this.txtPubKey.Name = "txtPubKey";
            this.txtPubKey.ReadOnly = true;
            this.txtPubKey.Size = new System.Drawing.Size(601, 44);
            this.txtPubKey.TabIndex = 1;
            // 
            // txtPrivKey
            // 
            this.txtPrivKey.Location = new System.Drawing.Point(45, 301);
            this.txtPrivKey.Name = "txtPrivKey";
            this.txtPrivKey.ReadOnly = true;
            this.txtPrivKey.Size = new System.Drawing.Size(929, 44);
            this.txtPrivKey.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose Maturity Date:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BiblePayTrustGenerator.Properties.Resources.bbp_logo_primary;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(663, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 288);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // dtMaturityDate
            // 
            this.dtMaturityDate.Location = new System.Drawing.Point(45, 69);
            this.dtMaturityDate.Name = "dtMaturityDate";
            this.dtMaturityDate.Size = new System.Drawing.Size(601, 44);
            this.dtMaturityDate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(447, 40);
            this.label3.TabIndex = 6;
            this.label3.Text = "Your BiblePay Trust Private Key:";
            // 
            // btnGenerateTrust
            // 
            this.btnGenerateTrust.Location = new System.Drawing.Point(45, 436);
            this.btnGenerateTrust.Name = "btnGenerateTrust";
            this.btnGenerateTrust.Size = new System.Drawing.Size(262, 61);
            this.btnGenerateTrust.TabIndex = 7;
            this.btnGenerateTrust.Text = "Generate Trust";
            this.btnGenerateTrust.UseVisualStyleBackColor = true;
            this.btnGenerateTrust.Click += new System.EventHandler(this.btnGenerateTrust_Click);
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Location = new System.Drawing.Point(332, 436);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(201, 61);
            this.btnSaveToFile.TabIndex = 8;
            this.btnSaveToFile.Text = "Save To File";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(38, 515);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(695, 40);
            this.lblInfo.TabIndex = 9;
            this.lblInfo.Text = "** For help and information, please visit this page: ";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(45, 585);
            this.progressBar1.Maximum = 120;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1013, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 10;
            this.progressBar1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chkTestNet
            // 
            this.chkTestNet.AutoSize = true;
            this.chkTestNet.Location = new System.Drawing.Point(45, 375);
            this.chkTestNet.Name = "chkTestNet";
            this.chkTestNet.Size = new System.Drawing.Size(160, 44);
            this.chkTestNet.TabIndex = 11;
            this.chkTestNet.Text = "TESTNET";
            this.chkTestNet.UseVisualStyleBackColor = true;
            // 
            // lnkInfo
            // 
            this.lnkInfo.AutoSize = true;
            this.lnkInfo.Location = new System.Drawing.Point(49, 553);
            this.lnkInfo.Name = "lnkInfo";
            this.lnkInfo.Size = new System.Drawing.Size(155, 40);
            this.lnkInfo.TabIndex = 12;
            this.lnkInfo.TabStop = true;
            this.lnkInfo.Text = "linkLabel1";
            this.lnkInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkInfo_LinkClicked);
            // 
            // frmTrust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 647);
            this.Controls.Add(this.lnkInfo);
            this.Controls.Add(this.chkTestNet);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.btnGenerateTrust);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtMaturityDate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPrivKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPubKey);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frmTrust";
            this.Text = "BiblePay Trust Generator v1.0";
            this.Load += new System.EventHandler(this.frmTrust_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPubKey;
        private System.Windows.Forms.TextBox txtPrivKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtMaturityDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGenerateTrust;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox chkTestNet;
        private System.Windows.Forms.LinkLabel lnkInfo;
    }
}

