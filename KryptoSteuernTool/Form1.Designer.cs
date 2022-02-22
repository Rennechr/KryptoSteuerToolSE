namespace KryptoSteuernTool
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnOpen = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnWallets = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.groupBoxDashboard = new System.Windows.Forms.GroupBox();
            this.groupBoxWallets = new System.Windows.Forms.GroupBox();
            this.groupBoxTransactions = new System.Windows.Forms.GroupBox();
            this.btnAddWallet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnWalletAdd = new System.Windows.Forms.Button();
            this.groupBoxDashboard.SuspendLayout();
            this.groupBoxWallets.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(93, 12);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(174, 12);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(86, 23);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // btnWallets
            // 
            this.btnWallets.Location = new System.Drawing.Point(266, 12);
            this.btnWallets.Name = "btnWallets";
            this.btnWallets.Size = new System.Drawing.Size(75, 23);
            this.btnWallets.TabIndex = 3;
            this.btnWallets.Text = "Wallets";
            this.btnWallets.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(-3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(6489, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // btnTransactions
            // 
            this.btnTransactions.Location = new System.Drawing.Point(347, 12);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(97, 23);
            this.btnTransactions.TabIndex = 5;
            this.btnTransactions.Text = "Transactions";
            this.btnTransactions.UseVisualStyleBackColor = true;
            // 
            // groupBoxDashboard
            // 
            this.groupBoxDashboard.Controls.Add(this.groupBoxWallets);
            this.groupBoxDashboard.Location = new System.Drawing.Point(1063, 195);
            this.groupBoxDashboard.Name = "groupBoxDashboard";
            this.groupBoxDashboard.Size = new System.Drawing.Size(109, 119);
            this.groupBoxDashboard.TabIndex = 6;
            this.groupBoxDashboard.TabStop = false;
            this.groupBoxDashboard.Text = "Dashboard";
            // 
            // groupBoxWallets
            // 
            this.groupBoxWallets.Controls.Add(this.btnAddWallet);
            this.groupBoxWallets.Location = new System.Drawing.Point(552, 232);
            this.groupBoxWallets.Name = "groupBoxWallets";
            this.groupBoxWallets.Size = new System.Drawing.Size(203, 55);
            this.groupBoxWallets.TabIndex = 7;
            this.groupBoxWallets.TabStop = false;
            this.groupBoxWallets.Text = "Wallets";
            // 
            // groupBoxTransactions
            // 
            this.groupBoxTransactions.Location = new System.Drawing.Point(933, 53);
            this.groupBoxTransactions.Name = "groupBoxTransactions";
            this.groupBoxTransactions.Size = new System.Drawing.Size(200, 100);
            this.groupBoxTransactions.TabIndex = 8;
            this.groupBoxTransactions.TabStop = false;
            this.groupBoxTransactions.Text = "Transactions";
            // 
            // btnAddWallet
            // 
            this.btnAddWallet.Location = new System.Drawing.Point(424, 22);
            this.btnAddWallet.Name = "btnAddWallet";
            this.btnAddWallet.Size = new System.Drawing.Size(75, 23);
            this.btnAddWallet.TabIndex = 0;
            this.btnAddWallet.Text = "add Wallet / Exchange";
            this.btnAddWallet.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnWalletAdd);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 212);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wallets";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(552, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 55);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wallets";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(424, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "add Wallet / Exchange";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnWalletAdd
            // 
            this.btnWalletAdd.Location = new System.Drawing.Point(324, 21);
            this.btnWalletAdd.Name = "btnWalletAdd";
            this.btnWalletAdd.Size = new System.Drawing.Size(177, 29);
            this.btnWalletAdd.TabIndex = 8;
            this.btnWalletAdd.Text = "add Wallet / Exchange";
            this.btnWalletAdd.UseVisualStyleBackColor = true;
            this.btnWalletAdd.Click += new System.EventHandler(this.btnWalletAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 409);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxTransactions);
            this.Controls.Add(this.groupBoxDashboard);
            this.Controls.Add(this.btnTransactions);
            this.Controls.Add(this.btnWallets);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Krypto Steuer Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxDashboard.ResumeLayout(false);
            this.groupBoxWallets.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnWallets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.GroupBox groupBoxDashboard;
        private System.Windows.Forms.GroupBox groupBoxWallets;
        private System.Windows.Forms.Button btnAddWallet;
        private System.Windows.Forms.GroupBox groupBoxTransactions;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnWalletAdd;
    }
}

