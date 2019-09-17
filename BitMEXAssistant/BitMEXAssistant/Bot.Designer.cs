namespace BitMEXAssistant
{
    partial class Bot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bot));
            this.ddlCandleTimes = new MetroFramework.Controls.MetroComboBox();
            this.ddlSymbol = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.Heartbeat = new System.Windows.Forms.Timer(this.components);
            this.TabControl = new MetroFramework.Controls.MetroTabControl();
            this.tabManual = new MetroFramework.Controls.MetroTabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnManualLimitCancelOpenOrders = new MetroFramework.Controls.MetroButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chkManualLimitPercentModifierUseCurrentPrice = new MetroFramework.Controls.MetroCheckBox();
            this.nudManualLimitPercentModifier4 = new System.Windows.Forms.NumericUpDown();
            this.btnManualLimitPercentModifier4Up = new MetroFramework.Controls.MetroButton();
            this.btnManualLimitPercentModifier4Down = new MetroFramework.Controls.MetroButton();
            this.nudManualLimitPercentModifier3 = new System.Windows.Forms.NumericUpDown();
            this.btnManualLimitPercentModifier3Up = new MetroFramework.Controls.MetroButton();
            this.btnManualLimitPercentModifier3Down = new MetroFramework.Controls.MetroButton();
            this.nudManualLimitPercentModifier2 = new System.Windows.Forms.NumericUpDown();
            this.btnManualLimitPercentModifier2Up = new MetroFramework.Controls.MetroButton();
            this.btnManualLimitPercentModifier2Down = new MetroFramework.Controls.MetroButton();
            this.nudManualLimitPercentModifier1 = new System.Windows.Forms.NumericUpDown();
            this.btnManualLimitPercentModifier1Up = new MetroFramework.Controls.MetroButton();
            this.btnManualLimitPercentModifier1Down = new MetroFramework.Controls.MetroButton();
            this.chkManualLimitHiddenOrder = new MetroFramework.Controls.MetroCheckBox();
            this.btnManualLimitSetCurrentPrice = new MetroFramework.Controls.MetroButton();
            this.btnManualLimitSell = new MetroFramework.Controls.MetroButton();
            this.chkManualLimitCancelWhileOrdering = new MetroFramework.Controls.MetroCheckBox();
            this.btnManualLimitBuy = new MetroFramework.Controls.MetroButton();
            this.chkManualLimitPostOnly = new MetroFramework.Controls.MetroCheckBox();
            this.label20 = new MetroFramework.Controls.MetroLabel();
            this.nudManualLimitPrice = new System.Windows.Forms.NumericUpDown();
            this.chkManualLimitReduceOnly = new MetroFramework.Controls.MetroCheckBox();
            this.label18 = new MetroFramework.Controls.MetroLabel();
            this.nudManualLimitContracts = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnManualMarketSell = new MetroFramework.Controls.MetroButton();
            this.btnManualMarketBuy = new MetroFramework.Controls.MetroButton();
            this.chkManualMarketBuyReduceOnly = new MetroFramework.Controls.MetroCheckBox();
            this.label19 = new MetroFramework.Controls.MetroLabel();
            this.nudManualMarketBuyContracts = new System.Windows.Forms.NumericUpDown();
            this.tabLimitNow = new MetroFramework.Controls.MetroTabPage();
            this.label30 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.chkLimitNowSellReduceOnly = new MetroFramework.Controls.MetroCheckBox();
            this.label29 = new MetroFramework.Controls.MetroLabel();
            this.ddlLimitNowSellMethod = new MetroFramework.Controls.MetroComboBox();
            this.chkLimitNowSellContinue = new MetroFramework.Controls.MetroCheckBox();
            this.nudLimitNowSellContracts = new System.Windows.Forms.NumericUpDown();
            this.label25 = new MetroFramework.Controls.MetroLabel();
            this.label26 = new MetroFramework.Controls.MetroLabel();
            this.nudLimitNowSellTicksFromCenter = new System.Windows.Forms.NumericUpDown();
            this.nudLimitNowSellDelay = new System.Windows.Forms.NumericUpDown();
            this.label27 = new MetroFramework.Controls.MetroLabel();
            this.btnLimitNowSell = new MetroFramework.Controls.MetroButton();
            this.btnLimitNowSellCancel = new MetroFramework.Controls.MetroButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.chkLimitNowBuyReduceOnly = new MetroFramework.Controls.MetroCheckBox();
            this.label28 = new MetroFramework.Controls.MetroLabel();
            this.ddlLimitNowBuyMethod = new MetroFramework.Controls.MetroComboBox();
            this.chkLimitNowBuyContinue = new MetroFramework.Controls.MetroCheckBox();
            this.nudLimitNowBuyContracts = new System.Windows.Forms.NumericUpDown();
            this.label21 = new MetroFramework.Controls.MetroLabel();
            this.label24 = new MetroFramework.Controls.MetroLabel();
            this.nudLimitNowBuyTicksFromCenter = new System.Windows.Forms.NumericUpDown();
            this.nudLimitNowBuyDelay = new System.Windows.Forms.NumericUpDown();
            this.label23 = new MetroFramework.Controls.MetroLabel();
            this.btnLimitNowBuy = new MetroFramework.Controls.MetroButton();
            this.btnLimitNowBuyCancel = new MetroFramework.Controls.MetroButton();
            this.tabSpread = new MetroFramework.Controls.MetroTabPage();
            this.chkSpreadCancelWhileOrdering = new MetroFramework.Controls.MetroCheckBox();
            this.btnSpreadCloseAllOpenOrders = new MetroFramework.Controls.MetroButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkSpreadSellPostOnly = new MetroFramework.Controls.MetroCheckBox();
            this.chkSpreadSellExecute = new MetroFramework.Controls.MetroCheckBox();
            this.nudSpreadSellOrderCount = new System.Windows.Forms.NumericUpDown();
            this.chkSpreadSellReduceOnly = new MetroFramework.Controls.MetroCheckBox();
            this.label12 = new MetroFramework.Controls.MetroLabel();
            this.nudSpreadSellValueApart = new System.Windows.Forms.NumericUpDown();
            this.label13 = new MetroFramework.Controls.MetroLabel();
            this.label14 = new MetroFramework.Controls.MetroLabel();
            this.nudSpreadSellContractsEach = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkSpreadyBuyPostOnly = new MetroFramework.Controls.MetroCheckBox();
            this.chkSpreadBuyExecute = new MetroFramework.Controls.MetroCheckBox();
            this.nudSpreadBuyOrderCount = new System.Windows.Forms.NumericUpDown();
            this.chkSpreadBuyReduceOnly = new MetroFramework.Controls.MetroCheckBox();
            this.label9 = new MetroFramework.Controls.MetroLabel();
            this.nudSpreadBuyValueApart = new System.Windows.Forms.NumericUpDown();
            this.label11 = new MetroFramework.Controls.MetroLabel();
            this.label10 = new MetroFramework.Controls.MetroLabel();
            this.nudSpreadBuyContractsEach = new System.Windows.Forms.NumericUpDown();
            this.btnSpreadPlaceOrders = new MetroFramework.Controls.MetroButton();
            this.tabDCA = new MetroFramework.Controls.MetroTabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkDCAExecuteImmediately = new MetroFramework.Controls.MetroCheckBox();
            this.chkDCAReduceOnly = new MetroFramework.Controls.MetroCheckBox();
            this.label4 = new MetroFramework.Controls.MetroLabel();
            this.nudDCAContracts = new System.Windows.Forms.NumericUpDown();
            this.lblalskdj = new MetroFramework.Controls.MetroLabel();
            this.nudDCAHours = new System.Windows.Forms.NumericUpDown();
            this.nudDCASeconds = new System.Windows.Forms.NumericUpDown();
            this.nudDCATimes = new System.Windows.Forms.NumericUpDown();
            this.label3 = new MetroFramework.Controls.MetroLabel();
            this.label5 = new MetroFramework.Controls.MetroLabel();
            this.nudDCAMinutes = new System.Windows.Forms.NumericUpDown();
            this.label6 = new MetroFramework.Controls.MetroLabel();
            this.pgbDCA = new MetroFramework.Controls.MetroProgressBar();
            this.lblDCASummary = new MetroFramework.Controls.MetroLabel();
            this.btnDCASell = new MetroFramework.Controls.MetroButton();
            this.btnDCABuy = new MetroFramework.Controls.MetroButton();
            this.btnDCAStop = new MetroFramework.Controls.MetroButton();
            this.tabStops = new MetroFramework.Controls.MetroTabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lblTrailingStopLimitPricePreviewLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lblStopTrailingLimitOffsetPrice = new MetroFramework.Controls.MetroLabel();
            this.chkStopTrailingCloseInFull = new MetroFramework.Controls.MetroCheckBox();
            this.chkTrailingStopEnabled = new MetroFramework.Controls.MetroToggle();
            this.nudStopTrailingLimitOffset = new System.Windows.Forms.NumericUpDown();
            this.lblTrailingStopLimitOffset = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.nudStopTrailingContracts = new System.Windows.Forms.NumericUpDown();
            this.lblStopTraillingPrice = new MetroFramework.Controls.MetroLabel();
            this.nudStopTrailingTrail = new System.Windows.Forms.NumericUpDown();
            this.ddlStopTrailingMethod = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tabSettings = new MetroFramework.Controls.MetroTabPage();
            this.lblSettingsWebsocketInfo = new MetroFramework.Controls.MetroLabel();
            this.btnExportCandles = new MetroFramework.Controls.MetroButton();
            this.label8 = new MetroFramework.Controls.MetroLabel();
            this.nudSettingsRetryWaitTime = new System.Windows.Forms.NumericUpDown();
            this.label7 = new MetroFramework.Controls.MetroLabel();
            this.chkSettingOverloadRetry = new MetroFramework.Controls.MetroCheckBox();
            this.nudSettingsOverloadRetryAttempts = new System.Windows.Forms.NumericUpDown();
            this.tabDonate = new MetroFramework.Controls.MetroTabPage();
            this.lblDonateAddress = new MetroFramework.Controls.MetroLabel();
            this.label16 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabVideos = new System.Windows.Forms.TabPage();
            this.tmrDCA = new System.Windows.Forms.Timer(this.components);
            this.btnPositionMargin = new MetroFramework.Controls.MetroButton();
            this.btnPositionMarketClose = new MetroFramework.Controls.MetroButton();
            this.btnPositionLimitClose = new MetroFramework.Controls.MetroButton();
            this.textBox8 = new MetroFramework.Controls.MetroTextBox();
            this.txtPositionLiquidation = new MetroFramework.Controls.MetroTextBox();
            this.textBox1 = new MetroFramework.Controls.MetroTextBox();
            this.textBox2 = new MetroFramework.Controls.MetroTextBox();
            this.textBox3 = new MetroFramework.Controls.MetroTextBox();
            this.textBox4 = new MetroFramework.Controls.MetroTextBox();
            this.textBox5 = new MetroFramework.Controls.MetroTextBox();
            this.textBox7 = new MetroFramework.Controls.MetroTextBox();
            this.txtPositionUnrealizedPnLPercent = new MetroFramework.Controls.MetroTextBox();
            this.txtPositionUnrealizedPnL = new MetroFramework.Controls.MetroTextBox();
            this.txtPositionMargin = new MetroFramework.Controls.MetroTextBox();
            this.txtPositionMarkPrice = new MetroFramework.Controls.MetroTextBox();
            this.txtPositionEntryPrice = new MetroFramework.Controls.MetroTextBox();
            this.txtPositionSize = new MetroFramework.Controls.MetroTextBox();
            this.nudPositionLimitPrice = new System.Windows.Forms.NumericUpDown();
            this.nudPositionMargin = new System.Windows.Forms.NumericUpDown();
            this.tmrClientUpdates = new System.Windows.Forms.Timer(this.components);
            this.nudCurrentPrice = new System.Windows.Forms.NumericUpDown();
            this.lblDonate = new MetroFramework.Controls.MetroLabel();
            this.pbxYouTubeSubscribe = new System.Windows.Forms.PictureBox();
            this.tmrLimitNowBuy = new System.Windows.Forms.Timer(this.components);
            this.tmrLimitNowSell = new System.Windows.Forms.Timer(this.components);
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MetroToolTip = new MetroFramework.Components.MetroToolTip();
            this.lblBalanceAndTime = new MetroFramework.Controls.MetroLabel();
            this.lblNetworkAndVersion = new MetroFramework.Controls.MetroLabel();
            this.pnlPosition = new MetroFramework.Controls.MetroPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.YouTubeVideoBrowser = new System.Windows.Forms.WebBrowser();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.nudSettingsLimitNowMinimumDelay = new System.Windows.Forms.NumericUpDown();
            this.TabControl.SuspendLayout();
            this.tabManual.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudManualLimitPercentModifier4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudManualLimitPercentModifier3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudManualLimitPercentModifier2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudManualLimitPercentModifier1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudManualLimitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudManualLimitContracts)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudManualMarketBuyContracts)).BeginInit();
            this.tabLimitNow.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimitNowSellContracts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimitNowSellTicksFromCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimitNowSellDelay)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimitNowBuyContracts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimitNowBuyTicksFromCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimitNowBuyDelay)).BeginInit();
            this.tabSpread.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpreadSellOrderCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpreadSellValueApart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpreadSellContractsEach)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpreadBuyOrderCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpreadBuyValueApart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpreadBuyContractsEach)).BeginInit();
            this.tabDCA.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDCAContracts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDCAHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDCASeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDCATimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDCAMinutes)).BeginInit();
            this.tabStops.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStopTrailingLimitOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStopTrailingContracts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStopTrailingTrail)).BeginInit();
            this.tabSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSettingsRetryWaitTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSettingsOverloadRetryAttempts)).BeginInit();
            this.tabDonate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPositionLimitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPositionMargin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCurrentPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxYouTubeSubscribe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlPosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSettingsLimitNowMinimumDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // ddlCandleTimes
            // 
            this.ddlCandleTimes.FormattingEnabled = true;
            this.ddlCandleTimes.ItemHeight = 23;
            this.ddlCandleTimes.Items.AddRange(new object[] {
            "1m",
            "5m",
            "1h",
            "1d"});
            this.ddlCandleTimes.Location = new System.Drawing.Point(492, 34);
            this.ddlCandleTimes.Name = "ddlCandleTimes";
            this.ddlCandleTimes.Size = new System.Drawing.Size(57, 29);
            this.ddlCandleTimes.TabIndex = 10;
            this.ddlCandleTimes.UseSelectable = true;
            this.ddlCandleTimes.SelectedIndexChanged += new System.EventHandler(this.ddlCandleTimes_SelectedIndexChanged);
            // 
            // ddlSymbol
            // 
            this.ddlSymbol.FormattingEnabled = true;
            this.ddlSymbol.ItemHeight = 23;
            this.ddlSymbol.Location = new System.Drawing.Point(266, 34);
            this.ddlSymbol.Name = "ddlSymbol";
            this.ddlSymbol.Size = new System.Drawing.Size(95, 29);
            this.ddlSymbol.TabIndex = 11;
            this.ddlSymbol.UseSelectable = true;
            this.ddlSymbol.SelectedIndexChanged += new System.EventHandler(this.ddlSymbol_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.label1.Location = new System.Drawing.Point(266, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Symbol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.label2.Location = new System.Drawing.Point(492, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Time";
            // 
            // Heartbeat
            // 
            this.Heartbeat.Interval = 1000;
            this.Heartbeat.Tick += new System.EventHandler(this.Heartbeat_Tick);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabManual);
            this.TabControl.Controls.Add(this.tabLimitNow);
            this.TabControl.Controls.Add(this.tabSpread);
            this.TabControl.Controls.Add(this.tabDCA);
            this.TabControl.Controls.Add(this.tabStops);
            this.TabControl.Controls.Add(this.tabSettings);
            this.TabControl.Controls.Add(this.tabDonate);
            this.TabControl.Controls.Add(this.tabVideos);
            this.TabControl.Location = new System.Drawing.Point(0, 125);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 1;
            this.TabControl.Size = new System.Drawing.Size(857, 394);
            this.TabControl.Style = MetroFramework.MetroColorStyle.White;
            this.TabControl.TabIndex = 14;
            this.TabControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TabControl.UseSelectable = true;
            this.TabControl.UseStyleColors = true;
            // 
            // tabManual
            // 
            this.tabManual.Controls.Add(this.groupBox5);
            this.tabManual.Controls.Add(this.groupBox4);
            this.tabManual.HorizontalScrollbarBarColor = true;
            this.tabManual.HorizontalScrollbarHighlightOnWheel = false;
            this.tabManual.HorizontalScrollbarSize = 10;
            this.tabManual.Location = new System.Drawing.Point(4, 38);
            this.tabManual.Name = "tabManual";
            this.tabManual.Size = new System.Drawing.Size(849, 352);
            this.tabManual.TabIndex = 4;
            this.tabManual.Text = "Manual Ordering";
            this.tabManual.UseVisualStyleBackColor = true;
            this.tabManual.VerticalScrollbarBarColor = true;
            this.tabManual.VerticalScrollbarHighlightOnWheel = false;
            this.tabManual.VerticalScrollbarSize = 10;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnManualLimitCancelOpenOrders);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.chkManualLimitHiddenOrder);
            this.groupBox5.Controls.Add(this.btnManualLimitSetCurrentPrice);
            this.groupBox5.Controls.Add(this.btnManualLimitSell);
            this.groupBox5.Controls.Add(this.chkManualLimitCancelWhileOrdering);
            this.groupBox5.Controls.Add(this.btnManualLimitBuy);
            this.groupBox5.Controls.Add(this.chkManualLimitPostOnly);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.nudManualLimitPrice);
            this.groupBox5.Controls.Add(this.chkManualLimitReduceOnly);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.nudManualLimitContracts);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox5.Location = new System.Drawing.Point(189, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(561, 160);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Limit";
            // 
            // btnManualLimitCancelOpenOrders
            // 
            this.btnManualLimitCancelOpenOrders.BackColor = System.Drawing.Color.DarkOrange;
            this.btnManualLimitCancelOpenOrders.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnManualLimitCancelOpenOrders.Location = new System.Drawing.Point(353, 108);
            this.btnManualLimitCancelOpenOrders.Name = "btnManualLimitCancelOpenOrders";
            this.btnManualLimitCancelOpenOrders.Size = new System.Drawing.Size(165, 33);
            this.btnManualLimitCancelOpenOrders.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnManualLimitCancelOpenOrders.TabIndex = 18;
            this.btnManualLimitCancelOpenOrders.Text = "Cancel All Orders";
            this.btnManualLimitCancelOpenOrders.UseSelectable = true;
            this.btnManualLimitCancelOpenOrders.UseStyleColors = true;
            this.btnManualLimitCancelOpenOrders.Click += new System.EventHandler(this.btnManualLimitCancelOpenOrders_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chkManualLimitPercentModifierUseCurrentPrice);
            this.groupBox6.Controls.Add(this.nudManualLimitPercentModifier4);
            this.groupBox6.Controls.Add(this.btnManualLimitPercentModifier4Up);
            this.groupBox6.Controls.Add(this.btnManualLimitPercentModifier4Down);
            this.groupBox6.Controls.Add(this.nudManualLimitPercentModifier3);
            this.groupBox6.Controls.Add(this.btnManualLimitPercentModifier3Up);
            this.groupBox6.Controls.Add(this.btnManualLimitPercentModifier3Down);
            this.groupBox6.Controls.Add(this.nudManualLimitPercentModifier2);
            this.groupBox6.Controls.Add(this.btnManualLimitPercentModifier2Up);
            this.groupBox6.Controls.Add(this.btnManualLimitPercentModifier2Down);
            this.groupBox6.Controls.Add(this.nudManualLimitPercentModifier1);
            this.groupBox6.Controls.Add(this.btnManualLimitPercentModifier1Up);
            this.groupBox6.Controls.Add(this.btnManualLimitPercentModifier1Down);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox6.Location = new System.Drawing.Point(6, 16);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(124, 140);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "% Price Modifiers";
            // 
            // chkManualLimitPercentModifierUseCurrentPrice
            // 
            this.chkManualLimitPercentModifierUseCurrentPrice.AutoSize = true;
            this.chkManualLimitPercentModifierUseCurrentPrice.Checked = true;
            this.chkManualLimitPercentModifierUseCurrentPrice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkManualLimitPercentModifierUseCurrentPrice.Location = new System.Drawing.Point(5, 117);
            this.chkManualLimitPercentModifierUseCurrentPrice.Name = "chkManualLimitPercentModifierUseCurrentPrice";
            this.chkManualLimitPercentModifierUseCurrentPrice.Size = new System.Drawing.Size(114, 15);
            this.chkManualLimitPercentModifierUseCurrentPrice.TabIndex = 26;
            this.chkManualLimitPercentModifierUseCurrentPrice.Text = "Use Current Price";
            this.chkManualLimitPercentModifierUseCurrentPrice.UseSelectable = true;
            this.chkManualLimitPercentModifierUseCurrentPrice.CheckedChanged += new System.EventHandler(this.chkManualLimitPercentModifierUseCurrentPrice_CheckedChanged);
            // 
            // nudManualLimitPercentModifier4
            // 
            this.nudManualLimitPercentModifier4.DecimalPlaces = 2;
            this.nudManualLimitPercentModifier4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudManualLimitPercentModifier4.Location = new System.Drawing.Point(5, 93);
            this.nudManualLimitPercentModifier4.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudManualLimitPercentModifier4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudManualLimitPercentModifier4.Name = "nudManualLimitPercentModifier4";
            this.nudManualLimitPercentModifier4.Size = new System.Drawing.Size(72, 20);
            this.nudManualLimitPercentModifier4.TabIndex = 23;
            this.nudManualLimitPercentModifier4.Value = new decimal(new int[] {
            11111,
            0,
            0,
            131072});
            this.nudManualLimitPercentModifier4.ValueChanged += new System.EventHandler(this.nudManualLimitPercentModifier4_ValueChanged);
            // 
            // btnManualLimitPercentModifier4Up
            // 
            this.btnManualLimitPercentModifier4Up.Location = new System.Drawing.Point(101, 92);
            this.btnManualLimitPercentModifier4Up.Name = "btnManualLimitPercentModifier4Up";
            this.btnManualLimitPercentModifier4Up.Size = new System.Drawing.Size(18, 22);
            this.btnManualLimitPercentModifier4Up.TabIndex = 25;
            this.btnManualLimitPercentModifier4Up.Text = "+";
            this.btnManualLimitPercentModifier4Up.UseSelectable = true;
            this.btnManualLimitPercentModifier4Up.Click += new System.EventHandler(this.btnManualLimitPercentModifier4Up_Click);
            // 
            // btnManualLimitPercentModifier4Down
            // 
            this.btnManualLimitPercentModifier4Down.Location = new System.Drawing.Point(83, 92);
            this.btnManualLimitPercentModifier4Down.Name = "btnManualLimitPercentModifier4Down";
            this.btnManualLimitPercentModifier4Down.Size = new System.Drawing.Size(18, 22);
            this.btnManualLimitPercentModifier4Down.TabIndex = 24;
            this.btnManualLimitPercentModifier4Down.Text = "-";
            this.btnManualLimitPercentModifier4Down.UseSelectable = true;
            this.btnManualLimitPercentModifier4Down.Click += new System.EventHandler(this.btnManualLimitPercentModifier4Down_Click);
            // 
            // nudManualLimitPercentModifier3
            // 
            this.nudManualLimitPercentModifier3.DecimalPlaces = 2;
            this.nudManualLimitPercentModifier3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudManualLimitPercentModifier3.Location = new System.Drawing.Point(5, 67);
            this.nudManualLimitPercentModifier3.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudManualLimitPercentModifier3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudManualLimitPercentModifier3.Name = "nudManualLimitPercentModifier3";
            this.nudManualLimitPercentModifier3.Size = new System.Drawing.Size(72, 20);
            this.nudManualLimitPercentModifier3.TabIndex = 20;
            this.nudManualLimitPercentModifier3.Value = new decimal(new int[] {
            11111,
            0,
            0,
            131072});
            this.nudManualLimitPercentModifier3.ValueChanged += new System.EventHandler(this.nudManualLimitPercentModifier3_ValueChanged);
            // 
            // btnManualLimitPercentModifier3Up
            // 
            this.btnManualLimitPercentModifier3Up.Location = new System.Drawing.Point(101, 66);
            this.btnManualLimitPercentModifier3Up.Name = "btnManualLimitPercentModifier3Up";
            this.btnManualLimitPercentModifier3Up.Size = new System.Drawing.Size(18, 22);
            this.btnManualLimitPercentModifier3Up.TabIndex = 22;
            this.btnManualLimitPercentModifier3Up.Text = "+";
            this.btnManualLimitPercentModifier3Up.UseSelectable = true;
            this.btnManualLimitPercentModifier3Up.Click += new System.EventHandler(this.btnManualLimitPercentModifier3Up_Click);
            // 
            // btnManualLimitPercentModifier3Down
            // 
            this.btnManualLimitPercentModifier3Down.Location = new System.Drawing.Point(83, 66);
            this.btnManualLimitPercentModifier3Down.Name = "btnManualLimitPercentModifier3Down";
            this.btnManualLimitPercentModifier3Down.Size = new System.Drawing.Size(18, 22);
            this.btnManualLimitPercentModifier3Down.TabIndex = 21;
            this.btnManualLimitPercentModifier3Down.Text = "-";
            this.btnManualLimitPercentModifier3Down.UseSelectable = true;
            this.btnManualLimitPercentModifier3Down.Click += new System.EventHandler(this.btnManualLimitPercentModifier3Down_Click);
            // 
            // nudManualLimitPercentModifier2
            // 
            this.nudManualLimitPercentModifier2.DecimalPlaces = 2;
            this.nudManualLimitPercentModifier2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudManualLimitPercentModifier2.Location = new System.Drawing.Point(5, 41);
            this.nudManualLimitPercentModifier2.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudManualLimitPercentModifier2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudManualLimitPercentModifier2.Name = "nudManualLimitPercentModifier2";
            this.nudManualLimitPercentModifier2.Size = new System.Drawing.Size(72, 20);
            this.nudManualLimitPercentModifier2.TabIndex = 17;
            this.nudManualLimitPercentModifier2.Value = new decimal(new int[] {
            11111,
            0,
            0,
            131072});
            this.nudManualLimitPercentModifier2.ValueChanged += new System.EventHandler(this.nudManualLimitPercentModifier2_ValueChanged);
            // 
            // btnManualLimitPercentModifier2Up
            // 
            this.btnManualLimitPercentModifier2Up.Location = new System.Drawing.Point(101, 40);
            this.btnManualLimitPercentModifier2Up.Name = "btnManualLimitPercentModifier2Up";
            this.btnManualLimitPercentModifier2Up.Size = new System.Drawing.Size(18, 22);
            this.btnManualLimitPercentModifier2Up.TabIndex = 19;
            this.btnManualLimitPercentModifier2Up.Text = "+";
            this.btnManualLimitPercentModifier2Up.UseSelectable = true;
            this.btnManualLimitPercentModifier2Up.Click += new System.EventHandler(this.btnManualLimitPercentModifier2Up_Click);
            // 
            // btnManualLimitPercentModifier2Down
            // 
            this.btnManualLimitPercentModifier2Down.Location = new System.Drawing.Point(83, 40);
            this.btnManualLimitPercentModifier2Down.Name = "btnManualLimitPercentModifier2Down";
            this.btnManualLimitPercentModifier2Down.Size = new System.Drawing.Size(18, 22);
            this.btnManualLimitPercentModifier2Down.TabIndex = 18;
            this.btnManualLimitPercentModifier2Down.Text = "-";
            this.btnManualLimitPercentModifier2Down.UseSelectable = true;
            this.btnManualLimitPercentModifier2Down.Click += new System.EventHandler(this.btnManualLimitPercentModifier2Down_Click);
            // 
            // nudManualLimitPercentModifier1
            // 
            this.nudManualLimitPercentModifier1.DecimalPlaces = 2;
            this.nudManualLimitPercentModifier1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudManualLimitPercentModifier1.Location = new System.Drawing.Point(5, 15);
            this.nudManualLimitPercentModifier1.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudManualLimitPercentModifier1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudManualLimitPercentModifier1.Name = "nudManualLimitPercentModifier1";
            this.nudManualLimitPercentModifier1.Size = new System.Drawing.Size(72, 20);
            this.nudManualLimitPercentModifier1.TabIndex = 14;
            this.nudManualLimitPercentModifier1.Value = new decimal(new int[] {
            11111,
            0,
            0,
            131072});
            this.nudManualLimitPercentModifier1.ValueChanged += new System.EventHandler(this.nudManualLimitPercentModifier1_ValueChanged);
            // 
            // btnManualLimitPercentModifier1Up
            // 
            this.btnManualLimitPercentModifier1Up.Location = new System.Drawing.Point(101, 14);
            this.btnManualLimitPercentModifier1Up.Name = "btnManualLimitPercentModifier1Up";
            this.btnManualLimitPercentModifier1Up.Size = new System.Drawing.Size(18, 22);
            this.btnManualLimitPercentModifier1Up.TabIndex = 16;
            this.btnManualLimitPercentModifier1Up.Text = "+";
            this.btnManualLimitPercentModifier1Up.UseSelectable = true;
            this.btnManualLimitPercentModifier1Up.Click += new System.EventHandler(this.btnManualLimitPercentModifier1Up_Click);
            // 
            // btnManualLimitPercentModifier1Down
            // 
            this.btnManualLimitPercentModifier1Down.Location = new System.Drawing.Point(83, 14);
            this.btnManualLimitPercentModifier1Down.Name = "btnManualLimitPercentModifier1Down";
            this.btnManualLimitPercentModifier1Down.Size = new System.Drawing.Size(18, 22);
            this.btnManualLimitPercentModifier1Down.TabIndex = 15;
            this.btnManualLimitPercentModifier1Down.Text = "-";
            this.btnManualLimitPercentModifier1Down.UseSelectable = true;
            this.btnManualLimitPercentModifier1Down.Click += new System.EventHandler(this.btnManualLimitPercentModifier1Down_Click);
            // 
            // chkManualLimitHiddenOrder
            // 
            this.chkManualLimitHiddenOrder.AutoSize = true;
            this.chkManualLimitHiddenOrder.Location = new System.Drawing.Point(136, 74);
            this.chkManualLimitHiddenOrder.Name = "chkManualLimitHiddenOrder";
            this.chkManualLimitHiddenOrder.Size = new System.Drawing.Size(95, 15);
            this.chkManualLimitHiddenOrder.TabIndex = 13;
            this.chkManualLimitHiddenOrder.Text = "Hidden Order";
            this.chkManualLimitHiddenOrder.UseSelectable = true;
            this.chkManualLimitHiddenOrder.CheckedChanged += new System.EventHandler(this.chkManualLimitHiddenOrder_CheckedChanged);
            // 
            // btnManualLimitSetCurrentPrice
            // 
            this.btnManualLimitSetCurrentPrice.Location = new System.Drawing.Point(256, 48);
            this.btnManualLimitSetCurrentPrice.Name = "btnManualLimitSetCurrentPrice";
            this.btnManualLimitSetCurrentPrice.Size = new System.Drawing.Size(52, 21);
            this.btnManualLimitSetCurrentPrice.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnManualLimitSetCurrentPrice.TabIndex = 12;
            this.btnManualLimitSetCurrentPrice.Text = "Current";
            this.btnManualLimitSetCurrentPrice.UseSelectable = true;
            this.btnManualLimitSetCurrentPrice.UseStyleColors = true;
            this.btnManualLimitSetCurrentPrice.Click += new System.EventHandler(this.btnManualLimitSetCurrentPrice_Click);
            // 
            // btnManualLimitSell
            // 
            this.btnManualLimitSell.BackColor = System.Drawing.Color.Red;
            this.btnManualLimitSell.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnManualLimitSell.Location = new System.Drawing.Point(438, 22);
            this.btnManualLimitSell.Name = "btnManualLimitSell";
            this.btnManualLimitSell.Size = new System.Drawing.Size(81, 80);
            this.btnManualLimitSell.Style = MetroFramework.MetroColorStyle.Red;
            this.btnManualLimitSell.TabIndex = 11;
            this.btnManualLimitSell.Text = "Limit Sell";
            this.btnManualLimitSell.UseSelectable = true;
            this.btnManualLimitSell.UseStyleColors = true;
            this.btnManualLimitSell.Click += new System.EventHandler(this.btnManualLimitSell_Click);
            // 
            // chkManualLimitCancelWhileOrdering
            // 
            this.chkManualLimitCancelWhileOrdering.AutoSize = true;
            this.chkManualLimitCancelWhileOrdering.Checked = true;
            this.chkManualLimitCancelWhileOrdering.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkManualLimitCancelWhileOrdering.Location = new System.Drawing.Point(136, 128);
            this.chkManualLimitCancelWhileOrdering.Name = "chkManualLimitCancelWhileOrdering";
            this.chkManualLimitCancelWhileOrdering.Size = new System.Drawing.Size(129, 15);
            this.chkManualLimitCancelWhileOrdering.TabIndex = 11;
            this.chkManualLimitCancelWhileOrdering.Text = "Cancel Open Orders";
            this.chkManualLimitCancelWhileOrdering.UseSelectable = true;
            this.chkManualLimitCancelWhileOrdering.CheckedChanged += new System.EventHandler(this.chkManualLimitCancelWhileOrdering_CheckedChanged);
            // 
            // btnManualLimitBuy
            // 
            this.btnManualLimitBuy.BackColor = System.Drawing.Color.LimeGreen;
            this.btnManualLimitBuy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnManualLimitBuy.Location = new System.Drawing.Point(353, 22);
            this.btnManualLimitBuy.Name = "btnManualLimitBuy";
            this.btnManualLimitBuy.Size = new System.Drawing.Size(81, 80);
            this.btnManualLimitBuy.Style = MetroFramework.MetroColorStyle.Green;
            this.btnManualLimitBuy.TabIndex = 10;
            this.btnManualLimitBuy.Text = "Limit Buy";
            this.btnManualLimitBuy.UseSelectable = true;
            this.btnManualLimitBuy.UseStyleColors = true;
            this.btnManualLimitBuy.Click += new System.EventHandler(this.btnManualLimitBuy_Click);
            // 
            // chkManualLimitPostOnly
            // 
            this.chkManualLimitPostOnly.AutoSize = true;
            this.chkManualLimitPostOnly.Checked = true;
            this.chkManualLimitPostOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkManualLimitPostOnly.Location = new System.Drawing.Point(136, 110);
            this.chkManualLimitPostOnly.Name = "chkManualLimitPostOnly";
            this.chkManualLimitPostOnly.Size = new System.Drawing.Size(74, 15);
            this.chkManualLimitPostOnly.TabIndex = 10;
            this.chkManualLimitPostOnly.Text = "Post Only";
            this.chkManualLimitPostOnly.UseSelectable = true;
            this.chkManualLimitPostOnly.CheckedChanged += new System.EventHandler(this.chkManualLimitPostOnly_CheckedChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(219, 52);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 19);
            this.label20.TabIndex = 9;
            this.label20.Text = "Price";
            // 
            // nudManualLimitPrice
            // 
            this.nudManualLimitPrice.Location = new System.Drawing.Point(136, 48);
            this.nudManualLimitPrice.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudManualLimitPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            524288});
            this.nudManualLimitPrice.Name = "nudManualLimitPrice";
            this.nudManualLimitPrice.Size = new System.Drawing.Size(81, 20);
            this.nudManualLimitPrice.TabIndex = 8;
            this.nudManualLimitPrice.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudManualLimitPrice.ValueChanged += new System.EventHandler(this.nudManualLimitPrice_ValueChanged);
            // 
            // chkManualLimitReduceOnly
            // 
            this.chkManualLimitReduceOnly.AutoSize = true;
            this.chkManualLimitReduceOnly.Location = new System.Drawing.Point(136, 92);
            this.chkManualLimitReduceOnly.Name = "chkManualLimitReduceOnly";
            this.chkManualLimitReduceOnly.Size = new System.Drawing.Size(90, 15);
            this.chkManualLimitReduceOnly.TabIndex = 7;
            this.chkManualLimitReduceOnly.Text = "Reduce Only";
            this.chkManualLimitReduceOnly.UseSelectable = true;
            this.chkManualLimitReduceOnly.CheckedChanged += new System.EventHandler(this.chkManualLimitReduceOnly_CheckedChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(219, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 19);
            this.label18.TabIndex = 5;
            this.label18.Text = "Contracts";
            // 
            // nudManualLimitContracts
            // 
            this.nudManualLimitContracts.Location = new System.Drawing.Point(136, 22);
            this.nudManualLimitContracts.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudManualLimitContracts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudManualLimitContracts.Name = "nudManualLimitContracts";
            this.nudManualLimitContracts.Size = new System.Drawing.Size(81, 20);
            this.nudManualLimitContracts.TabIndex = 4;
            this.nudManualLimitContracts.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudManualLimitContracts.ValueChanged += new System.EventHandler(this.nudManualLimitContracts_ValueChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnManualMarketSell);
            this.groupBox4.Controls.Add(this.btnManualMarketBuy);
            this.groupBox4.Controls.Add(this.chkManualMarketBuyReduceOnly);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.nudManualMarketBuyContracts);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox4.Location = new System.Drawing.Point(7, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(176, 160);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Market";
            // 
            // btnManualMarketSell
            // 
            this.btnManualMarketSell.BackColor = System.Drawing.Color.Red;
            this.btnManualMarketSell.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnManualMarketSell.Location = new System.Drawing.Point(89, 74);
            this.btnManualMarketSell.Name = "btnManualMarketSell";
            this.btnManualMarketSell.Size = new System.Drawing.Size(81, 80);
            this.btnManualMarketSell.Style = MetroFramework.MetroColorStyle.Red;
            this.btnManualMarketSell.TabIndex = 9;
            this.btnManualMarketSell.Text = "Market Sell";
            this.btnManualMarketSell.UseSelectable = true;
            this.btnManualMarketSell.UseStyleColors = true;
            this.btnManualMarketSell.Click += new System.EventHandler(this.btnManualMarketSell_Click);
            // 
            // btnManualMarketBuy
            // 
            this.btnManualMarketBuy.BackColor = System.Drawing.Color.LimeGreen;
            this.btnManualMarketBuy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnManualMarketBuy.Location = new System.Drawing.Point(4, 74);
            this.btnManualMarketBuy.Name = "btnManualMarketBuy";
            this.btnManualMarketBuy.Size = new System.Drawing.Size(81, 80);
            this.btnManualMarketBuy.Style = MetroFramework.MetroColorStyle.Green;
            this.btnManualMarketBuy.TabIndex = 8;
            this.btnManualMarketBuy.Text = "Market Buy";
            this.btnManualMarketBuy.UseSelectable = true;
            this.btnManualMarketBuy.UseStyleColors = true;
            this.btnManualMarketBuy.Click += new System.EventHandler(this.btnManualMarketBuy_Click);
            // 
            // chkManualMarketBuyReduceOnly
            // 
            this.chkManualMarketBuyReduceOnly.AutoSize = true;
            this.chkManualMarketBuyReduceOnly.Location = new System.Drawing.Point(76, 42);
            this.chkManualMarketBuyReduceOnly.Name = "chkManualMarketBuyReduceOnly";
            this.chkManualMarketBuyReduceOnly.Size = new System.Drawing.Size(90, 15);
            this.chkManualMarketBuyReduceOnly.TabIndex = 7;
            this.chkManualMarketBuyReduceOnly.Text = "Reduce Only";
            this.chkManualMarketBuyReduceOnly.UseSelectable = true;
            this.chkManualMarketBuyReduceOnly.CheckedChanged += new System.EventHandler(this.chkManualMarketBuyReduceOnly_CheckedChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(92, 22);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 19);
            this.label19.TabIndex = 5;
            this.label19.Text = "Contracts";
            // 
            // nudManualMarketBuyContracts
            // 
            this.nudManualMarketBuyContracts.Location = new System.Drawing.Point(9, 18);
            this.nudManualMarketBuyContracts.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudManualMarketBuyContracts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudManualMarketBuyContracts.Name = "nudManualMarketBuyContracts";
            this.nudManualMarketBuyContracts.Size = new System.Drawing.Size(81, 20);
            this.nudManualMarketBuyContracts.TabIndex = 4;
            this.nudManualMarketBuyContracts.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudManualMarketBuyContracts.ValueChanged += new System.EventHandler(this.nudManualMarketBuyContracts_ValueChanged);
            // 
            // tabLimitNow
            // 
            this.tabLimitNow.Controls.Add(this.label30);
            this.tabLimitNow.Controls.Add(this.groupBox8);
            this.tabLimitNow.Controls.Add(this.groupBox7);
            this.tabLimitNow.HorizontalScrollbarBarColor = true;
            this.tabLimitNow.HorizontalScrollbarHighlightOnWheel = false;
            this.tabLimitNow.HorizontalScrollbarSize = 10;
            this.tabLimitNow.Location = new System.Drawing.Point(4, 38);
            this.tabLimitNow.Name = "tabLimitNow";
            this.tabLimitNow.Padding = new System.Windows.Forms.Padding(3);
            this.tabLimitNow.Size = new System.Drawing.Size(849, 352);
            this.tabLimitNow.TabIndex = 5;
            this.tabLimitNow.Text = "Limit Now";
            this.tabLimitNow.VerticalScrollbarBarColor = true;
            this.tabLimitNow.VerticalScrollbarHighlightOnWheel = false;
            this.tabLimitNow.VerticalScrollbarSize = 10;
            // 
            // label30
            // 
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label30.Location = new System.Drawing.Point(498, 18);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(304, 88);
            this.label30.TabIndex = 34;
            this.label30.Text = resources.GetString("label30.Text");
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.Transparent;
            this.groupBox8.Controls.Add(this.chkLimitNowSellReduceOnly);
            this.groupBox8.Controls.Add(this.label29);
            this.groupBox8.Controls.Add(this.ddlLimitNowSellMethod);
            this.groupBox8.Controls.Add(this.chkLimitNowSellContinue);
            this.groupBox8.Controls.Add(this.nudLimitNowSellContracts);
            this.groupBox8.Controls.Add(this.label25);
            this.groupBox8.Controls.Add(this.label26);
            this.groupBox8.Controls.Add(this.nudLimitNowSellTicksFromCenter);
            this.groupBox8.Controls.Add(this.nudLimitNowSellDelay);
            this.groupBox8.Controls.Add(this.label27);
            this.groupBox8.Controls.Add(this.btnLimitNowSell);
            this.groupBox8.Controls.Add(this.btnLimitNowSellCancel);
            this.groupBox8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox8.Location = new System.Drawing.Point(254, 7);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(238, 187);
            this.groupBox8.TabIndex = 32;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Sell";
            // 
            // chkLimitNowSellReduceOnly
            // 
            this.chkLimitNowSellReduceOnly.AutoSize = true;
            this.chkLimitNowSellReduceOnly.Location = new System.Drawing.Point(6, 101);
            this.chkLimitNowSellReduceOnly.Name = "chkLimitNowSellReduceOnly";
            this.chkLimitNowSellReduceOnly.Size = new System.Drawing.Size(90, 15);
            this.chkLimitNowSellReduceOnly.TabIndex = 33;
            this.chkLimitNowSellReduceOnly.Text = "Reduce Only";
            this.chkLimitNowSellReduceOnly.UseSelectable = true;
            this.chkLimitNowSellReduceOnly.CheckedChanged += new System.EventHandler(this.chkLimitNowSellReduceOnly_CheckedChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(93, 150);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(55, 19);
            this.label29.TabIndex = 32;
            this.label29.Text = "Method";
            // 
            // ddlLimitNowSellMethod
            // 
            this.ddlLimitNowSellMethod.FormattingEnabled = true;
            this.ddlLimitNowSellMethod.ItemHeight = 23;
            this.ddlLimitNowSellMethod.Items.AddRange(new object[] {
            "Best Price",
            "Quick Fill"});
            this.ddlLimitNowSellMethod.Location = new System.Drawing.Point(6, 146);
            this.ddlLimitNowSellMethod.Name = "ddlLimitNowSellMethod";
            this.ddlLimitNowSellMethod.Size = new System.Drawing.Size(82, 29);
            this.ddlLimitNowSellMethod.TabIndex = 31;
            this.ddlLimitNowSellMethod.UseSelectable = true;
            this.ddlLimitNowSellMethod.SelectedIndexChanged += new System.EventHandler(this.ddlLimitNowSellMethod_SelectedIndexChanged);
            // 
            // chkLimitNowSellContinue
            // 
            this.chkLimitNowSellContinue.AutoSize = true;
            this.chkLimitNowSellContinue.Location = new System.Drawing.Point(6, 125);
            this.chkLimitNowSellContinue.Name = "chkLimitNowSellContinue";
            this.chkLimitNowSellContinue.Size = new System.Drawing.Size(136, 15);
            this.chkLimitNowSellContinue.TabIndex = 30;
            this.chkLimitNowSellContinue.Text = "Automatically Re-Sell";
            this.chkLimitNowSellContinue.UseSelectable = true;
            this.chkLimitNowSellContinue.CheckedChanged += new System.EventHandler(this.chkLimitNowSellContinue_CheckedChanged);
            // 
            // nudLimitNowSellContracts
            // 
            this.nudLimitNowSellContracts.Location = new System.Drawing.Point(6, 19);
            this.nudLimitNowSellContracts.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudLimitNowSellContracts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLimitNowSellContracts.Name = "nudLimitNowSellContracts";
            this.nudLimitNowSellContracts.Size = new System.Drawing.Size(81, 20);
            this.nudLimitNowSellContracts.TabIndex = 22;
            this.nudLimitNowSellContracts.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudLimitNowSellContracts.ValueChanged += new System.EventHandler(this.nudLimitNowSellContracts_ValueChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(89, 23);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(64, 19);
            this.label25.TabIndex = 24;
            this.label25.Text = "Contracts";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(89, 75);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(70, 19);
            this.label26.TabIndex = 28;
            this.label26.Text = "Delay (ms)";
            // 
            // nudLimitNowSellTicksFromCenter
            // 
            this.nudLimitNowSellTicksFromCenter.Location = new System.Drawing.Point(6, 45);
            this.nudLimitNowSellTicksFromCenter.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudLimitNowSellTicksFromCenter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLimitNowSellTicksFromCenter.Name = "nudLimitNowSellTicksFromCenter";
            this.nudLimitNowSellTicksFromCenter.Size = new System.Drawing.Size(81, 20);
            this.nudLimitNowSellTicksFromCenter.TabIndex = 25;
            this.nudLimitNowSellTicksFromCenter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLimitNowSellTicksFromCenter.ValueChanged += new System.EventHandler(this.nudLimitNowSellTicksFromCenter_ValueChanged);
            // 
            // nudLimitNowSellDelay
            // 
            this.nudLimitNowSellDelay.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudLimitNowSellDelay.Location = new System.Drawing.Point(6, 71);
            this.nudLimitNowSellDelay.Maximum = new decimal(new int[] {
            600000,
            0,
            0,
            0});
            this.nudLimitNowSellDelay.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudLimitNowSellDelay.Name = "nudLimitNowSellDelay";
            this.nudLimitNowSellDelay.Size = new System.Drawing.Size(81, 20);
            this.nudLimitNowSellDelay.TabIndex = 27;
            this.nudLimitNowSellDelay.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudLimitNowSellDelay.ValueChanged += new System.EventHandler(this.nudLimitNowSellDelay_ValueChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(89, 49);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(59, 19);
            this.label27.TabIndex = 26;
            this.label27.Text = "Ticks Off";
            // 
            // btnLimitNowSell
            // 
            this.btnLimitNowSell.BackColor = System.Drawing.Color.Red;
            this.btnLimitNowSell.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimitNowSell.Location = new System.Drawing.Point(165, 19);
            this.btnLimitNowSell.Name = "btnLimitNowSell";
            this.btnLimitNowSell.Size = new System.Drawing.Size(66, 80);
            this.btnLimitNowSell.Style = MetroFramework.MetroColorStyle.Red;
            this.btnLimitNowSell.TabIndex = 23;
            this.btnLimitNowSell.Text = "Limit Sell Now";
            this.btnLimitNowSell.UseSelectable = true;
            this.btnLimitNowSell.UseStyleColors = true;
            this.btnLimitNowSell.Click += new System.EventHandler(this.btnLimitNowSell_Click);
            // 
            // btnLimitNowSellCancel
            // 
            this.btnLimitNowSellCancel.BackColor = System.Drawing.Color.Gold;
            this.btnLimitNowSellCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimitNowSellCancel.Location = new System.Drawing.Point(165, 19);
            this.btnLimitNowSellCancel.Name = "btnLimitNowSellCancel";
            this.btnLimitNowSellCancel.Size = new System.Drawing.Size(66, 80);
            this.btnLimitNowSellCancel.TabIndex = 30;
            this.btnLimitNowSellCancel.Text = "Cancel Sell";
            this.btnLimitNowSellCancel.UseSelectable = true;
            this.btnLimitNowSellCancel.Visible = false;
            this.btnLimitNowSellCancel.Click += new System.EventHandler(this.btnLimitNowSellCancel_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Transparent;
            this.groupBox7.Controls.Add(this.chkLimitNowBuyReduceOnly);
            this.groupBox7.Controls.Add(this.label28);
            this.groupBox7.Controls.Add(this.ddlLimitNowBuyMethod);
            this.groupBox7.Controls.Add(this.chkLimitNowBuyContinue);
            this.groupBox7.Controls.Add(this.nudLimitNowBuyContracts);
            this.groupBox7.Controls.Add(this.label21);
            this.groupBox7.Controls.Add(this.label24);
            this.groupBox7.Controls.Add(this.nudLimitNowBuyTicksFromCenter);
            this.groupBox7.Controls.Add(this.nudLimitNowBuyDelay);
            this.groupBox7.Controls.Add(this.label23);
            this.groupBox7.Controls.Add(this.btnLimitNowBuy);
            this.groupBox7.Controls.Add(this.btnLimitNowBuyCancel);
            this.groupBox7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox7.Location = new System.Drawing.Point(9, 7);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(239, 187);
            this.groupBox7.TabIndex = 31;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Buy";
            // 
            // chkLimitNowBuyReduceOnly
            // 
            this.chkLimitNowBuyReduceOnly.AutoSize = true;
            this.chkLimitNowBuyReduceOnly.Location = new System.Drawing.Point(6, 101);
            this.chkLimitNowBuyReduceOnly.Name = "chkLimitNowBuyReduceOnly";
            this.chkLimitNowBuyReduceOnly.Size = new System.Drawing.Size(90, 15);
            this.chkLimitNowBuyReduceOnly.TabIndex = 32;
            this.chkLimitNowBuyReduceOnly.Text = "Reduce Only";
            this.chkLimitNowBuyReduceOnly.UseSelectable = true;
            this.chkLimitNowBuyReduceOnly.CheckedChanged += new System.EventHandler(this.chkLimitNowBuyReduceOnly_CheckedChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(90, 150);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(55, 19);
            this.label28.TabIndex = 31;
            this.label28.Text = "Method";
            // 
            // ddlLimitNowBuyMethod
            // 
            this.ddlLimitNowBuyMethod.FormattingEnabled = true;
            this.ddlLimitNowBuyMethod.ItemHeight = 23;
            this.ddlLimitNowBuyMethod.Items.AddRange(new object[] {
            "Best Price",
            "Quick Fill"});
            this.ddlLimitNowBuyMethod.Location = new System.Drawing.Point(5, 146);
            this.ddlLimitNowBuyMethod.Name = "ddlLimitNowBuyMethod";
            this.ddlLimitNowBuyMethod.Size = new System.Drawing.Size(82, 29);
            this.ddlLimitNowBuyMethod.TabIndex = 20;
            this.ddlLimitNowBuyMethod.UseSelectable = true;
            this.ddlLimitNowBuyMethod.SelectedIndexChanged += new System.EventHandler(this.ddlLimitNowBuyMethod_SelectedIndexChanged);
            // 
            // chkLimitNowBuyContinue
            // 
            this.chkLimitNowBuyContinue.AutoSize = true;
            this.chkLimitNowBuyContinue.Location = new System.Drawing.Point(6, 125);
            this.chkLimitNowBuyContinue.Name = "chkLimitNowBuyContinue";
            this.chkLimitNowBuyContinue.Size = new System.Drawing.Size(138, 15);
            this.chkLimitNowBuyContinue.TabIndex = 30;
            this.chkLimitNowBuyContinue.Text = "Automatically Re-Buy";
            this.chkLimitNowBuyContinue.UseSelectable = true;
            this.chkLimitNowBuyContinue.CheckedChanged += new System.EventHandler(this.chkLimitNowBuyContinue_CheckedChanged);
            // 
            // nudLimitNowBuyContracts
            // 
            this.nudLimitNowBuyContracts.Location = new System.Drawing.Point(6, 19);
            this.nudLimitNowBuyContracts.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudLimitNowBuyContracts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLimitNowBuyContracts.Name = "nudLimitNowBuyContracts";
            this.nudLimitNowBuyContracts.Size = new System.Drawing.Size(81, 20);
            this.nudLimitNowBuyContracts.TabIndex = 22;
            this.nudLimitNowBuyContracts.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudLimitNowBuyContracts.ValueChanged += new System.EventHandler(this.nudLimitNowBuyContracts_ValueChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(89, 23);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(64, 19);
            this.label21.TabIndex = 24;
            this.label21.Text = "Contracts";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(89, 75);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(70, 19);
            this.label24.TabIndex = 28;
            this.label24.Text = "Delay (ms)";
            // 
            // nudLimitNowBuyTicksFromCenter
            // 
            this.nudLimitNowBuyTicksFromCenter.Location = new System.Drawing.Point(6, 45);
            this.nudLimitNowBuyTicksFromCenter.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudLimitNowBuyTicksFromCenter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLimitNowBuyTicksFromCenter.Name = "nudLimitNowBuyTicksFromCenter";
            this.nudLimitNowBuyTicksFromCenter.Size = new System.Drawing.Size(81, 20);
            this.nudLimitNowBuyTicksFromCenter.TabIndex = 25;
            this.nudLimitNowBuyTicksFromCenter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLimitNowBuyTicksFromCenter.ValueChanged += new System.EventHandler(this.nudLimitNowBuyTicksFromCenter_ValueChanged);
            // 
            // nudLimitNowBuyDelay
            // 
            this.nudLimitNowBuyDelay.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudLimitNowBuyDelay.Location = new System.Drawing.Point(6, 71);
            this.nudLimitNowBuyDelay.Maximum = new decimal(new int[] {
            600000,
            0,
            0,
            0});
            this.nudLimitNowBuyDelay.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudLimitNowBuyDelay.Name = "nudLimitNowBuyDelay";
            this.nudLimitNowBuyDelay.Size = new System.Drawing.Size(81, 20);
            this.nudLimitNowBuyDelay.TabIndex = 27;
            this.nudLimitNowBuyDelay.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudLimitNowBuyDelay.ValueChanged += new System.EventHandler(this.nudLimitNowBuyDelay_ValueChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(89, 49);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(59, 19);
            this.label23.TabIndex = 26;
            this.label23.Text = "Ticks Off";
            // 
            // btnLimitNowBuy
            // 
            this.btnLimitNowBuy.BackColor = System.Drawing.Color.LimeGreen;
            this.btnLimitNowBuy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimitNowBuy.Location = new System.Drawing.Point(165, 19);
            this.btnLimitNowBuy.Name = "btnLimitNowBuy";
            this.btnLimitNowBuy.Size = new System.Drawing.Size(66, 80);
            this.btnLimitNowBuy.Style = MetroFramework.MetroColorStyle.Green;
            this.btnLimitNowBuy.TabIndex = 21;
            this.btnLimitNowBuy.Text = "Limit Buy Now";
            this.btnLimitNowBuy.UseSelectable = true;
            this.btnLimitNowBuy.UseStyleColors = true;
            this.btnLimitNowBuy.Click += new System.EventHandler(this.btnLimitNowBuy_Click);
            // 
            // btnLimitNowBuyCancel
            // 
            this.btnLimitNowBuyCancel.BackColor = System.Drawing.Color.Gold;
            this.btnLimitNowBuyCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimitNowBuyCancel.Location = new System.Drawing.Point(165, 19);
            this.btnLimitNowBuyCancel.Name = "btnLimitNowBuyCancel";
            this.btnLimitNowBuyCancel.Size = new System.Drawing.Size(66, 80);
            this.btnLimitNowBuyCancel.TabIndex = 29;
            this.btnLimitNowBuyCancel.Text = "Cancel Buy";
            this.btnLimitNowBuyCancel.UseSelectable = true;
            this.btnLimitNowBuyCancel.Visible = false;
            this.btnLimitNowBuyCancel.Click += new System.EventHandler(this.btnLimitNowBuyCancel_Click);
            // 
            // tabSpread
            // 
            this.tabSpread.Controls.Add(this.chkSpreadCancelWhileOrdering);
            this.tabSpread.Controls.Add(this.btnSpreadCloseAllOpenOrders);
            this.tabSpread.Controls.Add(this.groupBox3);
            this.tabSpread.Controls.Add(this.groupBox2);
            this.tabSpread.Controls.Add(this.btnSpreadPlaceOrders);
            this.tabSpread.HorizontalScrollbarBarColor = true;
            this.tabSpread.HorizontalScrollbarHighlightOnWheel = false;
            this.tabSpread.HorizontalScrollbarSize = 10;
            this.tabSpread.Location = new System.Drawing.Point(4, 38);
            this.tabSpread.Name = "tabSpread";
            this.tabSpread.Size = new System.Drawing.Size(849, 352);
            this.tabSpread.TabIndex = 2;
            this.tabSpread.Text = "Spread";
            this.tabSpread.VerticalScrollbarBarColor = true;
            this.tabSpread.VerticalScrollbarHighlightOnWheel = false;
            this.tabSpread.VerticalScrollbarSize = 10;
            // 
            // chkSpreadCancelWhileOrdering
            // 
            this.chkSpreadCancelWhileOrdering.AutoSize = true;
            this.chkSpreadCancelWhileOrdering.Checked = true;
            this.chkSpreadCancelWhileOrdering.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSpreadCancelWhileOrdering.Location = new System.Drawing.Point(572, 119);
            this.chkSpreadCancelWhileOrdering.Name = "chkSpreadCancelWhileOrdering";
            this.chkSpreadCancelWhileOrdering.Size = new System.Drawing.Size(225, 15);
            this.chkSpreadCancelWhileOrdering.TabIndex = 12;
            this.chkSpreadCancelWhileOrdering.Text = "Cancel All Open Orders Before Placing";
            this.chkSpreadCancelWhileOrdering.UseSelectable = true;
            this.chkSpreadCancelWhileOrdering.CheckedChanged += new System.EventHandler(this.chkSpreadCancelWhileOrdering_CheckedChanged);
            // 
            // btnSpreadCloseAllOpenOrders
            // 
            this.btnSpreadCloseAllOpenOrders.Location = new System.Drawing.Point(667, 224);
            this.btnSpreadCloseAllOpenOrders.Name = "btnSpreadCloseAllOpenOrders";
            this.btnSpreadCloseAllOpenOrders.Size = new System.Drawing.Size(139, 23);
            this.btnSpreadCloseAllOpenOrders.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnSpreadCloseAllOpenOrders.TabIndex = 11;
            this.btnSpreadCloseAllOpenOrders.Text = "Close All Open Orders";
            this.btnSpreadCloseAllOpenOrders.UseSelectable = true;
            this.btnSpreadCloseAllOpenOrders.UseStyleColors = true;
            this.btnSpreadCloseAllOpenOrders.Click += new System.EventHandler(this.btnSpreadCloseAllOpenOrders_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.chkSpreadSellPostOnly);
            this.groupBox3.Controls.Add(this.chkSpreadSellExecute);
            this.groupBox3.Controls.Add(this.nudSpreadSellOrderCount);
            this.groupBox3.Controls.Add(this.chkSpreadSellReduceOnly);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.nudSpreadSellValueApart);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.nudSpreadSellContractsEach);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Location = new System.Drawing.Point(336, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(316, 100);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sell";
            // 
            // chkSpreadSellPostOnly
            // 
            this.chkSpreadSellPostOnly.AutoSize = true;
            this.chkSpreadSellPostOnly.Checked = true;
            this.chkSpreadSellPostOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSpreadSellPostOnly.Location = new System.Drawing.Point(183, 37);
            this.chkSpreadSellPostOnly.Name = "chkSpreadSellPostOnly";
            this.chkSpreadSellPostOnly.Size = new System.Drawing.Size(74, 15);
            this.chkSpreadSellPostOnly.TabIndex = 10;
            this.chkSpreadSellPostOnly.Text = "Post Only";
            this.chkSpreadSellPostOnly.UseSelectable = true;
            this.chkSpreadSellPostOnly.CheckedChanged += new System.EventHandler(this.chkSpreadSellPostOnly_CheckedChanged);
            // 
            // chkSpreadSellExecute
            // 
            this.chkSpreadSellExecute.AutoSize = true;
            this.chkSpreadSellExecute.Checked = true;
            this.chkSpreadSellExecute.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSpreadSellExecute.Location = new System.Drawing.Point(183, 56);
            this.chkSpreadSellExecute.Name = "chkSpreadSellExecute";
            this.chkSpreadSellExecute.Size = new System.Drawing.Size(63, 15);
            this.chkSpreadSellExecute.TabIndex = 8;
            this.chkSpreadSellExecute.Text = "Execute";
            this.chkSpreadSellExecute.UseSelectable = true;
            this.chkSpreadSellExecute.CheckedChanged += new System.EventHandler(this.chkSpreadSellExecute_CheckedChanged);
            // 
            // nudSpreadSellOrderCount
            // 
            this.nudSpreadSellOrderCount.Location = new System.Drawing.Point(44, 17);
            this.nudSpreadSellOrderCount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudSpreadSellOrderCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpreadSellOrderCount.Name = "nudSpreadSellOrderCount";
            this.nudSpreadSellOrderCount.Size = new System.Drawing.Size(46, 20);
            this.nudSpreadSellOrderCount.TabIndex = 0;
            this.nudSpreadSellOrderCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudSpreadSellOrderCount.ValueChanged += new System.EventHandler(this.nudSpreadSellOrderCount_ValueChanged);
            // 
            // chkSpreadSellReduceOnly
            // 
            this.chkSpreadSellReduceOnly.AutoSize = true;
            this.chkSpreadSellReduceOnly.Location = new System.Drawing.Point(183, 19);
            this.chkSpreadSellReduceOnly.Name = "chkSpreadSellReduceOnly";
            this.chkSpreadSellReduceOnly.Size = new System.Drawing.Size(90, 15);
            this.chkSpreadSellReduceOnly.TabIndex = 7;
            this.chkSpreadSellReduceOnly.Text = "Reduce Only";
            this.chkSpreadSellReduceOnly.UseSelectable = true;
            this.chkSpreadSellReduceOnly.CheckedChanged += new System.EventHandler(this.chkSpreadSellReduceOnly_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(92, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 19);
            this.label12.TabIndex = 1;
            this.label12.Text = "Orders";
            // 
            // nudSpreadSellValueApart
            // 
            this.nudSpreadSellValueApart.DecimalPlaces = 1;
            this.nudSpreadSellValueApart.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudSpreadSellValueApart.Location = new System.Drawing.Point(9, 43);
            this.nudSpreadSellValueApart.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudSpreadSellValueApart.Name = "nudSpreadSellValueApart";
            this.nudSpreadSellValueApart.Size = new System.Drawing.Size(81, 20);
            this.nudSpreadSellValueApart.TabIndex = 2;
            this.nudSpreadSellValueApart.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudSpreadSellValueApart.ValueChanged += new System.EventHandler(this.nudSpreadSellValueApart_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(92, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 19);
            this.label13.TabIndex = 5;
            this.label13.Text = "Contracts Each";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(92, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 19);
            this.label14.TabIndex = 3;
            this.label14.Text = "Apart";
            // 
            // nudSpreadSellContractsEach
            // 
            this.nudSpreadSellContractsEach.Location = new System.Drawing.Point(9, 69);
            this.nudSpreadSellContractsEach.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudSpreadSellContractsEach.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpreadSellContractsEach.Name = "nudSpreadSellContractsEach";
            this.nudSpreadSellContractsEach.Size = new System.Drawing.Size(81, 20);
            this.nudSpreadSellContractsEach.TabIndex = 4;
            this.nudSpreadSellContractsEach.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudSpreadSellContractsEach.ValueChanged += new System.EventHandler(this.nudSpreadSellContractsEach_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.chkSpreadyBuyPostOnly);
            this.groupBox2.Controls.Add(this.chkSpreadBuyExecute);
            this.groupBox2.Controls.Add(this.nudSpreadBuyOrderCount);
            this.groupBox2.Controls.Add(this.chkSpreadBuyReduceOnly);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.nudSpreadBuyValueApart);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.nudSpreadBuyContractsEach);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(14, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buy";
            // 
            // chkSpreadyBuyPostOnly
            // 
            this.chkSpreadyBuyPostOnly.AutoSize = true;
            this.chkSpreadyBuyPostOnly.Checked = true;
            this.chkSpreadyBuyPostOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSpreadyBuyPostOnly.Location = new System.Drawing.Point(189, 36);
            this.chkSpreadyBuyPostOnly.Name = "chkSpreadyBuyPostOnly";
            this.chkSpreadyBuyPostOnly.Size = new System.Drawing.Size(74, 15);
            this.chkSpreadyBuyPostOnly.TabIndex = 9;
            this.chkSpreadyBuyPostOnly.Text = "Post Only";
            this.chkSpreadyBuyPostOnly.UseSelectable = true;
            this.chkSpreadyBuyPostOnly.CheckedChanged += new System.EventHandler(this.chkSpreadyBuyPostOnly_CheckedChanged);
            // 
            // chkSpreadBuyExecute
            // 
            this.chkSpreadBuyExecute.AutoSize = true;
            this.chkSpreadBuyExecute.Checked = true;
            this.chkSpreadBuyExecute.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSpreadBuyExecute.Location = new System.Drawing.Point(189, 55);
            this.chkSpreadBuyExecute.Name = "chkSpreadBuyExecute";
            this.chkSpreadBuyExecute.Size = new System.Drawing.Size(63, 15);
            this.chkSpreadBuyExecute.TabIndex = 8;
            this.chkSpreadBuyExecute.Text = "Execute";
            this.chkSpreadBuyExecute.UseSelectable = true;
            this.chkSpreadBuyExecute.CheckedChanged += new System.EventHandler(this.chkSpreadBuyExecute_CheckedChanged);
            // 
            // nudSpreadBuyOrderCount
            // 
            this.nudSpreadBuyOrderCount.Location = new System.Drawing.Point(44, 17);
            this.nudSpreadBuyOrderCount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudSpreadBuyOrderCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpreadBuyOrderCount.Name = "nudSpreadBuyOrderCount";
            this.nudSpreadBuyOrderCount.Size = new System.Drawing.Size(46, 20);
            this.nudSpreadBuyOrderCount.TabIndex = 0;
            this.nudSpreadBuyOrderCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudSpreadBuyOrderCount.ValueChanged += new System.EventHandler(this.nudSpreadBuyOrderCount_ValueChanged);
            // 
            // chkSpreadBuyReduceOnly
            // 
            this.chkSpreadBuyReduceOnly.AutoSize = true;
            this.chkSpreadBuyReduceOnly.Location = new System.Drawing.Point(189, 17);
            this.chkSpreadBuyReduceOnly.Name = "chkSpreadBuyReduceOnly";
            this.chkSpreadBuyReduceOnly.Size = new System.Drawing.Size(90, 15);
            this.chkSpreadBuyReduceOnly.TabIndex = 7;
            this.chkSpreadBuyReduceOnly.Text = "Reduce Only";
            this.chkSpreadBuyReduceOnly.UseSelectable = true;
            this.chkSpreadBuyReduceOnly.CheckedChanged += new System.EventHandler(this.chkSpreadBuyReduceOnly_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(92, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 19);
            this.label9.TabIndex = 1;
            this.label9.Text = "Orders";
            // 
            // nudSpreadBuyValueApart
            // 
            this.nudSpreadBuyValueApart.DecimalPlaces = 1;
            this.nudSpreadBuyValueApart.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudSpreadBuyValueApart.Location = new System.Drawing.Point(9, 43);
            this.nudSpreadBuyValueApart.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudSpreadBuyValueApart.Name = "nudSpreadBuyValueApart";
            this.nudSpreadBuyValueApart.Size = new System.Drawing.Size(81, 20);
            this.nudSpreadBuyValueApart.TabIndex = 2;
            this.nudSpreadBuyValueApart.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudSpreadBuyValueApart.ValueChanged += new System.EventHandler(this.nudSpreadBuyValueApart_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(92, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 19);
            this.label11.TabIndex = 5;
            this.label11.Text = "Contracts Each";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(92, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 19);
            this.label10.TabIndex = 3;
            this.label10.Text = "Apart";
            // 
            // nudSpreadBuyContractsEach
            // 
            this.nudSpreadBuyContractsEach.Location = new System.Drawing.Point(9, 69);
            this.nudSpreadBuyContractsEach.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudSpreadBuyContractsEach.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpreadBuyContractsEach.Name = "nudSpreadBuyContractsEach";
            this.nudSpreadBuyContractsEach.Size = new System.Drawing.Size(81, 20);
            this.nudSpreadBuyContractsEach.TabIndex = 4;
            this.nudSpreadBuyContractsEach.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudSpreadBuyContractsEach.ValueChanged += new System.EventHandler(this.nudSpreadBuyContractsEach_ValueChanged);
            // 
            // btnSpreadPlaceOrders
            // 
            this.btnSpreadPlaceOrders.Location = new System.Drawing.Point(658, 19);
            this.btnSpreadPlaceOrders.Name = "btnSpreadPlaceOrders";
            this.btnSpreadPlaceOrders.Size = new System.Drawing.Size(139, 94);
            this.btnSpreadPlaceOrders.Style = MetroFramework.MetroColorStyle.Green;
            this.btnSpreadPlaceOrders.TabIndex = 6;
            this.btnSpreadPlaceOrders.Text = "Place Spread Orders";
            this.btnSpreadPlaceOrders.UseSelectable = true;
            this.btnSpreadPlaceOrders.UseStyleColors = true;
            this.btnSpreadPlaceOrders.Click += new System.EventHandler(this.btnSpreadPlaceOrders_Click);
            // 
            // tabDCA
            // 
            this.tabDCA.Controls.Add(this.groupBox1);
            this.tabDCA.Controls.Add(this.pgbDCA);
            this.tabDCA.Controls.Add(this.lblDCASummary);
            this.tabDCA.Controls.Add(this.btnDCASell);
            this.tabDCA.Controls.Add(this.btnDCABuy);
            this.tabDCA.Controls.Add(this.btnDCAStop);
            this.tabDCA.HorizontalScrollbarBarColor = true;
            this.tabDCA.HorizontalScrollbarHighlightOnWheel = false;
            this.tabDCA.HorizontalScrollbarSize = 10;
            this.tabDCA.Location = new System.Drawing.Point(4, 38);
            this.tabDCA.Name = "tabDCA";
            this.tabDCA.Padding = new System.Windows.Forms.Padding(3);
            this.tabDCA.Size = new System.Drawing.Size(849, 352);
            this.tabDCA.TabIndex = 0;
            this.tabDCA.Text = "DCA";
            this.tabDCA.VerticalScrollbarBarColor = true;
            this.tabDCA.VerticalScrollbarHighlightOnWheel = false;
            this.tabDCA.VerticalScrollbarSize = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.chkDCAExecuteImmediately);
            this.groupBox1.Controls.Add(this.chkDCAReduceOnly);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudDCAContracts);
            this.groupBox1.Controls.Add(this.lblalskdj);
            this.groupBox1.Controls.Add(this.nudDCAHours);
            this.groupBox1.Controls.Add(this.nudDCASeconds);
            this.groupBox1.Controls.Add(this.nudDCATimes);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nudDCAMinutes);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 151);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DCA Settings";
            // 
            // chkDCAExecuteImmediately
            // 
            this.chkDCAExecuteImmediately.AutoSize = true;
            this.chkDCAExecuteImmediately.Checked = true;
            this.chkDCAExecuteImmediately.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDCAExecuteImmediately.Location = new System.Drawing.Point(181, 102);
            this.chkDCAExecuteImmediately.Name = "chkDCAExecuteImmediately";
            this.chkDCAExecuteImmediately.Size = new System.Drawing.Size(132, 15);
            this.chkDCAExecuteImmediately.TabIndex = 49;
            this.chkDCAExecuteImmediately.Text = "Execute Immediately";
            this.chkDCAExecuteImmediately.UseSelectable = true;
            this.chkDCAExecuteImmediately.CheckedChanged += new System.EventHandler(this.chkDCAExecuteImmediately_CheckedChanged);
            // 
            // chkDCAReduceOnly
            // 
            this.chkDCAReduceOnly.AutoSize = true;
            this.chkDCAReduceOnly.Location = new System.Drawing.Point(181, 78);
            this.chkDCAReduceOnly.Name = "chkDCAReduceOnly";
            this.chkDCAReduceOnly.Size = new System.Drawing.Size(90, 15);
            this.chkDCAReduceOnly.TabIndex = 48;
            this.chkDCAReduceOnly.Text = "Reduce Only";
            this.chkDCAReduceOnly.UseSelectable = true;
            this.chkDCAReduceOnly.CheckedChanged += new System.EventHandler(this.chkDCAReduceOnly_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 33;
            this.label4.Text = "Contracts Per";
            // 
            // nudDCAContracts
            // 
            this.nudDCAContracts.Location = new System.Drawing.Point(9, 41);
            this.nudDCAContracts.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudDCAContracts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDCAContracts.Name = "nudDCAContracts";
            this.nudDCAContracts.Size = new System.Drawing.Size(67, 20);
            this.nudDCAContracts.TabIndex = 36;
            this.nudDCAContracts.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudDCAContracts.ValueChanged += new System.EventHandler(this.nudDCAContracts_ValueChanged);
            // 
            // lblalskdj
            // 
            this.lblalskdj.AutoSize = true;
            this.lblalskdj.Location = new System.Drawing.Point(112, 102);
            this.lblalskdj.Name = "lblalskdj";
            this.lblalskdj.Size = new System.Drawing.Size(57, 19);
            this.lblalskdj.TabIndex = 45;
            this.lblalskdj.Text = "Seconds";
            // 
            // nudDCAHours
            // 
            this.nudDCAHours.Location = new System.Drawing.Point(114, 41);
            this.nudDCAHours.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudDCAHours.Name = "nudDCAHours";
            this.nudDCAHours.Size = new System.Drawing.Size(47, 20);
            this.nudDCAHours.TabIndex = 37;
            this.nudDCAHours.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDCAHours.ValueChanged += new System.EventHandler(this.nudDCAHours_ValueChanged);
            // 
            // nudDCASeconds
            // 
            this.nudDCASeconds.Location = new System.Drawing.Point(114, 122);
            this.nudDCASeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudDCASeconds.Name = "nudDCASeconds";
            this.nudDCASeconds.Size = new System.Drawing.Size(47, 20);
            this.nudDCASeconds.TabIndex = 44;
            this.nudDCASeconds.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDCASeconds.ValueChanged += new System.EventHandler(this.nudDCASeconds_ValueChanged);
            // 
            // nudDCATimes
            // 
            this.nudDCATimes.Location = new System.Drawing.Point(181, 41);
            this.nudDCATimes.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudDCATimes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDCATimes.Name = "nudDCATimes";
            this.nudDCATimes.Size = new System.Drawing.Size(47, 20);
            this.nudDCATimes.TabIndex = 38;
            this.nudDCATimes.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudDCATimes.ValueChanged += new System.EventHandler(this.nudDCATimes_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 43;
            this.label3.Text = "Minutes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 19);
            this.label5.TabIndex = 39;
            this.label5.Text = "Hours";
            // 
            // nudDCAMinutes
            // 
            this.nudDCAMinutes.Location = new System.Drawing.Point(114, 82);
            this.nudDCAMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudDCAMinutes.Name = "nudDCAMinutes";
            this.nudDCAMinutes.Size = new System.Drawing.Size(47, 20);
            this.nudDCAMinutes.TabIndex = 42;
            this.nudDCAMinutes.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDCAMinutes.ValueChanged += new System.EventHandler(this.nudDCAMinutes_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 19);
            this.label6.TabIndex = 40;
            this.label6.Text = "X Times";
            // 
            // pgbDCA
            // 
            this.pgbDCA.Location = new System.Drawing.Point(336, 77);
            this.pgbDCA.Name = "pgbDCA";
            this.pgbDCA.Size = new System.Drawing.Size(220, 23);
            this.pgbDCA.Style = MetroFramework.MetroColorStyle.Purple;
            this.pgbDCA.TabIndex = 46;
            this.pgbDCA.Visible = false;
            // 
            // lblDCASummary
            // 
            this.lblDCASummary.AutoSize = true;
            this.lblDCASummary.Location = new System.Drawing.Point(6, 160);
            this.lblDCASummary.Name = "lblDCASummary";
            this.lblDCASummary.Size = new System.Drawing.Size(97, 19);
            this.lblDCASummary.TabIndex = 32;
            this.lblDCASummary.Text = "DCA Summary";
            // 
            // btnDCASell
            // 
            this.btnDCASell.BackColor = System.Drawing.Color.LightCoral;
            this.btnDCASell.Location = new System.Drawing.Point(449, 12);
            this.btnDCASell.Name = "btnDCASell";
            this.btnDCASell.Size = new System.Drawing.Size(107, 61);
            this.btnDCASell.Style = MetroFramework.MetroColorStyle.Red;
            this.btnDCASell.TabIndex = 35;
            this.btnDCASell.Text = "Sell";
            this.btnDCASell.UseSelectable = true;
            this.btnDCASell.UseStyleColors = true;
            this.btnDCASell.Click += new System.EventHandler(this.btnDCASell_Click);
            // 
            // btnDCABuy
            // 
            this.btnDCABuy.BackColor = System.Drawing.Color.LightGreen;
            this.btnDCABuy.Location = new System.Drawing.Point(336, 12);
            this.btnDCABuy.Name = "btnDCABuy";
            this.btnDCABuy.Size = new System.Drawing.Size(107, 61);
            this.btnDCABuy.Style = MetroFramework.MetroColorStyle.Green;
            this.btnDCABuy.TabIndex = 34;
            this.btnDCABuy.Text = "Buy";
            this.btnDCABuy.UseSelectable = true;
            this.btnDCABuy.UseStyleColors = true;
            this.btnDCABuy.Click += new System.EventHandler(this.btnDCABuy_Click);
            // 
            // btnDCAStop
            // 
            this.btnDCAStop.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnDCAStop.Location = new System.Drawing.Point(336, 12);
            this.btnDCAStop.Name = "btnDCAStop";
            this.btnDCAStop.Size = new System.Drawing.Size(220, 61);
            this.btnDCAStop.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnDCAStop.TabIndex = 41;
            this.btnDCAStop.Text = "Stop";
            this.btnDCAStop.UseSelectable = true;
            this.btnDCAStop.UseStyleColors = true;
            this.btnDCAStop.Visible = false;
            this.btnDCAStop.Click += new System.EventHandler(this.btnDCAStop_Click);
            // 
            // tabStops
            // 
            this.tabStops.Controls.Add(this.groupBox9);
            this.tabStops.HorizontalScrollbarBarColor = true;
            this.tabStops.HorizontalScrollbarHighlightOnWheel = false;
            this.tabStops.HorizontalScrollbarSize = 10;
            this.tabStops.Location = new System.Drawing.Point(4, 38);
            this.tabStops.Name = "tabStops";
            this.tabStops.Size = new System.Drawing.Size(849, 352);
            this.tabStops.TabIndex = 6;
            this.tabStops.Text = "Stops";
            this.tabStops.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabStops.VerticalScrollbarBarColor = true;
            this.tabStops.VerticalScrollbarHighlightOnWheel = false;
            this.tabStops.VerticalScrollbarSize = 10;
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.Transparent;
            this.groupBox9.Controls.Add(this.lblTrailingStopLimitPricePreviewLabel);
            this.groupBox9.Controls.Add(this.metroLabel4);
            this.groupBox9.Controls.Add(this.lblStopTrailingLimitOffsetPrice);
            this.groupBox9.Controls.Add(this.chkStopTrailingCloseInFull);
            this.groupBox9.Controls.Add(this.chkTrailingStopEnabled);
            this.groupBox9.Controls.Add(this.nudStopTrailingLimitOffset);
            this.groupBox9.Controls.Add(this.lblTrailingStopLimitOffset);
            this.groupBox9.Controls.Add(this.metroLabel5);
            this.groupBox9.Controls.Add(this.nudStopTrailingContracts);
            this.groupBox9.Controls.Add(this.lblStopTraillingPrice);
            this.groupBox9.Controls.Add(this.nudStopTrailingTrail);
            this.groupBox9.Controls.Add(this.ddlStopTrailingMethod);
            this.groupBox9.Controls.Add(this.metroLabel2);
            this.groupBox9.Controls.Add(this.metroLabel3);
            this.groupBox9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox9.Location = new System.Drawing.Point(3, 3);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(265, 269);
            this.groupBox9.TabIndex = 23;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Trailing Stop";
            // 
            // lblTrailingStopLimitPricePreviewLabel
            // 
            this.lblTrailingStopLimitPricePreviewLabel.AutoSize = true;
            this.lblTrailingStopLimitPricePreviewLabel.Location = new System.Drawing.Point(134, 199);
            this.lblTrailingStopLimitPricePreviewLabel.Name = "lblTrailingStopLimitPricePreviewLabel";
            this.lblTrailingStopLimitPricePreviewLabel.Size = new System.Drawing.Size(70, 19);
            this.lblTrailingStopLimitPricePreviewLabel.TabIndex = 41;
            this.lblTrailingStopLimitPricePreviewLabel.Text = "Limit Price";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 199);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(83, 19);
            this.metroLabel4.TabIndex = 40;
            this.metroLabel4.Text = "Trigger Price";
            // 
            // lblStopTrailingLimitOffsetPrice
            // 
            this.lblStopTrailingLimitOffsetPrice.AutoSize = true;
            this.lblStopTrailingLimitOffsetPrice.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblStopTrailingLimitOffsetPrice.Location = new System.Drawing.Point(134, 218);
            this.lblStopTrailingLimitOffsetPrice.Name = "lblStopTrailingLimitOffsetPrice";
            this.lblStopTrailingLimitOffsetPrice.Size = new System.Drawing.Size(72, 25);
            this.lblStopTrailingLimitOffsetPrice.TabIndex = 39;
            this.lblStopTrailingLimitOffsetPrice.Text = "4564.65";
            // 
            // chkStopTrailingCloseInFull
            // 
            this.chkStopTrailingCloseInFull.AutoSize = true;
            this.chkStopTrailingCloseInFull.Location = new System.Drawing.Point(18, 45);
            this.chkStopTrailingCloseInFull.Name = "chkStopTrailingCloseInFull";
            this.chkStopTrailingCloseInFull.Size = new System.Drawing.Size(87, 15);
            this.chkStopTrailingCloseInFull.TabIndex = 38;
            this.chkStopTrailingCloseInFull.Text = "Close In Full";
            this.chkStopTrailingCloseInFull.UseSelectable = true;
            this.chkStopTrailingCloseInFull.CheckedChanged += new System.EventHandler(this.chkStopTrailingCloseInFull_CheckedChanged);
            // 
            // chkTrailingStopEnabled
            // 
            this.chkTrailingStopEnabled.AutoSize = true;
            this.chkTrailingStopEnabled.Location = new System.Drawing.Point(6, 169);
            this.chkTrailingStopEnabled.Name = "chkTrailingStopEnabled";
            this.chkTrailingStopEnabled.Size = new System.Drawing.Size(80, 17);
            this.chkTrailingStopEnabled.Style = MetroFramework.MetroColorStyle.Blue;
            this.chkTrailingStopEnabled.TabIndex = 37;
            this.chkTrailingStopEnabled.Text = "Off";
            this.chkTrailingStopEnabled.UseSelectable = true;
            this.chkTrailingStopEnabled.UseStyleColors = true;
            this.chkTrailingStopEnabled.CheckedChanged += new System.EventHandler(this.chkTrailingStopEnabled_CheckedChanged);
            // 
            // nudStopTrailingLimitOffset
            // 
            this.nudStopTrailingLimitOffset.Location = new System.Drawing.Point(6, 143);
            this.nudStopTrailingLimitOffset.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudStopTrailingLimitOffset.Minimum = new decimal(new int[] {
            1410065408,
            2,
            0,
            -2147483648});
            this.nudStopTrailingLimitOffset.Name = "nudStopTrailingLimitOffset";
            this.nudStopTrailingLimitOffset.Size = new System.Drawing.Size(82, 20);
            this.nudStopTrailingLimitOffset.TabIndex = 35;
            this.nudStopTrailingLimitOffset.ValueChanged += new System.EventHandler(this.nudStopTrailingLimitOffset_ValueChanged);
            // 
            // lblTrailingStopLimitOffset
            // 
            this.lblTrailingStopLimitOffset.AutoSize = true;
            this.lblTrailingStopLimitOffset.Location = new System.Drawing.Point(94, 144);
            this.lblTrailingStopLimitOffset.Name = "lblTrailingStopLimitOffset";
            this.lblTrailingStopLimitOffset.Size = new System.Drawing.Size(76, 19);
            this.lblTrailingStopLimitOffset.TabIndex = 36;
            this.lblTrailingStopLimitOffset.Text = "Limit Offset";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(94, 20);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(64, 19);
            this.metroLabel5.TabIndex = 34;
            this.metroLabel5.Text = "Contracts";
            // 
            // nudStopTrailingContracts
            // 
            this.nudStopTrailingContracts.Location = new System.Drawing.Point(6, 19);
            this.nudStopTrailingContracts.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nudStopTrailingContracts.Name = "nudStopTrailingContracts";
            this.nudStopTrailingContracts.Size = new System.Drawing.Size(82, 20);
            this.nudStopTrailingContracts.TabIndex = 33;
            this.nudStopTrailingContracts.ValueChanged += new System.EventHandler(this.nudStopTrailingContracts_ValueChanged);
            // 
            // lblStopTraillingPrice
            // 
            this.lblStopTraillingPrice.AutoSize = true;
            this.lblStopTraillingPrice.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblStopTraillingPrice.Location = new System.Drawing.Point(6, 218);
            this.lblStopTraillingPrice.Name = "lblStopTraillingPrice";
            this.lblStopTraillingPrice.Size = new System.Drawing.Size(72, 25);
            this.lblStopTraillingPrice.TabIndex = 32;
            this.lblStopTraillingPrice.Text = "4654.65";
            // 
            // nudStopTrailingTrail
            // 
            this.nudStopTrailingTrail.Location = new System.Drawing.Point(6, 82);
            this.nudStopTrailingTrail.Name = "nudStopTrailingTrail";
            this.nudStopTrailingTrail.Size = new System.Drawing.Size(82, 20);
            this.nudStopTrailingTrail.TabIndex = 2;
            this.nudStopTrailingTrail.ValueChanged += new System.EventHandler(this.nudStopTrailingPrice_ValueChanged);
            // 
            // ddlStopTrailingMethod
            // 
            this.ddlStopTrailingMethod.FormattingEnabled = true;
            this.ddlStopTrailingMethod.ItemHeight = 23;
            this.ddlStopTrailingMethod.Items.AddRange(new object[] {
            "Limit",
            "Market"});
            this.ddlStopTrailingMethod.Location = new System.Drawing.Point(6, 108);
            this.ddlStopTrailingMethod.Name = "ddlStopTrailingMethod";
            this.ddlStopTrailingMethod.Size = new System.Drawing.Size(82, 29);
            this.ddlStopTrailingMethod.TabIndex = 21;
            this.ddlStopTrailingMethod.UseSelectable = true;
            this.ddlStopTrailingMethod.SelectedIndexChanged += new System.EventHandler(this.ddlStopTrailingMethod_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(94, 83);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(32, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Trail";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(94, 113);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(76, 19);
            this.metroLabel3.TabIndex = 22;
            this.metroLabel3.Text = "Order Type";
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.metroLabel7);
            this.tabSettings.Controls.Add(this.nudSettingsLimitNowMinimumDelay);
            this.tabSettings.Controls.Add(this.lblSettingsWebsocketInfo);
            this.tabSettings.Controls.Add(this.btnExportCandles);
            this.tabSettings.Controls.Add(this.label8);
            this.tabSettings.Controls.Add(this.nudSettingsRetryWaitTime);
            this.tabSettings.Controls.Add(this.label7);
            this.tabSettings.Controls.Add(this.chkSettingOverloadRetry);
            this.tabSettings.Controls.Add(this.nudSettingsOverloadRetryAttempts);
            this.tabSettings.HorizontalScrollbarBarColor = true;
            this.tabSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.tabSettings.HorizontalScrollbarSize = 10;
            this.tabSettings.Location = new System.Drawing.Point(4, 38);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(849, 352);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            this.tabSettings.VerticalScrollbarBarColor = true;
            this.tabSettings.VerticalScrollbarHighlightOnWheel = false;
            this.tabSettings.VerticalScrollbarSize = 10;
            // 
            // lblSettingsWebsocketInfo
            // 
            this.lblSettingsWebsocketInfo.AutoSize = true;
            this.lblSettingsWebsocketInfo.Location = new System.Drawing.Point(6, 330);
            this.lblSettingsWebsocketInfo.Name = "lblSettingsWebsocketInfo";
            this.lblSettingsWebsocketInfo.Size = new System.Drawing.Size(105, 19);
            this.lblSettingsWebsocketInfo.TabIndex = 6;
            this.lblSettingsWebsocketInfo.Text = "Websocket Info: ";
            // 
            // btnExportCandles
            // 
            this.btnExportCandles.Location = new System.Drawing.Point(523, 6);
            this.btnExportCandles.Name = "btnExportCandles";
            this.btnExportCandles.Size = new System.Drawing.Size(101, 23);
            this.btnExportCandles.TabIndex = 5;
            this.btnExportCandles.Text = "Export Candles";
            this.btnExportCandles.UseSelectable = true;
            this.btnExportCandles.Click += new System.EventHandler(this.btnExportCandles_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(112, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "Retry Wait Time (ms)";
            // 
            // nudSettingsRetryWaitTime
            // 
            this.nudSettingsRetryWaitTime.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudSettingsRetryWaitTime.Location = new System.Drawing.Point(6, 55);
            this.nudSettingsRetryWaitTime.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nudSettingsRetryWaitTime.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudSettingsRetryWaitTime.Name = "nudSettingsRetryWaitTime";
            this.nudSettingsRetryWaitTime.Size = new System.Drawing.Size(100, 20);
            this.nudSettingsRetryWaitTime.TabIndex = 3;
            this.nudSettingsRetryWaitTime.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudSettingsRetryWaitTime.ValueChanged += new System.EventHandler(this.nudSettingsRetryWaitTime_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Attempts";
            // 
            // chkSettingOverloadRetry
            // 
            this.chkSettingOverloadRetry.AutoSize = true;
            this.chkSettingOverloadRetry.Location = new System.Drawing.Point(6, 6);
            this.chkSettingOverloadRetry.Name = "chkSettingOverloadRetry";
            this.chkSettingOverloadRetry.Size = new System.Drawing.Size(123, 15);
            this.chkSettingOverloadRetry.TabIndex = 1;
            this.chkSettingOverloadRetry.Text = "Retry on Overload?";
            this.chkSettingOverloadRetry.UseSelectable = true;
            this.chkSettingOverloadRetry.CheckedChanged += new System.EventHandler(this.chkSettingOverloadRetry_CheckedChanged);
            // 
            // nudSettingsOverloadRetryAttempts
            // 
            this.nudSettingsOverloadRetryAttempts.Location = new System.Drawing.Point(6, 29);
            this.nudSettingsOverloadRetryAttempts.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudSettingsOverloadRetryAttempts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSettingsOverloadRetryAttempts.Name = "nudSettingsOverloadRetryAttempts";
            this.nudSettingsOverloadRetryAttempts.Size = new System.Drawing.Size(45, 20);
            this.nudSettingsOverloadRetryAttempts.TabIndex = 0;
            this.nudSettingsOverloadRetryAttempts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSettingsOverloadRetryAttempts.ValueChanged += new System.EventHandler(this.nudSettingsOverloadRetryAttempts_ValueChanged);
            // 
            // tabDonate
            // 
            this.tabDonate.Controls.Add(this.lblDonateAddress);
            this.tabDonate.Controls.Add(this.label16);
            this.tabDonate.Controls.Add(this.pictureBox1);
            this.tabDonate.HorizontalScrollbarBarColor = true;
            this.tabDonate.HorizontalScrollbarHighlightOnWheel = false;
            this.tabDonate.HorizontalScrollbarSize = 10;
            this.tabDonate.Location = new System.Drawing.Point(4, 38);
            this.tabDonate.Name = "tabDonate";
            this.tabDonate.Size = new System.Drawing.Size(849, 352);
            this.tabDonate.TabIndex = 3;
            this.tabDonate.Text = "Donate";
            this.tabDonate.VerticalScrollbarBarColor = true;
            this.tabDonate.VerticalScrollbarHighlightOnWheel = false;
            this.tabDonate.VerticalScrollbarSize = 10;
            // 
            // lblDonateAddress
            // 
            this.lblDonateAddress.AutoSize = true;
            this.lblDonateAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDonateAddress.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblDonateAddress.Location = new System.Drawing.Point(171, 141);
            this.lblDonateAddress.Name = "lblDonateAddress";
            this.lblDonateAddress.Size = new System.Drawing.Size(327, 19);
            this.lblDonateAddress.TabIndex = 2;
            this.lblDonateAddress.Text = "BTC: 33biFCDFEZn3hLJcGKLR5Muu9oeRWBAFEX";
            this.MetroToolTip.SetToolTip(this.lblDonateAddress, "Click to Copy");
            this.lblDonateAddress.Click += new System.EventHandler(this.lblDonateAddress_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(171, 121);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(376, 19);
            this.label16.TabIndex = 1;
            this.label16.Text = "Any BTC donations are appreciated for supporting this project.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabVideos
            // 
            this.tabVideos.Location = new System.Drawing.Point(4, 38);
            this.tabVideos.Name = "tabVideos";
            this.tabVideos.Size = new System.Drawing.Size(849, 352);
            this.tabVideos.TabIndex = 7;
            this.tabVideos.Text = "Videos";
            // 
            // tmrDCA
            // 
            this.tmrDCA.Tick += new System.EventHandler(this.tmrDCA_Tick);
            // 
            // btnPositionMargin
            // 
            this.btnPositionMargin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPositionMargin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPositionMargin.Location = new System.Drawing.Point(766, 11);
            this.btnPositionMargin.Name = "btnPositionMargin";
            this.btnPositionMargin.Size = new System.Drawing.Size(60, 20);
            this.btnPositionMargin.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnPositionMargin.TabIndex = 21;
            this.btnPositionMargin.Text = "Margin";
            this.MetroToolTip.SetToolTip(this.btnPositionMargin, "Adjust Position Leverage. Use 0 for Cross Margin.");
            this.btnPositionMargin.UseSelectable = true;
            this.btnPositionMargin.UseStyleColors = true;
            this.btnPositionMargin.Click += new System.EventHandler(this.btnPositionMargin_Click);
            // 
            // btnPositionMarketClose
            // 
            this.btnPositionMarketClose.BackColor = System.Drawing.Color.Red;
            this.btnPositionMarketClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPositionMarketClose.Location = new System.Drawing.Point(700, 10);
            this.btnPositionMarketClose.Name = "btnPositionMarketClose";
            this.btnPositionMarketClose.Size = new System.Drawing.Size(60, 40);
            this.btnPositionMarketClose.Style = MetroFramework.MetroColorStyle.Red;
            this.btnPositionMarketClose.TabIndex = 18;
            this.btnPositionMarketClose.Text = "Market";
            this.MetroToolTip.SetToolTip(this.btnPositionMarketClose, "Market Close Position");
            this.btnPositionMarketClose.UseSelectable = true;
            this.btnPositionMarketClose.UseStyleColors = true;
            this.btnPositionMarketClose.Click += new System.EventHandler(this.btnPositionMarketClose_Click);
            // 
            // btnPositionLimitClose
            // 
            this.btnPositionLimitClose.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPositionLimitClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPositionLimitClose.Location = new System.Drawing.Point(634, 10);
            this.btnPositionLimitClose.Name = "btnPositionLimitClose";
            this.btnPositionLimitClose.Size = new System.Drawing.Size(60, 20);
            this.btnPositionLimitClose.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnPositionLimitClose.TabIndex = 17;
            this.btnPositionLimitClose.Text = "Limit";
            this.MetroToolTip.SetToolTip(this.btnPositionLimitClose, "Place a limit order at the specified price to close the position.");
            this.btnPositionLimitClose.UseSelectable = true;
            this.btnPositionLimitClose.UseStyleColors = true;
            this.btnPositionLimitClose.Click += new System.EventHandler(this.btnPositionLimitClose_Click);
            // 
            // textBox8
            // 
            // 
            // 
            // 
            this.textBox8.CustomButton.Image = null;
            this.textBox8.CustomButton.Location = new System.Drawing.Point(62, 2);
            this.textBox8.CustomButton.Name = "";
            this.textBox8.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.textBox8.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox8.CustomButton.TabIndex = 1;
            this.textBox8.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.textBox8.CustomButton.UseSelectable = true;
            this.textBox8.CustomButton.Visible = false;
            this.textBox8.Lines = new string[] {
        "Liquidation"};
            this.textBox8.Location = new System.Drawing.Point(290, 10);
            this.textBox8.MaxLength = 32767;
            this.textBox8.Name = "textBox8";
            this.textBox8.PasswordChar = '\0';
            this.textBox8.ReadOnly = true;
            this.textBox8.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox8.SelectedText = "";
            this.textBox8.SelectionLength = 0;
            this.textBox8.SelectionStart = 0;
            this.textBox8.ShortcutsEnabled = true;
            this.textBox8.Size = new System.Drawing.Size(80, 20);
            this.textBox8.Style = MetroFramework.MetroColorStyle.Red;
            this.textBox8.TabIndex = 15;
            this.textBox8.Text = "Liquidation";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox8.UseSelectable = true;
            this.textBox8.UseStyleColors = true;
            this.textBox8.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox8.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPositionLiquidation
            // 
            // 
            // 
            // 
            this.txtPositionLiquidation.CustomButton.Image = null;
            this.txtPositionLiquidation.CustomButton.Location = new System.Drawing.Point(62, 2);
            this.txtPositionLiquidation.CustomButton.Name = "";
            this.txtPositionLiquidation.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtPositionLiquidation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPositionLiquidation.CustomButton.TabIndex = 1;
            this.txtPositionLiquidation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtPositionLiquidation.CustomButton.UseSelectable = true;
            this.txtPositionLiquidation.CustomButton.Visible = false;
            this.txtPositionLiquidation.Lines = new string[0];
            this.txtPositionLiquidation.Location = new System.Drawing.Point(290, 30);
            this.txtPositionLiquidation.MaxLength = 32767;
            this.txtPositionLiquidation.Name = "txtPositionLiquidation";
            this.txtPositionLiquidation.PasswordChar = '\0';
            this.txtPositionLiquidation.ReadOnly = true;
            this.txtPositionLiquidation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPositionLiquidation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPositionLiquidation.SelectedText = "";
            this.txtPositionLiquidation.SelectionLength = 0;
            this.txtPositionLiquidation.SelectionStart = 0;
            this.txtPositionLiquidation.ShortcutsEnabled = true;
            this.txtPositionLiquidation.Size = new System.Drawing.Size(80, 20);
            this.txtPositionLiquidation.Style = MetroFramework.MetroColorStyle.Red;
            this.txtPositionLiquidation.TabIndex = 14;
            this.txtPositionLiquidation.UseSelectable = true;
            this.txtPositionLiquidation.UseStyleColors = true;
            this.txtPositionLiquidation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPositionLiquidation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBox1
            // 
            // 
            // 
            // 
            this.textBox1.CustomButton.Image = null;
            this.textBox1.CustomButton.Location = new System.Drawing.Point(62, 2);
            this.textBox1.CustomButton.Name = "";
            this.textBox1.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.textBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox1.CustomButton.TabIndex = 1;
            this.textBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.textBox1.CustomButton.UseSelectable = true;
            this.textBox1.CustomButton.Visible = false;
            this.textBox1.Lines = new string[] {
        "UnrlPnL %"};
            this.textBox1.Location = new System.Drawing.Point(548, 10);
            this.textBox1.MaxLength = 32767;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '\0';
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox1.SelectedText = "";
            this.textBox1.SelectionLength = 0;
            this.textBox1.SelectionStart = 0;
            this.textBox1.ShortcutsEnabled = true;
            this.textBox1.Size = new System.Drawing.Size(80, 20);
            this.textBox1.Style = MetroFramework.MetroColorStyle.Red;
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "UnrlPnL %";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.UseSelectable = true;
            this.textBox1.UseStyleColors = true;
            this.textBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBox2
            // 
            // 
            // 
            // 
            this.textBox2.CustomButton.Image = null;
            this.textBox2.CustomButton.Location = new System.Drawing.Point(62, 2);
            this.textBox2.CustomButton.Name = "";
            this.textBox2.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.textBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox2.CustomButton.TabIndex = 1;
            this.textBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.textBox2.CustomButton.UseSelectable = true;
            this.textBox2.CustomButton.Visible = false;
            this.textBox2.Lines = new string[] {
        "UnrealPnL"};
            this.textBox2.Location = new System.Drawing.Point(462, 10);
            this.textBox2.MaxLength = 32767;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '\0';
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox2.SelectedText = "";
            this.textBox2.SelectionLength = 0;
            this.textBox2.SelectionStart = 0;
            this.textBox2.ShortcutsEnabled = true;
            this.textBox2.Size = new System.Drawing.Size(80, 20);
            this.textBox2.Style = MetroFramework.MetroColorStyle.Red;
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "UnrealPnL";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.UseSelectable = true;
            this.textBox2.UseStyleColors = true;
            this.textBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBox3
            // 
            // 
            // 
            // 
            this.textBox3.CustomButton.Image = null;
            this.textBox3.CustomButton.Location = new System.Drawing.Point(62, 2);
            this.textBox3.CustomButton.Name = "";
            this.textBox3.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.textBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox3.CustomButton.TabIndex = 1;
            this.textBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.textBox3.CustomButton.UseSelectable = true;
            this.textBox3.CustomButton.Visible = false;
            this.textBox3.Lines = new string[] {
        "Margin"};
            this.textBox3.Location = new System.Drawing.Point(376, 10);
            this.textBox3.MaxLength = 32767;
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '\0';
            this.textBox3.ReadOnly = true;
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox3.SelectedText = "";
            this.textBox3.SelectionLength = 0;
            this.textBox3.SelectionStart = 0;
            this.textBox3.ShortcutsEnabled = true;
            this.textBox3.Size = new System.Drawing.Size(80, 20);
            this.textBox3.Style = MetroFramework.MetroColorStyle.Red;
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "Margin";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.UseSelectable = true;
            this.textBox3.UseStyleColors = true;
            this.textBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBox4
            // 
            // 
            // 
            // 
            this.textBox4.CustomButton.Image = null;
            this.textBox4.CustomButton.Location = new System.Drawing.Point(62, 2);
            this.textBox4.CustomButton.Name = "";
            this.textBox4.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.textBox4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox4.CustomButton.TabIndex = 1;
            this.textBox4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.textBox4.CustomButton.UseSelectable = true;
            this.textBox4.CustomButton.Visible = false;
            this.textBox4.Lines = new string[] {
        "Mark"};
            this.textBox4.Location = new System.Drawing.Point(204, 10);
            this.textBox4.MaxLength = 32767;
            this.textBox4.Name = "textBox4";
            this.textBox4.PasswordChar = '\0';
            this.textBox4.ReadOnly = true;
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox4.SelectedText = "";
            this.textBox4.SelectionLength = 0;
            this.textBox4.SelectionStart = 0;
            this.textBox4.ShortcutsEnabled = true;
            this.textBox4.Size = new System.Drawing.Size(80, 20);
            this.textBox4.Style = MetroFramework.MetroColorStyle.Red;
            this.textBox4.TabIndex = 10;
            this.textBox4.Text = "Mark";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.UseSelectable = true;
            this.textBox4.UseStyleColors = true;
            this.textBox4.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox4.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBox5
            // 
            // 
            // 
            // 
            this.textBox5.CustomButton.Image = null;
            this.textBox5.CustomButton.Location = new System.Drawing.Point(62, 2);
            this.textBox5.CustomButton.Name = "";
            this.textBox5.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.textBox5.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox5.CustomButton.TabIndex = 1;
            this.textBox5.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.textBox5.CustomButton.UseSelectable = true;
            this.textBox5.CustomButton.Visible = false;
            this.textBox5.Lines = new string[] {
        "Entry"};
            this.textBox5.Location = new System.Drawing.Point(118, 10);
            this.textBox5.MaxLength = 32767;
            this.textBox5.Name = "textBox5";
            this.textBox5.PasswordChar = '\0';
            this.textBox5.ReadOnly = true;
            this.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox5.SelectedText = "";
            this.textBox5.SelectionLength = 0;
            this.textBox5.SelectionStart = 0;
            this.textBox5.ShortcutsEnabled = true;
            this.textBox5.Size = new System.Drawing.Size(80, 20);
            this.textBox5.Style = MetroFramework.MetroColorStyle.Red;
            this.textBox5.TabIndex = 9;
            this.textBox5.Text = "Entry";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox5.UseSelectable = true;
            this.textBox5.UseStyleColors = true;
            this.textBox5.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox5.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBox7
            // 
            // 
            // 
            // 
            this.textBox7.CustomButton.Image = null;
            this.textBox7.CustomButton.Location = new System.Drawing.Point(62, 2);
            this.textBox7.CustomButton.Name = "";
            this.textBox7.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.textBox7.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox7.CustomButton.TabIndex = 1;
            this.textBox7.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.textBox7.CustomButton.UseSelectable = true;
            this.textBox7.CustomButton.Visible = false;
            this.textBox7.Lines = new string[] {
        "Size"};
            this.textBox7.Location = new System.Drawing.Point(32, 10);
            this.textBox7.MaxLength = 32767;
            this.textBox7.Name = "textBox7";
            this.textBox7.PasswordChar = '\0';
            this.textBox7.ReadOnly = true;
            this.textBox7.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox7.SelectedText = "";
            this.textBox7.SelectionLength = 0;
            this.textBox7.SelectionStart = 0;
            this.textBox7.ShortcutsEnabled = true;
            this.textBox7.Size = new System.Drawing.Size(80, 20);
            this.textBox7.Style = MetroFramework.MetroColorStyle.Red;
            this.textBox7.TabIndex = 7;
            this.textBox7.Text = "Size";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox7.UseSelectable = true;
            this.textBox7.UseStyleColors = true;
            this.textBox7.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox7.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPositionUnrealizedPnLPercent
            // 
            // 
            // 
            // 
            this.txtPositionUnrealizedPnLPercent.CustomButton.Image = null;
            this.txtPositionUnrealizedPnLPercent.CustomButton.Location = new System.Drawing.Point(62, 2);
            this.txtPositionUnrealizedPnLPercent.CustomButton.Name = "";
            this.txtPositionUnrealizedPnLPercent.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtPositionUnrealizedPnLPercent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPositionUnrealizedPnLPercent.CustomButton.TabIndex = 1;
            this.txtPositionUnrealizedPnLPercent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtPositionUnrealizedPnLPercent.CustomButton.UseSelectable = true;
            this.txtPositionUnrealizedPnLPercent.CustomButton.Visible = false;
            this.txtPositionUnrealizedPnLPercent.Lines = new string[0];
            this.txtPositionUnrealizedPnLPercent.Location = new System.Drawing.Point(548, 30);
            this.txtPositionUnrealizedPnLPercent.MaxLength = 32767;
            this.txtPositionUnrealizedPnLPercent.Name = "txtPositionUnrealizedPnLPercent";
            this.txtPositionUnrealizedPnLPercent.PasswordChar = '\0';
            this.txtPositionUnrealizedPnLPercent.ReadOnly = true;
            this.txtPositionUnrealizedPnLPercent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPositionUnrealizedPnLPercent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPositionUnrealizedPnLPercent.SelectedText = "";
            this.txtPositionUnrealizedPnLPercent.SelectionLength = 0;
            this.txtPositionUnrealizedPnLPercent.SelectionStart = 0;
            this.txtPositionUnrealizedPnLPercent.ShortcutsEnabled = true;
            this.txtPositionUnrealizedPnLPercent.Size = new System.Drawing.Size(80, 20);
            this.txtPositionUnrealizedPnLPercent.Style = MetroFramework.MetroColorStyle.Red;
            this.txtPositionUnrealizedPnLPercent.TabIndex = 6;
            this.txtPositionUnrealizedPnLPercent.UseSelectable = true;
            this.txtPositionUnrealizedPnLPercent.UseStyleColors = true;
            this.txtPositionUnrealizedPnLPercent.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPositionUnrealizedPnLPercent.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPositionUnrealizedPnL
            // 
            // 
            // 
            // 
            this.txtPositionUnrealizedPnL.CustomButton.Image = null;
            this.txtPositionUnrealizedPnL.CustomButton.Location = new System.Drawing.Point(62, 2);
            this.txtPositionUnrealizedPnL.CustomButton.Name = "";
            this.txtPositionUnrealizedPnL.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtPositionUnrealizedPnL.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPositionUnrealizedPnL.CustomButton.TabIndex = 1;
            this.txtPositionUnrealizedPnL.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtPositionUnrealizedPnL.CustomButton.UseSelectable = true;
            this.txtPositionUnrealizedPnL.CustomButton.Visible = false;
            this.txtPositionUnrealizedPnL.Lines = new string[0];
            this.txtPositionUnrealizedPnL.Location = new System.Drawing.Point(462, 30);
            this.txtPositionUnrealizedPnL.MaxLength = 32767;
            this.txtPositionUnrealizedPnL.Name = "txtPositionUnrealizedPnL";
            this.txtPositionUnrealizedPnL.PasswordChar = '\0';
            this.txtPositionUnrealizedPnL.ReadOnly = true;
            this.txtPositionUnrealizedPnL.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPositionUnrealizedPnL.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPositionUnrealizedPnL.SelectedText = "";
            this.txtPositionUnrealizedPnL.SelectionLength = 0;
            this.txtPositionUnrealizedPnL.SelectionStart = 0;
            this.txtPositionUnrealizedPnL.ShortcutsEnabled = true;
            this.txtPositionUnrealizedPnL.Size = new System.Drawing.Size(80, 20);
            this.txtPositionUnrealizedPnL.Style = MetroFramework.MetroColorStyle.Red;
            this.txtPositionUnrealizedPnL.TabIndex = 5;
            this.txtPositionUnrealizedPnL.UseSelectable = true;
            this.txtPositionUnrealizedPnL.UseStyleColors = true;
            this.txtPositionUnrealizedPnL.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPositionUnrealizedPnL.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPositionMargin
            // 
            // 
            // 
            // 
            this.txtPositionMargin.CustomButton.Image = null;
            this.txtPositionMargin.CustomButton.Location = new System.Drawing.Point(62, 2);
            this.txtPositionMargin.CustomButton.Name = "";
            this.txtPositionMargin.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtPositionMargin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPositionMargin.CustomButton.TabIndex = 1;
            this.txtPositionMargin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtPositionMargin.CustomButton.UseSelectable = true;
            this.txtPositionMargin.CustomButton.Visible = false;
            this.txtPositionMargin.Lines = new string[0];
            this.txtPositionMargin.Location = new System.Drawing.Point(376, 30);
            this.txtPositionMargin.MaxLength = 32767;
            this.txtPositionMargin.Name = "txtPositionMargin";
            this.txtPositionMargin.PasswordChar = '\0';
            this.txtPositionMargin.ReadOnly = true;
            this.txtPositionMargin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPositionMargin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPositionMargin.SelectedText = "";
            this.txtPositionMargin.SelectionLength = 0;
            this.txtPositionMargin.SelectionStart = 0;
            this.txtPositionMargin.ShortcutsEnabled = true;
            this.txtPositionMargin.Size = new System.Drawing.Size(80, 20);
            this.txtPositionMargin.Style = MetroFramework.MetroColorStyle.Red;
            this.txtPositionMargin.TabIndex = 4;
            this.txtPositionMargin.UseSelectable = true;
            this.txtPositionMargin.UseStyleColors = true;
            this.txtPositionMargin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPositionMargin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPositionMarkPrice
            // 
            // 
            // 
            // 
            this.txtPositionMarkPrice.CustomButton.Image = null;
            this.txtPositionMarkPrice.CustomButton.Location = new System.Drawing.Point(62, 2);
            this.txtPositionMarkPrice.CustomButton.Name = "";
            this.txtPositionMarkPrice.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtPositionMarkPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPositionMarkPrice.CustomButton.TabIndex = 1;
            this.txtPositionMarkPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtPositionMarkPrice.CustomButton.UseSelectable = true;
            this.txtPositionMarkPrice.CustomButton.Visible = false;
            this.txtPositionMarkPrice.Lines = new string[0];
            this.txtPositionMarkPrice.Location = new System.Drawing.Point(204, 30);
            this.txtPositionMarkPrice.MaxLength = 32767;
            this.txtPositionMarkPrice.Name = "txtPositionMarkPrice";
            this.txtPositionMarkPrice.PasswordChar = '\0';
            this.txtPositionMarkPrice.ReadOnly = true;
            this.txtPositionMarkPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPositionMarkPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPositionMarkPrice.SelectedText = "";
            this.txtPositionMarkPrice.SelectionLength = 0;
            this.txtPositionMarkPrice.SelectionStart = 0;
            this.txtPositionMarkPrice.ShortcutsEnabled = true;
            this.txtPositionMarkPrice.Size = new System.Drawing.Size(80, 20);
            this.txtPositionMarkPrice.Style = MetroFramework.MetroColorStyle.Red;
            this.txtPositionMarkPrice.TabIndex = 3;
            this.txtPositionMarkPrice.UseSelectable = true;
            this.txtPositionMarkPrice.UseStyleColors = true;
            this.txtPositionMarkPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPositionMarkPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPositionEntryPrice
            // 
            // 
            // 
            // 
            this.txtPositionEntryPrice.CustomButton.Image = null;
            this.txtPositionEntryPrice.CustomButton.Location = new System.Drawing.Point(62, 2);
            this.txtPositionEntryPrice.CustomButton.Name = "";
            this.txtPositionEntryPrice.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtPositionEntryPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPositionEntryPrice.CustomButton.TabIndex = 1;
            this.txtPositionEntryPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtPositionEntryPrice.CustomButton.UseSelectable = true;
            this.txtPositionEntryPrice.CustomButton.Visible = false;
            this.txtPositionEntryPrice.Lines = new string[0];
            this.txtPositionEntryPrice.Location = new System.Drawing.Point(118, 30);
            this.txtPositionEntryPrice.MaxLength = 32767;
            this.txtPositionEntryPrice.Name = "txtPositionEntryPrice";
            this.txtPositionEntryPrice.PasswordChar = '\0';
            this.txtPositionEntryPrice.ReadOnly = true;
            this.txtPositionEntryPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPositionEntryPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPositionEntryPrice.SelectedText = "";
            this.txtPositionEntryPrice.SelectionLength = 0;
            this.txtPositionEntryPrice.SelectionStart = 0;
            this.txtPositionEntryPrice.ShortcutsEnabled = true;
            this.txtPositionEntryPrice.Size = new System.Drawing.Size(80, 20);
            this.txtPositionEntryPrice.Style = MetroFramework.MetroColorStyle.Red;
            this.txtPositionEntryPrice.TabIndex = 2;
            this.txtPositionEntryPrice.UseSelectable = true;
            this.txtPositionEntryPrice.UseStyleColors = true;
            this.txtPositionEntryPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPositionEntryPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPositionSize
            // 
            // 
            // 
            // 
            this.txtPositionSize.CustomButton.Image = null;
            this.txtPositionSize.CustomButton.Location = new System.Drawing.Point(62, 2);
            this.txtPositionSize.CustomButton.Name = "";
            this.txtPositionSize.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtPositionSize.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPositionSize.CustomButton.TabIndex = 1;
            this.txtPositionSize.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtPositionSize.CustomButton.UseSelectable = true;
            this.txtPositionSize.CustomButton.Visible = false;
            this.txtPositionSize.Lines = new string[0];
            this.txtPositionSize.Location = new System.Drawing.Point(32, 30);
            this.txtPositionSize.MaxLength = 32767;
            this.txtPositionSize.Name = "txtPositionSize";
            this.txtPositionSize.PasswordChar = '\0';
            this.txtPositionSize.ReadOnly = true;
            this.txtPositionSize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPositionSize.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPositionSize.SelectedText = "";
            this.txtPositionSize.SelectionLength = 0;
            this.txtPositionSize.SelectionStart = 0;
            this.txtPositionSize.ShortcutsEnabled = true;
            this.txtPositionSize.Size = new System.Drawing.Size(80, 20);
            this.txtPositionSize.Style = MetroFramework.MetroColorStyle.Red;
            this.txtPositionSize.TabIndex = 0;
            this.txtPositionSize.UseSelectable = true;
            this.txtPositionSize.UseStyleColors = true;
            this.txtPositionSize.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPositionSize.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // nudPositionLimitPrice
            // 
            this.nudPositionLimitPrice.DecimalPlaces = 1;
            this.nudPositionLimitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPositionLimitPrice.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudPositionLimitPrice.Location = new System.Drawing.Point(634, 30);
            this.nudPositionLimitPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPositionLimitPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            524288});
            this.nudPositionLimitPrice.Name = "nudPositionLimitPrice";
            this.nudPositionLimitPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nudPositionLimitPrice.Size = new System.Drawing.Size(60, 20);
            this.nudPositionLimitPrice.TabIndex = 19;
            this.nudPositionLimitPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            524288});
            // 
            // nudPositionMargin
            // 
            this.nudPositionMargin.DecimalPlaces = 2;
            this.nudPositionMargin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPositionMargin.Location = new System.Drawing.Point(766, 30);
            this.nudPositionMargin.Name = "nudPositionMargin";
            this.nudPositionMargin.Size = new System.Drawing.Size(60, 20);
            this.nudPositionMargin.TabIndex = 20;
            this.nudPositionMargin.Value = new decimal(new int[] {
            1,
            0,
            0,
            524288});
            // 
            // tmrClientUpdates
            // 
            this.tmrClientUpdates.Tick += new System.EventHandler(this.tmrClientUpdates_Tick);
            // 
            // nudCurrentPrice
            // 
            this.nudCurrentPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCurrentPrice.ImeMode = System.Windows.Forms.ImeMode.On;
            this.nudCurrentPrice.Location = new System.Drawing.Point(365, 34);
            this.nudCurrentPrice.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.nudCurrentPrice.Minimum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            -2147483648});
            this.nudCurrentPrice.Name = "nudCurrentPrice";
            this.nudCurrentPrice.ReadOnly = true;
            this.nudCurrentPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nudCurrentPrice.Size = new System.Drawing.Size(123, 29);
            this.nudCurrentPrice.TabIndex = 17;
            // 
            // lblDonate
            // 
            this.lblDonate.AutoSize = true;
            this.lblDonate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDonate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblDonate.Location = new System.Drawing.Point(403, 528);
            this.lblDonate.Name = "lblDonate";
            this.lblDonate.Size = new System.Drawing.Size(319, 19);
            this.lblDonate.Style = MetroFramework.MetroColorStyle.Green;
            this.lblDonate.TabIndex = 18;
            this.lblDonate.Text = "Please consider donating BTC to support this project.";
            this.lblDonate.UseStyleColors = true;
            this.lblDonate.Click += new System.EventHandler(this.lblDonate_Click);
            // 
            // pbxYouTubeSubscribe
            // 
            this.pbxYouTubeSubscribe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxYouTubeSubscribe.Image = ((System.Drawing.Image)(resources.GetObject("pbxYouTubeSubscribe.Image")));
            this.pbxYouTubeSubscribe.Location = new System.Drawing.Point(578, 12);
            this.pbxYouTubeSubscribe.Name = "pbxYouTubeSubscribe";
            this.pbxYouTubeSubscribe.Size = new System.Drawing.Size(137, 30);
            this.pbxYouTubeSubscribe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxYouTubeSubscribe.TabIndex = 19;
            this.pbxYouTubeSubscribe.TabStop = false;
            this.pbxYouTubeSubscribe.Click += new System.EventHandler(this.pbxYouTubeSubscribe_Click);
            // 
            // tmrLimitNowBuy
            // 
            this.tmrLimitNowBuy.Interval = 1000;
            this.tmrLimitNowBuy.Tick += new System.EventHandler(this.tmrLimitNowBuy_Tick);
            // 
            // tmrLimitNowSell
            // 
            this.tmrLimitNowSell.Interval = 1000;
            this.tmrLimitNowSell.Tick += new System.EventHandler(this.tmrLimitNowSell_Tick);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(365, 12);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(43, 19);
            this.metroLabel1.TabIndex = 20;
            this.metroLabel1.Text = "Price";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(200, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // MetroToolTip
            // 
            this.MetroToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.MetroToolTip.StyleManager = null;
            this.MetroToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblBalanceAndTime
            // 
            this.lblBalanceAndTime.AutoSize = true;
            this.lblBalanceAndTime.Location = new System.Drawing.Point(4, 528);
            this.lblBalanceAndTime.Name = "lblBalanceAndTime";
            this.lblBalanceAndTime.Size = new System.Drawing.Size(83, 19);
            this.lblBalanceAndTime.Style = MetroFramework.MetroColorStyle.White;
            this.lblBalanceAndTime.TabIndex = 22;
            this.lblBalanceAndTime.Text = "metroLabel2";
            this.lblBalanceAndTime.UseStyleColors = true;
            // 
            // lblNetworkAndVersion
            // 
            this.lblNetworkAndVersion.AutoSize = true;
            this.lblNetworkAndVersion.Location = new System.Drawing.Point(755, 528);
            this.lblNetworkAndVersion.Name = "lblNetworkAndVersion";
            this.lblNetworkAndVersion.Size = new System.Drawing.Size(83, 19);
            this.lblNetworkAndVersion.Style = MetroFramework.MetroColorStyle.White;
            this.lblNetworkAndVersion.TabIndex = 23;
            this.lblNetworkAndVersion.Text = "metroLabel2";
            this.lblNetworkAndVersion.UseStyleColors = true;
            // 
            // pnlPosition
            // 
            this.pnlPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlPosition.Controls.Add(this.btnPositionMargin);
            this.pnlPosition.Controls.Add(this.btnPositionMarketClose);
            this.pnlPosition.Controls.Add(this.textBox7);
            this.pnlPosition.Controls.Add(this.txtPositionUnrealizedPnL);
            this.pnlPosition.Controls.Add(this.btnPositionLimitClose);
            this.pnlPosition.Controls.Add(this.txtPositionUnrealizedPnLPercent);
            this.pnlPosition.Controls.Add(this.txtPositionMargin);
            this.pnlPosition.Controls.Add(this.textBox8);
            this.pnlPosition.Controls.Add(this.txtPositionMarkPrice);
            this.pnlPosition.Controls.Add(this.textBox5);
            this.pnlPosition.Controls.Add(this.txtPositionLiquidation);
            this.pnlPosition.Controls.Add(this.txtPositionEntryPrice);
            this.pnlPosition.Controls.Add(this.textBox4);
            this.pnlPosition.Controls.Add(this.textBox1);
            this.pnlPosition.Controls.Add(this.txtPositionSize);
            this.pnlPosition.Controls.Add(this.nudPositionMargin);
            this.pnlPosition.Controls.Add(this.textBox3);
            this.pnlPosition.Controls.Add(this.textBox2);
            this.pnlPosition.Controls.Add(this.nudPositionLimitPrice);
            this.pnlPosition.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlPosition.HorizontalScrollbarBarColor = true;
            this.pnlPosition.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlPosition.HorizontalScrollbarSize = 10;
            this.pnlPosition.Location = new System.Drawing.Point(0, 69);
            this.pnlPosition.Name = "pnlPosition";
            this.pnlPosition.Size = new System.Drawing.Size(857, 60);
            this.pnlPosition.Style = MetroFramework.MetroColorStyle.Purple;
            this.pnlPosition.TabIndex = 24;
            this.pnlPosition.UseCustomBackColor = true;
            this.pnlPosition.UseCustomForeColor = true;
            this.pnlPosition.UseStyleColors = true;
            this.pnlPosition.VerticalScrollbarBarColor = true;
            this.pnlPosition.VerticalScrollbarHighlightOnWheel = false;
            this.pnlPosition.VerticalScrollbarSize = 10;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.SteelBlue;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(0, 69);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(857, 4);
            this.label15.TabIndex = 25;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.SteelBlue;
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(0, 125);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(857, 4);
            this.label22.TabIndex = 26;
            // 
            // label31
            // 
            this.label31.BackColor = System.Drawing.Color.SteelBlue;
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.Location = new System.Drawing.Point(0, 519);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(857, 4);
            this.label31.TabIndex = 27;
            // 
            // YouTubeVideoBrowser
            // 
            this.YouTubeVideoBrowser.Location = new System.Drawing.Point(0, 0);
            this.YouTubeVideoBrowser.Name = "YouTubeVideoBrowser";
            this.YouTubeVideoBrowser.Size = new System.Drawing.Size(250, 250);
            this.YouTubeVideoBrowser.TabIndex = 0;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(577, 46);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(261, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel6.TabIndex = 28;
            this.metroLabel6.Text = "This application is not affiliated with BitMEX";
            this.metroLabel6.UseStyleColors = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(721, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(109, 199);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(164, 19);
            this.metroLabel7.TabIndex = 8;
            this.metroLabel7.Text = "Limit Now Minimum Delay";
            // 
            // nudSettingsLimitNowMinimumDelay
            // 
            this.nudSettingsLimitNowMinimumDelay.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudSettingsLimitNowMinimumDelay.Location = new System.Drawing.Point(3, 199);
            this.nudSettingsLimitNowMinimumDelay.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nudSettingsLimitNowMinimumDelay.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudSettingsLimitNowMinimumDelay.Name = "nudSettingsLimitNowMinimumDelay";
            this.nudSettingsLimitNowMinimumDelay.Size = new System.Drawing.Size(100, 20);
            this.nudSettingsLimitNowMinimumDelay.TabIndex = 7;
            this.nudSettingsLimitNowMinimumDelay.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudSettingsLimitNowMinimumDelay.ValueChanged += new System.EventHandler(this.nudSettingsLimitNowMinimumDelay_ValueChanged);
            // 
            // Bot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 554);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pnlPosition);
            this.Controls.Add(this.lblNetworkAndVersion);
            this.Controls.Add(this.lblBalanceAndTime);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lblDonate);
            this.Controls.Add(this.nudCurrentPrice);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddlSymbol);
            this.Controls.Add(this.ddlCandleTimes);
            this.Controls.Add(this.pbxYouTubeSubscribe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Bot";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "BitMEX Assistant";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bot_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Bot_FormClosed);
            this.Load += new System.EventHandler(this.Bot_Load);
            this.TabControl.ResumeLayout(false);
            this.tabManual.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudManualLimitPercentModifier4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudManualLimitPercentModifier3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudManualLimitPercentModifier2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudManualLimitPercentModifier1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudManualLimitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudManualLimitContracts)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudManualMarketBuyContracts)).EndInit();
            this.tabLimitNow.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimitNowSellContracts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimitNowSellTicksFromCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimitNowSellDelay)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimitNowBuyContracts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimitNowBuyTicksFromCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimitNowBuyDelay)).EndInit();
            this.tabSpread.ResumeLayout(false);
            this.tabSpread.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpreadSellOrderCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpreadSellValueApart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpreadSellContractsEach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpreadBuyOrderCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpreadBuyValueApart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpreadBuyContractsEach)).EndInit();
            this.tabDCA.ResumeLayout(false);
            this.tabDCA.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDCAContracts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDCAHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDCASeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDCATimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDCAMinutes)).EndInit();
            this.tabStops.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStopTrailingLimitOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStopTrailingContracts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStopTrailingTrail)).EndInit();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSettingsRetryWaitTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSettingsOverloadRetryAttempts)).EndInit();
            this.tabDonate.ResumeLayout(false);
            this.tabDonate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPositionLimitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPositionMargin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCurrentPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxYouTubeSubscribe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlPosition.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSettingsLimitNowMinimumDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox ddlCandleTimes;
        private MetroFramework.Controls.MetroComboBox ddlSymbol;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroLabel label2;
        private System.Windows.Forms.Timer Heartbeat;
        private MetroFramework.Controls.MetroTabControl TabControl;
        private MetroFramework.Controls.MetroTabPage tabDCA;
        private MetroFramework.Controls.MetroLabel lblalskdj;
        private System.Windows.Forms.NumericUpDown nudDCASeconds;
        private MetroFramework.Controls.MetroLabel label3;
        private System.Windows.Forms.NumericUpDown nudDCAMinutes;
        private MetroFramework.Controls.MetroButton btnDCAStop;
        private MetroFramework.Controls.MetroLabel lblDCASummary;
        private MetroFramework.Controls.MetroLabel label6;
        private MetroFramework.Controls.MetroLabel label5;
        private MetroFramework.Controls.MetroLabel label4;
        private System.Windows.Forms.NumericUpDown nudDCATimes;
        private System.Windows.Forms.NumericUpDown nudDCAHours;
        private System.Windows.Forms.NumericUpDown nudDCAContracts;
        private MetroFramework.Controls.MetroButton btnDCASell;
        private MetroFramework.Controls.MetroButton btnDCABuy;
        private MetroFramework.Controls.MetroTabPage tabSettings;
        private System.Windows.Forms.Timer tmrDCA;
        private MetroFramework.Controls.MetroProgressBar pgbDCA;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroCheckBox chkDCAReduceOnly;
        private MetroFramework.Controls.MetroCheckBox chkDCAExecuteImmediately;
        private MetroFramework.Controls.MetroButton btnPositionMarketClose;
        private MetroFramework.Controls.MetroButton btnPositionLimitClose;
        private MetroFramework.Controls.MetroTextBox textBox8;
        private MetroFramework.Controls.MetroTextBox txtPositionLiquidation;
        private MetroFramework.Controls.MetroTextBox textBox1;
        private MetroFramework.Controls.MetroTextBox textBox2;
        private MetroFramework.Controls.MetroTextBox textBox3;
        private MetroFramework.Controls.MetroTextBox textBox4;
        private MetroFramework.Controls.MetroTextBox textBox5;
        private MetroFramework.Controls.MetroTextBox textBox7;
        private MetroFramework.Controls.MetroTextBox txtPositionUnrealizedPnLPercent;
        private MetroFramework.Controls.MetroTextBox txtPositionUnrealizedPnL;
        private MetroFramework.Controls.MetroTextBox txtPositionMargin;
        private MetroFramework.Controls.MetroTextBox txtPositionMarkPrice;
        private MetroFramework.Controls.MetroTextBox txtPositionEntryPrice;
        private MetroFramework.Controls.MetroTextBox txtPositionSize;
        private System.Windows.Forms.NumericUpDown nudPositionLimitPrice;
        private MetroFramework.Controls.MetroLabel label8;
        private System.Windows.Forms.NumericUpDown nudSettingsRetryWaitTime;
        private MetroFramework.Controls.MetroLabel label7;
        private MetroFramework.Controls.MetroCheckBox chkSettingOverloadRetry;
        private System.Windows.Forms.NumericUpDown nudSettingsOverloadRetryAttempts;
        private MetroFramework.Controls.MetroTabPage tabSpread;
        private MetroFramework.Controls.MetroLabel label10;
        private System.Windows.Forms.NumericUpDown nudSpreadBuyValueApart;
        private MetroFramework.Controls.MetroLabel label9;
        private System.Windows.Forms.NumericUpDown nudSpreadBuyOrderCount;
        private MetroFramework.Controls.MetroLabel label11;
        private System.Windows.Forms.NumericUpDown nudSpreadBuyContractsEach;
        private MetroFramework.Controls.MetroButton btnSpreadPlaceOrders;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroCheckBox chkSpreadSellExecute;
        private System.Windows.Forms.NumericUpDown nudSpreadSellOrderCount;
        private MetroFramework.Controls.MetroCheckBox chkSpreadSellReduceOnly;
        private MetroFramework.Controls.MetroLabel label12;
        private System.Windows.Forms.NumericUpDown nudSpreadSellValueApart;
        private MetroFramework.Controls.MetroLabel label13;
        private MetroFramework.Controls.MetroLabel label14;
        private System.Windows.Forms.NumericUpDown nudSpreadSellContractsEach;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroCheckBox chkSpreadBuyExecute;
        private MetroFramework.Controls.MetroCheckBox chkSpreadBuyReduceOnly;
        private MetroFramework.Controls.MetroButton btnSpreadCloseAllOpenOrders;
        private MetroFramework.Controls.MetroCheckBox chkSpreadCancelWhileOrdering;
        private MetroFramework.Controls.MetroCheckBox chkSpreadSellPostOnly;
        private MetroFramework.Controls.MetroCheckBox chkSpreadyBuyPostOnly;
        private MetroFramework.Controls.MetroButton btnExportCandles;
        private System.Windows.Forms.Timer tmrClientUpdates;
        private System.Windows.Forms.NumericUpDown nudCurrentPrice;
        private MetroFramework.Controls.MetroTabPage tabDonate;
        private MetroFramework.Controls.MetroLabel lblDonateAddress;
        private MetroFramework.Controls.MetroLabel label16;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel lblDonate;
        private MetroFramework.Controls.MetroTabPage tabManual;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroButton btnManualMarketSell;
        private MetroFramework.Controls.MetroButton btnManualMarketBuy;
        private MetroFramework.Controls.MetroCheckBox chkManualMarketBuyReduceOnly;
        private MetroFramework.Controls.MetroLabel label19;
        private System.Windows.Forms.NumericUpDown nudManualMarketBuyContracts;
        private System.Windows.Forms.GroupBox groupBox5;
        private MetroFramework.Controls.MetroButton btnManualLimitSell;
        private MetroFramework.Controls.MetroCheckBox chkManualLimitCancelWhileOrdering;
        private MetroFramework.Controls.MetroButton btnManualLimitBuy;
        private MetroFramework.Controls.MetroCheckBox chkManualLimitPostOnly;
        private MetroFramework.Controls.MetroLabel label20;
        private System.Windows.Forms.NumericUpDown nudManualLimitPrice;
        private MetroFramework.Controls.MetroCheckBox chkManualLimitReduceOnly;
        private MetroFramework.Controls.MetroLabel label18;
        private System.Windows.Forms.NumericUpDown nudManualLimitContracts;
        private MetroFramework.Controls.MetroButton btnManualLimitSetCurrentPrice;
        private MetroFramework.Controls.MetroCheckBox chkManualLimitHiddenOrder;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown nudManualLimitPercentModifier4;
        private MetroFramework.Controls.MetroButton btnManualLimitPercentModifier4Up;
        private MetroFramework.Controls.MetroButton btnManualLimitPercentModifier4Down;
        private System.Windows.Forms.NumericUpDown nudManualLimitPercentModifier3;
        private MetroFramework.Controls.MetroButton btnManualLimitPercentModifier3Up;
        private MetroFramework.Controls.MetroButton btnManualLimitPercentModifier3Down;
        private System.Windows.Forms.NumericUpDown nudManualLimitPercentModifier2;
        private MetroFramework.Controls.MetroButton btnManualLimitPercentModifier2Up;
        private MetroFramework.Controls.MetroButton btnManualLimitPercentModifier2Down;
        private System.Windows.Forms.NumericUpDown nudManualLimitPercentModifier1;
        private MetroFramework.Controls.MetroButton btnManualLimitPercentModifier1Up;
        private MetroFramework.Controls.MetroButton btnManualLimitPercentModifier1Down;
        private MetroFramework.Controls.MetroCheckBox chkManualLimitPercentModifierUseCurrentPrice;
        private MetroFramework.Controls.MetroButton btnManualLimitCancelOpenOrders;
        private System.Windows.Forms.PictureBox pbxYouTubeSubscribe;
        private MetroFramework.Controls.MetroButton btnPositionMargin;
        private System.Windows.Forms.NumericUpDown nudPositionMargin;
        private MetroFramework.Controls.MetroTabPage tabLimitNow;
        private MetroFramework.Controls.MetroButton btnLimitNowSell;
        private MetroFramework.Controls.MetroLabel label21;
        private MetroFramework.Controls.MetroButton btnLimitNowBuy;
        private System.Windows.Forms.NumericUpDown nudLimitNowBuyContracts;
        private System.Windows.Forms.Timer tmrLimitNowBuy;
        private System.Windows.Forms.Timer tmrLimitNowSell;
        private MetroFramework.Controls.MetroLabel label23;
        private System.Windows.Forms.NumericUpDown nudLimitNowBuyTicksFromCenter;
        private MetroFramework.Controls.MetroLabel label24;
        private System.Windows.Forms.NumericUpDown nudLimitNowBuyDelay;
        private MetroFramework.Controls.MetroButton btnLimitNowBuyCancel;
        private MetroFramework.Controls.MetroButton btnLimitNowSellCancel;
        private System.Windows.Forms.GroupBox groupBox7;
        private MetroFramework.Controls.MetroCheckBox chkLimitNowBuyContinue;
        private System.Windows.Forms.GroupBox groupBox8;
        private MetroFramework.Controls.MetroCheckBox chkLimitNowSellContinue;
        private System.Windows.Forms.NumericUpDown nudLimitNowSellContracts;
        private MetroFramework.Controls.MetroLabel label25;
        private MetroFramework.Controls.MetroLabel label26;
        private System.Windows.Forms.NumericUpDown nudLimitNowSellTicksFromCenter;
        private System.Windows.Forms.NumericUpDown nudLimitNowSellDelay;
        private MetroFramework.Controls.MetroLabel label27;
        private MetroFramework.Controls.MetroComboBox ddlLimitNowBuyMethod;
        private MetroFramework.Controls.MetroLabel label29;
        private MetroFramework.Controls.MetroComboBox ddlLimitNowSellMethod;
        private MetroFramework.Controls.MetroLabel label28;
        private MetroFramework.Controls.MetroCheckBox chkLimitNowSellReduceOnly;
        private MetroFramework.Controls.MetroCheckBox chkLimitNowBuyReduceOnly;
        private MetroFramework.Controls.MetroLabel lblSettingsWebsocketInfo;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label30;
        private MetroFramework.Components.MetroToolTip MetroToolTip;
        private MetroFramework.Controls.MetroLabel lblNetworkAndVersion;
        private MetroFramework.Controls.MetroLabel lblBalanceAndTime;
        private MetroFramework.Controls.MetroPanel pnlPosition;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label15;
        private MetroFramework.Controls.MetroTabPage tabStops;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox ddlStopTrailingMethod;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.NumericUpDown nudStopTrailingTrail;
        private System.Windows.Forms.GroupBox groupBox9;
        private MetroFramework.Controls.MetroLabel lblStopTraillingPrice;
        private System.Windows.Forms.NumericUpDown nudStopTrailingLimitOffset;
        private MetroFramework.Controls.MetroLabel lblTrailingStopLimitOffset;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.NumericUpDown nudStopTrailingContracts;
        private MetroFramework.Controls.MetroToggle chkTrailingStopEnabled;
        private MetroFramework.Controls.MetroCheckBox chkStopTrailingCloseInFull;
        private MetroFramework.Controls.MetroLabel lblStopTrailingLimitOffsetPrice;
        private MetroFramework.Controls.MetroLabel lblTrailingStopLimitPricePreviewLabel;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.TabPage tabVideos;
        private System.Windows.Forms.WebBrowser YouTubeVideoBrowser;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.NumericUpDown nudSettingsLimitNowMinimumDelay;
    }
}