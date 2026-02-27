namespace Juns_Sari_Sari_Store_POS.Forms
{
    partial class Stock_View
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
            this.panelStockItem = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.labelStockCount = new System.Windows.Forms.Label();
            this.panelPurchasingValue = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.labelPurchasingValue = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lowQuantityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeItermToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelStockItem.SuspendLayout();
            this.panelPurchasingValue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStockItem
            // 
            this.panelStockItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelStockItem.BackColor = System.Drawing.Color.Navy;
            this.panelStockItem.Controls.Add(this.label6);
            this.panelStockItem.Controls.Add(this.labelStockCount);
            this.panelStockItem.Location = new System.Drawing.Point(15, 12);
            this.panelStockItem.Name = "panelStockItem";
            this.panelStockItem.Size = new System.Drawing.Size(249, 149);
            this.panelStockItem.TabIndex = 17;
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
            this.panelPurchasingValue.Location = new System.Drawing.Point(292, 12);
            this.panelPurchasingValue.Name = "panelPurchasingValue";
            this.panelPurchasingValue.Size = new System.Drawing.Size(249, 149);
            this.panelPurchasingValue.TabIndex = 18;
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
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MediumBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 188);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1376, 659);
            this.dataGridView1.TabIndex = 19;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lowQuantityToolStripMenuItem,
            this.removeItermToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(172, 52);
            // 
            // lowQuantityToolStripMenuItem
            // 
            this.lowQuantityToolStripMenuItem.Name = "lowQuantityToolStripMenuItem";
            this.lowQuantityToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.lowQuantityToolStripMenuItem.Text = "Low Quantity";
            // 
            // removeItermToolStripMenuItem
            // 
            this.removeItermToolStripMenuItem.Name = "removeItermToolStripMenuItem";
            this.removeItermToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.removeItermToolStripMenuItem.Text = "Remove Iterm";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1139, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 149);
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Low Stock Item:";
            // 
            // Stock_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 847);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelPurchasingValue);
            this.Controls.Add(this.panelStockItem);
            this.MinimumSize = new System.Drawing.Size(1418, 894);
            this.Name = "Stock_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock_View";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.panelStockItem.ResumeLayout(false);
            this.panelStockItem.PerformLayout();
            this.panelPurchasingValue.ResumeLayout(false);
            this.panelPurchasingValue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStockItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelStockCount;
        private System.Windows.Forms.Panel panelPurchasingValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelPurchasingValue;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lowQuantityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeItermToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}