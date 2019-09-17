using BitMEX;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using ToastNotifications;

namespace BitMEXAssistant
{
    public partial class APIInfo : MetroForm
    {

        BitMEXApi bitmex;
        public bool APIValid = false;
        public bool FormClosed = false;

        public APIInfo()
        {
            InitializeComponent();
            InitializeSettings();
        }

        private void InitializeSettings()
        {

            chkConsent.Checked = Properties.Settings.Default.Consent;

            switch(Properties.Settings.Default.Network)
            {
                case "Real":
                    rbNetworkReal.Checked = true;
                    rbNetworkTest.Checked = false;
                    txtKey.Text = Properties.Settings.Default.APIKey;
                    txtSecret.Text = Properties.Settings.Default.APISecret;
                    break;
                case "Test":
                    rbNetworkReal.Checked = false;
                    rbNetworkTest.Checked = true;
                    txtKey.Text = Properties.Settings.Default.TestAPIKey;
                    txtSecret.Text = Properties.Settings.Default.TestAPISecret;
                    break;
                default:
                    rbNetworkReal.Checked = false;
                    rbNetworkTest.Checked = true;
                    txtKey.Text = Properties.Settings.Default.TestAPIKey;
                    txtSecret.Text = Properties.Settings.Default.TestAPISecret;
                    break;
            }
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {

            if(chkConsent.Checked)
            {
                try
                {
                    bool RealNetwork = (Properties.Settings.Default.Network == "Real"); // Set the bool = true if the setting is real network, false if test
                    bitmex = new BitMEXApi(txtKey.Text.Trim(), txtSecret.Text.Trim(), RealNetwork);
                    GetAPIValidity();
                    if (APIValid)
                    {
                        // Check permissions for the API Key.
                        bool hasPermission = bitmex.GetAPIKeyPermissions();

                        if (hasPermission)
                        {
                            Notification Test = new Notification("API Valid", "You were able to successfully log in with your API Key and Secret", 5, FormAnimator.AnimationMethod.Fade, FormAnimator.AnimationDirection.Down);
                            Test.Show();
                            this.Visible = false;
                        }
                        else
                        {
                            APIValid = false;
                            lblAPIStatus.Text = "API info does not have correct permissions!";
                            lblAPIStatus.ForeColor = Color.Red;
                        }
                    }
                }
                catch (Exception ex)
                {
                    // If it shoots an error, API is invalid.
                    APIValid = false;
                    lblAPIStatus.Text = "API info is invalid!";
                    lblAPIStatus.ForeColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("Please acknowledge the risks of using this application and accept responsibility for trades made by the application if you wish to continue.  \n\nDo this by reading the warning on the API Info form and checking the box under the warning that is followed by ''I understand'' if you acknowledge the risks and accept responsibility for trades made with the application.");
            }
        }

        // Check account balance/validity
        private void GetAPIValidity()
        {
            decimal WalletBalance = 0;
            try // Code is simple, if we get our account balance without an error the API is valid, if not, it will throw an error and API will be marked not valid.
            {

                WalletBalance = bitmex.GetAccountBalance();
                if (WalletBalance >= 0)
                {
                    APIValid = true;
                    lblAPIStatus.Text = "API info valid.";
                    lblAPIStatus.ForeColor = Color.Green;
                }
                else
                {
                    APIValid = false;
                    lblAPIStatus.Text = "API info is invalid!";
                    lblAPIStatus.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                APIValid = false;
                lblAPIStatus.Text = "API info is invalid!";
                lblAPIStatus.ForeColor = Color.Red;
            }
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.Save();
        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {
            switch (Properties.Settings.Default.Network)
            {
                case "Real":
                    Properties.Settings.Default.APIKey = txtKey.Text.Trim();
                    break;
                case "Test":
                    Properties.Settings.Default.TestAPIKey = txtKey.Text.Trim();
                    break;
                default:
                    Properties.Settings.Default.TestAPIKey = txtKey.Text.Trim();
                    break;
            }
            
            SaveSettings();
        }

        private void txtSecret_TextChanged(object sender, EventArgs e)
        {
            switch (Properties.Settings.Default.Network)
            {
                case "Real":
                    Properties.Settings.Default.APISecret = txtSecret.Text.Trim();
                    break;
                case "Test":
                    Properties.Settings.Default.TestAPISecret = txtSecret.Text.Trim();
                    break;
                default:
                    Properties.Settings.Default.TestAPISecret = txtSecret.Text.Trim();
                    break;
            }
            
            SaveSettings();
        }

        private void APIInfo_Load(object sender, EventArgs e)
        {

        }

        private void rbNetworkReal_CheckedChanged(object sender, EventArgs e)
        {
            if(rbNetworkReal.Checked)
            {
                Properties.Settings.Default.Network = "Real";
                SaveSettings();
                txtKey.Text = Properties.Settings.Default.APIKey;
                txtSecret.Text = Properties.Settings.Default.APISecret;
            }
        }

        private void rbNetworkTest_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNetworkTest.Checked)
            {
                Properties.Settings.Default.Network = "Test";
                SaveSettings();
                txtKey.Text = Properties.Settings.Default.TestAPIKey;
                txtSecret.Text = Properties.Settings.Default.TestAPISecret;
            }
        }

        private void chkConsent_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Consent = chkConsent.Checked;
            SaveSettings();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            FormClosed = true;
            this.Visible = false;
        }
    }

    
}
