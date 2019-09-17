namespace BitMEXAssistant
{
    partial class APIInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(APIInfo));
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.txtKey = new MetroFramework.Controls.MetroTextBox();
            this.txtSecret = new MetroFramework.Controls.MetroTextBox();
            this.btnValidate = new MetroFramework.Controls.MetroButton();
            this.rbNetworkTest = new MetroFramework.Controls.MetroRadioButton();
            this.rbNetworkReal = new MetroFramework.Controls.MetroRadioButton();
            this.chkConsent = new MetroFramework.Controls.MetroCheckBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.lblAPIStatus = new MetroFramework.Controls.MetroLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.label1.Location = new System.Drawing.Point(34, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Key:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.label2.Location = new System.Drawing.Point(16, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Secret:";
            // 
            // txtKey
            // 
            // 
            // 
            // 
            this.txtKey.CustomButton.Image = null;
            this.txtKey.CustomButton.Location = new System.Drawing.Point(387, 2);
            this.txtKey.CustomButton.Name = "";
            this.txtKey.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtKey.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKey.CustomButton.TabIndex = 1;
            this.txtKey.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKey.CustomButton.UseSelectable = true;
            this.txtKey.CustomButton.Visible = false;
            this.txtKey.Lines = new string[] {
        "AKL23@LWLJCMQPQIOSCU3829"};
            this.txtKey.Location = new System.Drawing.Point(70, 66);
            this.txtKey.MaxLength = 32767;
            this.txtKey.Name = "txtKey";
            this.txtKey.PasswordChar = '*';
            this.txtKey.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKey.SelectedText = "";
            this.txtKey.SelectionLength = 0;
            this.txtKey.SelectionStart = 0;
            this.txtKey.ShortcutsEnabled = true;
            this.txtKey.Size = new System.Drawing.Size(415, 30);
            this.txtKey.TabIndex = 2;
            this.txtKey.Text = "AKL23@LWLJCMQPQIOSCU3829";
            this.txtKey.UseSelectable = true;
            this.txtKey.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKey.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
            // 
            // txtSecret
            // 
            // 
            // 
            // 
            this.txtSecret.CustomButton.Image = null;
            this.txtSecret.CustomButton.Location = new System.Drawing.Point(387, 2);
            this.txtSecret.CustomButton.Name = "";
            this.txtSecret.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtSecret.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSecret.CustomButton.TabIndex = 1;
            this.txtSecret.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSecret.CustomButton.UseSelectable = true;
            this.txtSecret.CustomButton.Visible = false;
            this.txtSecret.Lines = new string[] {
        "AKL23@LWLJCMQPQIOSCU3829"};
            this.txtSecret.Location = new System.Drawing.Point(70, 95);
            this.txtSecret.MaxLength = 32767;
            this.txtSecret.Name = "txtSecret";
            this.txtSecret.PasswordChar = '*';
            this.txtSecret.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSecret.SelectedText = "";
            this.txtSecret.SelectionLength = 0;
            this.txtSecret.SelectionStart = 0;
            this.txtSecret.ShortcutsEnabled = true;
            this.txtSecret.Size = new System.Drawing.Size(415, 30);
            this.txtSecret.TabIndex = 3;
            this.txtSecret.Text = "AKL23@LWLJCMQPQIOSCU3829";
            this.txtSecret.UseSelectable = true;
            this.txtSecret.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSecret.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSecret.TextChanged += new System.EventHandler(this.txtSecret_TextChanged);
            // 
            // btnValidate
            // 
            this.btnValidate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnValidate.Location = new System.Drawing.Point(469, 66);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(78, 59);
            this.btnValidate.TabIndex = 4;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseSelectable = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // rbNetworkTest
            // 
            this.rbNetworkTest.AutoSize = true;
            this.rbNetworkTest.Location = new System.Drawing.Point(553, 97);
            this.rbNetworkTest.Name = "rbNetworkTest";
            this.rbNetworkTest.Size = new System.Drawing.Size(44, 15);
            this.rbNetworkTest.TabIndex = 1;
            this.rbNetworkTest.Text = "Test";
            this.rbNetworkTest.UseSelectable = true;
            this.rbNetworkTest.CheckedChanged += new System.EventHandler(this.rbNetworkTest_CheckedChanged);
            // 
            // rbNetworkReal
            // 
            this.rbNetworkReal.AutoSize = true;
            this.rbNetworkReal.Checked = true;
            this.rbNetworkReal.Location = new System.Drawing.Point(553, 74);
            this.rbNetworkReal.Name = "rbNetworkReal";
            this.rbNetworkReal.Size = new System.Drawing.Size(45, 15);
            this.rbNetworkReal.TabIndex = 0;
            this.rbNetworkReal.TabStop = true;
            this.rbNetworkReal.Text = "Real";
            this.rbNetworkReal.UseSelectable = true;
            this.rbNetworkReal.CheckedChanged += new System.EventHandler(this.rbNetworkReal_CheckedChanged);
            // 
            // chkConsent
            // 
            this.chkConsent.AutoSize = true;
            this.chkConsent.Location = new System.Drawing.Point(73, 175);
            this.chkConsent.Name = "chkConsent";
            this.chkConsent.Size = new System.Drawing.Size(89, 15);
            this.chkConsent.TabIndex = 9;
            this.chkConsent.Text = "I understand";
            this.chkConsent.UseSelectable = true;
            this.chkConsent.CheckedChanged += new System.EventHandler(this.chkConsent_CheckedChanged);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblAPIStatus
            // 
            this.lblAPIStatus.AutoSize = true;
            this.lblAPIStatus.ForeColor = System.Drawing.Color.Gold;
            this.lblAPIStatus.Location = new System.Drawing.Point(4, 202);
            this.lblAPIStatus.Name = "lblAPIStatus";
            this.lblAPIStatus.Size = new System.Drawing.Size(127, 19);
            this.lblAPIStatus.TabIndex = 11;
            this.lblAPIStatus.Text = "API Validation Status";
            this.lblAPIStatus.UseCustomBackColor = true;
            this.lblAPIStatus.UseCustomForeColor = true;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(70, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(477, 44);
            this.label4.TabIndex = 12;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.Red;
            this.metroButton1.ForeColor = System.Drawing.Color.Black;
            this.metroButton1.Location = new System.Drawing.Point(568, 12);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(42, 23);
            this.metroButton1.TabIndex = 13;
            this.metroButton1.Text = "EXIT";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(349, 202);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(261, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "This application is not affiliated with BitMEX";
            this.metroLabel1.UseStyleColors = true;
            // 
            // APIInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(618, 225);
            this.ControlBox = false;
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.rbNetworkTest);
            this.Controls.Add(this.chkConsent);
            this.Controls.Add(this.rbNetworkReal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAPIStatus);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.txtSecret);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "APIInfo";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "API Information";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.APIInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroLabel label2;
        private MetroFramework.Controls.MetroTextBox txtKey;
        private MetroFramework.Controls.MetroTextBox txtSecret;
        private MetroFramework.Controls.MetroButton btnValidate;
        private MetroFramework.Controls.MetroRadioButton rbNetworkTest;
        private MetroFramework.Controls.MetroRadioButton rbNetworkReal;
        private MetroFramework.Controls.MetroCheckBox chkConsent;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLabel lblAPIStatus;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}

