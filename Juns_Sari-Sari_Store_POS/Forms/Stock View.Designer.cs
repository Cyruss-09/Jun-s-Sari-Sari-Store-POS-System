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
            this.panelStockItem = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.labelStockCount = new System.Windows.Forms.Label();
            this.panelPurchasingValue = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.labelPurchasingValue = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelStockItem.SuspendLayout();
            this.panelPurchasingValue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panelPurchasingValue.Location = new System.Drawing.Point(270, 12);
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 188);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1376, 659);
            this.dataGridView1.TabIndex = 19;
            // 
            // Stock_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 847);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelPurchasingValue);
            this.Controls.Add(this.panelStockItem);
            this.Name = "Stock_View";
            this.Text = "Stock_View";
            this.panelStockItem.ResumeLayout(false);
            this.panelStockItem.PerformLayout();
            this.panelPurchasingValue.ResumeLayout(false);
            this.panelPurchasingValue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}