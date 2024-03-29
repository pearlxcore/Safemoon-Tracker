﻿namespace Safemoon_Stats
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
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTotalReceived = new System.Windows.Forms.Label();
            this.labelTotalSent = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCurrentBalance = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelReflection = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelMarketcap = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.darkDataGridView1 = new DarkUI.Controls.DarkDataGridView();
            this.darkContextMenu1 = new DarkUI.Controls.DarkContextMenu();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPull = new DarkUI.Controls.DarkButton();
            this.flatTabControl1 = new FlatTabControl.FlatTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.darkSectionPanel2 = new DarkUI.Controls.DarkSectionPanel();
            this.label24 = new System.Windows.Forms.Label();
            this.labelRoiToken = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.labelRoiFiat = new System.Windows.Forms.Label();
            this.darkSectionPanel1 = new DarkUI.Controls.DarkSectionPanel();
            this.label22 = new System.Windows.Forms.Label();
            this.labelTotalSell = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.labelTotalBuy = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.darkNumericUpDown1 = new DarkUI.Controls.DarkNumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbTotalSafemoon = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbVolume = new System.Windows.Forms.TextBox();
            this.tbAmountSafemoon = new System.Windows.Forms.TextBox();
            this.tbDailyReflection = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbPriceInUsd = new System.Windows.Forms.TextBox();
            this.btnMySafemoon = new DarkUI.Controls.DarkButton();
            this.GetCurrentPRICEVOLUME = new DarkUI.Controls.DarkButton();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCalculate = new DarkUI.Controls.DarkButton();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.darkButton1 = new DarkUI.Controls.DarkButton();
            this.labelVolume = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.darkDataGridView1)).BeginInit();
            this.darkContextMenu1.SuspendLayout();
            this.flatTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.darkSectionPanel2.SuspendLayout();
            this.darkSectionPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.darkNumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAddress
            // 
            this.tbAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tbAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbAddress.Location = new System.Drawing.Point(161, 62);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(309, 23);
            this.tbAddress.TabIndex = 0;
            this.tbAddress.Text = "0x73c308089DE90E8D7c186271C872f3cDec061cC0";
            this.tbAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(53, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wallet Address :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(7, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Received (Total) :";
            // 
            // labelTotalReceived
            // 
            this.labelTotalReceived.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTotalReceived.AutoSize = true;
            this.labelTotalReceived.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalReceived.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTotalReceived.Location = new System.Drawing.Point(115, 73);
            this.labelTotalReceived.Name = "labelTotalReceived";
            this.labelTotalReceived.Size = new System.Drawing.Size(13, 15);
            this.labelTotalReceived.TabIndex = 5;
            this.labelTotalReceived.Text = "..";
            // 
            // labelTotalSent
            // 
            this.labelTotalSent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTotalSent.AutoSize = true;
            this.labelTotalSent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalSent.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTotalSent.Location = new System.Drawing.Point(115, 94);
            this.labelTotalSent.Name = "labelTotalSent";
            this.labelTotalSent.Size = new System.Drawing.Size(13, 15);
            this.labelTotalSent.TabIndex = 7;
            this.labelTotalSent.Text = "..";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(7, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sent (Total) :";
            // 
            // labelCurrentBalance
            // 
            this.labelCurrentBalance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCurrentBalance.AutoSize = true;
            this.labelCurrentBalance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentBalance.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelCurrentBalance.Location = new System.Drawing.Point(112, 31);
            this.labelCurrentBalance.Name = "labelCurrentBalance";
            this.labelCurrentBalance.Size = new System.Drawing.Size(13, 15);
            this.labelCurrentBalance.TabIndex = 9;
            this.labelCurrentBalance.Text = "..";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(9, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Current balance :";
            // 
            // labelReflection
            // 
            this.labelReflection.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelReflection.AutoSize = true;
            this.labelReflection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReflection.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelReflection.Location = new System.Drawing.Point(112, 52);
            this.labelReflection.Name = "labelReflection";
            this.labelReflection.Size = new System.Drawing.Size(13, 15);
            this.labelReflection.TabIndex = 11;
            this.labelReflection.Text = "..";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(9, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Reflections :";
            // 
            // labelPrice
            // 
            this.labelPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelPrice.Location = new System.Drawing.Point(684, 18);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(13, 15);
            this.labelPrice.TabIndex = 13;
            this.labelPrice.Text = "..";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(595, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Price :";
            // 
            // labelMarketcap
            // 
            this.labelMarketcap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMarketcap.AutoSize = true;
            this.labelMarketcap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarketcap.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelMarketcap.Location = new System.Drawing.Point(684, 44);
            this.labelMarketcap.Name = "labelMarketcap";
            this.labelMarketcap.Size = new System.Drawing.Size(13, 15);
            this.labelMarketcap.TabIndex = 15;
            this.labelMarketcap.Text = "..";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(595, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Marketcap :";
            // 
            // darkDataGridView1
            // 
            this.darkDataGridView1.AllowUserToAddRows = false;
            this.darkDataGridView1.AllowUserToDeleteRows = false;
            this.darkDataGridView1.AllowUserToDragDropRows = false;
            this.darkDataGridView1.AllowUserToPasteCells = false;
            this.darkDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.darkDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.darkDataGridView1.ColumnHeadersHeight = 4;
            this.darkDataGridView1.ContextMenuStrip = this.darkContextMenu1;
            this.darkDataGridView1.Location = new System.Drawing.Point(16, 135);
            this.darkDataGridView1.MultiSelect = false;
            this.darkDataGridView1.Name = "darkDataGridView1";
            this.darkDataGridView1.ReadOnly = true;
            this.darkDataGridView1.RowHeadersWidth = 41;
            this.darkDataGridView1.Size = new System.Drawing.Size(905, 186);
            this.darkDataGridView1.TabIndex = 16;
            // 
            // darkContextMenu1
            // 
            this.darkContextMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkContextMenu1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.copyToolStripMenuItem});
            this.darkContextMenu1.Name = "darkContextMenu1";
            this.darkContextMenu1.Size = new System.Drawing.Size(194, 48);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.viewToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.viewToolStripMenuItem.Text = "View transaction detail";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.copyToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.copyToolStripMenuItem.Text = "Copy transaction hash";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // btnPull
            // 
            this.btnPull.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPull.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPull.Location = new System.Drawing.Point(475, 62);
            this.btnPull.Name = "btnPull";
            this.btnPull.Size = new System.Drawing.Size(76, 23);
            this.btnPull.TabIndex = 17;
            this.btnPull.Text = "Pull Data";
            this.btnPull.Click += new System.EventHandler(this.btnPull_Click);
            // 
            // flatTabControl1
            // 
            this.flatTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flatTabControl1.Controls.Add(this.tabPage1);
            this.flatTabControl1.Controls.Add(this.tabPage2);
            this.flatTabControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatTabControl1.Location = new System.Drawing.Point(12, 98);
            this.flatTabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flatTabControl1.myBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.flatTabControl1.Name = "flatTabControl1";
            this.flatTabControl1.SelectedIndex = 0;
            this.flatTabControl1.Size = new System.Drawing.Size(944, 364);
            this.flatTabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tabPage1.Controls.Add(this.darkSectionPanel2);
            this.tabPage1.Controls.Add(this.darkSectionPanel1);
            this.tabPage1.Controls.Add(this.darkDataGridView1);
            this.tabPage1.ForeColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(936, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Wallet";
            // 
            // darkSectionPanel2
            // 
            this.darkSectionPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.darkSectionPanel2.Controls.Add(this.label24);
            this.darkSectionPanel2.Controls.Add(this.labelRoiToken);
            this.darkSectionPanel2.Controls.Add(this.label21);
            this.darkSectionPanel2.Controls.Add(this.labelRoiFiat);
            this.darkSectionPanel2.Controls.Add(this.label5);
            this.darkSectionPanel2.Controls.Add(this.labelCurrentBalance);
            this.darkSectionPanel2.Controls.Add(this.label6);
            this.darkSectionPanel2.Controls.Add(this.labelReflection);
            this.darkSectionPanel2.Location = new System.Drawing.Point(471, 13);
            this.darkSectionPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.darkSectionPanel2.Name = "darkSectionPanel2";
            this.darkSectionPanel2.SectionHeader = "Wallet Summary";
            this.darkSectionPanel2.Size = new System.Drawing.Size(450, 117);
            this.darkSectionPanel2.TabIndex = 26;
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Gainsboro;
            this.label24.Location = new System.Drawing.Point(9, 94);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(79, 15);
            this.label24.TabIndex = 14;
            this.label24.Text = "ROI (Token) :";
            // 
            // labelRoiToken
            // 
            this.labelRoiToken.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelRoiToken.AutoSize = true;
            this.labelRoiToken.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoiToken.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelRoiToken.Location = new System.Drawing.Point(112, 94);
            this.labelRoiToken.Name = "labelRoiToken";
            this.labelRoiToken.Size = new System.Drawing.Size(13, 15);
            this.labelRoiToken.TabIndex = 15;
            this.labelRoiToken.Text = "..";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Gainsboro;
            this.label21.Location = new System.Drawing.Point(9, 73);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 15);
            this.label21.TabIndex = 12;
            this.label21.Text = "ROI (Fiat) :";
            // 
            // labelRoiFiat
            // 
            this.labelRoiFiat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelRoiFiat.AutoSize = true;
            this.labelRoiFiat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoiFiat.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelRoiFiat.Location = new System.Drawing.Point(112, 73);
            this.labelRoiFiat.Name = "labelRoiFiat";
            this.labelRoiFiat.Size = new System.Drawing.Size(13, 15);
            this.labelRoiFiat.TabIndex = 13;
            this.labelRoiFiat.Text = "..";
            // 
            // darkSectionPanel1
            // 
            this.darkSectionPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.darkSectionPanel1.Controls.Add(this.label22);
            this.darkSectionPanel1.Controls.Add(this.labelTotalSent);
            this.darkSectionPanel1.Controls.Add(this.labelTotalSell);
            this.darkSectionPanel1.Controls.Add(this.label4);
            this.darkSectionPanel1.Controls.Add(this.label20);
            this.darkSectionPanel1.Controls.Add(this.labelTotalReceived);
            this.darkSectionPanel1.Controls.Add(this.labelTotalBuy);
            this.darkSectionPanel1.Controls.Add(this.label2);
            this.darkSectionPanel1.Location = new System.Drawing.Point(16, 13);
            this.darkSectionPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.darkSectionPanel1.Name = "darkSectionPanel1";
            this.darkSectionPanel1.SectionHeader = "Historic Data";
            this.darkSectionPanel1.Size = new System.Drawing.Size(451, 117);
            this.darkSectionPanel1.TabIndex = 25;
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Gainsboro;
            this.label22.Location = new System.Drawing.Point(7, 52);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(71, 15);
            this.label22.TabIndex = 23;
            this.label22.Text = "Sell (Total) :";
            // 
            // labelTotalSell
            // 
            this.labelTotalSell.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTotalSell.AutoSize = true;
            this.labelTotalSell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalSell.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTotalSell.Location = new System.Drawing.Point(115, 52);
            this.labelTotalSell.Name = "labelTotalSell";
            this.labelTotalSell.Size = new System.Drawing.Size(13, 15);
            this.labelTotalSell.TabIndex = 24;
            this.labelTotalSell.Text = "..";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Gainsboro;
            this.label20.Location = new System.Drawing.Point(7, 31);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(72, 15);
            this.label20.TabIndex = 21;
            this.label20.Text = "Buy (Total) :";
            // 
            // labelTotalBuy
            // 
            this.labelTotalBuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTotalBuy.AutoSize = true;
            this.labelTotalBuy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalBuy.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTotalBuy.Location = new System.Drawing.Point(115, 31);
            this.labelTotalBuy.Name = "labelTotalBuy";
            this.labelTotalBuy.Size = new System.Drawing.Size(13, 15);
            this.labelTotalBuy.TabIndex = 22;
            this.labelTotalBuy.Text = "..";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.darkNumericUpDown1);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.tbTotalSafemoon);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.tbVolume);
            this.tabPage2.Controls.Add(this.tbAmountSafemoon);
            this.tabPage2.Controls.Add(this.tbDailyReflection);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.tbPriceInUsd);
            this.tabPage2.Controls.Add(this.btnMySafemoon);
            this.tabPage2.Controls.Add(this.GetCurrentPRICEVOLUME);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.btnCalculate);
            this.tabPage2.Controls.Add(this.tbPrice);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.ForeColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(936, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Calculator";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Gainsboro;
            this.label19.Location = new System.Drawing.Point(685, 44);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(146, 20);
            this.label19.TabIndex = 33;
            this.label19.Text = "Safemoon <-> USD";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Gainsboro;
            this.label18.Location = new System.Drawing.Point(271, 44);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 20);
            this.label18.TabIndex = 32;
            this.label18.Text = "Reflections";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(620, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 270);
            this.panel1.TabIndex = 31;
            // 
            // darkNumericUpDown1
            // 
            this.darkNumericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.darkNumericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.darkNumericUpDown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkNumericUpDown1.IncrementAlternate = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.darkNumericUpDown1.Location = new System.Drawing.Point(193, 214);
            this.darkNumericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.darkNumericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.darkNumericUpDown1.MousewheelSingleIncrement = true;
            this.darkNumericUpDown1.Name = "darkNumericUpDown1";
            this.darkNumericUpDown1.Size = new System.Drawing.Size(233, 29);
            this.darkNumericUpDown1.TabIndex = 30;
            this.darkNumericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.darkNumericUpDown1.ValueChanged += new System.EventHandler(this.darkNumericUpDown1_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(754, 156);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Gainsboro;
            this.label14.Location = new System.Drawing.Point(-22725, 226);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "Daily reflection :";
            // 
            // tbTotalSafemoon
            // 
            this.tbTotalSafemoon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbTotalSafemoon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tbTotalSafemoon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTotalSafemoon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalSafemoon.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbTotalSafemoon.Location = new System.Drawing.Point(193, 97);
            this.tbTotalSafemoon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTotalSafemoon.Name = "tbTotalSafemoon";
            this.tbTotalSafemoon.Size = new System.Drawing.Size(233, 23);
            this.tbTotalSafemoon.TabIndex = 2;
            this.tbTotalSafemoon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTotalSafemoon.TextChanged += new System.EventHandler(this.tbTotalSafemoon_TextChanged);
            this.tbTotalSafemoon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTotalSafemoon_KeyPress);
            this.tbTotalSafemoon.Leave += new System.EventHandler(this.tbTotalSafemoon_Leave);
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Gainsboro;
            this.label17.Location = new System.Drawing.Point(652, 104);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 15);
            this.label17.TabIndex = 23;
            this.label17.Text = "Price in USD";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Gainsboro;
            this.label15.Location = new System.Drawing.Point(60, 217);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 15);
            this.label15.TabIndex = 29;
            this.label15.Text = "Days :";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(60, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "Total Safemoon :";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Gainsboro;
            this.label16.Location = new System.Drawing.Point(652, 184);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 15);
            this.label16.TabIndex = 22;
            this.label16.Text = "Safemoon amount :";
            // 
            // tbVolume
            // 
            this.tbVolume.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tbVolume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbVolume.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVolume.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbVolume.Location = new System.Drawing.Point(193, 177);
            this.tbVolume.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(233, 23);
            this.tbVolume.TabIndex = 22;
            this.tbVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbVolume.TextChanged += new System.EventHandler(this.tbVolume_TextChanged);
            this.tbVolume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbVolume_KeyPress);
            this.tbVolume.Leave += new System.EventHandler(this.tbVolume_Leave);
            // 
            // tbAmountSafemoon
            // 
            this.tbAmountSafemoon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAmountSafemoon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tbAmountSafemoon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAmountSafemoon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAmountSafemoon.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbAmountSafemoon.Location = new System.Drawing.Point(655, 203);
            this.tbAmountSafemoon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbAmountSafemoon.Name = "tbAmountSafemoon";
            this.tbAmountSafemoon.Size = new System.Drawing.Size(221, 23);
            this.tbAmountSafemoon.TabIndex = 20;
            this.tbAmountSafemoon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAmountSafemoon.TextChanged += new System.EventHandler(this.tbAmountSafemoon_TextChanged);
            this.tbAmountSafemoon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // tbDailyReflection
            // 
            this.tbDailyReflection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDailyReflection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tbDailyReflection.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDailyReflection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDailyReflection.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbDailyReflection.Location = new System.Drawing.Point(193, 253);
            this.tbDailyReflection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDailyReflection.Multiline = true;
            this.tbDailyReflection.Name = "tbDailyReflection";
            this.tbDailyReflection.ReadOnly = true;
            this.tbDailyReflection.Size = new System.Drawing.Size(393, 36);
            this.tbDailyReflection.TabIndex = 27;
            this.tbDailyReflection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gainsboro;
            this.label12.Location = new System.Drawing.Point(60, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 15);
            this.label12.TabIndex = 23;
            this.label12.Text = "Volume (USD) :";
            // 
            // tbPriceInUsd
            // 
            this.tbPriceInUsd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPriceInUsd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tbPriceInUsd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPriceInUsd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPriceInUsd.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbPriceInUsd.Location = new System.Drawing.Point(655, 123);
            this.tbPriceInUsd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPriceInUsd.Name = "tbPriceInUsd";
            this.tbPriceInUsd.Size = new System.Drawing.Size(221, 23);
            this.tbPriceInUsd.TabIndex = 21;
            this.tbPriceInUsd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPriceInUsd.TextChanged += new System.EventHandler(this.tbPriceInUsd_TextChanged);
            this.tbPriceInUsd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPriceInUsd_KeyPress);
            // 
            // btnMySafemoon
            // 
            this.btnMySafemoon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMySafemoon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMySafemoon.Location = new System.Drawing.Point(431, 97);
            this.btnMySafemoon.Name = "btnMySafemoon";
            this.btnMySafemoon.Size = new System.Drawing.Size(155, 23);
            this.btnMySafemoon.TabIndex = 18;
            this.btnMySafemoon.Text = "My Safemoon";
            this.btnMySafemoon.Click += new System.EventHandler(this.darkButton2_Click);
            // 
            // GetCurrentPRICEVOLUME
            // 
            this.GetCurrentPRICEVOLUME.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GetCurrentPRICEVOLUME.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetCurrentPRICEVOLUME.Location = new System.Drawing.Point(431, 137);
            this.GetCurrentPRICEVOLUME.Name = "GetCurrentPRICEVOLUME";
            this.GetCurrentPRICEVOLUME.Size = new System.Drawing.Size(155, 63);
            this.GetCurrentPRICEVOLUME.TabIndex = 21;
            this.GetCurrentPRICEVOLUME.Text = "Get current price & volume";
            this.GetCurrentPRICEVOLUME.Click += new System.EventHandler(this.darkButton3_Click);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Gainsboro;
            this.label13.Location = new System.Drawing.Point(60, 255);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 15);
            this.label13.TabIndex = 21;
            this.label13.Text = "Reflections :";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(431, 214);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(155, 29);
            this.btnCalculate.TabIndex = 21;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.Click += new System.EventHandler(this.darkButton5_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tbPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbPrice.Location = new System.Drawing.Point(193, 137);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(233, 23);
            this.tbPrice.TabIndex = 19;
            this.tbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPrice.TextChanged += new System.EventHandler(this.tbPrice_TextChanged);
            this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrice_KeyPress);
            this.tbPrice.Leave += new System.EventHandler(this.tbPrice_Leave);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gainsboro;
            this.label11.Location = new System.Drawing.Point(60, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 15);
            this.label11.TabIndex = 20;
            this.label11.Text = "Price (USD):";
            // 
            // darkButton1
            // 
            this.darkButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.darkButton1.Location = new System.Drawing.Point(755, 40);
            this.darkButton1.Name = "darkButton1";
            this.darkButton1.Size = new System.Drawing.Size(155, 20);
            this.darkButton1.TabIndex = 20;
            this.darkButton1.Text = "Refresh Safemoon Stats";
            this.darkButton1.Visible = false;
            this.darkButton1.Click += new System.EventHandler(this.darkButton1_Click);
            // 
            // labelVolume
            // 
            this.labelVolume.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelVolume.AutoSize = true;
            this.labelVolume.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVolume.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelVolume.Location = new System.Drawing.Point(684, 70);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(13, 15);
            this.labelVolume.TabIndex = 18;
            this.labelVolume.Text = "..";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(595, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "Volume :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(42, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "SAFEMOON TRACKER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 471);
            this.Controls.Add(this.darkButton1);
            this.Controls.Add(this.btnPull);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.flatTabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelMarketcap);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(984, 510);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Safemoon Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.darkDataGridView1)).EndInit();
            this.darkContextMenu1.ResumeLayout(false);
            this.flatTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.darkSectionPanel2.ResumeLayout(false);
            this.darkSectionPanel2.PerformLayout();
            this.darkSectionPanel1.ResumeLayout(false);
            this.darkSectionPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.darkNumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTotalReceived;
        private System.Windows.Forms.Label labelTotalSent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCurrentBalance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelReflection;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelMarketcap;
        private System.Windows.Forms.Label label8;
        private DarkUI.Controls.DarkDataGridView darkDataGridView1;
        private DarkUI.Controls.DarkButton btnPull;
        private FlatTabControl.FlatTabControl flatTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private DarkUI.Controls.DarkButton darkButton1;
        private DarkUI.Controls.DarkButton btnCalculate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbVolume;
        private DarkUI.Controls.DarkButton GetCurrentPRICEVOLUME;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbPrice;
        private DarkUI.Controls.DarkButton btnMySafemoon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbTotalSafemoon;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbDailyReflection;
        private DarkUI.Controls.DarkNumericUpDown darkNumericUpDown1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbAmountSafemoon;
        private System.Windows.Forms.TextBox tbPriceInUsd;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel1;
        private DarkUI.Controls.DarkContextMenu darkContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label labelTotalSell;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label labelTotalBuy;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel1;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label labelRoiToken;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label labelRoiFiat;
    }
}

