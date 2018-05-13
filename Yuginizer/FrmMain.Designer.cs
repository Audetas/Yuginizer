namespace Yuginizer
{
    partial class FrmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
			this.splitMain = new System.Windows.Forms.SplitContainer();
			this.tabsMenu = new System.Windows.Forms.TabControl();
			this.tabCards = new System.Windows.Forms.TabPage();
			this.lstYourCards = new System.Windows.Forms.ListBox();
			this.pnlYourCardsSearch = new System.Windows.Forms.Panel();
			this.lblSearch = new System.Windows.Forms.Label();
			this.tbxSearch = new System.Windows.Forms.TextBox();
			this.pnlYourCardsHeader = new System.Windows.Forms.Panel();
			this.btnRefreshTotalValue = new System.Windows.Forms.LinkLabel();
			this.lblTotalValue = new System.Windows.Forms.Label();
			this.lblYourCardsTitle = new System.Windows.Forms.Label();
			this.tabFind = new System.Windows.Forms.TabPage();
			this.lstSearchResults = new System.Windows.Forms.ListBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblResultsValue = new System.Windows.Forms.Label();
			this.lblResultsCount = new System.Windows.Forms.Label();
			this.pnlNewCardsSearch = new System.Windows.Forms.Panel();
			this.chkSupportCards = new System.Windows.Forms.RadioButton();
			this.chkSets = new System.Windows.Forms.RadioButton();
			this.chkCards = new System.Windows.Forms.RadioButton();
			this.lblFilter = new System.Windows.Forms.Label();
			this.lstFilter = new System.Windows.Forms.ComboBox();
			this.btnNewCardsSearch = new System.Windows.Forms.Button();
			this.lblSearchNew = new System.Windows.Forms.Label();
			this.tbxNewCardsSearch = new System.Windows.Forms.TextBox();
			this.pnlNewCardsHeader = new System.Windows.Forms.Panel();
			this.lblNewCardsSubTitle = new System.Windows.Forms.Label();
			this.lblNewCardsTitle = new System.Windows.Forms.Label();
			this.pnlCardView = new System.Windows.Forms.Panel();
			this.btnRemoveCard = new System.Windows.Forms.Button();
			this.btnAddCard = new System.Windows.Forms.Button();
			this.pnlCardHeader = new System.Windows.Forms.Panel();
			this.lblPrintTag = new System.Windows.Forms.Label();
			this.btnSellCard = new System.Windows.Forms.LinkLabel();
			this.lblCardSet = new System.Windows.Forms.Label();
			this.lblCardValue = new System.Windows.Forms.Label();
			this.lblCardRarity = new System.Windows.Forms.Label();
			this.pbxCardImage = new System.Windows.Forms.PictureBox();
			this.btnUpdateDB = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
			this.splitMain.Panel1.SuspendLayout();
			this.splitMain.Panel2.SuspendLayout();
			this.splitMain.SuspendLayout();
			this.tabsMenu.SuspendLayout();
			this.tabCards.SuspendLayout();
			this.pnlYourCardsSearch.SuspendLayout();
			this.pnlYourCardsHeader.SuspendLayout();
			this.tabFind.SuspendLayout();
			this.panel1.SuspendLayout();
			this.pnlNewCardsSearch.SuspendLayout();
			this.pnlNewCardsHeader.SuspendLayout();
			this.pnlCardView.SuspendLayout();
			this.pnlCardHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbxCardImage)).BeginInit();
			this.SuspendLayout();
			// 
			// splitMain
			// 
			this.splitMain.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitMain.Location = new System.Drawing.Point(0, 0);
			this.splitMain.Name = "splitMain";
			// 
			// splitMain.Panel1
			// 
			this.splitMain.Panel1.Controls.Add(this.tabsMenu);
			// 
			// splitMain.Panel2
			// 
			this.splitMain.Panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.splitMain.Panel2.Controls.Add(this.pnlCardView);
			this.splitMain.Size = new System.Drawing.Size(784, 561);
			this.splitMain.SplitterDistance = 261;
			this.splitMain.TabIndex = 0;
			// 
			// tabsMenu
			// 
			this.tabsMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabsMenu.Controls.Add(this.tabCards);
			this.tabsMenu.Controls.Add(this.tabFind);
			this.tabsMenu.Location = new System.Drawing.Point(-2, 0);
			this.tabsMenu.Name = "tabsMenu";
			this.tabsMenu.SelectedIndex = 0;
			this.tabsMenu.Size = new System.Drawing.Size(265, 562);
			this.tabsMenu.TabIndex = 0;
			// 
			// tabCards
			// 
			this.tabCards.Controls.Add(this.lstYourCards);
			this.tabCards.Controls.Add(this.pnlYourCardsSearch);
			this.tabCards.Controls.Add(this.pnlYourCardsHeader);
			this.tabCards.Location = new System.Drawing.Point(4, 22);
			this.tabCards.Margin = new System.Windows.Forms.Padding(0);
			this.tabCards.Name = "tabCards";
			this.tabCards.Size = new System.Drawing.Size(257, 536);
			this.tabCards.TabIndex = 0;
			this.tabCards.Text = "Your Cards";
			this.tabCards.UseVisualStyleBackColor = true;
			// 
			// lstYourCards
			// 
			this.lstYourCards.BackColor = System.Drawing.Color.Gray;
			this.lstYourCards.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstYourCards.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.lstYourCards.ForeColor = System.Drawing.Color.Yellow;
			this.lstYourCards.FormattingEnabled = true;
			this.lstYourCards.IntegralHeight = false;
			this.lstYourCards.ItemHeight = 15;
			this.lstYourCards.Location = new System.Drawing.Point(0, 104);
			this.lstYourCards.Name = "lstYourCards";
			this.lstYourCards.Size = new System.Drawing.Size(257, 432);
			this.lstYourCards.Sorted = true;
			this.lstYourCards.TabIndex = 0;
			this.lstYourCards.SelectedIndexChanged += new System.EventHandler(this.lstYourCards_SelectedIndexChanged);
			// 
			// pnlYourCardsSearch
			// 
			this.pnlYourCardsSearch.BackColor = System.Drawing.SystemColors.Control;
			this.pnlYourCardsSearch.Controls.Add(this.lblSearch);
			this.pnlYourCardsSearch.Controls.Add(this.tbxSearch);
			this.pnlYourCardsSearch.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlYourCardsSearch.Location = new System.Drawing.Point(0, 60);
			this.pnlYourCardsSearch.Name = "pnlYourCardsSearch";
			this.pnlYourCardsSearch.Size = new System.Drawing.Size(257, 44);
			this.pnlYourCardsSearch.TabIndex = 4;
			// 
			// lblSearch
			// 
			this.lblSearch.AutoSize = true;
			this.lblSearch.Location = new System.Drawing.Point(9, 15);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(41, 13);
			this.lblSearch.TabIndex = 1;
			this.lblSearch.Text = "Search";
			// 
			// tbxSearch
			// 
			this.tbxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbxSearch.Location = new System.Drawing.Point(56, 12);
			this.tbxSearch.Name = "tbxSearch";
			this.tbxSearch.Size = new System.Drawing.Size(189, 22);
			this.tbxSearch.TabIndex = 0;
			this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
			// 
			// pnlYourCardsHeader
			// 
			this.pnlYourCardsHeader.BackColor = System.Drawing.SystemColors.ControlLight;
			this.pnlYourCardsHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlYourCardsHeader.Controls.Add(this.btnUpdateDB);
			this.pnlYourCardsHeader.Controls.Add(this.btnRefreshTotalValue);
			this.pnlYourCardsHeader.Controls.Add(this.lblTotalValue);
			this.pnlYourCardsHeader.Controls.Add(this.lblYourCardsTitle);
			this.pnlYourCardsHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlYourCardsHeader.Location = new System.Drawing.Point(0, 0);
			this.pnlYourCardsHeader.Name = "pnlYourCardsHeader";
			this.pnlYourCardsHeader.Size = new System.Drawing.Size(257, 60);
			this.pnlYourCardsHeader.TabIndex = 3;
			// 
			// btnRefreshTotalValue
			// 
			this.btnRefreshTotalValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRefreshTotalValue.AutoSize = true;
			this.btnRefreshTotalValue.Location = new System.Drawing.Point(128, 40);
			this.btnRefreshTotalValue.Name = "btnRefreshTotalValue";
			this.btnRefreshTotalValue.Size = new System.Drawing.Size(62, 13);
			this.btnRefreshTotalValue.TabIndex = 2;
			this.btnRefreshTotalValue.TabStop = true;
			this.btnRefreshTotalValue.Text = "Refresh All";
			this.btnRefreshTotalValue.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnRefreshTotalValue_LinkClicked);
			// 
			// lblTotalValue
			// 
			this.lblTotalValue.AutoSize = true;
			this.lblTotalValue.Location = new System.Drawing.Point(8, 40);
			this.lblTotalValue.Name = "lblTotalValue";
			this.lblTotalValue.Size = new System.Drawing.Size(95, 13);
			this.lblTotalValue.TabIndex = 1;
			this.lblTotalValue.Text = "Total Value: $0.00";
			// 
			// lblYourCardsTitle
			// 
			this.lblYourCardsTitle.AutoSize = true;
			this.lblYourCardsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblYourCardsTitle.Location = new System.Drawing.Point(0, 0);
			this.lblYourCardsTitle.Name = "lblYourCardsTitle";
			this.lblYourCardsTitle.Size = new System.Drawing.Size(202, 40);
			this.lblYourCardsTitle.TabIndex = 0;
			this.lblYourCardsTitle.Text = "Your Cards (0)";
			// 
			// tabFind
			// 
			this.tabFind.Controls.Add(this.lstSearchResults);
			this.tabFind.Controls.Add(this.panel1);
			this.tabFind.Controls.Add(this.pnlNewCardsSearch);
			this.tabFind.Controls.Add(this.pnlNewCardsHeader);
			this.tabFind.Location = new System.Drawing.Point(4, 22);
			this.tabFind.Margin = new System.Windows.Forms.Padding(0);
			this.tabFind.Name = "tabFind";
			this.tabFind.Size = new System.Drawing.Size(257, 536);
			this.tabFind.TabIndex = 1;
			this.tabFind.Text = "Add New Cards";
			this.tabFind.UseVisualStyleBackColor = true;
			// 
			// lstSearchResults
			// 
			this.lstSearchResults.BackColor = System.Drawing.Color.Gray;
			this.lstSearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstSearchResults.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstSearchResults.ForeColor = System.Drawing.Color.Yellow;
			this.lstSearchResults.FormattingEnabled = true;
			this.lstSearchResults.IntegralHeight = false;
			this.lstSearchResults.ItemHeight = 15;
			this.lstSearchResults.Location = new System.Drawing.Point(0, 175);
			this.lstSearchResults.Name = "lstSearchResults";
			this.lstSearchResults.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.lstSearchResults.Size = new System.Drawing.Size(257, 346);
			this.lstSearchResults.TabIndex = 6;
			this.lstSearchResults.SelectedIndexChanged += new System.EventHandler(this.lstSearchResults_SelectedIndexChanged);
			this.lstSearchResults.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstSearchResults_KeyUp);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Controls.Add(this.lblResultsValue);
			this.panel1.Controls.Add(this.lblResultsCount);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 521);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(257, 15);
			this.panel1.TabIndex = 10;
			// 
			// lblResultsValue
			// 
			this.lblResultsValue.AutoSize = true;
			this.lblResultsValue.Dock = System.Windows.Forms.DockStyle.Right;
			this.lblResultsValue.Location = new System.Drawing.Point(177, 0);
			this.lblResultsValue.Name = "lblResultsValue";
			this.lblResultsValue.Size = new System.Drawing.Size(80, 13);
			this.lblResultsValue.TabIndex = 1;
			this.lblResultsValue.Text = "Total Value: $0";
			// 
			// lblResultsCount
			// 
			this.lblResultsCount.AutoSize = true;
			this.lblResultsCount.Dock = System.Windows.Forms.DockStyle.Left;
			this.lblResultsCount.Location = new System.Drawing.Point(0, 0);
			this.lblResultsCount.Name = "lblResultsCount";
			this.lblResultsCount.Size = new System.Drawing.Size(56, 13);
			this.lblResultsCount.TabIndex = 0;
			this.lblResultsCount.Text = "Results: 0";
			// 
			// pnlNewCardsSearch
			// 
			this.pnlNewCardsSearch.BackColor = System.Drawing.SystemColors.Control;
			this.pnlNewCardsSearch.Controls.Add(this.chkSupportCards);
			this.pnlNewCardsSearch.Controls.Add(this.chkSets);
			this.pnlNewCardsSearch.Controls.Add(this.chkCards);
			this.pnlNewCardsSearch.Controls.Add(this.lblFilter);
			this.pnlNewCardsSearch.Controls.Add(this.lstFilter);
			this.pnlNewCardsSearch.Controls.Add(this.btnNewCardsSearch);
			this.pnlNewCardsSearch.Controls.Add(this.lblSearchNew);
			this.pnlNewCardsSearch.Controls.Add(this.tbxNewCardsSearch);
			this.pnlNewCardsSearch.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlNewCardsSearch.Location = new System.Drawing.Point(0, 60);
			this.pnlNewCardsSearch.Name = "pnlNewCardsSearch";
			this.pnlNewCardsSearch.Size = new System.Drawing.Size(257, 115);
			this.pnlNewCardsSearch.TabIndex = 7;
			// 
			// chkSupportCards
			// 
			this.chkSupportCards.AutoSize = true;
			this.chkSupportCards.Location = new System.Drawing.Point(56, 89);
			this.chkSupportCards.Name = "chkSupportCards";
			this.chkSupportCards.Size = new System.Drawing.Size(99, 17);
			this.chkSupportCards.TabIndex = 4;
			this.chkSupportCards.Text = "Support Cards";
			this.chkSupportCards.UseVisualStyleBackColor = true;
			// 
			// chkSets
			// 
			this.chkSets.AutoSize = true;
			this.chkSets.Location = new System.Drawing.Point(56, 74);
			this.chkSets.Name = "chkSets";
			this.chkSets.Size = new System.Drawing.Size(46, 17);
			this.chkSets.TabIndex = 3;
			this.chkSets.Text = "Sets";
			this.chkSets.UseVisualStyleBackColor = true;
			// 
			// chkCards
			// 
			this.chkCards.AutoSize = true;
			this.chkCards.Checked = true;
			this.chkCards.Location = new System.Drawing.Point(56, 59);
			this.chkCards.Name = "chkCards";
			this.chkCards.Size = new System.Drawing.Size(54, 17);
			this.chkCards.TabIndex = 2;
			this.chkCards.TabStop = true;
			this.chkCards.Text = "Cards";
			this.chkCards.UseVisualStyleBackColor = true;
			// 
			// lblFilter
			// 
			this.lblFilter.AutoSize = true;
			this.lblFilter.Location = new System.Drawing.Point(9, 38);
			this.lblFilter.Name = "lblFilter";
			this.lblFilter.Size = new System.Drawing.Size(36, 13);
			this.lblFilter.TabIndex = 4;
			this.lblFilter.Text = "Rarity";
			// 
			// lstFilter
			// 
			this.lstFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.lstFilter.FormattingEnabled = true;
			this.lstFilter.Items.AddRange(new object[] {
            "All Rarities",
            "Common",
            "Rare",
            "Super Rare",
            "Holofoil Rare",
            "Ultra Rare",
            "Ultimate Rare",
            "Secret Rare",
            "Ultra Secret Rare",
            "Secret Ultra Rare",
            "Prismatic Secret Rare",
            "Parallel Rare",
            "Starfoil Rare",
            "Ghost Rare",
            "Gold Ultra Rare"});
			this.lstFilter.Location = new System.Drawing.Point(56, 35);
			this.lstFilter.Name = "lstFilter";
			this.lstFilter.Size = new System.Drawing.Size(188, 21);
			this.lstFilter.TabIndex = 1;
			this.lstFilter.SelectedIndexChanged += new System.EventHandler(this.lstFilter_SelectedIndexChanged);
			// 
			// btnNewCardsSearch
			// 
			this.btnNewCardsSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNewCardsSearch.Location = new System.Drawing.Point(180, 59);
			this.btnNewCardsSearch.Name = "btnNewCardsSearch";
			this.btnNewCardsSearch.Size = new System.Drawing.Size(64, 45);
			this.btnNewCardsSearch.TabIndex = 5;
			this.btnNewCardsSearch.Text = "Go";
			this.btnNewCardsSearch.UseVisualStyleBackColor = true;
			this.btnNewCardsSearch.Click += new System.EventHandler(this.btnNewCardsSearch_Click);
			// 
			// lblSearchNew
			// 
			this.lblSearchNew.AutoSize = true;
			this.lblSearchNew.Location = new System.Drawing.Point(9, 15);
			this.lblSearchNew.Name = "lblSearchNew";
			this.lblSearchNew.Size = new System.Drawing.Size(41, 13);
			this.lblSearchNew.TabIndex = 1;
			this.lblSearchNew.Text = "Search";
			// 
			// tbxNewCardsSearch
			// 
			this.tbxNewCardsSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbxNewCardsSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.tbxNewCardsSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.tbxNewCardsSearch.Location = new System.Drawing.Point(56, 12);
			this.tbxNewCardsSearch.Name = "tbxNewCardsSearch";
			this.tbxNewCardsSearch.Size = new System.Drawing.Size(188, 22);
			this.tbxNewCardsSearch.TabIndex = 0;
			this.tbxNewCardsSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxNewCardsSearch_KeyUp);
			// 
			// pnlNewCardsHeader
			// 
			this.pnlNewCardsHeader.BackColor = System.Drawing.SystemColors.ControlLight;
			this.pnlNewCardsHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlNewCardsHeader.Controls.Add(this.lblNewCardsSubTitle);
			this.pnlNewCardsHeader.Controls.Add(this.lblNewCardsTitle);
			this.pnlNewCardsHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlNewCardsHeader.Location = new System.Drawing.Point(0, 0);
			this.pnlNewCardsHeader.Name = "pnlNewCardsHeader";
			this.pnlNewCardsHeader.Size = new System.Drawing.Size(257, 60);
			this.pnlNewCardsHeader.TabIndex = 6;
			// 
			// lblNewCardsSubTitle
			// 
			this.lblNewCardsSubTitle.AutoSize = true;
			this.lblNewCardsSubTitle.Location = new System.Drawing.Point(8, 40);
			this.lblNewCardsSubTitle.Name = "lblNewCardsSubTitle";
			this.lblNewCardsSubTitle.Size = new System.Drawing.Size(138, 13);
			this.lblNewCardsSubTitle.TabIndex = 1;
			this.lblNewCardsSubTitle.Text = "Search by Name, Set, Type";
			// 
			// lblNewCardsTitle
			// 
			this.lblNewCardsTitle.AutoSize = true;
			this.lblNewCardsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNewCardsTitle.Location = new System.Drawing.Point(0, 0);
			this.lblNewCardsTitle.Name = "lblNewCardsTitle";
			this.lblNewCardsTitle.Size = new System.Drawing.Size(223, 40);
			this.lblNewCardsTitle.TabIndex = 0;
			this.lblNewCardsTitle.Text = "Find New Cards";
			// 
			// pnlCardView
			// 
			this.pnlCardView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCardView.BackgroundImage")));
			this.pnlCardView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pnlCardView.Controls.Add(this.btnRemoveCard);
			this.pnlCardView.Controls.Add(this.btnAddCard);
			this.pnlCardView.Controls.Add(this.pnlCardHeader);
			this.pnlCardView.Controls.Add(this.pbxCardImage);
			this.pnlCardView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlCardView.Location = new System.Drawing.Point(0, 0);
			this.pnlCardView.Name = "pnlCardView";
			this.pnlCardView.Size = new System.Drawing.Size(519, 561);
			this.pnlCardView.TabIndex = 0;
			// 
			// btnRemoveCard
			// 
			this.btnRemoveCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRemoveCard.Location = new System.Drawing.Point(492, 29);
			this.btnRemoveCard.Name = "btnRemoveCard";
			this.btnRemoveCard.Size = new System.Drawing.Size(25, 25);
			this.btnRemoveCard.TabIndex = 5;
			this.btnRemoveCard.Text = "-";
			this.btnRemoveCard.UseVisualStyleBackColor = true;
			this.btnRemoveCard.Visible = false;
			this.btnRemoveCard.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// btnAddCard
			// 
			this.btnAddCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddCard.Location = new System.Drawing.Point(492, 2);
			this.btnAddCard.Name = "btnAddCard";
			this.btnAddCard.Size = new System.Drawing.Size(25, 25);
			this.btnAddCard.TabIndex = 4;
			this.btnAddCard.Text = "+";
			this.btnAddCard.UseVisualStyleBackColor = true;
			this.btnAddCard.Visible = false;
			this.btnAddCard.Click += new System.EventHandler(this.btnAddCard_Click);
			// 
			// pnlCardHeader
			// 
			this.pnlCardHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlCardHeader.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.pnlCardHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlCardHeader.Controls.Add(this.lblPrintTag);
			this.pnlCardHeader.Controls.Add(this.btnSellCard);
			this.pnlCardHeader.Controls.Add(this.lblCardSet);
			this.pnlCardHeader.Controls.Add(this.lblCardValue);
			this.pnlCardHeader.Controls.Add(this.lblCardRarity);
			this.pnlCardHeader.Location = new System.Drawing.Point(4, 3);
			this.pnlCardHeader.Name = "pnlCardHeader";
			this.pnlCardHeader.Size = new System.Drawing.Size(485, 50);
			this.pnlCardHeader.TabIndex = 3;
			this.pnlCardHeader.Visible = false;
			// 
			// lblPrintTag
			// 
			this.lblPrintTag.AutoSize = true;
			this.lblPrintTag.Dock = System.Windows.Forms.DockStyle.Left;
			this.lblPrintTag.Font = new System.Drawing.Font("DINPro-Medium", 18F, System.Drawing.FontStyle.Bold);
			this.lblPrintTag.ForeColor = System.Drawing.Color.Gainsboro;
			this.lblPrintTag.Location = new System.Drawing.Point(62, 0);
			this.lblPrintTag.Name = "lblPrintTag";
			this.lblPrintTag.Size = new System.Drawing.Size(111, 31);
			this.lblPrintTag.TabIndex = 4;
			this.lblPrintTag.Text = "print tag";
			// 
			// btnSellCard
			// 
			this.btnSellCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSellCard.AutoSize = true;
			this.btnSellCard.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnSellCard.Location = new System.Drawing.Point(400, 29);
			this.btnSellCard.Name = "btnSellCard";
			this.btnSellCard.Size = new System.Drawing.Size(77, 13);
			this.btnSellCard.TabIndex = 3;
			this.btnSellCard.TabStop = true;
			this.btnSellCard.Text = "Create Listing";
			this.btnSellCard.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnSellCard_LinkClicked);
			// 
			// lblCardSet
			// 
			this.lblCardSet.AutoSize = true;
			this.lblCardSet.Font = new System.Drawing.Font("DINPro-Regular", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCardSet.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.lblCardSet.Location = new System.Drawing.Point(5, 29);
			this.lblCardSet.Name = "lblCardSet";
			this.lblCardSet.Size = new System.Drawing.Size(81, 14);
			this.lblCardSet.TabIndex = 2;
			this.lblCardSet.Text = "Structure Deck";
			// 
			// lblCardValue
			// 
			this.lblCardValue.AutoSize = true;
			this.lblCardValue.Dock = System.Windows.Forms.DockStyle.Left;
			this.lblCardValue.Font = new System.Drawing.Font("DINPro-Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCardValue.ForeColor = System.Drawing.Color.Maroon;
			this.lblCardValue.Location = new System.Drawing.Point(0, 0);
			this.lblCardValue.Name = "lblCardValue";
			this.lblCardValue.Size = new System.Drawing.Size(62, 31);
			this.lblCardValue.TabIndex = 0;
			this.lblCardValue.Text = "$1.0";
			// 
			// lblCardRarity
			// 
			this.lblCardRarity.AutoSize = true;
			this.lblCardRarity.Dock = System.Windows.Forms.DockStyle.Right;
			this.lblCardRarity.Font = new System.Drawing.Font("DINPro-Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCardRarity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.lblCardRarity.Location = new System.Drawing.Point(365, 0);
			this.lblCardRarity.Name = "lblCardRarity";
			this.lblCardRarity.Size = new System.Drawing.Size(116, 31);
			this.lblCardRarity.TabIndex = 1;
			this.lblCardRarity.Text = "Common";
			// 
			// pbxCardImage
			// 
			this.pbxCardImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pbxCardImage.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.pbxCardImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pbxCardImage.ImageLocation = "";
			this.pbxCardImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbxCardImage.InitialImage")));
			this.pbxCardImage.Location = new System.Drawing.Point(95, 56);
			this.pbxCardImage.Name = "pbxCardImage";
			this.pbxCardImage.Size = new System.Drawing.Size(342, 500);
			this.pbxCardImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbxCardImage.TabIndex = 2;
			this.pbxCardImage.TabStop = false;
			this.pbxCardImage.Visible = false;
			// 
			// btnUpdateDB
			// 
			this.btnUpdateDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnUpdateDB.AutoSize = true;
			this.btnUpdateDB.Location = new System.Drawing.Point(189, 40);
			this.btnUpdateDB.Name = "btnUpdateDB";
			this.btnUpdateDB.Size = new System.Drawing.Size(63, 13);
			this.btnUpdateDB.TabIndex = 3;
			this.btnUpdateDB.TabStop = true;
			this.btnUpdateDB.Text = "Update DB";
			this.btnUpdateDB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnUpdateDB_LinkClicked);
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.splitMain);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(800, 600);
			this.Name = "FrmMain";
			this.Text = "Yuginizer";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
			this.Load += new System.EventHandler(this.FrmMain_Load);
			this.splitMain.Panel1.ResumeLayout(false);
			this.splitMain.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
			this.splitMain.ResumeLayout(false);
			this.tabsMenu.ResumeLayout(false);
			this.tabCards.ResumeLayout(false);
			this.pnlYourCardsSearch.ResumeLayout(false);
			this.pnlYourCardsSearch.PerformLayout();
			this.pnlYourCardsHeader.ResumeLayout(false);
			this.pnlYourCardsHeader.PerformLayout();
			this.tabFind.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.pnlNewCardsSearch.ResumeLayout(false);
			this.pnlNewCardsSearch.PerformLayout();
			this.pnlNewCardsHeader.ResumeLayout(false);
			this.pnlNewCardsHeader.PerformLayout();
			this.pnlCardView.ResumeLayout(false);
			this.pnlCardHeader.ResumeLayout(false);
			this.pnlCardHeader.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbxCardImage)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.TabControl tabsMenu;
        private System.Windows.Forms.TabPage tabCards;
        private System.Windows.Forms.TabPage tabFind;
        private System.Windows.Forms.Panel pnlYourCardsSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Panel pnlYourCardsHeader;
        private System.Windows.Forms.Label lblYourCardsTitle;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.LinkLabel btnRefreshTotalValue;
        private System.Windows.Forms.Panel pnlNewCardsSearch;
        private System.Windows.Forms.Label lblSearchNew;
        private System.Windows.Forms.TextBox tbxNewCardsSearch;
        private System.Windows.Forms.Panel pnlNewCardsHeader;
        private System.Windows.Forms.Label lblNewCardsSubTitle;
        private System.Windows.Forms.Label lblNewCardsTitle;
        private System.Windows.Forms.Button btnNewCardsSearch;
        private System.Windows.Forms.Panel pnlCardView;
        private System.Windows.Forms.PictureBox pbxCardImage;
        private System.Windows.Forms.Panel pnlCardHeader;
        private System.Windows.Forms.Label lblCardValue;
        private System.Windows.Forms.Label lblCardRarity;
        private System.Windows.Forms.Label lblCardSet;
        private System.Windows.Forms.ComboBox lstFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Button btnAddCard;
        private System.Windows.Forms.ListBox lstYourCards;
        private System.Windows.Forms.Button btnRemoveCard;
        private System.Windows.Forms.RadioButton chkCards;
        private System.Windows.Forms.RadioButton chkSets;
        private System.Windows.Forms.RadioButton chkSupportCards;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblResultsCount;
        private System.Windows.Forms.Label lblResultsValue;
        private System.Windows.Forms.ListBox lstSearchResults;
        private System.Windows.Forms.LinkLabel btnSellCard;
        private System.Windows.Forms.Label lblPrintTag;
		private System.Windows.Forms.LinkLabel btnUpdateDB;
	}
}

