﻿﻿namespace BookKatalogue
{
    partial class bibForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bibForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DateimenuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.ansichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suchenmodusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.seitenansichtsmodulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktuellistToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.geheZuLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farbmodusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.infosZuBuchkatalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlCollectionItem = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddCollection = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlBookEdit = new System.Windows.Forms.Panel();
            this.btnMoveBook = new System.Windows.Forms.Button();
            this.cbBookEdit = new System.Windows.Forms.CheckBox();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.cbSearchColumn = new System.Windows.Forms.ComboBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.pnlViewChange = new System.Windows.Forms.Panel();
            this.rbtnBücherInf = new System.Windows.Forms.RadioButton();
            this.rbShowDataGridView = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.listView = new System.Windows.Forms.ListView();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ladenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DateimenuStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlBookEdit.SuspendLayout();
            this.pnlViewChange.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DateimenuStrip
            // 
            this.DateimenuStrip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DateimenuStrip.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateimenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.ansichtToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.DateimenuStrip.Location = new System.Drawing.Point(0, 0);
            this.DateimenuStrip.Name = "DateimenuStrip";
            this.DateimenuStrip.Size = new System.Drawing.Size(1195, 26);
            this.DateimenuStrip.TabIndex = 0;
            this.DateimenuStrip.Text = "menuStrip2";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speichernToolStripMenuItem,
            this.ladenToolStripMenuItem,
            this.toolStripMenuItem4});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(53, 22);
            this.toolStripMenuItem2.Text = "Datei";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.toolStripMenuItem4.Size = new System.Drawing.Size(189, 22);
            this.toolStripMenuItem4.Text = "Beenden";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.tsmiBeenden_Click);
            // 
            // ansichtToolStripMenuItem
            // 
            this.ansichtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suchenmodusToolStripMenuItem,
            this.toolStripSeparator6,
            this.seitenansichtsmodulToolStripMenuItem,
            this.toolStripSeparator3,
            this.geheZuLayoutToolStripMenuItem,
            this.farbmodusToolStripMenuItem});
            this.ansichtToolStripMenuItem.Name = "ansichtToolStripMenuItem";
            this.ansichtToolStripMenuItem.Size = new System.Drawing.Size(66, 22);
            this.ansichtToolStripMenuItem.Text = "Ansicht";
            // 
            // suchenmodusToolStripMenuItem
            // 
            this.suchenmodusToolStripMenuItem.Name = "suchenmodusToolStripMenuItem";
            this.suchenmodusToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.suchenmodusToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.suchenmodusToolStripMenuItem.Text = "Vollbildmodus";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(215, 6);
            // 
            // seitenansichtsmodulToolStripMenuItem
            // 
            this.seitenansichtsmodulToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aktuellistToolStrip,
            this.autorToolStripMenuItem,
            this.titleToolStripMenuItem});
            this.seitenansichtsmodulToolStripMenuItem.Name = "seitenansichtsmodulToolStripMenuItem";
            this.seitenansichtsmodulToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.seitenansichtsmodulToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.seitenansichtsmodulToolStripMenuItem.Text = "sotieren nach";
            // 
            // aktuellistToolStrip
            // 
            this.aktuellistToolStrip.Checked = true;
            this.aktuellistToolStrip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.aktuellistToolStrip.Name = "aktuellistToolStrip";
            this.aktuellistToolStrip.Size = new System.Drawing.Size(137, 22);
            this.aktuellistToolStrip.Text = "Aktuellste";
            this.aktuellistToolStrip.Click += new System.EventHandler(this.aktuellistToolStrip_Click);
            // 
            // autorToolStripMenuItem
            // 
            this.autorToolStripMenuItem.CheckOnClick = true;
            this.autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            this.autorToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.autorToolStripMenuItem.Text = "Autor";
            this.autorToolStripMenuItem.Click += new System.EventHandler(this.autorToolStripMenuItem_Click);
            // 
            // titleToolStripMenuItem
            // 
            this.titleToolStripMenuItem.Name = "titleToolStripMenuItem";
            this.titleToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.titleToolStripMenuItem.Text = "Titel";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(215, 6);
            // 
            // geheZuLayoutToolStripMenuItem
            // 
            this.geheZuLayoutToolStripMenuItem.Name = "geheZuLayoutToolStripMenuItem";
            this.geheZuLayoutToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.geheZuLayoutToolStripMenuItem.Text = "zoom";
            // 
            // farbmodusToolStripMenuItem
            // 
            this.farbmodusToolStripMenuItem.Name = "farbmodusToolStripMenuItem";
            this.farbmodusToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.farbmodusToolStripMenuItem.Text = "Farbmodus";
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LzToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.formatToolStripMenuItem.Text = "Werkzeuge";
            // 
            // LzToolStripMenuItem
            // 
            this.LzToolStripMenuItem.Name = "LzToolStripMenuItem";
            this.LzToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.LzToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.LzToolStripMenuItem.Text = "Lesezeichen";
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hilfeToolStripMenuItem1,
            this.toolStripSeparator4,
            this.infosZuBuchkatalogToolStripMenuItem});
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(47, 22);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // hilfeToolStripMenuItem1
            // 
            this.hilfeToolStripMenuItem1.Name = "hilfeToolStripMenuItem1";
            this.hilfeToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.hilfeToolStripMenuItem1.Size = new System.Drawing.Size(213, 22);
            this.hilfeToolStripMenuItem1.Text = "Hilfe ..";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(210, 6);
            // 
            // infosZuBuchkatalogToolStripMenuItem
            // 
            this.infosZuBuchkatalogToolStripMenuItem.Name = "infosZuBuchkatalogToolStripMenuItem";
            this.infosZuBuchkatalogToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.infosZuBuchkatalogToolStripMenuItem.Text = "Infos zu Buchkatalog";
            // 
            // pnlCollectionItem
            // 
            this.pnlCollectionItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCollectionItem.AutoScroll = true;
            this.pnlCollectionItem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlCollectionItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlCollectionItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.pnlCollectionItem.Location = new System.Drawing.Point(6, 44);
            this.pnlCollectionItem.Name = "pnlCollectionItem";
            this.pnlCollectionItem.Size = new System.Drawing.Size(276, 523);
            this.pnlCollectionItem.TabIndex = 10;
            this.pnlCollectionItem.SizeChanged += new System.EventHandler(this.pnlCollectionItem_SizeChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.btnAddCollection);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 40);
            this.panel2.TabIndex = 10;
            // 
            // btnAddCollection
            // 
            this.btnAddCollection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCollection.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddCollection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddCollection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddCollection.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCollection.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnAddCollection.Location = new System.Drawing.Point(3, 8);
            this.btnAddCollection.Name = "btnAddCollection";
            this.btnAddCollection.Size = new System.Drawing.Size(276, 25);
            this.btnAddCollection.TabIndex = 2;
            this.btnAddCollection.Text = "Sammlung hinzufügen";
            this.btnAddCollection.UseVisualStyleBackColor = false;
            this.btnAddCollection.Click += new System.EventHandler(this.btnAddCollection_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.rbShowDataGridView);
            this.panel1.Controls.Add(this.rbtnBücherInf);
            this.panel1.Controls.Add(this.pnlBookEdit);
            this.panel1.Controls.Add(this.btnAddBook);
            this.panel1.Controls.Add(this.pnlViewChange);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 40);
            this.panel1.TabIndex = 9;
            // 
            // pnlBookEdit
            // 
            this.pnlBookEdit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnlBookEdit.Controls.Add(this.btnMoveBook);
            this.pnlBookEdit.Controls.Add(this.cbBookEdit);
            this.pnlBookEdit.Controls.Add(this.btnDeleteBook);
            this.pnlBookEdit.Location = new System.Drawing.Point(600, 3);
            this.pnlBookEdit.Name = "pnlBookEdit";
            this.pnlBookEdit.Size = new System.Drawing.Size(298, 34);
            this.pnlBookEdit.TabIndex = 10;
            // 
            // btnMoveBook
            // 
            this.btnMoveBook.Location = new System.Drawing.Point(206, 6);
            this.btnMoveBook.Name = "btnMoveBook";
            this.btnMoveBook.Size = new System.Drawing.Size(75, 23);
            this.btnMoveBook.TabIndex = 7;
            this.btnMoveBook.Text = "move";
            this.btnMoveBook.UseVisualStyleBackColor = true;
            this.btnMoveBook.Visible = false;
            this.btnMoveBook.Click += new System.EventHandler(this.btnMoveBook_Click);
            // 
            // cbBookEdit
            // 
            this.cbBookEdit.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbBookEdit.Location = new System.Drawing.Point(16, 6);
            this.cbBookEdit.Name = "cbBookEdit";
            this.cbBookEdit.Size = new System.Drawing.Size(86, 23);
            this.cbBookEdit.TabIndex = 10;
            this.cbBookEdit.Text = "editieren";
            this.cbBookEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbBookEdit.UseVisualStyleBackColor = true;
            this.cbBookEdit.CheckedChanged += new System.EventHandler(this.cbBookEdit_CheckedChanged);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(115, 6);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteBook.TabIndex = 11;
            this.btnDeleteBook.Text = "löschen";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Visible = false;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // cbSearchColumn
            // 
            this.cbSearchColumn.AllowDrop = true;
            this.cbSearchColumn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbSearchColumn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbSearchColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbSearchColumn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbSearchColumn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbSearchColumn.FormattingEnabled = true;
            this.cbSearchColumn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbSearchColumn.Items.AddRange(new object[] {
            "Titel",
            "Autor",
            "ISBN"});
            this.cbSearchColumn.Location = new System.Drawing.Point(12, 7);
            this.cbSearchColumn.Name = "cbSearchColumn";
            this.cbSearchColumn.Size = new System.Drawing.Size(92, 27);
            this.cbSearchColumn.TabIndex = 6;
            this.cbSearchColumn.Text = "Autor";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(485, 7);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(106, 27);
            this.btnAddBook.TabIndex = 9;
            this.btnAddBook.Text = "Buch hinzufügen";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // pnlViewChange
            // 
            this.pnlViewChange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlViewChange.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlViewChange.Controls.Add(this.cbSearchColumn);
            this.pnlViewChange.Controls.Add(this.textBox1);
            this.pnlViewChange.Location = new System.Drawing.Point(79, 0);
            this.pnlViewChange.Name = "pnlViewChange";
            this.pnlViewChange.Size = new System.Drawing.Size(397, 40);
            this.pnlViewChange.TabIndex = 7;
            // 
            // rbtnBücherInf
            // 
            this.rbtnBücherInf.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnBücherInf.AutoSize = true;
            this.rbtnBücherInf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rbtnBücherInf.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbtnBücherInf.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbtnBücherInf.Image = ((System.Drawing.Image)(resources.GetObject("rbtnBücherInf.Image")));
            this.rbtnBücherInf.Location = new System.Drawing.Point(0, 2);
            this.rbtnBücherInf.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnBücherInf.Name = "rbtnBücherInf";
            this.rbtnBücherInf.Size = new System.Drawing.Size(35, 35);
            this.rbtnBücherInf.TabIndex = 1;
            this.rbtnBücherInf.TabStop = true;
            this.rbtnBücherInf.UseVisualStyleBackColor = true;
            this.rbtnBücherInf.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbShowDataGridView
            // 
            this.rbShowDataGridView.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbShowDataGridView.AutoSize = true;
            this.rbShowDataGridView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rbShowDataGridView.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbShowDataGridView.Image = ((System.Drawing.Image)(resources.GetObject("rbShowDataGridView.Image")));
            this.rbShowDataGridView.Location = new System.Drawing.Point(41, 2);
            this.rbShowDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.rbShowDataGridView.Name = "rbShowDataGridView";
            this.rbShowDataGridView.Size = new System.Drawing.Size(35, 35);
            this.rbShowDataGridView.TabIndex = 2;
            this.rbShowDataGridView.TabStop = true;
            this.rbShowDataGridView.UseVisualStyleBackColor = true;
            this.rbShowDataGridView.CheckedChanged += new System.EventHandler(this.rbShowDataGridView_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(114, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 27);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Suche ...";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Controls.Add(this.pnlCollectionItem);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(0, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(288, 570);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.listView);
            this.panel4.Controls.Add(this.dgvBooks);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Location = new System.Drawing.Point(288, 29);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(907, 570);
            this.panel4.TabIndex = 6;
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listView.BackgroundImageTiled = true;
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.HideSelection = false;
            this.listView.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.listView.Location = new System.Drawing.Point(3, 45);
            this.listView.Margin = new System.Windows.Forms.Padding(1);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(901, 522);
            this.listView.TabIndex = 10;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.DoubleClick += new System.EventHandler(this.listView_DoubleClick);
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dgvBooks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBooks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBooks.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBooks.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBooks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvBooks.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvBooks.Location = new System.Drawing.Point(3, 45);
            this.dgvBooks.MultiSelect = false;
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvBooks.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBooks.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvBooks.RowTemplate.Height = 35;
            this.dgvBooks.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(901, 522);
            this.dgvBooks.TabIndex = 5;
            this.dgvBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellClick);
            this.dgvBooks.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellDoubleClick);
            this.dgvBooks.SelectionChanged += new System.EventHandler(this.dgvBooks_SelectionChanged);
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.speichernToolStripMenuItem.Text = "Speichern";
            this.speichernToolStripMenuItem.Click += new System.EventHandler(this.speichernToolStripMenuItem_Click_1);
            // 
            // collectionBindingSource
            // 
            this.collectionBindingSource.DataSource = typeof(BookKatalogue.model.Collection);
            // 
            // bibFormBindingSource
            // 
            this.bibFormBindingSource.DataSource = typeof(BookKatalogue.model.Book);
            // 
            // ladenToolStripMenuItem
            // 
            this.ladenToolStripMenuItem.Name = "ladenToolStripMenuItem";
            this.ladenToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.ladenToolStripMenuItem.Text = "Laden";
            this.ladenToolStripMenuItem.Click += new System.EventHandler(this.ladenToolStripMenuItem_Click);
            // 
            // bibForm
            // 
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1195, 599);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.DateimenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.DateimenuStrip;
            this.Name = "bibForm";
            this.Text = "Mein Buch Katalog";
            this.Load += new System.EventHandler(this.bibForm_Load);
            this.DateimenuStrip.ResumeLayout(false);
            this.DateimenuStrip.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlBookEdit.ResumeLayout(false);
            this.pnlViewChange.ResumeLayout(false);
            this.pnlViewChange.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibFormBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.MenuStrip DateimenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem ansichtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suchenmodusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seitenansichtsmodulToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem geheZuLayoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aktuellistToolStrip;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem titleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem farbmodusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem infosZuBuchkatalogToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel pnlViewChange;
        private System.Windows.Forms.RadioButton rbtnBücherInf;
        private System.Windows.Forms.RadioButton rbShowDataGridView;
        private System.Windows.Forms.ComboBox cbSearchColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddCollection;
        private System.Windows.Forms.BindingSource collectionBindingSource;
        private System.Windows.Forms.BindingSource bibFormBindingSource;
        private System.Windows.Forms.Panel pnlCollectionItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Panel pnlBookEdit;
        private System.Windows.Forms.CheckBox cbBookEdit;
        private System.Windows.Forms.Button btnMoveBook;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ladenToolStripMenuItem;
    }
}