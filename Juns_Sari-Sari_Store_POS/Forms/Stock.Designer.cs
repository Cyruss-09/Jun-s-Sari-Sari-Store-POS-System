namespace Juns_Sari_Sari_Store_POS.Forms
{
    partial class Stockpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stockpage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.labelSupplier = new System.Windows.Forms.Label();
            this.comboBoxSupplier = new System.Windows.Forms.ComboBox();
            this.textBoxPurchasingOrder = new System.Windows.Forms.TextBox();
            this.labelPurchasingOrder = new System.Windows.Forms.Label();
            this.textBoxSellingPrice = new System.Windows.Forms.TextBox();
            this.labelSellingPrice = new System.Windows.Forms.Label();
            this.textBoxPurchaseValue = new System.Windows.Forms.TextBox();
            this.labelPurchaseValue = new System.Windows.Forms.Label();
            this.textBoxPurchasingPrice = new System.Windows.Forms.TextBox();
            this.labelPurchasingPrice = new System.Windows.Forms.Label();
            this.textBoxPurchasingQuantity = new System.Windows.Forms.TextBox();
            this.labelPurchasing = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDecription = new System.Windows.Forms.Label();
            this.textBoxItem = new System.Windows.Forms.TextBox();
            this.labelItem = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullScreenViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelStockItem = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.labelStockCount = new System.Windows.Forms.Label();
            this.panelPurchasingValue = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.labelPurchasingValue = new System.Windows.Forms.Label();
            this.btnPurchasingSummary = new System.Windows.Forms.Button();
            this.btnPrintStock = new System.Windows.Forms.Button();
            this.btnViewItem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panelStockItem.SuspendLayout();
            this.panelPurchasingValue.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnAddItem);
            this.panel1.Controls.Add(this.labelSupplier);
            this.panel1.Controls.Add(this.comboBoxSupplier);
            this.panel1.Controls.Add(this.textBoxPurchasingOrder);
            this.panel1.Controls.Add(this.labelPurchasingOrder);
            this.panel1.Controls.Add(this.textBoxSellingPrice);
            this.panel1.Controls.Add(this.labelSellingPrice);
            this.panel1.Controls.Add(this.textBoxPurchaseValue);
            this.panel1.Controls.Add(this.labelPurchaseValue);
            this.panel1.Controls.Add(this.textBoxPurchasingPrice);
            this.panel1.Controls.Add(this.labelPurchasingPrice);
            this.panel1.Controls.Add(this.textBoxPurchasingQuantity);
            this.panel1.Controls.Add(this.labelPurchasing);
            this.panel1.Controls.Add(this.textBoxDescription);
            this.panel1.Controls.Add(this.labelDecription);
            this.panel1.Controls.Add(this.textBoxItem);
            this.panel1.Controls.Add(this.labelItem);
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 898);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Purple;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = global::Juns_Sari_Sari_Store_POS.Properties.Resources.favicon__6_;
            this.btnClear.Location = new System.Drawing.Point(227, 811);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(124, 50);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.Indigo;
            this.btnAddItem.FlatAppearance.BorderSize = 0;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Image = global::Juns_Sari_Sari_Store_POS.Properties.Resources.favicon__5_;
            this.btnAddItem.Location = new System.Drawing.Point(17, 811);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(193, 50);
            this.btnAddItem.TabIndex = 9;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddItem.UseVisualStyleBackColor = false;
            // 
            // labelSupplier
            // 
            this.labelSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSupplier.AutoEllipsis = true;
            this.labelSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSupplier.ForeColor = System.Drawing.Color.White;
            this.labelSupplier.Location = new System.Drawing.Point(17, 698);
            this.labelSupplier.Name = "labelSupplier";
            this.labelSupplier.Size = new System.Drawing.Size(193, 47);
            this.labelSupplier.TabIndex = 14;
            this.labelSupplier.Text = "Supplier:";
            // 
            // comboBoxSupplier
            // 
            this.comboBoxSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSupplier.FormattingEnabled = true;
            this.comboBoxSupplier.Location = new System.Drawing.Point(17, 748);
            this.comboBoxSupplier.Name = "comboBoxSupplier";
            this.comboBoxSupplier.Size = new System.Drawing.Size(334, 33);
            this.comboBoxSupplier.TabIndex = 8;
            // 
            // textBoxPurchasingOrder
            // 
            this.textBoxPurchasingOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPurchasingOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPurchasingOrder.Location = new System.Drawing.Point(17, 652);
            this.textBoxPurchasingOrder.Name = "textBoxPurchasingOrder";
            this.textBoxPurchasingOrder.Size = new System.Drawing.Size(334, 29);
            this.textBoxPurchasingOrder.TabIndex = 7;
            // 
            // labelPurchasingOrder
            // 
            this.labelPurchasingOrder.AutoEllipsis = true;
            this.labelPurchasingOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPurchasingOrder.ForeColor = System.Drawing.Color.White;
            this.labelPurchasingOrder.Location = new System.Drawing.Point(17, 602);
            this.labelPurchasingOrder.Name = "labelPurchasingOrder";
            this.labelPurchasingOrder.Size = new System.Drawing.Size(249, 47);
            this.labelPurchasingOrder.TabIndex = 12;
            this.labelPurchasingOrder.Text = "Purchasing Order Number:";
            // 
            // textBoxSellingPrice
            // 
            this.textBoxSellingPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSellingPrice.Location = new System.Drawing.Point(17, 552);
            this.textBoxSellingPrice.Name = "textBoxSellingPrice";
            this.textBoxSellingPrice.Size = new System.Drawing.Size(334, 29);
            this.textBoxSellingPrice.TabIndex = 6;
            // 
            // labelSellingPrice
            // 
            this.labelSellingPrice.AutoEllipsis = true;
            this.labelSellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSellingPrice.ForeColor = System.Drawing.Color.White;
            this.labelSellingPrice.Location = new System.Drawing.Point(17, 502);
            this.labelSellingPrice.Name = "labelSellingPrice";
            this.labelSellingPrice.Size = new System.Drawing.Size(223, 47);
            this.labelSellingPrice.TabIndex = 10;
            this.labelSellingPrice.Text = "MRP / Selling Price:";
            // 
            // textBoxPurchaseValue
            // 
            this.textBoxPurchaseValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPurchaseValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPurchaseValue.Location = new System.Drawing.Point(17, 465);
            this.textBoxPurchaseValue.Name = "textBoxPurchaseValue";
            this.textBoxPurchaseValue.Size = new System.Drawing.Size(334, 29);
            this.textBoxPurchaseValue.TabIndex = 5;
            // 
            // labelPurchaseValue
            // 
            this.labelPurchaseValue.AutoEllipsis = true;
            this.labelPurchaseValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPurchaseValue.ForeColor = System.Drawing.Color.White;
            this.labelPurchaseValue.Location = new System.Drawing.Point(17, 415);
            this.labelPurchaseValue.Name = "labelPurchaseValue";
            this.labelPurchaseValue.Size = new System.Drawing.Size(172, 47);
            this.labelPurchaseValue.TabIndex = 8;
            this.labelPurchaseValue.Text = "Purchase Value";
            // 
            // textBoxPurchasingPrice
            // 
            this.textBoxPurchasingPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPurchasingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPurchasingPrice.Location = new System.Drawing.Point(17, 369);
            this.textBoxPurchasingPrice.Name = "textBoxPurchasingPrice";
            this.textBoxPurchasingPrice.Size = new System.Drawing.Size(334, 29);
            this.textBoxPurchasingPrice.TabIndex = 4;
            // 
            // labelPurchasingPrice
            // 
            this.labelPurchasingPrice.AutoEllipsis = true;
            this.labelPurchasingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPurchasingPrice.ForeColor = System.Drawing.Color.White;
            this.labelPurchasingPrice.Location = new System.Drawing.Point(17, 319);
            this.labelPurchasingPrice.Name = "labelPurchasingPrice";
            this.labelPurchasingPrice.Size = new System.Drawing.Size(172, 47);
            this.labelPurchasingPrice.TabIndex = 6;
            this.labelPurchasingPrice.Text = "Purchasing Price:";
            // 
            // textBoxPurchasingQuantity
            // 
            this.textBoxPurchasingQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPurchasingQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPurchasingQuantity.Location = new System.Drawing.Point(17, 263);
            this.textBoxPurchasingQuantity.Name = "textBoxPurchasingQuantity";
            this.textBoxPurchasingQuantity.Size = new System.Drawing.Size(334, 29);
            this.textBoxPurchasingQuantity.TabIndex = 3;
            // 
            // labelPurchasing
            // 
            this.labelPurchasing.AutoEllipsis = true;
            this.labelPurchasing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPurchasing.ForeColor = System.Drawing.Color.White;
            this.labelPurchasing.Location = new System.Drawing.Point(17, 213);
            this.labelPurchasing.Name = "labelPurchasing";
            this.labelPurchasing.Size = new System.Drawing.Size(204, 47);
            this.labelPurchasing.TabIndex = 4;
            this.labelPurchasing.Text = "Purchasing Quantity:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(17, 166);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(334, 29);
            this.textBoxDescription.TabIndex = 2;
            // 
            // labelDecription
            // 
            this.labelDecription.AutoEllipsis = true;
            this.labelDecription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDecription.ForeColor = System.Drawing.Color.White;
            this.labelDecription.Location = new System.Drawing.Point(17, 116);
            this.labelDecription.Name = "labelDecription";
            this.labelDecription.Size = new System.Drawing.Size(172, 47);
            this.labelDecription.TabIndex = 2;
            this.labelDecription.Text = "Description:";
            // 
            // textBoxItem
            // 
            this.textBoxItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxItem.Location = new System.Drawing.Point(17, 61);
            this.textBoxItem.Name = "textBoxItem";
            this.textBoxItem.Size = new System.Drawing.Size(334, 29);
            this.textBoxItem.TabIndex = 1;
            // 
            // labelItem
            // 
            this.labelItem.AutoEllipsis = true;
            this.labelItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItem.ForeColor = System.Drawing.Color.White;
            this.labelItem.Location = new System.Drawing.Point(17, 11);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(172, 47);
            this.labelItem.TabIndex = 0;
            this.labelItem.Text = "Item Code: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MediumBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(371, -16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1052, 745);
            this.dataGridView1.TabIndex = 15;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeItemToolStripMenuItem,
            this.fullScreenViewToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(186, 52);
            // 
            // removeItemToolStripMenuItem
            // 
            this.removeItemToolStripMenuItem.Name = "removeItemToolStripMenuItem";
            this.removeItemToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.removeItemToolStripMenuItem.Text = "Remove Item";
            // 
            // fullScreenViewToolStripMenuItem
            // 
            this.fullScreenViewToolStripMenuItem.Name = "fullScreenViewToolStripMenuItem";
            this.fullScreenViewToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.fullScreenViewToolStripMenuItem.Text = "Full Screen View";
            // 
            // panelStockItem
            // 
            this.panelStockItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelStockItem.BackColor = System.Drawing.Color.Navy;
            this.panelStockItem.Controls.Add(this.label6);
            this.panelStockItem.Controls.Add(this.labelStockCount);
            this.panelStockItem.Location = new System.Drawing.Point(910, 733);
            this.panelStockItem.Name = "panelStockItem";
            this.panelStockItem.Size = new System.Drawing.Size(249, 149);
            this.panelStockItem.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "00";
            // 
            // labelStockCount
            // 
            this.labelStockCount.AutoSize = true;
            this.labelStockCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStockCount.ForeColor = System.Drawing.Color.White;
            this.labelStockCount.Location = new System.Drawing.Point(12, 21);
            this.labelStockCount.Name = "labelStockCount";
            this.labelStockCount.Size = new System.Drawing.Size(168, 25);
            this.labelStockCount.TabIndex = 0;
            this.labelStockCount.Text = "Stock Item Count:";
            // 
            // panelPurchasingValue
            // 
            this.panelPurchasingValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPurchasingValue.BackColor = System.Drawing.Color.Navy;
            this.panelPurchasingValue.Controls.Add(this.label7);
            this.panelPurchasingValue.Controls.Add(this.labelPurchasingValue);
            this.panelPurchasingValue.Location = new System.Drawing.Point(1165, 733);
            this.panelPurchasingValue.Name = "panelPurchasingValue";
            this.panelPurchasingValue.Size = new System.Drawing.Size(249, 149);
            this.panelPurchasingValue.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 29);
            this.label7.TabIndex = 1;
            this.label7.Text = "₱0.00";
            // 
            // labelPurchasingValue
            // 
            this.labelPurchasingValue.AutoSize = true;
            this.labelPurchasingValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPurchasingValue.ForeColor = System.Drawing.Color.White;
            this.labelPurchasingValue.Location = new System.Drawing.Point(12, 21);
            this.labelPurchasingValue.Name = "labelPurchasingValue";
            this.labelPurchasingValue.Size = new System.Drawing.Size(172, 25);
            this.labelPurchasingValue.TabIndex = 0;
            this.labelPurchasingValue.Text = "Purchasing Value:";
            // 
            // btnPurchasingSummary
            // 
            this.btnPurchasingSummary.BackColor = System.Drawing.Color.LightGray;
            this.btnPurchasingSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchasingSummary.ForeColor = System.Drawing.Color.Black;
            this.btnPurchasingSummary.Image = global::Juns_Sari_Sari_Store_POS.Properties.Resources.favicon__9_;
            this.btnPurchasingSummary.Location = new System.Drawing.Point(657, 733);
            this.btnPurchasingSummary.Name = "btnPurchasingSummary";
            this.btnPurchasingSummary.Size = new System.Drawing.Size(146, 149);
            this.btnPurchasingSummary.TabIndex = 14;
            this.btnPurchasingSummary.Text = "Purchasing Summary";
            this.btnPurchasingSummary.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPurchasingSummary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPurchasingSummary.UseVisualStyleBackColor = false;
            this.btnPurchasingSummary.Click += new System.EventHandler(this.btnPurchasingSummary_Click);
            // 
            // btnPrintStock
            // 
            this.btnPrintStock.BackColor = System.Drawing.Color.LightGray;
            this.btnPrintStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintStock.ForeColor = System.Drawing.Color.Black;
            this.btnPrintStock.Image = global::Juns_Sari_Sari_Store_POS.Properties.Resources.favicon__7_;
            this.btnPrintStock.Location = new System.Drawing.Point(518, 733);
            this.btnPrintStock.Name = "btnPrintStock";
            this.btnPrintStock.Size = new System.Drawing.Size(133, 149);
            this.btnPrintStock.TabIndex = 13;
            this.btnPrintStock.Text = "Print Stock Balance";
            this.btnPrintStock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrintStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrintStock.UseVisualStyleBackColor = false;
            // 
            // btnViewItem
            // 
            this.btnViewItem.BackColor = System.Drawing.Color.LightGray;
            this.btnViewItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewItem.ForeColor = System.Drawing.Color.Black;
            this.btnViewItem.Image = global::Juns_Sari_Sari_Store_POS.Properties.Resources.favicon__8_;
            this.btnViewItem.Location = new System.Drawing.Point(379, 733);
            this.btnViewItem.Name = "btnViewItem";
            this.btnViewItem.Size = new System.Drawing.Size(133, 149);
            this.btnViewItem.TabIndex = 12;
            this.btnViewItem.Text = "View All Item";
            this.btnViewItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnViewItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnViewItem.UseVisualStyleBackColor = false;
            // 
            // Stockpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1418, 894);
            this.Controls.Add(this.btnPurchasingSummary);
            this.Controls.Add(this.panelPurchasingValue);
            this.Controls.Add(this.panelStockItem);
            this.Controls.Add(this.btnPrintStock);
            this.Controls.Add(this.btnViewItem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stockpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Stock_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panelStockItem.ResumeLayout(false);
            this.panelStockItem.PerformLayout();
            this.panelPurchasingValue.ResumeLayout(false);
            this.panelPurchasingValue.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelItem;
        private System.Windows.Forms.TextBox textBoxItem;
        private System.Windows.Forms.TextBox textBoxPurchasingQuantity;
        private System.Windows.Forms.Label labelPurchasing;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelDecription;
        private System.Windows.Forms.TextBox textBoxPurchasingPrice;
        private System.Windows.Forms.Label labelPurchasingPrice;
        private System.Windows.Forms.TextBox textBoxPurchaseValue;
        private System.Windows.Forms.Label labelPurchaseValue;
        private System.Windows.Forms.TextBox textBoxPurchasingOrder;
        private System.Windows.Forms.Label labelPurchasingOrder;
        private System.Windows.Forms.TextBox textBoxSellingPrice;
        private System.Windows.Forms.Label labelSellingPrice;
        private System.Windows.Forms.Label labelSupplier;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.ComboBox comboBoxSupplier;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnViewItem;
        private System.Windows.Forms.Button btnPrintStock;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem removeItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullScreenViewToolStripMenuItem;
        private System.Windows.Forms.Panel panelStockItem;
        private System.Windows.Forms.Label labelStockCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelPurchasingValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelPurchasingValue;
        private System.Windows.Forms.Button btnPurchasingSummary;
    }
}