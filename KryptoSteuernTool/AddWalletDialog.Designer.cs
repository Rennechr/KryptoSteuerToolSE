namespace KryptoSteuernTool
{
    partial class AddWalletDialog
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonCustom = new System.Windows.Forms.RadioButton();
            this.radioButtonCSVImport = new System.Windows.Forms.RadioButton();
            this.radioButtonAPISync = new System.Windows.Forms.RadioButton();
            this.addTransactionsPanel = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonAbort = new System.Windows.Forms.Button();
            this.groupBoxTransactionImport = new System.Windows.Forms.GroupBox();
            this.groupBoxTransactionImport.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(16, 45);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(184, 26);
            this.textBoxName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wallet/Exchange Name";
            // 
            // radioButtonCustom
            // 
            this.radioButtonCustom.AutoSize = true;
            this.radioButtonCustom.Checked = true;
            this.radioButtonCustom.Location = new System.Drawing.Point(6, 25);
            this.radioButtonCustom.Name = "radioButtonCustom";
            this.radioButtonCustom.Size = new System.Drawing.Size(184, 24);
            this.radioButtonCustom.TabIndex = 3;
            this.radioButtonCustom.TabStop = true;
            this.radioButtonCustom.Text = "Custom Transactions";
            this.radioButtonCustom.UseVisualStyleBackColor = true;
            // 
            // radioButtonCSVImport
            // 
            this.radioButtonCSVImport.Location = new System.Drawing.Point(6, 55);
            this.radioButtonCSVImport.Name = "radioButtonCSVImport";
            this.radioButtonCSVImport.Size = new System.Drawing.Size(218, 24);
            this.radioButtonCSVImport.TabIndex = 4;
            this.radioButtonCSVImport.Text = "Add CSV Transactions";
            // 
            // radioButtonAPISync
            // 
            this.radioButtonAPISync.AutoSize = true;
            this.radioButtonAPISync.Location = new System.Drawing.Point(6, 85);
            this.radioButtonAPISync.Name = "radioButtonAPISync";
            this.radioButtonAPISync.Size = new System.Drawing.Size(194, 24);
            this.radioButtonAPISync.TabIndex = 5;
            this.radioButtonAPISync.Text = "API Sync Transactions";
            this.radioButtonAPISync.UseVisualStyleBackColor = true;
            // 
            // addTransactionsPanel
            // 
            this.addTransactionsPanel.Location = new System.Drawing.Point(257, 22);
            this.addTransactionsPanel.Name = "addTransactionsPanel";
            this.addTransactionsPanel.Size = new System.Drawing.Size(531, 416);
            this.addTransactionsPanel.TabIndex = 6;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 201);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(93, 29);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Save";
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonAbort
            // 
            this.buttonAbort.Location = new System.Drawing.Point(111, 201);
            this.buttonAbort.Name = "buttonAbort";
            this.buttonAbort.Size = new System.Drawing.Size(89, 29);
            this.buttonAbort.TabIndex = 8;
            this.buttonAbort.Text = "Abort";
            this.buttonAbort.UseVisualStyleBackColor = true;
            this.buttonAbort.Click += new System.EventHandler(this.buttonAbort_Click);
            // 
            // groupBoxTransactionImport
            // 
            this.groupBoxTransactionImport.Controls.Add(this.radioButtonCustom);
            this.groupBoxTransactionImport.Controls.Add(this.radioButtonCSVImport);
            this.groupBoxTransactionImport.Controls.Add(this.radioButtonAPISync);
            this.groupBoxTransactionImport.Location = new System.Drawing.Point(12, 77);
            this.groupBoxTransactionImport.Name = "groupBoxTransactionImport";
            this.groupBoxTransactionImport.Size = new System.Drawing.Size(239, 118);
            this.groupBoxTransactionImport.TabIndex = 10;
            this.groupBoxTransactionImport.TabStop = false;
            this.groupBoxTransactionImport.Text = "Transactions Import";
            // 
            // AddWalletDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxTransactionImport);
            this.Controls.Add(this.buttonAbort);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.addTransactionsPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Name = "AddWalletDialog";
            this.Text = "AddWalletDialog";
            this.groupBoxTransactionImport.ResumeLayout(false);
            this.groupBoxTransactionImport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonCustom;
        private System.Windows.Forms.RadioButton radioButtonCSVImport;
        private System.Windows.Forms.RadioButton radioButtonAPISync;
        private System.Windows.Forms.Panel addTransactionsPanel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonAbort;
        private System.Windows.Forms.GroupBox groupBoxTransactionImport;
    }
}