
namespace BankAccountApplication
{
    partial class FrmMain
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
            this.LblHeading = new System.Windows.Forms.Label();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.txtAcBalance = new System.Windows.Forms.TextBox();
            this.lblAcBalance = new System.Windows.Forms.Label();
            this.txtAcName = new System.Windows.Forms.TextBox();
            this.lblAcName = new System.Windows.Forms.Label();
            this.txtAcNo = new System.Windows.Forms.TextBox();
            this.lblAcNo = new System.Windows.Forms.Label();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.pnlInput.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblHeading
            // 
            this.LblHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LblHeading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblHeading.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeading.Location = new System.Drawing.Point(28, 18);
            this.LblHeading.Name = "LblHeading";
            this.LblHeading.Size = new System.Drawing.Size(459, 55);
            this.LblHeading.TabIndex = 0;
            this.LblHeading.Text = "APNA BANK";
            this.LblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlInput
            // 
            this.pnlInput.Controls.Add(this.txtAcBalance);
            this.pnlInput.Controls.Add(this.lblAcBalance);
            this.pnlInput.Controls.Add(this.txtAcName);
            this.pnlInput.Controls.Add(this.lblAcName);
            this.pnlInput.Controls.Add(this.txtAcNo);
            this.pnlInput.Controls.Add(this.lblAcNo);
            this.pnlInput.Location = new System.Drawing.Point(28, 76);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(459, 169);
            this.pnlInput.TabIndex = 1;
            // 
            // txtAcBalance
            // 
            this.txtAcBalance.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcBalance.Location = new System.Drawing.Point(115, 117);
            this.txtAcBalance.Name = "txtAcBalance";
            this.txtAcBalance.Size = new System.Drawing.Size(309, 22);
            this.txtAcBalance.TabIndex = 5;
            // 
            // lblAcBalance
            // 
            this.lblAcBalance.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcBalance.Location = new System.Drawing.Point(3, 119);
            this.lblAcBalance.Name = "lblAcBalance";
            this.lblAcBalance.Size = new System.Drawing.Size(106, 23);
            this.lblAcBalance.TabIndex = 4;
            this.lblAcBalance.Text = "Ac Balance:";
            // 
            // txtAcName
            // 
            this.txtAcName.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcName.Location = new System.Drawing.Point(115, 74);
            this.txtAcName.Name = "txtAcName";
            this.txtAcName.Size = new System.Drawing.Size(309, 22);
            this.txtAcName.TabIndex = 3;
            // 
            // lblAcName
            // 
            this.lblAcName.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcName.Location = new System.Drawing.Point(15, 76);
            this.lblAcName.Name = "lblAcName";
            this.lblAcName.Size = new System.Drawing.Size(94, 23);
            this.lblAcName.TabIndex = 2;
            this.lblAcName.Text = "Ac Name:";
            this.lblAcName.Click += new System.EventHandler(this.lblAcName_Click);
            // 
            // txtAcNo
            // 
            this.txtAcNo.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcNo.Location = new System.Drawing.Point(115, 24);
            this.txtAcNo.Name = "txtAcNo";
            this.txtAcNo.Size = new System.Drawing.Size(309, 22);
            this.txtAcNo.TabIndex = 1;
            // 
            // lblAcNo
            // 
            this.lblAcNo.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcNo.Location = new System.Drawing.Point(36, 26);
            this.lblAcNo.Name = "lblAcNo";
            this.lblAcNo.Size = new System.Drawing.Size(64, 23);
            this.lblAcNo.TabIndex = 0;
            this.lblAcNo.Text = "Ac No:";
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnExit);
            this.pnlButton.Controls.Add(this.btnCheck);
            this.pnlButton.Controls.Add(this.btnWithdraw);
            this.pnlButton.Controls.Add(this.btnDeposit);
            this.pnlButton.Controls.Add(this.btnOpen);
            this.pnlButton.Location = new System.Drawing.Point(28, 251);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(459, 67);
            this.pnlButton.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(372, 15);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(67, 36);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Enabled = false;
            this.btnCheck.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(299, 15);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(67, 36);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Enabled = false;
            this.btnWithdraw.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.Location = new System.Drawing.Point(188, 15);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(105, 36);
            this.btnWithdraw.TabIndex = 2;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Enabled = false;
            this.btnDeposit.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.Location = new System.Drawing.Point(96, 15);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(86, 36);
            this.btnDeposit.TabIndex = 1;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(23, 15);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(67, 36);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtMsg
            // 
            this.txtMsg.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMsg.Location = new System.Drawing.Point(28, 324);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMsg.Size = new System.Drawing.Size(459, 114);
            this.txtMsg.TabIndex = 3;
            this.txtMsg.WordWrap = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(518, 450);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.LblHeading);
            this.Name = "FrmMain";
            this.Text = "Apna Bank";
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.pnlButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblHeading;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.TextBox txtAcName;
        private System.Windows.Forms.Label lblAcName;
        private System.Windows.Forms.TextBox txtAcNo;
        private System.Windows.Forms.Label lblAcNo;
        private System.Windows.Forms.TextBox txtAcBalance;
        private System.Windows.Forms.Label lblAcBalance;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtMsg;
    }
}

