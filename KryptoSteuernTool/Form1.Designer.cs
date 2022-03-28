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
            this.btnAddWallet = new System.Windows.Forms.Button();
            this.groupBoxTransactions = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnWalletAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxDashboard.SuspendLayout();
            this.groupBoxWallets.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(14, 15);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(84, 29);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(105, 15);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(84, 29);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(196, 15);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(97, 29);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // btnWallets
            // 
            this.btnWallets.Location = new System.Drawing.Point(299, 15);
            this.btnWallets.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnWallets.Name = "btnWallets";
            this.btnWallets.Size = new System.Drawing.Size(84, 29);
            this.btnWallets.TabIndex = 3;
            this.btnWallets.Text = "Wallets";
            this.btnWallets.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(-3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(8343, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // btnTransactions
            // 
            this.btnTransactions.Location = new System.Drawing.Point(390, 15);
            this.btnTransactions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(109, 29);
            this.btnTransactions.TabIndex = 5;
            this.btnTransactions.Text = "Transactions";
            this.btnTransactions.UseVisualStyleBackColor = true;
            // 
            // groupBoxDashboard
            // 
            this.groupBoxDashboard.Controls.Add(this.groupBoxWallets);
            this.groupBoxDashboard.Location = new System.Drawing.Point(991, 66);
            this.groupBoxDashboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxDashboard.Name = "groupBoxDashboard";
            this.groupBoxDashboard.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxDashboard.Size = new System.Drawing.Size(123, 149);
            this.groupBoxDashboard.TabIndex = 6;
            this.groupBoxDashboard.TabStop = false;
            this.groupBoxDashboard.Text = "Dashboard";
            // 
            // groupBoxWallets
            // 
            this.groupBoxWallets.Controls.Add(this.btnAddWallet);
            this.groupBoxWallets.Location = new System.Drawing.Point(621, 290);
            this.groupBoxWallets.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxWallets.Name = "groupBoxWallets";
            this.groupBoxWallets.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxWallets.Size = new System.Drawing.Size(228, 69);
            this.groupBoxWallets.TabIndex = 7;
            this.groupBoxWallets.TabStop = false;
            this.groupBoxWallets.Text = "Wallets";
            // 
            // btnAddWallet
            // 
            this.btnAddWallet.Location = new System.Drawing.Point(477, 28);
            this.btnAddWallet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddWallet.Name = "btnAddWallet";
            this.btnAddWallet.Size = new System.Drawing.Size(84, 29);
            this.btnAddWallet.TabIndex = 0;
            this.btnAddWallet.Text = "add Wallet / Exchange";
            this.btnAddWallet.UseVisualStyleBackColor = true;
            // 
            // groupBoxTransactions
            // 
            this.groupBoxTransactions.Location = new System.Drawing.Point(591, 66);
            this.groupBoxTransactions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxTransactions.Name = "groupBoxTransactions";
            this.groupBoxTransactions.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxTransactions.Size = new System.Drawing.Size(394, 265);
            this.groupBoxTransactions.TabIndex = 8;
            this.groupBoxTransactions.TabStop = false;
            this.groupBoxTransactions.Text = "Transactions";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnWalletAdd);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(14, 66);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(570, 265);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wallets";
            // 
            // btnWalletAdd
            // 
            this.btnWalletAdd.Location = new System.Drawing.Point(364, 26);
            this.btnWalletAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnWalletAdd.Name = "btnWalletAdd";
            this.btnWalletAdd.Size = new System.Drawing.Size(199, 36);
            this.btnWalletAdd.TabIndex = 8;
            this.btnWalletAdd.Text = "add Wallet / Exchange";
            this.btnWalletAdd.UseVisualStyleBackColor = true;
            this.btnWalletAdd.Click += new System.EventHandler(this.btnWalletAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(621, 290);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(228, 69);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wallets";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(477, 28);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "add Wallet / Exchange";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 511);
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

