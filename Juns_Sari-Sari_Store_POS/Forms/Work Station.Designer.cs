namespace Juns_Sari_Sari_Store_POS
{
    partial class Work_Station
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Work_Station));
            this.btnStock = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnBusiness = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStock
            // 
            resources.ApplyResources(this.btnStock, "btnStock");
            this.btnStock.BackColor = System.Drawing.Color.DimGray;
            this.btnStock.ForeColor = System.Drawing.Color.White;
            this.btnStock.Name = "btnStock";
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnPayments
            // 
            resources.ApplyResources(this.btnPayments, "btnPayments");
            this.btnPayments.BackColor = System.Drawing.Color.DimGray;
            this.btnPayments.ForeColor = System.Drawing.Color.White;
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.UseVisualStyleBackColor = false;
            // 
            // btnInvoice
            // 
            resources.ApplyResources(this.btnInvoice, "btnInvoice");
            this.btnInvoice.BackColor = System.Drawing.Color.DimGray;
            this.btnInvoice.ForeColor = System.Drawing.Color.White;
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.UseVisualStyleBackColor = false;
            // 
            // btnCustomers
            // 
            resources.ApplyResources(this.btnCustomers, "btnCustomers");
            this.btnCustomers.BackColor = System.Drawing.Color.DimGray;
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            // 
            // btnBusiness
            // 
            resources.ApplyResources(this.btnBusiness, "btnBusiness");
            this.btnBusiness.BackColor = System.Drawing.Color.DimGray;
            this.btnBusiness.ForeColor = System.Drawing.Color.White;
            this.btnBusiness.Name = "btnBusiness";
            this.btnBusiness.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Work_Station
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBusiness);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.btnPayments);
            this.Controls.Add(this.btnStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Work_Station";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnBusiness;
        private System.Windows.Forms.Button btnExit;
    }
}