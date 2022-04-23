namespace KryptoSteuernTool
{
    partial class AddTransactionsDialog
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBoxAddType = new System.Windows.Forms.GroupBox();
            this.radioButtonAPI = new System.Windows.Forms.RadioButton();
            this.radioButtonCSV = new System.Windows.Forms.RadioButton();
            this.radioButtonMaual = new System.Windows.Forms.RadioButton();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxAddType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(133, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add Transactions";
            // 
            // groupBoxAddType
            // 
            this.groupBoxAddType.Controls.Add(this.radioButtonAPI);
            this.groupBoxAddType.Controls.Add(this.radioButtonCSV);
            this.groupBoxAddType.Controls.Add(this.radioButtonMaual);
            this.groupBoxAddType.Location = new System.Drawing.Point(12, 32);
            this.groupBoxAddType.Name = "groupBoxAddType";
            this.groupBoxAddType.Size = new System.Drawing.Size(161, 129);
            this.groupBoxAddType.TabIndex = 1;
            this.groupBoxAddType.TabStop = false;
            this.groupBoxAddType.Text = "Type of Import";
            // 
            // radioButtonAPI
            // 
            this.radioButtonAPI.AutoSize = true;
            this.radioButtonAPI.Location = new System.Drawing.Point(6, 85);
            this.radioButtonAPI.Name = "radioButtonAPI";
            this.radioButtonAPI.Size = new System.Drawing.Size(99, 24);
            this.radioButtonAPI.TabIndex = 2;
            this.radioButtonAPI.TabStop = true;
            this.radioButtonAPI.Text = "API Sync";
            this.radioButtonAPI.UseVisualStyleBackColor = true;
            // 
            // radioButtonCSV
            // 
            this.radioButtonCSV.AutoSize = true;
            this.radioButtonCSV.Location = new System.Drawing.Point(6, 55);
            this.radioButtonCSV.Name = "radioButtonCSV";
            this.radioButtonCSV.Size = new System.Drawing.Size(117, 24);
            this.radioButtonCSV.TabIndex = 1;
            this.radioButtonCSV.TabStop = true;
            this.radioButtonCSV.Text = "CSV Import";
            this.radioButtonCSV.UseVisualStyleBackColor = true;
            // 
            // radioButtonMaual
            // 
            this.radioButtonMaual.AutoSize = true;
            this.radioButtonMaual.Location = new System.Drawing.Point(6, 25);
            this.radioButtonMaual.Name = "radioButtonMaual";
            this.radioButtonMaual.Size = new System.Drawing.Size(136, 24);
            this.radioButtonMaual.TabIndex = 0;
            this.radioButtonMaual.TabStop = true;
            this.radioButtonMaual.Text = "Manual Import";
            this.radioButtonMaual.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(12, 168);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 33);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.Location = new System.Drawing.Point(93, 168);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(80, 33);
            this.btnAbort.TabIndex = 3;
            this.btnAbort.Text = "Abort";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(180, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 397);
            this.panel1.TabIndex = 4;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(176, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(0, 20);
            this.labelTitle.TabIndex = 0;
            // 
            // AddTransactionsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.groupBoxAddType);
            this.Controls.Add(this.lblTitle);
            this.Name = "AddTransactionsDialog";
            this.Text = "AddTransactionsDialog";
            this.groupBoxAddType.ResumeLayout(false);
            this.groupBoxAddType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBoxAddType;
        private System.Windows.Forms.RadioButton radioButtonAPI;
        private System.Windows.Forms.RadioButton radioButtonCSV;
        private System.Windows.Forms.RadioButton radioButtonMaual;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTitle;
    }
}