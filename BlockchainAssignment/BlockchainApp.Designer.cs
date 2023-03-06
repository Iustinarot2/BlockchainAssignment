
namespace BlockchainAssignment
{
    partial class BlockchainApp
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.printBtn = new System.Windows.Forms.Button();
            this.indexTBox = new System.Windows.Forms.TextBox();
            this.infoLbl = new System.Windows.Forms.Label();
            this.genWalletBtn = new System.Windows.Forms.Button();
            this.valKeysBtn = new System.Windows.Forms.Button();
            this.publicKey = new System.Windows.Forms.TextBox();
            this.pubKeyLbl = new System.Windows.Forms.Label();
            this.privKeyLbl = new System.Windows.Forms.Label();
            this.privateKey = new System.Windows.Forms.TextBox();
            this.createTransBtn = new System.Windows.Forms.Button();
            this.amountLbl = new System.Windows.Forms.Label();
            this.feeLbl = new System.Windows.Forms.Label();
            this.RKeyLbl = new System.Windows.Forms.Label();
            this.amountTBox = new System.Windows.Forms.TextBox();
            this.feeTBox = new System.Windows.Forms.TextBox();
            this.recieverKeyTBox = new System.Windows.Forms.TextBox();
            this.blockGenBtn = new System.Windows.Forms.Button();
            this.printAllBtn = new System.Windows.Forms.Button();
            this.readPendTrandBtn = new System.Windows.Forms.Button();
            this.adjustDiff = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.validate = new System.Windows.Forms.Button();
            this.addressFind = new System.Windows.Forms.TextBox();
            this.CheckBalance = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBox1.Location = new System.Drawing.Point(13, 23);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(551, 314);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(568, 226);
            this.printBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(100, 28);
            this.printBtn.TabIndex = 1;
            this.printBtn.Text = "Print";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // indexTBox
            // 
            this.indexTBox.Location = new System.Drawing.Point(568, 185);
            this.indexTBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.indexTBox.Name = "indexTBox";
            this.indexTBox.Size = new System.Drawing.Size(216, 22);
            this.indexTBox.TabIndex = 2;
            this.indexTBox.TextChanged += new System.EventHandler(this.IndexInput_TextChanged);
            // 
            // infoLbl
            // 
            this.infoLbl.AutoSize = true;
            this.infoLbl.Location = new System.Drawing.Point(1085, 47);
            this.infoLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infoLbl.Name = "infoLbl";
            this.infoLbl.Size = new System.Drawing.Size(0, 16);
            this.infoLbl.TabIndex = 3;
            // 
            // genWalletBtn
            // 
            this.genWalletBtn.Location = new System.Drawing.Point(676, 415);
            this.genWalletBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.genWalletBtn.Name = "genWalletBtn";
            this.genWalletBtn.Size = new System.Drawing.Size(100, 64);
            this.genWalletBtn.TabIndex = 4;
            this.genWalletBtn.Text = "Generate New Wallet";
            this.genWalletBtn.UseVisualStyleBackColor = true;
            this.genWalletBtn.Click += new System.EventHandler(this.GenWalletBtn_Click);
            // 
            // valKeysBtn
            // 
            this.valKeysBtn.Location = new System.Drawing.Point(676, 487);
            this.valKeysBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.valKeysBtn.Name = "valKeysBtn";
            this.valKeysBtn.Size = new System.Drawing.Size(100, 62);
            this.valKeysBtn.TabIndex = 5;
            this.valKeysBtn.Text = "Validate Keys";
            this.valKeysBtn.UseVisualStyleBackColor = true;
            this.valKeysBtn.Click += new System.EventHandler(this.ValKeysBtn_Click);
            // 
            // publicKey
            // 
            this.publicKey.Location = new System.Drawing.Point(273, 415);
            this.publicKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.publicKey.Name = "publicKey";
            this.publicKey.Size = new System.Drawing.Size(376, 22);
            this.publicKey.TabIndex = 6;
            this.publicKey.TextChanged += new System.EventHandler(this.publicKey_TextChanged);
            // 
            // pubKeyLbl
            // 
            this.pubKeyLbl.AutoSize = true;
            this.pubKeyLbl.Location = new System.Drawing.Point(269, 395);
            this.pubKeyLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pubKeyLbl.Name = "pubKeyLbl";
            this.pubKeyLbl.Size = new System.Drawing.Size(70, 16);
            this.pubKeyLbl.TabIndex = 7;
            this.pubKeyLbl.Text = "Public Key";
            this.pubKeyLbl.Click += new System.EventHandler(this.pubKeyLbl_Click);
            // 
            // privKeyLbl
            // 
            this.privKeyLbl.AutoSize = true;
            this.privKeyLbl.Location = new System.Drawing.Point(269, 443);
            this.privKeyLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.privKeyLbl.Name = "privKeyLbl";
            this.privKeyLbl.Size = new System.Drawing.Size(75, 16);
            this.privKeyLbl.TabIndex = 8;
            this.privKeyLbl.Text = "Private Key";
            this.privKeyLbl.Click += new System.EventHandler(this.privKeyLbl_Click);
            // 
            // privateKey
            // 
            this.privateKey.Location = new System.Drawing.Point(273, 463);
            this.privateKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.privateKey.Name = "privateKey";
            this.privateKey.Size = new System.Drawing.Size(376, 22);
            this.privateKey.TabIndex = 9;
            this.privateKey.TextChanged += new System.EventHandler(this.privateKey_TextChanged);
            // 
            // createTransBtn
            // 
            this.createTransBtn.Location = new System.Drawing.Point(16, 487);
            this.createTransBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.createTransBtn.Name = "createTransBtn";
            this.createTransBtn.Size = new System.Drawing.Size(97, 57);
            this.createTransBtn.TabIndex = 10;
            this.createTransBtn.Text = "Create Transaction";
            this.createTransBtn.UseVisualStyleBackColor = true;
            this.createTransBtn.Click += new System.EventHandler(this.CreateTransBtn_Click);
            // 
            // amountLbl
            // 
            this.amountLbl.AutoSize = true;
            this.amountLbl.Location = new System.Drawing.Point(122, 496);
            this.amountLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.amountLbl.Name = "amountLbl";
            this.amountLbl.Size = new System.Drawing.Size(52, 16);
            this.amountLbl.TabIndex = 11;
            this.amountLbl.Text = "Amount";
            // 
            // feeLbl
            // 
            this.feeLbl.AutoSize = true;
            this.feeLbl.Location = new System.Drawing.Point(122, 523);
            this.feeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.feeLbl.Name = "feeLbl";
            this.feeLbl.Size = new System.Drawing.Size(31, 16);
            this.feeLbl.TabIndex = 12;
            this.feeLbl.Text = "Fee";
            // 
            // RKeyLbl
            // 
            this.RKeyLbl.AutoSize = true;
            this.RKeyLbl.Location = new System.Drawing.Point(270, 498);
            this.RKeyLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RKeyLbl.Name = "RKeyLbl";
            this.RKeyLbl.Size = new System.Drawing.Size(88, 16);
            this.RKeyLbl.TabIndex = 13;
            this.RKeyLbl.Text = "Receiver Key";
            // 
            // amountTBox
            // 
            this.amountTBox.Location = new System.Drawing.Point(187, 488);
            this.amountTBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.amountTBox.Name = "amountTBox";
            this.amountTBox.Size = new System.Drawing.Size(60, 22);
            this.amountTBox.TabIndex = 14;
            // 
            // feeTBox
            // 
            this.feeTBox.Location = new System.Drawing.Point(187, 520);
            this.feeTBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.feeTBox.Name = "feeTBox";
            this.feeTBox.Size = new System.Drawing.Size(60, 22);
            this.feeTBox.TabIndex = 15;
            // 
            // recieverKeyTBox
            // 
            this.recieverKeyTBox.Location = new System.Drawing.Point(272, 522);
            this.recieverKeyTBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.recieverKeyTBox.Name = "recieverKeyTBox";
            this.recieverKeyTBox.Size = new System.Drawing.Size(377, 22);
            this.recieverKeyTBox.TabIndex = 16;
            // 
            // blockGenBtn
            // 
            this.blockGenBtn.Location = new System.Drawing.Point(568, 266);
            this.blockGenBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.blockGenBtn.Name = "blockGenBtn";
            this.blockGenBtn.Size = new System.Drawing.Size(100, 68);
            this.blockGenBtn.TabIndex = 17;
            this.blockGenBtn.Text = "Generate New Block";
            this.blockGenBtn.UseVisualStyleBackColor = true;
            this.blockGenBtn.Click += new System.EventHandler(this.BlockGenBtn_Click);
            // 
            // printAllBtn
            // 
            this.printAllBtn.Location = new System.Drawing.Point(687, 226);
            this.printAllBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.printAllBtn.Name = "printAllBtn";
            this.printAllBtn.Size = new System.Drawing.Size(97, 28);
            this.printAllBtn.TabIndex = 18;
            this.printAllBtn.Text = "Print All";
            this.printAllBtn.UseVisualStyleBackColor = true;
            this.printAllBtn.Click += new System.EventHandler(this.PrintAllBtn_Click);
            // 
            // readPendTrandBtn
            // 
            this.readPendTrandBtn.Location = new System.Drawing.Point(138, 390);
            this.readPendTrandBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.readPendTrandBtn.Name = "readPendTrandBtn";
            this.readPendTrandBtn.Size = new System.Drawing.Size(109, 69);
            this.readPendTrandBtn.TabIndex = 19;
            this.readPendTrandBtn.Text = "Read Pending Transactions ";
            this.readPendTrandBtn.UseVisualStyleBackColor = true;
            this.readPendTrandBtn.Click += new System.EventHandler(this.ReadPendTrandBtn_Click);
            // 
            // adjustDiff
            // 
            this.adjustDiff.Location = new System.Drawing.Point(568, 43);
            this.adjustDiff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adjustDiff.Name = "adjustDiff";
            this.adjustDiff.Size = new System.Drawing.Size(100, 28);
            this.adjustDiff.TabIndex = 20;
            this.adjustDiff.Text = "Adjust Diff";
            this.adjustDiff.UseVisualStyleBackColor = true;
            this.adjustDiff.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(676, 45);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 28);
            this.button1.TabIndex = 21;
            this.button1.Text = "PRNT ALL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "None";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Greedy",
            "Altruistic",
            "Random",
            "Address Preference"});
            this.comboBox1.Location = new System.Drawing.Point(568, 80);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(216, 24);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.Text = "Select Mining Setting";
            this.comboBox1.ValueMember = "None";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // validate
            // 
            this.validate.Location = new System.Drawing.Point(690, 272);
            this.validate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.validate.Name = "validate";
            this.validate.Size = new System.Drawing.Size(97, 57);
            this.validate.TabIndex = 23;
            this.validate.Text = "Validate Blockchain";
            this.validate.UseVisualStyleBackColor = true;
            this.validate.Click += new System.EventHandler(this.Validate_Click);
            // 
            // addressFind
            // 
            this.addressFind.Location = new System.Drawing.Point(568, 117);
            this.addressFind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addressFind.Name = "addressFind";
            this.addressFind.Size = new System.Drawing.Size(216, 22);
            this.addressFind.TabIndex = 25;
            this.addressFind.Text = "Search for: ";
            // 
            // CheckBalance
            // 
            this.CheckBalance.Location = new System.Drawing.Point(16, 390);
            this.CheckBalance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CheckBalance.Name = "CheckBalance";
            this.CheckBalance.Size = new System.Drawing.Size(99, 69);
            this.CheckBalance.TabIndex = 24;
            this.CheckBalance.Text = "Check Balance";
            this.CheckBalance.UseVisualStyleBackColor = true;
            this.CheckBalance.Click += new System.EventHandler(this.CheckBalance_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(568, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Block#";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BlockchainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(813, 581);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addressFind);
            this.Controls.Add(this.CheckBalance);
            this.Controls.Add(this.validate);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.adjustDiff);
            this.Controls.Add(this.readPendTrandBtn);
            this.Controls.Add(this.printAllBtn);
            this.Controls.Add(this.blockGenBtn);
            this.Controls.Add(this.recieverKeyTBox);
            this.Controls.Add(this.feeTBox);
            this.Controls.Add(this.amountTBox);
            this.Controls.Add(this.RKeyLbl);
            this.Controls.Add(this.feeLbl);
            this.Controls.Add(this.amountLbl);
            this.Controls.Add(this.createTransBtn);
            this.Controls.Add(this.privateKey);
            this.Controls.Add(this.privKeyLbl);
            this.Controls.Add(this.pubKeyLbl);
            this.Controls.Add(this.publicKey);
            this.Controls.Add(this.valKeysBtn);
            this.Controls.Add(this.genWalletBtn);
            this.Controls.Add(this.infoLbl);
            this.Controls.Add(this.indexTBox);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.richTextBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BlockchainApp";
            this.Text = "Blockchain App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.TextBox indexTBox;
        private System.Windows.Forms.Label infoLbl;
        private System.Windows.Forms.Button genWalletBtn;
        private System.Windows.Forms.Button valKeysBtn;
        private System.Windows.Forms.TextBox publicKey;
        private System.Windows.Forms.Label pubKeyLbl;
        private System.Windows.Forms.Label privKeyLbl;
        private System.Windows.Forms.TextBox privateKey;
        private System.Windows.Forms.Button createTransBtn;
        private System.Windows.Forms.Label amountLbl;
        private System.Windows.Forms.Label feeLbl;
        private System.Windows.Forms.Label RKeyLbl;
        private System.Windows.Forms.TextBox amountTBox;
        private System.Windows.Forms.TextBox feeTBox;
        private System.Windows.Forms.TextBox recieverKeyTBox;
        private System.Windows.Forms.Button blockGenBtn;
        private System.Windows.Forms.Button printAllBtn;
        private System.Windows.Forms.Button readPendTrandBtn;
        private System.Windows.Forms.Button adjustDiff;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button validate;
        private System.Windows.Forms.TextBox addressFind;
        private System.Windows.Forms.Button CheckBalance;
        private System.Windows.Forms.Label label1;
    }
}
